using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ReverseString
    {
        public void ReverseStrings()
        {
            string userInput = Console.ReadLine();
            string result = string.Empty;
            if (!string.IsNullOrEmpty(userInput))
            {
                for (int i = userInput.Length - 1; i > 0; i--)
                {
                    result = result + userInput[i];
                }
                Console.WriteLine(result);
            }
        }
    }
}
