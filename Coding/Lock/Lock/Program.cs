using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lock
{
    class Program
    {

        static void Main(string[] args)
        {
            BankAcct acct = new BankAcct(10);
            Thread[] threads = new Thread[15];

            // CurrentThread gets you the current
            // executing thread
            Thread.CurrentThread.Name = "main";

            // Create 15 threads that will call for 
            // IssueWithdraw to execute
            for (int i = 0; i < 15; i++)
            {
                // You can only point at methods
                // without arguments and that return 
                // nothing
                Thread t = new Thread(new ThreadStart(acct.IssueWithdraw));
                t.Name = i.ToString();
                threads[i] = t;
            }

            // Have threads try to execute
            for (int i = 0; i < 15; i++)
            {
                // Check if thread has started
                Console.WriteLine("Thread {0} Alive : {1}",
                    threads[i].Name, threads[i].IsAlive);
                Thread.Sleep(500);
                // Start thread
                threads[i].Start();
                
                // Check if thread has started
                Console.WriteLine("Thread {0} Alive : {1}",
                    threads[i].Name, threads[i].IsAlive);
            }

            // Get thread priority (Normal Default)
            // Also Lowest, BelowNormal, AboveNormal
            // and Highest
            // changing priority doesn't guarantee
            // the highest precedence though
            // It is best to not mess with this
            Console.WriteLine("Current Priority : {0}",
                Thread.CurrentThread.Priority);

            Console.WriteLine("Thread {0} Ending",
                Thread.CurrentThread.Name);

            Console.ReadLine();
        }
    }
}

class BankAcct
{
    private Object acctLock = new Object();
    double Balance { get; set; }
    string Name { get; set; }

    public BankAcct(double bal)
    {
        Balance = bal;
    }

    public double Withdraw(double amt)
    {
        if ((Balance - amt) < 0)
        {
            Console.WriteLine($"Sorry ${Balance} in Account");
            Thread.Sleep(500);
            return Balance;
            
        }

        lock (acctLock)
        {
            if (Balance >= amt)
            {
                Console.WriteLine("Removed {0} and {1} left in Account",
                amt, (Balance - amt));
                Balance -= amt;
                Thread.Sleep(500);
            }

            return Balance;

        }
    }

    // You can only point at methods
    // without arguments and that return 
    // nothing
    public void IssueWithdraw()
    {
        Withdraw(1);
    }
}
        
    

