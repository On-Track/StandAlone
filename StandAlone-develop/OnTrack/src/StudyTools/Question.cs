using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTrack.src.StudyTools
{
    class Question
    {
        private string question;
        private string answer1;
        private string answer2;
        private string answer3;
        private string answer4;
        private string answer;

        public Question(string question, string ans1, string ans2, string ans3, string ans4, string ans)
        {
            this.question = question;
            this.answer1 = ans1;
            this.answer2 = ans2;
            this.answer3 = ans3;
            this.answer4 = ans4;
            this.answer = ans;
        }

        public string getQuestion()
        {
            return this.question;
        }
    }
}
