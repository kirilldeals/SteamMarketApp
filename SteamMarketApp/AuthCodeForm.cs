using System;
using System.Windows.Forms;

namespace SteamMarketApp
{
    public partial class AuthCodeForm : Form
    {
        public string Code { get; set; }

        public AuthCodeForm()
        {
            InitializeComponent();
        }

        private void Submit(object sender, EventArgs e)
        {
            Code = txtCode.Text;
            this.Close();
        }
    }
}
