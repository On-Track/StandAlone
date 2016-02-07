using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace OnTrack.src.WebConnection
{
    /**
     *  @class WebHandler
     **/
    class WebHandler
    {
        /**
         *  @var WebRequest request
         **/
        private WebRequest request;
        /**
         *  @var HttpWebResponse response
         **/
        private HttpWebResponse response;
        /**
         *  @var string responseData
         **/
        private string responseData;

        /**
         *  @note default constructor
         *  @return void
         **/
        public WebHandler()
        {

        }

        /**
         *  @return string
         **/
        public string getResponseData()
        {
            return this.responseData;
        }
    }
}
