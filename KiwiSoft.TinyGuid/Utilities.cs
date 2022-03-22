using System;
using System.Text.Encodings;
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

        private static decimal Power(int i)
        {
            if (i == 0) return 1;
            if (i == 1) return 16;
            decimal result = 16;
            for(int j=2;j<=i;j++)
            {
                result = result * 16;
            }
            return result;
        }
        public static decimal ConvertToDecimal(string hexaValue)
        {
            int j = 0;
            decimal result = 0;
            byte[] temps = Encoding.UTF8.GetBytes(hexaValue);
            for(int i = temps.Length - 1; i >= 0; i--)
            {
                string keyToFind = Encoding.UTF8.GetString(new byte[] { temps[i] });
                KeyValuePair<int,string> keyValuePair = Maps.Hexa.Where(w => w.Value == keyToFind).FirstOrDefault();
                decimal count = (decimal)keyValuePair.Key * (decimal)Math.Pow(16,j);
                result += count;
                j++;
            }
            return result;
        }

        public static string ConvertTo65Base(decimal number)
        {
            if (number < 65) return Maps.Special[(int)number];

            return string.Empty;
        }
    }
}
