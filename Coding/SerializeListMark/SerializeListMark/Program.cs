using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SerializeListMark
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(sleep);
            t.Start();
            Console.Read();
        }
        static void sleep()
        {
            while (true)
            {
                Console.WriteLine("Hello");
                Thread.Sleep(2000);
                Console.WriteLine("Oh I am sleepy");
                Thread.Sleep(1000);
            }

        }
    }
}
