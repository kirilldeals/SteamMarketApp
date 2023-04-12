using PuppeteerSharp;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamMarketApp.Auth
{
    public class SteamSession
    {
        const string SelectorCredentialsInput = ".newlogindialog_TextInput_2eKVn";
        const string SelectorSubmitCredentials = ".newlogindialog_SubmitButton_2QgFE";
        const string SelectorError = ".newlogindialog_Danger_1-HwJ";
        const string SelectorMobileAuth = ".newlogindialog_AwaitingMobileConfText_7LmnT";
        const string SelectorMobileAuthFailure = ".newlogindialog_FailureTitle_A3Y-u";
        const string SelectorCodeInputLink = ".newlogindialog_TextLink_1cnUQ";
        const string SelectorCodeInput = ".newlogindialog_SegmentedCharacterInput_1kJ6q";
        const string SelectorAccountAuthorized = "#account_pulldown";

        public SteamAccount Account { get; private set; }

        private SteamSession()
        {
        }

        public static async Task<(bool IsSuccess, SteamSession Session)> CreateAsync(string accountName, string password)
        {
            var session = new SteamSession();
            var isSuccess = await session.Initialize(accountName, password);
            return (isSuccess, session);
        }

        private async Task<bool> Initialize(string accountName, string password)
        {
            try
            {
                await new BrowserFetcher().DownloadAsync(BrowserFetcher.DefaultChromiumRevision);
                var options = new LaunchOptions
                {
                    Headless = true
                };
                IBrowser browser = await Puppeteer.LaunchAsync(options);

                var page = await browser.NewPageAsync();
                await page.GoToAsync("https://store.steampowered.com/login/");
                await page.WaitForSelectorAsync(SelectorCredentialsInput);
                await page.TypeAsync($"input{SelectorCredentialsInput}[type=\"text\"]", accountName);
                await page.TypeAsync($"input{SelectorCredentialsInput}[type=\"password\"]", password);
                await page.ClickAsync(SelectorSubmitCredentials);

                await page.WaitForSelectorAsync($"{SelectorError}, {SelectorMobileAuth}, {SelectorCodeInput}");
                if (await page.QuerySelectorAsync(SelectorError) != null)
                {
                    // Wrong login or password
                    await browser.CloseAsync();
                    MessageBox.Show("Invalid account name or password");
                    return false;
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
                        AuthCodeForm authCodeForm = new AuthCodeForm();
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

                await page.WaitForSelectorAsync(SelectorAccountAuthorized);
                var cookies = await page.GetCookiesAsync();
                var cookie = cookies.FirstOrDefault(c => c.Name == "steamLoginSecure");
                Account = new SteamAccount(cookie.Value);
                await browser.CloseAsync();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }
    }
}
