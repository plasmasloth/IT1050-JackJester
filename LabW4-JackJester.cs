using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabW4JackJester
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int sum;
            int x = 1;
            int y = 2;
            int z = 3;
            int value;

            Console.WriteLine("Please input the value for the first number.");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input the value for the second number.");
            number2 = int.Parse(Console.ReadLine());

            sum = number1 + number2;
            Console.WriteLine("The sum of " + number1 + " and " + number2 + " equals " + sum + ".");

            value = (x + y) * (z + 10);

            Console.WriteLine("\nThe value of the expression \"(x + y) * (z + 10)\", when x=1, y=2, and z=3, is equal to " + value);

            Console.WriteLine("\nHello\tWorld!");
            Console.WriteLine("\nHello\nWorld");
            Console.WriteLine("\n\"Hello World!\"");
            Console.WriteLine("\nHello\\World!");

            
        }
    }
}
