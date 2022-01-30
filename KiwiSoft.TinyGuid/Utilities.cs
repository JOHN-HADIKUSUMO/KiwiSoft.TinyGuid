using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace KiwiSoft.TinyGuid
{
    public static class Utilities
    {
        public static string GetMACAddress()
        {
            string address = string.Empty;
            foreach (NetworkInterface network in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (network.OperationalStatus == OperationalStatus.Up)
                {
                    address = network.GetPhysicalAddress().ToString();
                    break;
                }

            }

            return address;
        }

        public static decimal ConvertToDecimal(string hexaValue)
        {
            int index = 0;
            string[] temps = hexaValue.Split();
            for(int i = temps.Length - 1; i >= 0; i--)
            {
                KeyValuePair<int,string> keyValuePair = Maps.Hexa.Where(w => w.Value == temps[i]).FirstOrDefault();
                decimal result = keyValuePair.Key ^ index;
            }
            return 0;
        }
    }
}
