using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace OnTrack.src.MachineEnvironment
{
    class MachineEnvironment
    {
        private string machineName;
        private string windowsUser;
        private int machineUpTime = 0;
        private string machineIPAddress;
        private string machineHostName;
            
        public string getMachineName()
        {
            if (this.machineName == null) {
                this.machineName = Environment.MachineName;
            }
            return this.machineName;
        }

        public string getWindowsUser()
        {
            if (this.windowsUser == null) {
                this.windowsUser = Environment.UserName;
            }
            return this.windowsUser;
        }

        public int getMachineUpTime()
        {
            if (this.machineUpTime == 0) {
                this.machineUpTime = Environment.TickCount;
            }
            return this.machineUpTime;
        }

        public string getMachineHostName()
        {
            if (this.machineHostName == null) {
                this.machineHostName = Dns.GetHostName();
            }
            return this.machineHostName;
            
        }

        public string getLocalIP()
        {
            if (this.machineIPAddress == null ) {
                this.machineIPAddress = this.getLocalIPAddress();
            }
            return this.machineIPAddress;
        }

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
    }
}
