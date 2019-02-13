using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        public static bool CheckPrime(int x)//initializing prime checker function
        { if (x < 2) {
                return false;
            }
            for (int b = 2; b <= Math.Sqrt(x); ++b)
            {
                if (x % b == 0) { return false; }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int length;// how much numbers you are going to enter(length of the array)
            length = Convert.ToInt32(Console.ReadLine());//assigning number to variable length (initially converting from string to int) 
            int[] a = new int[length]; //creating int array
            int num = 0, x;//initializing prime counter and variable which will help in loop
            string[] numbers = Console.ReadLine().Split();//reading numbers from the console and splitting them apart
            for (int i = 0; i < length; ++i)// loop for checking for being prime and if its prime add to int array
            {
                x = Convert.ToInt32(numbers[i]);
                if (CheckPrime(x))
                {
                    a[num++] = x;// after adding prime number to respective cell, counter also increases by 1
                }
            }
                Console.WriteLine(num);// returning counter to the console
                for(int i = 0; i < num; ++i)// loop for returning prime numbers
                {
                    Console.Write(a[i].ToString() + " ");
                }
            }


        }
    }

