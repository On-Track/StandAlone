using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTrack.src.DateHelper
{
    class DateHelper
    {
        private int milliSeconds;

        // mutator / setter methods...
        public void setMilliseconds(int milliSeconds)
        {
            this.milliSeconds = milliSeconds;
        }


        // helper / getter methods...
        public int getMilliSeconds()
        {
            return this.milliSeconds;
        }

        public int getSeconds()
        {
            return this.milliSeconds / 1000;
        }

        public int getMinutes()
        {
            return this.getSeconds() / 60;
        }

        public int getHours()
        {
            return this.getMinutes() / 60;
        }

        public int getDays()
        {
            return this.getHours() / 24;
        }
    }
}
