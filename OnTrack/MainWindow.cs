﻿using System;
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
        /**
         *  @var Quiz quiz
         **/
        Quiz quiz;

        /**
         *  @note initialize gui components for the main window
         **/
        public MainWindow()
        {
            InitializeComponent();
            new OnTrack.src.Monitor.Monitor();
            this.quiz = new Quiz();
            this.machineMonitor = new MachineStatusMonitor();
            this.statusThread = new Thread(status);
            this.statusThread.IsBackground = true;
            this.statusThread.Start();
            this.FormClosing += this.MainWindow_Close;
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
            if (response.Length > 0) {
                foreach (var subject in json.subjects)
                {
                    /**
                     *  @todo create links to other content for each subject
                     **/
                }
            }
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

        /**
         *  @param object sender
         *  @param EventArgs e
         *  @return void
         **/
        private void btnTakeQuiz_Click(object sender, EventArgs e)
        {
            /**
             *  @note load questions from the server and create panels to display the questions
             **/
            this.mainPanel.Hide();
            this.HomeTabPage.Controls.Add(this.quiz.getCurrentQuestionPanel());
            this.quiz.getCurrentQuestionPanel().Show();
            /**
             *  @note add controls for the quiz
             **/
            this.controlPanel.Controls.Clear();
            this.controlPanel.Controls.Add(this.btnQuizNext);
            this.controlPanel.Controls.Add(this.btnQuizPrev);
            this.controlPanel.Controls.Add(this.btnQuizSubmit);
        }

        /**
         *  @note update index of question list to show prev question
         **/
        private void btnQuizPrev_Click(object sender, EventArgs e)
        {
            this.quiz.getCurrentQuestionPanel().Hide();
            string ans = "";
            /**
             *  @note check if an answer has been supplied
             **/
            if (this.quiz.getCurrentQuestion().getRBAnswer1().Checked) {
                ans = this.quiz.getCurrentQuestion().getRBAnswer1().Text;
            } else if (this.quiz.getCurrentQuestion().getRBAnswer2().Checked) {
                ans = this.quiz.getCurrentQuestion().getRBAnswer2().Text;
            } else if (this.quiz.getCurrentQuestion().getRBAnswer3().Checked) {
                ans = this.quiz.getCurrentQuestion().getRBAnswer3().Text;
            } else if (this.quiz.getCurrentQuestion().getRBAnswer4().Checked) {
                ans = this.quiz.getCurrentQuestion().getRBAnswer4().Text;
            }
            /**
             *  @note change the question
             **/
            this.quiz.getCurrentQuestion().setAttempt(ans);
            this.quiz.prev();
            this.HomeTabPage.Controls.Add(this.quiz.getCurrentQuestionPanel());
            this.quiz.getCurrentQuestionPanel().Show();
        }

        /**
         *  @note update index of question list to show next question
         **/
        private void btnQuizNext_Click(object sender, EventArgs e)
        {
            this.quiz.getCurrentQuestionPanel().Hide();
            string ans = "";
            /**
             *  @note check if an answer has been supplied
             **/
            if (this.quiz.getCurrentQuestion().getRBAnswer1().Checked) {
                ans = this.quiz.getCurrentQuestion().getRBAnswer1().Text;
            } else if (this.quiz.getCurrentQuestion().getRBAnswer2().Checked) {
                ans = this.quiz.getCurrentQuestion().getRBAnswer2().Text;
            } else if (this.quiz.getCurrentQuestion().getRBAnswer3().Checked) {
                ans = this.quiz.getCurrentQuestion().getRBAnswer3().Text;
            } else if (this.quiz.getCurrentQuestion().getRBAnswer4().Checked) {
                ans = this.quiz.getCurrentQuestion().getRBAnswer4().Text;
            }
            /**
             *  @note change the question
             **/
            this.quiz.getCurrentQuestion().setAttempt(ans);
            this.quiz.next();
            this.HomeTabPage.Controls.Add(this.quiz.getCurrentQuestionPanel());
            this.quiz.getCurrentQuestionPanel().Show();
        }
        
        /**
         *  @note event fired when the quiz submit buttin is clicked
         **/
        private void btnQuizSubmit_Click(object sender, EventArgs e)
        {
            /**
             *  @note if we can successfully submit the quiz, open our main page and clear our control panel
             **/
            if (this.quiz.submit()) {
                this.controlPanel.Controls.Clear();
                this.mainPanel.Show();
            }
        }
    }
}
