using KiwiSoft.TinyGuid;

namespace KiwiSoft.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            string address = Utilities.GetMACAddress();
            decimal result = Utilities.ConvertToDecimal(address);
            Console.WriteLine(address);
            Console.WriteLine(result);
            //Console.WriteLine(Utilities.Power(0));
            //Console.WriteLine(Utilities.Power(1));
            //Console.WriteLine(Utilities.Power(2));
            //Console.WriteLine(Utilities.Power(3));
            Console.ReadLine();
        }
    }
}