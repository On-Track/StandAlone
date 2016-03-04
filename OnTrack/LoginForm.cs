using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using OnTrack.src.Models;
using OnTrack.src.WebConnection;
using System.Net;

using System.Diagnostics;

namespace OnTrack
{
    public partial class LoginForm : MetroForm
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            lbLoginBanner.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // perform login check and open main window.
            string username = txtUsername.Text, password = txtPassword.Text;
            lbLoginBanner.Text = "";
            try {
                WebConnection webRequest = new WebConnection("http://ontrackapp.org/login/remote", "POST", "username=" + username + "&password=" + password);
                string response = webRequest.getResponse();
                if (response == WebConnection.CODE_LOGIN_SUCCESSFUL)
                {
                    User.username = username;
                    this.Hide();
                    this.loadMainWindow();
                }
                else if (username.Length == 0 || password.Length == 0)
                {
                    lbLoginBanner.Text = "Please Complete the Form!";
                }
                else if (response == WebConnection.CODE_LOGIN_FAILED)
                {
                    lbLoginBanner.Text = "Login Failed.  Please Try Again!";
                }
            } catch (WebException) {
                lbLoginBanner.Text = "Please Check Your Connection";
            }
        }

        [STAThread]
        private void loadMainWindow()
        {
            new MainWindow().Show();
        }
    }
}
