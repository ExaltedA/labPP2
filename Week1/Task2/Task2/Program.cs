using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;

namespace Task2
{
    
    class Student//creating Student class
    {
        public string name;
        public string id;
        public string year;
        public int x;
      /* public Student(string name, string id, int x)
        {
            this.name = name;
            this.id = id;
            this.x = x;
            Console.WriteLine(name + "'s id is " + id + " and he is currently " + (x + 1) + " course student.");

            //Additional method if write student info in the code
        }*/
        public Student()//main method without any "flaws"
        {
            string[] consoleread = Console.ReadLine().Split();//reading from console
            while (consoleread.Length != 3)//this loop would work until array size wouldn't be 3
            {
                Console.WriteLine("Don't try any tricks!!" +
                    " Write name, id and year of study one after another!");//warning and instructions
                consoleread = Console.ReadLine().Split();//repeating 
            }
            this.name = consoleread[0];//assigning name
            this.id = consoleread[1];//assigning id
            this.year = consoleread[2];//assigning year
            bool success = Int32.TryParse(year, out x);//checking if year was written appropriately
           
            {
                if (success)// then year will be assigned to x and then write line
                {
                    this.x = Convert.ToInt32(consoleread[2]);
                    Console.WriteLine(name + "'s id is " + id + " and he is currently " + (x + 1) + " course student.");
                }
                else//if not then warning and try again
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
        Student student = new Student();//initializing student 
       /* Student he = new Student("Ivan", "asd8", 2);*/
        
    }
}

