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
using OnTrack.src.Monitor;
using OnTrack.src.WebConnection;
using OnTrack.src.MachineEnvironment;
using OnTrack.src.Models;
using System.Diagnostics;

namespace OnTrack
{
    public partial class MainWindow : MetroForm
    {

        public MainWindow()
        {
            InitializeComponent();
            new Monitor();
            this.FormClosing += this.MainWindow_Close;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //@todo check if this is machines first time opening app
            Machine machine = new Machine();
            WebConnection webRequest = new WebConnection("http://ontrackapp.org/update/register", "POST", "machine-name="+machine.getMachineName()+"&uptime="+machine.getMachineUpTime()+"&last-user="+User.username);
            string response = webRequest.getResponse();
            Debug.WriteLine(response);
            //@todo load all study material from server
        }

        private void register()
        {
            //@todo check if this is machines first time opening app
            Machine machine = new Machine();
            WebConnection webRequest = new WebConnection("http://ontrackapp.org/update/register", "POST", "machine-name=" + machine.getMachineName() + "&uptime=" + machine.getMachineUpTime() + "&last-user=" + User.username);
            string response = webRequest.getResponse();
            Debug.WriteLine(response);
            //@todo load all study material from server
        }

        private void MainWindow_Close(object sender, EventArgs e)
        {
            //@todo try save any unsaved progress
            Environment.Exit(1);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.register();
        }
    }
}
