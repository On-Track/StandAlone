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
using OnTrack.src.StudyTools;
using System.Diagnostics;
using System.Threading;

namespace OnTrack
{
    public partial class MainWindow : MetroForm
    {
        MachineStatusMonitor machineMonitor;
        Thread statusThread;

        public MainWindow()
        {
            InitializeComponent();
            new OnTrack.src.Monitor.Monitor();
            this.machineMonitor = new MachineStatusMonitor();
            this.statusThread = new Thread(status);
            this.statusThread.IsBackground = true;
            this.statusThread.Start();
            this.FormClosing += this.MainWindow_Close;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //@todo check if this is machines first time opening app
            Machine machine = new Machine();
            WebConnection webRequest = new WebConnection("http://ontrackapp.org/update/register", "POST", "machine-name="+machine.getMachineName()+"&uptime="+machine.getMachineUpTime()+"&last-user="+User.username);
            string response = webRequest.getResponse();
            //@todo load all study material from server
        }

        

        private void status()
        {
            while (true) {
                this.lbStatus.BeginInvoke(new Action(() =>
                {
                    if (machineMonitor.getIsConnected())
                    {
                        this.lbStatus.ForeColor = Color.Green;
                        this.lbStatus.Text = "Connected as " + User.username;
                    }
                    else {
                        this.lbStatus.ForeColor = Color.Red;
                        this.lbStatus.Text = "Disconnected.  Please check your internet connection";
                    }
                }));
                Thread.Sleep(1000);
            }
        }
        private void MainWindow_Close(object sender, EventArgs e)
        {
            //@todo try save any unsaved progress
            Environment.Exit(1);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            quiz.getQuestions();
            quiz.viewQuestions();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
        
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void q4wa2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nxtbutton1_Click(object sender, EventArgs e)
        {
            metropanel2.Visible = true;
        }
        private void nxtbutton2_Click(object sender, EventArgs e)
        {
            metropanel3.Visible = true;
            metropanel2.Visible = false;
        }
        private void nxtbutton3_Click(object sender, EventArgs e)
        {
            metropanel4.Visible = true;
            metropanel2.Visible = false;
            metropanel3.Visible = false;
        }

        private void bckbutton3_Click(object sender, EventArgs e)
        {
            metropanel4.Visible = false;
            metropanel2.Visible = false;
            metropanel3.Visible = true;
        }
        private void bckbutton2_Click(object sender, EventArgs e)
        {
            metropanel4.Visible = false;
            metropanel2.Visible = true;
            metropanel3.Visible = false;
        }
        private void bckbutton1_Click(object sender, EventArgs e)
        {
            metropanel4.Visible = false;
            metropanel2.Visible = false;
            metropanel3.Visible = false;
        }

        private void metropanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void metropanel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void metropanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nxtbutton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
