using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[3];
            for (int i=0,k=0;i<3;i++)
            {
                k++;
                threads[i] = new Thread(Printing);
                threads[i].Name = k.ToString();
                threads[i].Start();
            }
            
        }
        static void Printing()
        {
            Object obj = new Object();
            lock (obj)
            {
                for(int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Thread number {0} is saying Hello!)", Thread.CurrentThread.Name);
                }
            }

        }
    }
}
