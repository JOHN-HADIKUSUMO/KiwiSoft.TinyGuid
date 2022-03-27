using KiwiSoft.TinyGuid;

namespace KiwiSoft.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            GuidGenerator guidGenerator = new GuidGenerator();  
            while(true)
            {
                Console.WriteLine(guidGenerator.UUID());
                Task.Delay(500);
            }
            Console.ReadLine();
        }
    }
}