using System;
using System.Collections.Generic;
using System.Text;

namespace LogicProblems
{
    public class Fibonacci
    {
        public void Fibb(int len)
        {
           
            int a = 0, b = 1, c ;
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.WriteLine("c", c);
                a = b;
                b = c;
            }
        }
    }
}
