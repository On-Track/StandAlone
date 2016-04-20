using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using OnTrack.src.Monitor;
using OnTrack.src.WebConnection;
using OnTrack.src.MachineEnvironment;
using OnTrack.src.Models;
using OnTrack.src.StudyTools;
using System.Threading;
using Newtonsoft.Json.Linq;
using OnTrack.src.gfx;
using System.Collections.Generic;

namespace OnTrack
{
    public partial class MainWindow : MetroForm
    {
        /**
         *  @var MachineStatusMonitor machineMonitor
         **/
        MachineStatusMonitor machineMonitor;
        /**
         *  @var Thread statusThread
         **/
        Thread statusThread;

        List<Subject> subjects = new List<Subject>();

        /**
         *  @note initialize gui components for the main window
         **/
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

        /**
         *  @note seemed to be having an issue with the screen flickering when changing questions...
         *  @note tried everything from enabling built-in double buffer to disabling redraw method on resize
         *  @note snippet from http://www.codeproject.com/Questions/589712/C-plusControlsplusflickeringpluspluswhileplusMai
         **/
        protected override CreateParams CreateParams
        {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }

        /**
         *  @return void
         **/
        private void MainWindow_Load(object sender, EventArgs e)
        {
            Machine machine = new Machine();
            /**
             *  @note update machine's online status
             **/
            WebConnection webRequest = new WebConnection("http://ontrackapp.org/update/register", "POST", "machine-name="+machine.getMachineName()+"&uptime="+machine.getMachineUpTime()+"&last-user="+User.username);
            /**
             *  @note load subjects
             **/
            webRequest = new WebConnection("http://ontrackapp.org/ajax/subjects", "POST", "");
            string response = webRequest.getResponse();
            dynamic json = JObject.Parse(response);
            foreach (var subject in json.subjects) {
                Subject sub = new Subject();
                sub.setSubjectName((string)subject.title);
                this.subjects.Add(sub);
            }
            
        }

        public Subject getSubject(string subjectName)
        {
            foreach (Subject subject in this.subjects) {
                if (subject.getSubjectName() == subjectName)
                {
                    return subject;
                }
            }
            return new Subject();
        }
        
        /**
         *  @return void
         **/
        private void status()
        {
            /**
             *  @todo add a way to exit this loop
             **/
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
            /**
             *  @todo try save any unsaved progress
             **/
            Environment.Exit(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
            groupBox5.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (button2.Text == "Off")
            {
                button2.Text = "On";
            }
            else if (button2.Text == "On")
            {
                button2.Text = "Off";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Off")
            {
                button3.Text = "On";
            }
            else if (button3.Text == "On")
            {
                button3.Text = "Off";
            }
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "This button will enable/disable the reporting on reports tab";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            label4.Text = "This button will enable/disable the restriction of gaming applications.";
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void btnMathStudy_Click(object sender, EventArgs e)
        {
            this.mainPanel.Hide();
            this.HomeTabPage.Controls.Add(this.getSubject("math").createPanel(this.mainPanel));
        }

        private void btnScienceStudy_Click(object sender, EventArgs e)
        {
            this.mainPanel.Hide();
            this.HomeTabPage.Controls.Add(this.getSubject("science").createPanel(this.mainPanel));
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            this.mainPanel.Hide();
            this.HomeTabPage.Controls.Add(this.getSubject("history").createPanel(this.mainPanel));
        }

        private void btnTakeQuizMath_Click(object sender, EventArgs e)
        {
            this.getSubject("math").createQuiz();
            this.getSubject("math").getQuiz().getCurrentQuestion().create();
            this.getSubject("math").getQuiz().getCurrentQuestionPanel().Show();
            Quiz quiz = new Quiz(this.getSubject("math").getQuiz());
            quiz.Controls.Add(this.getSubject("math").getQuiz().getCurrentQuestionPanel());
            this.getSubject("math").getQuiz().getCurrentQuestionPanel().BringToFront();
            quiz.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.getSubject("science").createQuiz();
            this.getSubject("science").getQuiz().getCurrentQuestion().create();   
            this.getSubject("science").getQuiz().getCurrentQuestionPanel().Show();
            Quiz quiz = new Quiz(this.getSubject("science").getQuiz());
            quiz.Controls.Add(this.getSubject("science").getQuiz().getCurrentQuestionPanel());
            this.getSubject("science").getQuiz().getCurrentQuestionPanel().BringToFront();
            quiz.Show();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            
            this.getSubject("history").createQuiz();
            this.getSubject("history").getQuiz().getCurrentQuestion().create();
            this.getSubject("history").getQuiz().getCurrentQuestionPanel().Show();
            Quiz quiz = new Quiz(this.getSubject("history").getQuiz());
            quiz.Controls.Add(this.getSubject("history").getQuiz().getCurrentQuestionPanel());
            this.getSubject("history").getQuiz().getCurrentQuestionPanel().BringToFront();
            quiz.Show();
        }
    }
}
