using System;

namespace LogicProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logic programs");

            Console.WriteLine("Enter a choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Fibonacci fibonacci = new Fibonacci();
                    fibonacci.Fibb(5);
                    break;
                case 2:

                    PerfectNumber perfectnumber = new PerfectNumber();
                    perfectnumber.PerfectNum();
                    break;
            }
           
        }
    }
}
