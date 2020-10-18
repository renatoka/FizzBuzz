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

                //Checks if the number is divisible with 3 and 5
                if (num % 3 == 0 & num % 5 == 0)
                {
                    output += "FizzBuzz";
                }

                //Checks if the number is divisible 3
                else if (num % 3 == 0)
                {
                    output += "Fizz";
                }

                //Checks if the number is divisible with 5
                else if (num % 5 == 0)
                {
                    output += "Buzz";
                }

                /*If there was output change from above(either FizzBuzz, Fizz or Buzz) 
                 * the program will print one of three strings
                 * and won't print the actual number for that string
                 * 
                 */
                if (output != "")
                {
                    Console.WriteLine(output);
                }

                //If there was not output change this will print the number that wasn't changed.
                else
                {
                    Console.WriteLine(num);
                }

                num += 1;
            }
        }
    }
}
