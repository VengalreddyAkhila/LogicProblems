using System;
using System.Collections.Generic;
using System.Text;

namespace LogicProblems
{
    public class Prime
    {
        public void PrimeNumber()
        {
            Console.WriteLine("enter number to check its prime or not : ");
            int Num = Convert.ToInt32(Console.ReadLine());
            int  a = 0;
            for (int i = 2; i <= Num-1; i++)
            {
                if (Num % i == 0)
                {
                    a = a + 1;
                }
            }
            if (a > 0)
            {
                Console.WriteLine("not a Prime Number" +Num);
            }
            else
            {
                Console.WriteLine(" Prime Number" +Num);
            }
        }
    }
}
