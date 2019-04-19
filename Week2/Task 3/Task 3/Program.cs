using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_3
{
    class Program
    {
        static void A(string path, string level) // initializing function with 2 parameters(path and level(space bars))
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            Console.WriteLine(level + dir.Name);
            level += "    ";
            FileSystemInfo[] re = dir.GetFileSystemInfos();
            for (int i = 0; i < re.Length; i++)
            {
                if (re[i].GetType() == typeof(FileInfo))
                {
                    Console.WriteLine(level + re[i].Name);
                }
                else
                {
                    A(re[i].FullName, level);
                }
            }

        }

            static void Main(string[] args)
            {
                string path = @"C:\Users\Exalted\Music";
                A(path, "");

                Console.ReadKey();
            }
        } } 


