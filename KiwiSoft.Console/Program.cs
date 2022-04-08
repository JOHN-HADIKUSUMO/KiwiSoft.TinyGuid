using KiwiSoft.TinyGuid;

namespace KiwiSoft.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string address = Utilities.GetMACAddress();
            Console.WriteLine();
        }
    }
}