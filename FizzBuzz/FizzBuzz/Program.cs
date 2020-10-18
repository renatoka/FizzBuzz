using System;
using System.ComponentModel.Design.Serialization;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            while (num != 100)
            {
                string output = "";

                if (num % 3 == 0 & num % 5 == 0)
                {
                    output += "FizzBuzz";
                }
                else if(num % 3 == 0)
                {
                    output += "Fizz";
                }
                else if(num % 5 == 0)
                {
                    output += "Buzz";
                }

                if (output != "")
                {
                    Console.WriteLine(output);
                }
                else
                {
                    Console.WriteLine(num);
                }

                num += 1;
            }
        }
    }
}
