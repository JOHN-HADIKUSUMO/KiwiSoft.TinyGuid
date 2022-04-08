using System.Collections;
using KiwiSoft.TinyGuid;

namespace KiwiSoft.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> temp = new HashSet<string>();
            GuidGenerator guidGenerator = new GuidGenerator();
            int count = 0;
            for(int i=0;i<100000000;i++)
            {
                string uuid = guidGenerator.UUID();
                bool check = temp.Add(uuid);
                if(!check) count++;
                Console.WriteLine(String.Format("{0:000000000}", i) + " " + uuid);
                Task.Delay(50);
            }
            Console.WriteLine("Total duplication => " + count);
            Console.ReadLine();
        }
    }
}