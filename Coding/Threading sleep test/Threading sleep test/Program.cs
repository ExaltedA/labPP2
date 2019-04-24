using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threading_sleep_test
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
            
            Thread N = new Thread(Print2);

            
            N.Start();
            int num = 0;
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Thread main says: ");
                Console.WriteLine(num);

                Thread.Sleep(500);
                

            }
        }
         static void Print2()
        {
            int num = 1;
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Thread 1 says: ");
                Console.WriteLine(num);
                
                Thread.Sleep(500);
               

            }
            Console.ReadKey();
        }
    }
}
