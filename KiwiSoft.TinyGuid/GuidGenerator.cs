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
        public string UUID()
        {
            string uuid;
            int index0 = random.Next(65);
            int index1 = random.Next(65);
            int index2 = random.Next(65);
            string address = Maps.MACAddresses[index0];
            double value = Utilities.ConvertToDecimal(address);
            double formula = value * DateTime.Now.Ticks * random.Next(1, 65);
            double power = Math.Pow(65, 10);
            uuid = Maps.Special[index1]+ Utilities.ConvertTo65Base(formula/power) + Maps.Special[index2];
            return uuid;
        }

    }
}
