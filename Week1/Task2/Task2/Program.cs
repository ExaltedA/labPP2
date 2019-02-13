using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;

namespace Task2
{
    
    class Student
    {
        public string name;
        public string id;
        public string year;
        public int x;
        public Student(string name, string id, int x)
        {
            this.name = name;
            this.id = id;
            this.x = x;
            
        }
        public Student()
        {
            string[] consoleread = Console.ReadLine().Split();
            while (consoleread.Length != 3)
            {
                Console.WriteLine("Don't try any tricks!!" +
                    " Write name, id and year of study one after another!");
                consoleread = Console.ReadLine().Split();
            }
            this.name = consoleread[0];
            this.id = consoleread[1];
            this.year = consoleread[2];
            bool success = Int32.TryParse(year, out x);
           
            {
                if (success)
                {
                    this.x = Convert.ToInt32(consoleread[2]);
                    Console.WriteLine(name + "'s id is " + id + " and he is currently " + (x + 1) + " course student.");
                }
                else
                {
                    Console.WriteLine("Write year using integers please!");
                    Student asd = new Student();                }
            }
        }
        
    }



}
class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        
    }
}

