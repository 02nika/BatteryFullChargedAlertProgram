using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace WindowsFormsApp1
{
    static class Batteries
    {
        public static Dictionary<string, object> BatteryInformation()
        {
            ObjectQuery query = new ObjectQuery("Select * FROM Win32_Battery");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection collection = searcher.Get();

            Dictionary<string, object> info = new Dictionary<string, object>();

            foreach (ManagementObject mo in collection)
            {
                foreach (PropertyData property in mo.Properties)
                {
                    if (property.Value != null && property.Name == "Status" || property.Name == "EstimatedChargeRemaining")
                    {
                        info.Add(property.Name, property.Value);
                    }
                }
            }
            return info;
        }
    }
}
