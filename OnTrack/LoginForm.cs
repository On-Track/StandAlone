using System;
using MetroFramework.Forms;
using OnTrack.src.Models;
using OnTrack.src.WebConnection;
using System.Net;
using Newtonsoft.Json.Linq;

namespace OnTrack
{
    /**
     *  @note MetroForm used for logging in and gaining accessing to the main window
     **/
    public partial class LoginForm : MetroForm
    {
        /**
         *  @note initialize GUI objects for the login frame
         **/
        public LoginForm()
        {
            InitializeComponent();
        }

        /**
         *  @param object sender
         *  @param EventArgs e
         *  @return void
         **/
        private void LoginForm_Load(object sender, EventArgs e)
        {
            lbLoginBanner.Text = "";
        }

        /**
         *  @note event fired when login button is clicked
         **/
        private void btnLogin_Click(object sender, EventArgs e)
        {
            /**
             * @note perform login check and open main window.
             **/
            string username = txtUsername.Text, password = txtPassword.Text;
            lbLoginBanner.Text = "";
            /**
             *  @note form validation
             **/
            if (username.Length <= 2 || password.Length <= 6) {
                lbLoginBanner.Text = "Please Complete the Form!";
            } else {
                try {
                    WebConnection webRequest = new WebConnection("http://ontrackapp.org/ajax/remotelogin", "POST", "username=" + username + "&password=" + password);
                    dynamic json = JObject.Parse(webRequest.getResponse());
                    if (json.status == WebConnection.CODE_LOGIN_SUCCESSFUL) {
                        User.username = username;
                        this.Hide();
                        this.loadMainWindow();
                    } else {
                        lbLoginBanner.Text = "Login Failed.  Please Try Again!";
                    }
                } catch (WebException) {
                    lbLoginBanner.Text = "Please Check Your Connection";
                }
            }
        }

        /**
         *  @note function to load main window
         **/
        [STAThread]
        private void loadMainWindow()
        {
            new MainWindow().Show();
        }
    }
}
