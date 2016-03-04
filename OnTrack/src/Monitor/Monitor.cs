using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OnTrack.src.MachineEnvironment;
using OnTrack.src.Models;
using OnTrack.src.WebConnection;
using System.Diagnostics;

namespace OnTrack.src.Monitor
{
    class Monitor
    {
        /**
         *  @var Thread
         **/
        private Thread monitorThread;
        
        /**
         *  @var bool
         **/
        private bool isMonitoring;

        /**
         *  @var Machine
         **/
        private Machine machine;

        /**
         *  @var int 
         **/
        private int timePlaying = 0;


        public Monitor()
        {
            this.isMonitoring = true;
            machine = new Machine();
            this.monitorThread = new Thread(run);
            this.monitorThread.IsBackground = true;
            this.monitorThread.Start();
        }

        /**
         *  @return void
         **/
        public void run()
        {
            while (this.isMonitoring) {
                if (machine.isProcessRunning("Steam") || machine.isProcessRunning("Origin")) {
                    this.timePlaying++;
                    Debug.WriteLine("Playing - " + this.timePlaying);
                    if ((this.timePlaying % 60) == 0) {
                        src.WebConnection.WebConnection webrequest = new src.WebConnection.WebConnection("http://ontrackapp.org/update/playing", "POST", "username=" + User.username+"&time="+this.timePlaying);
                        this.timePlaying = 0;
                    }
                } else {

                }
                /**
                 *  @note check if process is running every 1000ms
                 **/
                Thread.Sleep(1000);
            }
        }
    }
}
