using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Diagnostics;

namespace OnTrack.src.MachineEnvironment
{
    /**
     *  @class MachineEnvironment
     **/
    class Machine
    {
        /**
         *  @var string machineName
         **/
        private string machineName;
        /**
         *  @var string windowsUser
         **/
        private string windowsUser;
        /**
         *  @var int machineUpTime
         **/
        private int machineUpTime = 0;
        /**
         *  @var string machineIPAddress
         **/
        private string machineIPAddress;
        /**
         *  @var string machineHostName
         **/
        private string machineHostName;
        
        /**
         *  @var Process[] processes
         **/
        private Process[] processes;
        
        /**
         *  @return string
         **/    
        public string getMachineName()
        {
            if (this.machineName == null) {
                this.machineName = Environment.MachineName;
            }
            return this.machineName;
        }

        /**
         *  @return string
         **/
        public string getWindowsUser()
        {
            if (this.windowsUser == null) {
                this.windowsUser = Environment.UserName;
            }
            return this.windowsUser;
        }

        /**
         *  @return int
         **/
        public int getMachineUpTime()
        {
            if (this.machineUpTime == 0) {
                this.machineUpTime = Environment.TickCount;
            }
            return this.machineUpTime;
        }

        /**
         *  @return string
         **/
        public string getMachineHostName()
        {
            if (this.machineHostName == null) {
                this.machineHostName = Dns.GetHostName();
            }
            return this.machineHostName;
            
        }

        /**
         *  @return string
         **/
        public string getLocalIP()
        {
            if (this.machineIPAddress == null ) {
                this.machineIPAddress = this.getLocalIPAddress();
            }
            return this.machineIPAddress;
        }

        /**
         *  @return string
         **/
        private string getLocalIPAddress()
        {
            IPAddress[] localIPAddresses = Dns.GetHostAddresses(this.getMachineHostName());
            foreach (IPAddress ip in localIPAddresses) {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork) {
                    this.machineIPAddress = ip.ToString();
                    return this.machineIPAddress;
                }
            }
            return null;
        }
        
        /**
         *  @return Process[]
         **/
        public Process[] getProcesses()
        {
            this.processes = Process.GetProcesses();
            return this.processes;
        }

        /**
         *  @return boolean
         **/
        public bool isProcessRunning(string name)
        {
            this.getProcesses();

            foreach (var process in this.processes) {
                if (process.ProcessName == name) {
                    return true;
                }
            }
            return false;
        }
    }
}
