using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace OnTrack
{
    public partial class Quiz : MetroForm
    {
        OnTrack.src.StudyTools.Quiz quiz;
        public Quiz(OnTrack.src.StudyTools.Quiz quiz)
        {
            this.quiz = quiz;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void quizPrev_Click(object sender, EventArgs e)
        {

            this.quiz.getCurrentQuestionPanel().Hide();
            string ans = "";
            /**
+             *  @note check if an answer has been supplied
+             **/
            if (this.quiz.getCurrentQuestion().getRBAnswer1().Checked)
            {
                ans = this.quiz.getCurrentQuestion().getRBAnswer1().Text;
            }
            else if (this.quiz.getCurrentQuestion().getRBAnswer2().Checked)
            {
                ans = this.quiz.getCurrentQuestion().getRBAnswer2().Text;
            }
            else if (this.quiz.getCurrentQuestion().getRBAnswer3().Checked)
            {
                ans = this.quiz.getCurrentQuestion().getRBAnswer3().Text;
            }
            else if (this.quiz.getCurrentQuestion().getRBAnswer4().Checked)
            {
                ans = this.quiz.getCurrentQuestion().getRBAnswer4().Text;
            }
            /**
+             *  @note change the question
+             **/
            this.quiz.getCurrentQuestion().setAttempt(ans);
            this.quiz.prev();
            this.Controls.Add(this.quiz.getCurrentQuestionPanel());
            this.quiz.getCurrentQuestionPanel().BringToFront();
            this.quiz.getCurrentQuestionPanel().Show();
        }

        private void quizNext_Click(object sender, EventArgs e)
        {
            this.quiz.getCurrentQuestionPanel().Hide();
            string ans = "";
            if (this.quiz.getCurrentQuestion().getRBAnswer1().Checked)
            {
                ans = this.quiz.getCurrentQuestion().getRBAnswer1().Text;
            }
            else if (this.quiz.getCurrentQuestion().getRBAnswer2().Checked)
            {
                ans = this.quiz.getCurrentQuestion().getRBAnswer2().Text;
            }
            else if (this.quiz.getCurrentQuestion().getRBAnswer3().Checked)
            {
                ans = this.quiz.getCurrentQuestion().getRBAnswer3().Text;
            }
            else if (this.quiz.getCurrentQuestion().getRBAnswer4().Checked)
            {
                ans = this.quiz.getCurrentQuestion().getRBAnswer4().Text;
            }
            this.quiz.getCurrentQuestion().setAttempt(ans);
            this.quiz.next();
            this.Controls.Add(this.quiz.getCurrentQuestionPanel());
            this.quiz.getCurrentQuestionPanel().BringToFront();
            this.quiz.getCurrentQuestionPanel().Show();
        }

        private void quizFinish_Click(object sender, EventArgs e)
        {
            if (this.quiz.submit())
            {
                this.Hide();
            }
        }
    }
}
