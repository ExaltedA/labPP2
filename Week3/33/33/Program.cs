using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _33
{
    class FarManager
    {
        public string path;
        public int cursor;
        public DirectoryInfo DIR = null;
        public FileSystemInfo[] FSI = null;
        public FileSystemInfo f1;
        public int size;
        
        public FarManager(string path)
        {
            this.path = path;
            cursor = 0;
        }
        public void Color(FileSystemInfo f,int index)
        {
            if (cursor == index)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                f1 = f;
            }
           else if (f.GetType() == typeof(DirectoryInfo))
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
        }
        public void Show(string path)
        {
            DIR = new DirectoryInfo(path);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            for(int k = 0,j=0; k < FSI.Length; k++)
            {
                if (FSI[k].Name.StartsWith("."))
                    continue;
                Color(FSI[k],j);
                Console.WriteLine(j+1+". " + FSI[k].Name);
                j++;
            }
        }
        public void Calc()
        {
            DIR = new DirectoryInfo(path);
           FSI = DIR.GetFileSystemInfos();
            size = FSI.Length;
            for(int k = 0; k < FSI.Length; k++)
            {
                if (FSI[k].Name[0] == '.')
                    size--;
            }
        }
        public void Down()
        {
            cursor++;
            if (cursor == size)
                cursor = 0;
        }
        public void Up()
        {
            cursor--;
            if (cursor < 0)
                cursor = size - 1;
            
        }
        public void Start()
        {
            ConsoleKeyInfo Kons;
            while (true)
            {
                Calc();
                Show(path);
                Kons = Console.ReadKey(); 
                if (Kons.Key == ConsoleKey.DownArrow)
                {
                    Down();
                }
                else if(Kons.Key == ConsoleKey.UpArrow)
                {
                    Up();
                }
                else if (Kons.Key == ConsoleKey.Enter)
                {
                    
                    if (f1.GetType() == typeof(DirectoryInfo))
                    {
                        path = f1.FullName;
                        cursor = 0;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        StreamReader sr = new StreamReader(f1.FullName);
                        Console.WriteLine(sr.ReadToEnd());
                        sr.Close();
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else if (Kons.Key == ConsoleKey.Escape)
                {
                    if (DIR.Parent.FullName != @"C:\")
                    {
                        path = DIR.Parent.FullName;
                        cursor = 0;
                    }
                    else 
                    {
                        Console.Clear();
                        Console.WriteLine("You can't go out from this folder");
                        Console.ReadKey();                    
                    }
                }
                else if(Kons.Key == ConsoleKey.Backspace)
                {
                    if (f1.GetType() == typeof(DirectoryInfo))
                    {
                        cursor = 0;
                        Directory.Delete(f1.FullName,true);
                    }
                    else
                    {
                        cursor = 0;
                        File.Delete(f1.FullName);
                    }
                }
                else if(Kons.Key == ConsoleKey.Tab)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.Write("Write the name Of the folder : ");
                    string name = Console.ReadLine();
                    string NewPath = Path.Combine(DIR.FullName, name);
                    if (f1.GetType() == typeof(DirectoryInfo))
                    {
                        Directory.Move(f1.FullName, NewPath);
                    }
                    else
                    {
                        File.Move(f1.FullName, NewPath);
                    }
                }
                
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Exalted\Desktop";
            FarManager FM = new FarManager(path);
            FM.Start();
            Console.ReadKey();
        }
    }
}