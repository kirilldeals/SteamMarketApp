using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
