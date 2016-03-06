using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace OnTrack.src.StudyTools
{
    class Question
    {
        /**
         *  @var string question
         **/
        private string question;
        /**
         *  @var string answer1
         **/
        private string answer1;
        /**
         *  @var string answer2
         **/
        private string answer2;
        /**
         *  @var string answer3
         **/
        private string answer3;
        /**
         *  @var string answer4
         **/
        private string answer4;
        /**
         *  @var string answer
         **/
        private string answer;
        /**
         *  @var string attempt
         **/
        private string attempt = "";
        /**
         *  @var MetroPanel panel
         **/
        private MetroPanel panel;
        /**
         *  @var MetroLabel lbQuestion
         **/
        private MetroLabel lbQuestion;
        /**
         *  @var MetroRadioButton rbAnswer1
         **/
        private MetroRadioButton rbAnswer1;
        /**
         *  @var MetroRadioButton rbAnswer2
         **/
        private MetroRadioButton rbAnswer2;
        /**
         *  @var MetroRadioButton rbAnswer3
         **/
        private MetroRadioButton rbAnswer3;
        /**
         *  @var MetroRadioButton rbAnswer4
         **/
        private MetroRadioButton rbAnswer4;

        /**
         *  @param string question
         *  @param string ans1
         *  @param string ans2
         *  @param string ans3
         *  @param string ans4
         *  @param string ans
         **/
        public Question(string question, string ans1, string ans2, string ans3, string ans4, string ans)
        {
            this.question = question;
            this.answer1 = ans1;
            this.answer2 = ans2;
            this.answer3 = ans3;
            this.answer4 = ans4;
            this.answer = ans;

            this.panel = new MetroPanel();
            this.lbQuestion = new MetroLabel();
            this.rbAnswer1 = new MetroRadioButton();
            this.rbAnswer2 = new MetroRadioButton();
            this.rbAnswer3 = new MetroRadioButton();
            this.rbAnswer4 = new MetroRadioButton();
        }

        /**
         *  @return string
         **/
        public string getQuestion()
        {
            return this.question;
        }

        /**
         *  @return string
         **/
        public string getAnswer1()
        {
            return this.answer1;
        }

        /**
         *  @return string
         **/
        public string getAnswer2()
        {
            return this.answer2;
        }

        /**
         *  @return string
         **/
        public string getAnswer3()
        {
            return this.answer3;
        }

        /**
         *  @return string
         **/
        public string getAnswer4()
        {
            return this.answer4;
        }

        /**
         *  @return string
         **/
        public string getAnswer()
        {
            return this.answer;
        }

        /**
         *  @return string
         **/
        public string getAttempt()
        {
            return this.attempt;
        }

        /**
         *  @param string answer
         **/
        public void setAttempt(string answer)
        {
            this.attempt = answer;
        }

        /**
         *  @return Panel
         **/
        public Panel create()
        {
            /**
             *  @note panel
             **/
            this.panel.SuspendLayout();
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.HorizontalScrollbarBarColor = true;
            this.panel.HorizontalScrollbarHighlightOnWheel = false;
            this.panel.HorizontalScrollbarSize = 7;
            this.panel.Location = new System.Drawing.Point(124, 3);
            this.panel.Size = new System.Drawing.Size(909, 442);
            this.panel.TabIndex = 1;
            this.panel.VerticalScrollbarBarColor = true;
            this.panel.VerticalScrollbarHighlightOnWheel = false;
            this.panel.VerticalScrollbarSize = 7;
            
            /**
             *  @note lbQuestion
             **/
            this.lbQuestion.Text = this.getQuestion();
            this.lbQuestion.Left = 0;
            this.lbQuestion.Width = this.panel.Width;
            this.lbQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbQuestion.Top = 50;
            this.lbQuestion.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbQuestion.FontWeight = MetroFramework.MetroLabelWeight.Bold;

            /**
             *  @note rbAnswer1
             **/
            this.rbAnswer1.Text = this.getAnswer1();
            this.rbAnswer1.AutoSize = true;
            this.rbAnswer1.CheckedChanged += this.rbAnswer1_CheckedChanged;
            this.rbAnswer1.Location = new System.Drawing.Point(this.panel.Width /4 , ((lbQuestion.Top + lbQuestion.Height) + 10));
            this.rbAnswer1.FontSize = MetroFramework.MetroCheckBoxSize.Tall;

            /**
             *  @note rbAnswer2
             **/
            this.rbAnswer2.Text = this.getAnswer2();
            this.rbAnswer2.AutoSize = true;
            this.rbAnswer2.Location = new System.Drawing.Point(this.panel.Width / 4, ((lbQuestion.Top + lbQuestion.Height) + 40));
            this.rbAnswer2.FontSize = MetroFramework.MetroCheckBoxSize.Tall;

            /**
             *  @note rbAnswer3
             **/
            this.rbAnswer3.Text = this.getAnswer3();
            this.rbAnswer3.AutoSize = true;
            this.rbAnswer3.Location = new System.Drawing.Point(this.panel.Width / 4, ((lbQuestion.Top + lbQuestion.Height) + 70));
            this.rbAnswer3.FontSize = MetroFramework.MetroCheckBoxSize.Tall;

            /**
             *  @note rbAnswer4
             **/
            this.rbAnswer4.Text = this.getAnswer4();
            this.rbAnswer4.AutoSize = true;
            this.rbAnswer4.Location = new System.Drawing.Point(this.panel.Width / 4, ((lbQuestion.Top + lbQuestion.Height) + 100));
            this.rbAnswer4.FontSize = MetroFramework.MetroCheckBoxSize.Tall;

            /**
             *  @note add elements to panel
             **/
            this.panel.Controls.Add(lbQuestion);
            this.panel.Controls.Add(rbAnswer1);
            this.panel.Controls.Add(rbAnswer2);
            this.panel.Controls.Add(rbAnswer3);
            this.panel.Controls.Add(rbAnswer4);

            /**
             *  @note hide the panel by default
             **/
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel.Hide();

            /**
             *  @note return the panel
             **/
            return this.panel;
        }

        /**
         *  @param object sender
         *  @param EventArgs e
         **/
        private void rbAnswer1_CheckedChanged(object sender, EventArgs e)
        {
            this.setAttempt(this.rbAnswer1.Text);
        }

        /**
         *  @param object sender
         *  @param EventArgs e
         **/
        private void rbAnswer2_CheckedChanged(object sender, EventArgs e)
        {
            this.setAttempt(this.rbAnswer2.Text);
        }

        /**
         *  @param object sender
         *  @param EventArgs e
         **/
        private void rbAnswer3_CheckedChanged(object sender, EventArgs e)
        {
            this.setAttempt(this.rbAnswer3.Text);
        }

        /**
         *  @param object sender
         *  @param EventArgs e
         **/
        private void rbAnswer4_CheckedChanged(object sender, EventArgs e)
        {
            this.setAttempt(this.rbAnswer4.Text);
        }

        /**
         *  @return Panel
         **/
        public Panel getPanel()
        {
            return this.panel;
        }

        /**
         *  @return MetroRadioButton
         **/
        public MetroRadioButton getRBAnswer1()
        {
            return this.rbAnswer1;
        }

        /**
         *  @return MetroRadioButton
         **/
        public MetroRadioButton getRBAnswer2()
        {
            return this.rbAnswer2;
        }

        /**
         *  @return MetroRadioButton
         **/
        public MetroRadioButton getRBAnswer3()
        {
            return this.rbAnswer3;
        }

        /**
         *  @return MetroRadioButton
         **/
        public MetroRadioButton getRBAnswer4()
        {
            return this.rbAnswer4;
        }
    }
}
