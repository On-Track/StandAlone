using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTrack.src.DateHelper
{
    /**
     *  @class DateHelper
     **/
    class DateHelper
    {
        /**
         *  @var int milliseconds
         **/
        private int milliseconds;

        #region mutator/setter methods...
        /**
         *  @param int milliseconds
         *  @return void
         **/
        public void setMilliseconds(int milliseconds)
        {
            this.milliseconds = milliseconds;
        }
        #endregion

        #region helper/getter methods...
        /**
         *  @return int
         **/
        public int getMilliSeconds()
        {
            return this.milliseconds;
        }

        /**
         *  @return int
         **/
        public int getSeconds()
        {
            return this.milliseconds / 1000;
        }

        /**
         *  @return int
         **/
        public int getMinutes()
        {
            return this.getSeconds() / 60;
        }
        
        /**
         *  @return int
         **/
        public int getHours()
        {
            return this.getMinutes() / 60;
        }

        /**
         *  @return int
         **/
        public int getDays()
        {
            return this.getHours() / 24;
        }
        #endregion
    }
}