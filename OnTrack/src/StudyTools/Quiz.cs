using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Windows.Forms;
using OnTrack.src.Models;
using Newtonsoft.Json.Linq;

namespace OnTrack.src.StudyTools
{
    class Quiz
    {
        /**
         *  @var List<Question> questions
         **/
        List<Question> questions = new List<Question>();
        /**
         *  @var List<Panel> questionPanels
         **/
        List<Panel> questionPanels = new List<Panel>();
        /**
         *  @var int index
         **/
        private int index = 0;

        /**
         *  @note pull a list of available questions from the server and store in a json object
         **/
        public Quiz()
        {
            src.WebConnection.WebConnection webrequest = new WebConnection.WebConnection("http://ontrackapp.org/quiz/getquestions", "POST", "");
            string response = webrequest.getResponse();
            dynamic json = JObject.Parse(response);
            /**
             *  @note iterate through json object and create a question object for each question in the bank
             **/
            foreach (var question in json.questions)
            {
                Question q = new Question((string)question.question, (string)question.answer1, (string)question.answer2, (string)question.answer3, (string)question.answer4, (string)question.answer);
                this.questions.Add(q);
                q.create();
            }
        }

        /**
         *  @return List<Question>
         **/
        public List<Question> getQuestions()
        {
            return this.questions;
        }

        /**
         *  @param int i
         **/
        public void incIndex(int i)
        {
            if (this.index+i >= this.questions.Count) {
                this.index = 0;
            } else {
                this.index += i;
            }
        }

        /**
         *  @param int i
         **/
        public void decIndex(int i)
        {
            if (this.index - i <= 0) {
                this.index = (this.questions.Count-1);
            } else {
                this.index -= i;
            }
        }

        /**
         *  @return void
         **/
        public void next()
        {
            this.incIndex(1);
        }

        /**
         *  @return void
         **/
        public void prev()
        {
            this.decIndex(1);
        }

        /**
         *  @return Question
         **/
        public Question getCurrentQuestion()
        {
            return this.questions.ElementAt(this.index);
        }

        /**
         *  @return Panel
         **/
        public Panel getCurrentQuestionPanel()
        {
            return this.questions.ElementAt(this.index).getQuestionPanel();
        }

        /**
         *  @return bool
         **/
        public bool submit()
        {
            double questionCount = this.questions.Count;
            double correct = 0;
            /**
             *  @note iterate through each question and make sure it's been answered
             *  @note also check if the supplied attempt is correct
             **/
            foreach (var question in this.questions) {
                if (question != null) {
                    if (question.getAttempt().Equals("") || question == null) {
                        MessageBox.Show("Please complete all questions");
                        return false;
                    } else if (question.getAttempt().Equals(question.getAnswer())) {
                        correct++;
                    }
                }
            }
            /**
             *  @note get result of the quiz as a percentage
             **/
            double result = (correct/questionCount)*100;
            /**
             *  @note hide question panels
             **/
            foreach (var question in this.questions) {
                question.getQuestionPanel().Hide();
            }
            /**
             *  @note sync the result upstream
             **/
            src.WebConnection.WebConnection webrequest = new src.WebConnection.WebConnection("http://ontrackapp.org/quiz/submit/" + User.username, "POST", "result="+result);
            MessageBox.Show(correct + "/" + questionCount + " " + ((correct / questionCount) * 100) + "%");
            return true;
        }

        public int getIndex()
        {
            return this.index;
        }

        public void reset()
        {
            foreach (Question q in this.questions)
            {
                q.reset();
            }
            this.index = 0;
            this.getQuestions();
        }
    }
}
