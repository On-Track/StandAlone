using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OnTrack.src.MachineEnvironment;
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
                    Debug.WriteLine("Playing");
                    timePlaying++;
                } else {
                    Debug.WriteLine("Not Playing");
                }
                
                Thread.Sleep(900);
            }
        }
    }
}
