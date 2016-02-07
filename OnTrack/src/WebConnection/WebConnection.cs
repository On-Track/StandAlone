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
        /**
         *  @var string url
         **/
        private string url;

        /**
         *  @note default constructor
         *  @return void
         **/
        public WebConnection()
        {
            
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
