using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            GetFizzBuzzString fizzBuzzString = new GetFizzBuzzString();
            fizzBuzzString.GetString();

            ReverseString reverseInput = new ReverseString();
            reverseInput.ReverseStrings();

        }
    }
}
