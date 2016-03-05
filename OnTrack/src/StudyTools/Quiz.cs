using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Collections;
using OnTrack.src.WebConnection;

namespace OnTrack.src.StudyTools
{
    class Quiz
    {
        List<Question> questions = new List<Question>();

        public void getQuestions()
        {
            src.WebConnection.WebConnection webrequest = new WebConnection.WebConnection("http://ontrackapp.org/quiz/getquestions", "POST", "");
            //Debug.WriteLine(webrequest.getResponse());
            string res = webrequest.getResponse();
            if (res != "") {
                //Debug.WriteLine("Beginning regex");
                
                foreach (Match match in Regex.Matches(res, "([^*!{]+)[{]")) {
                    List<String> data = new List<String>();
                    foreach (Match m in Regex.Matches(match.Value, "([^*!#]+)#")) {
                        data.Add(m.Value);
                    }
                    //Debug.WriteLine(data.ElementAt(0));
                    this.questions.Add(new Question(data.ElementAt(0), data.ElementAt(1), data.ElementAt(2), data.ElementAt(3), data.ElementAt(4), data.ElementAt(4)));
                }
                
            }
        }

        public void viewQuestions()
        {
            foreach (Question q in this.questions) {
                Debug.WriteLine(q.getQuestion());
            }
        }
    }
}
