using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;   

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            string file = File.ReadAllText(@"C:\Users\Exalted\Desktop\PP@\Week 2\Task 1\Task 1\bin\Debug\input.txt");
            char[] polindrome = file.ToArray();
            Array.Reverse(polindrome);
            a = new string(polindrome);
            if (a == file)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
