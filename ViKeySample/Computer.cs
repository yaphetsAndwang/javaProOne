using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace ViKeySample
{
    public static class Computer
    {
        public static string GetCpuID()
        {
            try
            {
                ManagementClass mc = new ManagementClass("Win32_Processor");
                ManagementObjectCollection moc = mc.GetInstances();

                String strCpuID = null;
                foreach (ManagementObject mo in moc)
                {
                    strCpuID = mo.Properties["ProcessorId"].Value.ToString();
                    break;
                }
                return strCpuID;
            }
            catch
            {
                return "";
            }

        }//end meth
        //取第一块硬盘编号   
        public static string GetHardDiskID()
        {
            try
            {
                String strHardDiskID = null;
                ManagementClass cimobject = new ManagementClass("Win32_DiskDrive");
                ManagementObjectCollection moc = cimobject.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    strHardDiskID = (string)mo.Properties["Model"].Value;
                }
                return strHardDiskID;
            }
            catch
            {
                return "";
            }
           
        }//end    
       
            
    }
}
