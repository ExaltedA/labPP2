using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threading_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread y = new Thread(Print1);
            y.Start();
            for (int i = 0; i < 100; i++)
            {
                Console.Write(0);

            }
            

            Console.ReadKey();

        }
        static void Print1()
        {
            for (int i= 0;i<100 ;i++ )
            {
                Console.Write(1);

            }
            
        }
    }
}
