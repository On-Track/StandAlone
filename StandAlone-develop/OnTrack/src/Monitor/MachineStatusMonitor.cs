using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnTrack.src.MachineEnvironment;
using System.Threading;
using OnTrack.src.Models;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;

namespace OnTrack.src.Monitor
{
    class MachineStatusMonitor
    {
        /**
         *  @var Thread
         **/
        private Thread updateUserThread;
        private Thread updateMachineThread;

        /**
         *  @var bool
         **/
        private bool isMonitoring;

        /**
         *  @var Machine
         **/
        private Machine machine;

        private bool isConnected = false;


        public MachineStatusMonitor()
        {
            this.isMonitoring = true;
            machine = new Machine();

            this.updateUserThread= new Thread(updateUser);
            this.updateUserThread.IsBackground = true;
            this.updateUserThread.Start();

            this.updateMachineThread = new Thread(updateMachine);
            this.updateMachineThread.IsBackground = true;
            this.updateMachineThread.Start();
        }

        /**
         *  @return void
         **/
        public void updateUser()
        {
            while (this.isMonitoring)
            {
                try
                {
                    src.WebConnection.WebConnection useronlinerequest = new src.WebConnection.WebConnection("http://ontrackapp.org/update/apponline", "POST", "username=" + User.username);
                    useronlinerequest.getResponse();
                }
                catch (Exception e) {
                    this.isConnected = false;
                    Debug.WriteLine(e.Message);
                }
                Thread.Sleep(1000);
            }
        }

        public void updateMachine()
        {
            while (this.isMonitoring)
            {
                try {
                    src.WebConnection.WebConnection deviceonlinerequest = new src.WebConnection.WebConnection("http://ontrackapp.org/update/deviceonline", "POST", "machine-name=" + machine.getMachineName() + "&username=" + User.username + "&uptime=" + machine.getMachineUpTime());
                    if (deviceonlinerequest.getRequestStatusDescription() == "OK")
                    {
                        this.isConnected = true;
                    } else {
                        this.isConnected = false;
                    }
                    deviceonlinerequest.getResponse();
                } catch (Exception) {
                    this.isConnected = false;
                }
                //Debug.WriteLine(this.isConnected);
                Thread.Sleep(1000);
            }
        }

        public bool getIsConnected()
        {
            return this.isConnected;
        }
    }
}
