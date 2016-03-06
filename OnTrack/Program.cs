using System;
using System.Windows.Forms;

namespace OnTrack
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /**
             *  @note load the login form first
             **/
            Application.Run(new LoginForm());
        }
    }
}
