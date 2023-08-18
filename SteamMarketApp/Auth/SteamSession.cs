using PuppeteerSharp;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamMarketApp.Auth
{
    public static class SteamSession
    {
        const string SelectorCredentialsInput = ".newlogindialog_TextInput_2eKVn";
        const string SelectorSubmitCredentials = ".newlogindialog_SubmitButton_2QgFE";
        const string SelectorError = ".newlogindialog_Danger_1-HwJ";
        const string SelectorMobileAuth = ".newlogindialog_AwaitingMobileConfText_7LmnT";
        const string SelectorCodeInputLink = ".newlogindialog_TextLink_1cnUQ";
        const string SelectorCodeInput = ".segmentedinputs_SegmentedCharacterInput_3PDBF";
        const string SelectorAccountAuthorized = "#account_pulldown";

        public static async Task<SteamAccount> AuthorizeAsync(string accountName, string password, bool headlessMode = true)
        {
            await new BrowserFetcher().DownloadAsync(BrowserFetcher.DefaultChromiumRevision);
            var options = new LaunchOptions
            {
                Headless = headlessMode,
                Args = new[] { "--window-size=1280,960" }
            };
            IBrowser browser = await Puppeteer.LaunchAsync(options);

            var page = await browser.NewPageAsync();
            await page.GoToAsync("https://store.steampowered.com/login/");

            if (headlessMode)
            {
                await AuthorizeHeadlessAsync(accountName, password, browser, page);
            }

            await page.WaitForSelectorAsync(SelectorAccountAuthorized, new WaitForSelectorOptions { Timeout = headlessMode ? 30000 : 0 });
            var cookies = await page.GetCookiesAsync();
            var cookie = cookies.First(c => c.Name == "steamLoginSecure");
            await browser.CloseAsync();
            return new SteamAccount(cookie.Value);
        }

        private static async Task AuthorizeHeadlessAsync(string accountName, string password, IBrowser browser, IPage page)
        {
            await page.WaitForSelectorAsync(SelectorCredentialsInput);
            await page.TypeAsync($"input{SelectorCredentialsInput}[type=\"text\"]", accountName);
            await page.TypeAsync($"input{SelectorCredentialsInput}[type=\"password\"]", password);
            await page.ClickAsync(SelectorSubmitCredentials);

            await page.WaitForSelectorAsync($"{SelectorError}, {SelectorMobileAuth}, {SelectorCodeInput}");
            if (await page.QuerySelectorAsync(SelectorError) != null)
            {
                // Wrong login or password
                await browser.CloseAsync();
                throw new Exception("Invalid account name or password");
            }
            else if (await page.QuerySelectorAsync(SelectorMobileAuth) != null)
            {
                await page.ClickAsync(SelectorCodeInputLink);
            }
            if (await page.QuerySelectorAsync(SelectorCodeInput) != null)
            {
                // Two-Factor Authentication is required
                await page.WaitForSelectorAsync(SelectorCodeInput);
                var twoFactorCodeField = await page.QuerySelectorAsync(SelectorCodeInput);
                var inputs = twoFactorCodeField.QuerySelectorAllAsync("input").Result.ToArray();

                while (true)
                {
                    var authCodeForm = new AuthCodeForm();
                    var result = authCodeForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string authCode = authCodeForm.Code;
                        for (int i = 0; i < inputs.Length; i++)
                        {
                            await inputs[i].TypeAsync(authCode[i].ToString());
                        }
                    }

                    await page.WaitForSelectorAsync($"{SelectorError}, {SelectorAccountAuthorized}");
                    if (await page.QuerySelectorAsync(SelectorError) != null)
                    {
                        MessageBox.Show("Incorrect code, please try again");
                        foreach (var input in inputs)
                        {
                            await input.ClickAsync();
                            await page.Keyboard.PressAsync("Backspace");
                        }
                    }
                    else
                        break;
                }
            }
        }
    }
}
