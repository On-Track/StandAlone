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
using OnTrack.src.WebConnection;

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

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // perform login check and open main window.
            string username = txtUsername.Text, password = txtPassword.Text;
            WebConnection webRequest = new WebConnection("http://ontrackapp.org/login/remote", "POST", "username=" + username + "&password=" + password);
            string response = webRequest.getResponse();
            Debug.WriteLine(response);
            if (response == "0x000A") {
                this.Hide();
                this.loadMainWindow();
            } else if (response == "0x000F") {
                lbLoginBanner.Text = "Login Failed.  Please Try Again!";
            }

            /**
            **/
        }

        [STAThread]
        private void loadMainWindow()
        {
            new MainWindow().Show();
        }
    }
}
