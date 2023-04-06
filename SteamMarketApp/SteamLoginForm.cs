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

        private void Submit(object sender, EventArgs e)
        {

            var result = Task.Run(() => SteamSession.CreateAsync(txtAccountName.Text, txtPassword.Text)).Result;

            if (result.IsSuccess)
            {
                if (chkRememberMe.Checked)
                {
                    Settings.Default.AccountName = txtAccountName.Text;
                    Settings.Default.Password = txtPassword.Text;
                    Settings.Default.SteamLoginSecure = result.Session.Account.SteamLoginSecure;
                    Settings.Default.IsRemembered = true;
                    Settings.Default.Save();
                }
                else
                {
                    Settings.Default.SteamLoginSecure = null;
                    Settings.Default.IsRemembered = false;
                    Settings.Default.Save();
                }
                this.Hide();
                SteamMarketForm steamMarketForm = new SteamMarketForm(result.Session.Account);
                steamMarketForm.ShowDialog();
                Application.Exit();
            }
        }
    }
}