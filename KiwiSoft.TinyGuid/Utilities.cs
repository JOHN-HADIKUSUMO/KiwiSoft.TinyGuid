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

        public static double ConvertToDecimal(string hexaValue)
        {
            int j = 0;
            double result = 0;
            byte[] temps = Encoding.UTF8.GetBytes(hexaValue);
            for(int i = temps.Length - 1; i >= 0; i--)
            {
                string keyToFind = Encoding.UTF8.GetString(new byte[] { temps[i] });
                KeyValuePair<int,string> keyValuePair = Maps.Hexa.Where(w => w.Value == keyToFind).FirstOrDefault();
                double count = keyValuePair.Key * Math.Pow(16,j);
                result += count;
                j++;
            }
            return result;
        }

        public static string ConvertTo65Base(double number)
        {
            List<string> result = new List<string>();
            int baseNumber = 65;
            int power = 0;
            while(true)
            {
                double exitCode = Math.Pow(baseNumber, power);
                if (exitCode > number)
                {
                    power--;
                    break;
                }
                power++;
            }
            for(int i = power; i >= 0; i--)
            {
                int a = (int)Math.Floor(number / Math.Pow(baseNumber, i));
                number -= (a * Math.Pow(baseNumber, i));
                result.Add(Maps.Special[a]);
            }

            return string.Join("", result);
        }
    }
}
