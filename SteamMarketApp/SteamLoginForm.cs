using SteamMarketApp.Api;
using SteamMarketApp.Auth;
using SteamMarketApp.Properties;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamMarketApp
{
    public partial class SteamLoginForm : Form
    {
        public SteamLoginForm()
        {
            InitializeComponent();

            txtAccountName.Text = Settings.Default.AccountName;
            txtPassword.Text = Settings.Default.Password;
            chkRememberMe.Checked = Settings.Default.IsRemembered;
        }

        private async void Submit(object sender, EventArgs e)
        {
            await SingInAsync(true);
        }

        private async void SubmitWithBrowser(object sender, EventArgs e)
        {
            await SingInAsync(false);
        }

        private async Task SingInAsync(bool headlessMode)
        {
            btnSubmit.Enabled = false;
            btnSubmitWithBrowser.Enabled = false;

            try
            {
                SteamAccount account = await SteamSession.AuthorizeAsync(txtAccountName.Text, txtPassword.Text, headlessMode);
                SaveAccountSettings(account);

                this.Hide();
                SteamMarketForm steamMarketForm = new SteamMarketForm(this, account);
                steamMarketForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            btnSubmit.Enabled = true;
            btnSubmitWithBrowser.Enabled = true;
        }

        private void SaveAccountSettings(SteamAccount account)
        {
            if (chkRememberMe.Checked)
            {
                Settings.Default.AccountName = txtAccountName.Text;
                Settings.Default.Password = txtPassword.Text;
                Settings.Default.SteamLoginSecure = account.SteamLoginSecure;
                Settings.Default.IsRemembered = true;
            }
            else
            {
                Settings.Default.SteamLoginSecure = null;
                Settings.Default.IsRemembered = false;
            }
            Settings.Default.Save();
        }
    }
}