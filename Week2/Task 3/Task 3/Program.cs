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
            DirectoryInfo dir = new DirectoryInfo(path);//creating DirectoryInfo class dir with inserted path 
            level += "    ";// adding space bars to level if folders or in the beginning
            Console.WriteLine(level + dir.Name); // writing name of file of path given
            FileSystemInfo[] inf = dir.GetFileSystemInfos();//creating filesysteminfo array type for saving info about dir
            for (int i = 0; i < inf.Length; i++)
            { 
                
                if (inf[i].GetType() == typeof(FileInfo))
                {
                    Console.WriteLine(level + inf[i].Name);
                }
                else
                {
                    A(inf[i].FullName, level);

                }

            }
        }
        static void Main(string[] args)
        {
            string path = @"C:\Users\Exalted\Music";
            A(path,"");

            Console.ReadKey();
        }
    }
}

