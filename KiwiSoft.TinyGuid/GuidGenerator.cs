using System.Net.NetworkInformation;

namespace KiwiSoft.TinyGuid
{
    public class GuidGenerator
    {
        private Random random;
        public GuidGenerator()
        {
            random = new Random();
        }
        public string UUID(bool onlyAlphanumeric = false)
        {
            string uuid;
            int total = onlyAlphanumeric ? Maps.Basic.Count : Maps.Special.Count; 
            int index0 = random.Next(Maps.MACAddresses.Count);
            int index1 = random.Next(total);
            int index2 = random.Next(total);
            string address = Maps.MACAddresses[index0];
            double value = Utilities.ConvertToDecimal(address);
            double formula = value * DateTime.Now.Ticks * random.Next(1, total);
            double power = Math.Pow(total, 10);
            uuid = (onlyAlphanumeric?Maps.Basic[index1]:Maps.Special[index2]) + Utilities.ConvertTo65Base(formula/power) + (onlyAlphanumeric ? Maps.Basic[index1] : Maps.Special[index2]);
            return uuid;
        }

    }
}
