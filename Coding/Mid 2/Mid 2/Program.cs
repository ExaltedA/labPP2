using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Mid_2
{

    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int x, y;

            x = rand.Next(100);
            y = rand.Next(100);
            rando(x, y);


        }
        static void rando(int x, int y)
        {
            bool t = true;
            while (t)
            {
                Random rand = new Random();
                x = rand.Next(100);
                y = rand.Next(100);
                Console.Clear();



                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(x++, y);
                Console.Write('#');
                Thread.Sleep(500);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(x, y);
                Console.Write('$');
                Thread.Sleep(500);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(x++, y);
                Console.Write('&');
                Thread.Sleep(500);
                Console.Clear();
            }
        }
    }
}
