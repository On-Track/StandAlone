using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTrack.src.WebConnection
{
    /**
     *  @class WebConnection
     **/
    class WebConnection
    {
        public static string CODE_LOGIN_SUCCESSFUL ="0x000A";
        public static string CODE_LOGIN_FAILED = "0x000F";
        /**
         *  @var string url
         **/
        private string url;

        /**
         *  @var string method
         **/
        private string method;

        /**
         *  @var string postData
         **/
        private string postData;

        /**
         *  @var WebHandler handler
         **/
        private WebHandler handler;

        /**
         *  @note default constructor
         *  @return void
         **/
        public WebConnection(string url, string method, string postData)
        {
            this.url = url;
            this.method = method;
            this.postData = postData;
            this.handler = new WebHandler(this.url, this.method, this.postData);
            this.handler.run();
        }

        public string getResponse()
        {
            return this.handler.getResponse();
        }

        /**
         *  @return string
         **/
        public string getURL()
        {
            return this.url;
        }

        /**
         *  @param string url
         *  @return void
         **/
        public void setURL(string url)
        {
            this.url = url;
        }
    }
}
