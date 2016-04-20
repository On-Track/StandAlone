using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using MetroFramework;

namespace OnTrack.src.StudyTools
{
    /**
     *  @class  Subject
     *  @note handles gathering and display course content to end-user
     */
    public class Subject
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

        private string quizURL = "http://ontrackapp.org/ajax/getquestions/";

        private Panel panel;
        private Panel parentPanel;
        private HtmlDocument htmlDocument;
        private WebBrowser webBrowser;

        private MetroFramework.Controls.MetroButton btnClose;

        /**
         *  @note default constructor
         *  @param int subjectName
         *  @return void
         **/
        public Subject()
        {
            
        }

        public Panel create(string html)
        {
            this.panel = new System.Windows.Forms.Panel();
            this.panel.Dock = DockStyle.Fill;
            this.panel.BringToFront();
            this.panel.BackColor = MetroColors.White;

            this.webBrowser = new WebBrowser();
            this.webBrowser.Width = 1030;
            this.webBrowser.Height = 400;
            this.webBrowser.DocumentText = html;
            this.htmlDocument = this.webBrowser.Document;

            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnClose.Text = "close";
            this.btnClose.Width = 50;
            this.btnClose.Height = 20;
            this.btnClose.Location = new System.Drawing.Point(990, 422);
            this.btnClose.Theme = MetroThemeStyle.Dark;
            this.btnClose.BringToFront();
            this.btnClose.Click += new EventHandler(this.btnClose_Click);


            /**
             *
             */
            this.panel.Controls.Add(this.webBrowser);
            this.panel.Controls.Add(this.btnClose);

            this.panel.Show();
            return this.panel;
        }

        public void close()
        {
            this.panel.Hide();
        }

        public Quiz getQuiz()
        {
            return this.quiz;
        }

        public void setSubjectName(string subjectName)
        {
            this.subjectName = subjectName;
        }

        public string getSubjectName()
        {
            return this.subjectName;
        }

        public Panel getContent()
        {
            string html = "";
            OnTrack.src.WebConnection.WebConnection webRequest = new OnTrack.src.WebConnection.WebConnection("http://ontrackapp.org/ajax/subjectContent/", "POST", "subject="+this.subjectName+"&user="+OnTrack.src.Models.User.username);
            string response = webRequest.getResponse();
            if (response.Length > 0) {
                dynamic json = JObject.Parse(response);
                foreach (var entry in json["entries"]) {
                    html += entry.body;
                }
            }
            return this.create(html);
        }

        public Panel createPanel(Panel panel)
        {
            this.parentPanel = panel;
            return this.getContent();
        }

        public void createQuiz()
        {
            this.quiz = new Quiz(this.quizURL+this.subjectName);
        }

        public void btnClose_Click(object sender, EventArgs e)
        {
            this.panel.Hide();
            this.parentPanel.Show();
        }
    }
}
