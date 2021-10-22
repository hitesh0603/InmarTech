using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class GetFizzBuzzString
    {
        public void GetString()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
            }
        }
    }
}
