using System;
using OnTrack.src.MachineEnvironment;
using System.Threading;
using OnTrack.src.Models;
using System.Diagnostics;

namespace OnTrack.src.Monitor
{
    class MachineStatusMonitor
    {
        /**
         *  @var Thread updateUserThread
         **/
        private Thread updateUserThread;
        /**
         *  @var Thread updateMachineThread
         **/
        private Thread updateMachineThread;
        /**
         *  @var bool isMonitoring
         **/
        private bool isMonitoring;
        /**
         *  @var Machine machine
         **/
        private Machine machine;
        /**
         *  @var bool isConnected
         **/
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
            while (this.isMonitoring) {
                try {
                    src.WebConnection.WebConnection useronlinerequest = new src.WebConnection.WebConnection("http://ontrackapp.org/ajax/updateUserOnlineStatus/" + User.username, "POST", "method=client app");
                    useronlinerequest.getResponse();
                } catch (Exception e) {
                    this.isConnected = false;
                    Debug.WriteLine(e.Message);
                }
                Thread.Sleep(1000);
            }
        }

        /**
         *  @return void
         **/
        public void updateMachine()
        {
            while (this.isMonitoring) {
                try {
                    src.WebConnection.WebConnection deviceonlinerequest = new src.WebConnection.WebConnection("http://ontrackapp.org/ajax/updateDeviceOnlineStatus", "POST", "machine-name=" + machine.getMachineName() + "&username=" + User.username + "&uptime=" + machine.getMachineUpTime());
                    if (deviceonlinerequest.getRequestStatusDescription() == "OK") {
                        this.isConnected = true;
                    } else {
                        this.isConnected = false;
                    }
                    deviceonlinerequest.getResponse();
                } catch (Exception) {
                    this.isConnected = false;
                }
                Thread.Sleep(1000);
            }
        }

        /**
         *  @return bool
         **/
        public bool getIsConnected()
        {
            return this.isConnected;
        }
    }
}
