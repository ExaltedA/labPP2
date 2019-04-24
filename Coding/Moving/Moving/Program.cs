using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Moving
{
    class Program
    {
        static int okey = 1;
        static int x1 = 1,y1=1;
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            while (true)
            {
                Console.Clear();
                Move();
            }
        }
        public static void Move()
        {
            if(okey > 4)
            {
                okey = 1;
            }
            else if(okey == 1)
            {
                if (x1 == 40)
                {
                    okey++;
                }
                else
                {
                    x1++;
                }
            }
            else if (okey == 2)
            {
                if (y1 == 20)
                {
                    okey++;
                }
                else
                {
                    y1++;
                }
            }
            else if(okey == 3)
            {
                if (x1 == 1)
                {
                    okey++;
                }
                else
                {
                    x1--;
                }
            }
            else if(okey == 4)
            {
                if (y1 == 1)
                {
                    okey = 1;
                }
                else
                {
                    y1--;
                }
            }
            Console.SetCursorPosition(x1, y1);
            Console.Write('*');
            Thread.Sleep(100);
        } 
    }
}
