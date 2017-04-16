using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tests the 1.100 numbers and prints the text when matched
            for (int i=1;i<=100;i++)
            {
                Console.WriteLine(FizzBuzz.Library.FizzBuzzer.GetValue(i));
            }
            Console.ReadLine();
        }
    }
}
