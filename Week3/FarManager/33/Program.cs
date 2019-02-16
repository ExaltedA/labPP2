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
        public string path;//to override path in FarManager function
        public int cursor;//to hold an index of cursor
        public DirectoryInfo DIR = null; //to hold an info of path folder 
        public FileSystemInfo[] FSI = null; //to hold an info about the content of dir folder
        public FileSystemInfo f1; //to hold info about file that cursor show
        public int size;//size of possible cursor index
        
        public FarManager(string path)//to override path
        {
            this.path = path;
            cursor = 0;
        }
        public void Color(FileSystemInfo f,int index) // to change color of cursor file , folders and files
        {
            if (cursor == index)//cursor file color and info about f1
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                f1 = f;//to assign that f1 is where cursor is currently
            }
           else if (f.GetType() == typeof(DirectoryInfo)) // folder color
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else                                              // file color
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
        }
        public void Show(string path)//function that filters invisible folders and writing folder contents in the console
        {
            DIR = new DirectoryInfo(path);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            for(int k = 0,j=0; k < FSI.Length; k++)
            {
                if (FSI[k].Name.StartsWith("."))//if invisible skip
                    continue;
                Color(FSI[k],j);//decide color
                Console.WriteLine(j+1+". " + FSI[k].Name);//write in the console
                j++;//increment j to assure right numeration
            }
        }
        public void Calc()// calculating right size of files while filtering invisible
        {
            DIR = new DirectoryInfo(path);
           FSI = DIR.GetFileSystemInfos();
            size = FSI.Length;
            for(int k = 0; k < FSI.Length; k++)
            {
                if (FSI[k].Name[0] == '.')
                    size--; // if invisible decrease size so that cursor would be always visible
            }
        }
        public void Down() //if cursor index is more than number of files than it will shift to begining
        {
            cursor++;
            if (cursor == size)
                cursor = 0;
        }
        public void Up() // if cursor index less than 0(first) than shift to the end
        {
            cursor--;
            if (cursor < 0)
                cursor = size - 1;
            
        }
        public void Start()//main function It holds function of all keys that binded to appropriate function
        {
            ConsoleKeyInfo Kons;//new type for key reading
            while (true)//infinite loop
            {
                Calc();// using calc to decide size
                Show(path);//using show to show contents of folder 
                Kons = Console.ReadKey(); // variable cons reading key info
                if (Kons.Key == ConsoleKey.DownArrow) //curs down
                {
                    Down();
                }
                else if(Kons.Key == ConsoleKey.UpArrow)//curs up
                {
                    Up();
                }
                else if (Kons.Key == ConsoleKey.Enter)//if dir then enter
                {
                    
                    if (f1.GetType() == typeof(DirectoryInfo))
                    {
                        path = f1.FullName;
                        cursor = 0;
                    }
                    else// if text file then read
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
                else if (Kons.Key == ConsoleKey.Escape)//if escape go to parent folder until c:\
                {
                    if (DIR.Parent.FullName != @"C:\")
                    {
                        path = DIR.Parent.FullName;
                        cursor = 0;
                    }
                    else 
                    {
                        Console.Clear();
                        Console.WriteLine("You can't go out from this folder");//if next parent is c you will see warning that it is restricted
                        Console.ReadKey();                    
                    }
                }
                else if(Kons.Key == ConsoleKey.Backspace)//deletes file or folder if backspace
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
                else if(Kons.Key == ConsoleKey.Tab)//If tab renaming
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
                   else if (Kons.Key == ConsoleKey.Q)//if q quits manager
                {
                    Environment.Exit(1);
                }
            }

        }
    }
    class Program
    {
        static void Main(string[] args)//main program
        {
            string path = @"C:\Users\Exalted\Desktop";//path of start folder
            FarManager FM = new FarManager(path);//initializing far manager class
            FM.Start();//starting manager
            Console.ReadKey();//don't close until key is pressed
        }
    }
}