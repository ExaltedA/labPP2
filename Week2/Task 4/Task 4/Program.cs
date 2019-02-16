using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Exalted\Desktop\text12.txt";
            string path1 = @"C:\Users\Exalted\Documents\copied.txt";
            FileInfo t = new FileInfo(path);
            if (File.Exists(path))
            {
                if (File.Exists(path1))
                {
                    t.CopyTo(path1, true);
                    t.Delete();
                }
            }
            else
            {
                StreamWriter r = new StreamWriter(path);
                r.Close();

                if (File.Exists(path1)==false)
                {
                    StreamWriter d = new StreamWriter(path1);
                    d.Close();
                }
                t.CopyTo(path1, true);
                t.Delete();

            }
            
            
           
        }
    }
}
