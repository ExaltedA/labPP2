using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class MyThread
    {
         public Thread threadField;

        
        public MyThread(string name)
        {
            threadField = new Thread(Show);
            threadField.Name = name;
            
        }
        public void startThread()
        {
            threadField.Start();

        }
        public void Show()
        {
            for (int i =0,k=1;i<4;i++)
            {
                Console.WriteLine("{0} выводит: {1} ",Thread.CurrentThread.Name,i);
                k++;
                if (i == 3)
                {
                    Console.WriteLine(" {0} завершился ", Thread.CurrentThread.Name);
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyThread t1 = new MyThread("Threat 1");
            MyThread t2 = new MyThread("Threat 2");
            MyThread t3 = new MyThread("Threat 3");

            t1.startThread();
            t2.startThread();
            t3.startThread();
            Console.Read();


        }
        
    }
}
