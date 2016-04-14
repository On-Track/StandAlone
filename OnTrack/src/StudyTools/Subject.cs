using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTrack.src.StudyTools
{
    /**
     *  @class  Subject
     *  @note handles gathering and display course content to end-user
     */
    class Subject
    {
        # region static variables
        /**
         *  @var int MATH = 1
         **/
        public static int MATH = 1;
        /**
         *  @var int SCIENCE = 2
         **/
        public static int SCIENCE = 2;
        /**
         *  @var int GEOGRAOHY = 3
         **/
        public static int GEOGRAPHY = 3;
        /**
         *  @var int HISTORY = 4
         **/
        public static int HISTORY = 4;
        #endregion


        /**
         *  @var string subjectName
         **/
        private string subjectName;

        private Quiz quiz;

        private string quizURL = "http://ontrackapp.org/quiz/getquestions";

        /**
         *  @note default constructor
         *  @param int subjectName
         *  @return void
         **/
        public Subject(string subjectName)
        {
            //this.subjectName = subjectName;
        }

        public void createQuiz()
        {
            this.quiz = new Quiz(this.quizURL);
        }
    }
}
