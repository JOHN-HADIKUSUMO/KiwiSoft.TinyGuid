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
            Console.ReadLine();
        }
    }
}