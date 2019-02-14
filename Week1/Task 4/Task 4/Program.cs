using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Star(int a)
        {
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("[*]");
                }
                Console.WriteLine(" ");
            }
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            Star(a);
        }
    }
}
