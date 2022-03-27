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
            int loop = 0;
            int count = 0;
            while(true)
            {
                string uuid = guidGenerator.UUID();
                bool check = temp.Add(uuid);
                if(!check) count++;
                Console.WriteLine(String.Format("{0:000000000}",loop) + " " + uuid + (check?"":" is duplicated " + count));
                Task.Delay(50);
                loop++;
            }
            Console.ReadLine();
        }
    }
}