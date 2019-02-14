using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{

    class Program
    {
        
        private static void toDouble(int a, string[] numbers) //a = number would be written, string array of numbers
        {
                int[] first = new int[a];// initializing first array
                int[] second = new int[a * 2];// initializing second array
            
                while (numbers.Length != a)//checking if size of string array meet the condition of int a
                {
                    Console.WriteLine("Don't try any tricks!!" +
                        " Write appropriate number of integers!!");//warning and instructions
                    numbers = Console.ReadLine().Split();//repeating 
                }
         
            
            for (int n = 0; n < a; n++)// moving numbers from string to int array
            {
                first[n] = Convert.ToInt32(numbers[n]);
            }
            for (int n = 0, r=0; r < a*2; n++)//moving and doubling numbers from first array to second
            {
                second[r] = first[n];
                r++;
                second[r] = first[n];
                r++;
            }
            for(int n= 0; n < a * 2; ++n)// write in one line the content of second array
            {
                Console.Write(second[n] + " ");
             
            }
        }       
        static void Main(string[] args)
        {
            int b = Convert.ToInt32(Console.ReadLine());//reading first number
            string[] digits = Console.ReadLine().Split();//reading numbers
            toDouble(b, digits);//
        }

    }
}
