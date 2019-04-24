using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace sfetafor
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(DoIt);
            thread.Start();
            Console.CursorVisible = false;

        }
        static void DoIt()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"          
                     [____]
                 .----'  '----.
             .===|    .==.    |===.
             \   |   /####\   |   /
             /   |   \####/   |   \
             '===|     ""    |==='
             .===|            |===.
             \   |            |   /
             /   |            |   \
             '===|            |==='
             .===|            |===.
             \   |            |   /
             /   |            |   \
             '===|            |==='
                 '--.______.--'
");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine(@"          
                     [____]
                 .----'  '----.
             .===|            |===.
             \   |            |   /
             /   |            |   \
             '===|            |==='
             .===|    .==.    |===.
             \   |   /::::\   |   /
             /   |   \::::/   |   \
             '===|     ""    |==='
             .===|            |===.
             \   |            |   /
             /   |            |   \
             '===|            |==='
                 '--.______.--'
");
                
                Thread.Sleep(2000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"          
                     [____]
                 .----'  '----.
             .===|            |===.
             \   |            |   /
             /   |            |   \
             '===|            |==='
             .===|            |===.
             \   |            |   /
             /   |            |   \
             '===|            |==='
             .===|    .==.    |===.
             \   |   /&&&&\   |   /
             /   |   \&&&&/   |   \
             '===|     ""    |==='
                 '--.______.--'
");

                Thread.Sleep(2000);
                Console.Clear();
            }
        }
    }
}
