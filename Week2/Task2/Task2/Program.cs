using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{ class Program
    {
       static void Main(string[] args)
        {
            int x; //initializing integer

            bool CheckPrime(int l)              //initializing prime checker function
            {
                if (l < 2)
                {
                    return false;
                }
                for (int b = 2; b <= Math.Sqrt(l); ++b)
                {
                    if (l % b == 0) { return false; }
                }
                return true;
            }
            string[] initial = File.ReadAllText(@"C:\Users\Exalted\Desktop\PP@\Week 2\Task2\Task2\bin\Debug\input.txt").Split(' ');// all info from input to sting[] 
            int[] ar = new int[initial.Length]; // array for prime numbers
            for (int i = 0; i < initial.Length; i++) // loop for checking for being prime and if its prime add to int array
            {
                x = Convert.ToInt32(initial[i]); //assigning element to x 
                if (CheckPrime(x))// check if num is prime
                {
                    ar[i] = x;                  // after adding prime number to respective cell, counter also increases by 1
                }
               

            }
            using (StreamWriter file = new StreamWriter(@"C:\Users\Exalted\Desktop\PP@\Week 2\Task2\Task2\bin\Debug\output.txt")) // creating new stream writer named file and assigning path for output file
            {
                for (int i = 0;i<ar.Length;i++)//loop for writing in the file prime numbers
                {
                    if (ar[i] != 0)
                        file.Write(ar[i] + " ");
                    else continue;
                }
            }
        }


    } }

       
    
