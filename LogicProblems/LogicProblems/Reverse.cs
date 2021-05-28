using System;
using System.Collections.Generic;
using System.Text;

namespace LogicProblems
{
    public class Reverse
    {
        public void Rev()
        {
            Console.WriteLine("Enter a Number");
            int Num = int.Parse(Console.ReadLine());
            int Reverse = 0;
            while (Num > 0)
            {
                int remainder = Num % 10;
                Reverse = (Reverse * 10) + remainder;
                Num = Num / 10;
            }
            Console.WriteLine("Reverse No. is {0}", Reverse);
            Console.ReadLine();
        }
    }
}
