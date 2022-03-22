using KiwiSoft.TinyGuid;

namespace KiwiSoft.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            string address = Utilities.GetMACAddress();
            double result = Utilities.ConvertToDecimal(address);
            string babe = Utilities.ConvertTo65Base(result + Environment.TickCount);
            Console.WriteLine(babe);
            //Utilities.ConvertTo65Base(result);
            //Console.WriteLine(address);
            //Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}