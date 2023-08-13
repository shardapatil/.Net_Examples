using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        public delegate void salDelegate(double sal);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            salDelegate sd = Program.Deposit;
            sd += Reward;
            sd(5000);
        }

        static double salary = 2000;
        public static void Deposit(double amount)
        {
            salary = salary + amount;
            Console.WriteLine("total salary: "+ salary);
        }

        public static void Reward(double amount)
        {
            if(salary > 5000)
            {
                salary = salary + amount;
                Console.WriteLine("total amount after reward: "+ salary);
            }
            else
            {
                Console.WriteLine("no reward added, total salary: "+salary);
                
            }
        }
    }
}
