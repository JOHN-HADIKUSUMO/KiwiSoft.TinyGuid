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
            int index = random.Next(65);
            string address = Maps.MACAddresses[index];
            double value = Utilities.ConvertToDecimal(address);
            uuid = Utilities.ConvertTo65Base(value + Environment.TickCount);
            return uuid;
        }

    }
}
