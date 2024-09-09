using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            //Prompts user to give 3 numbers
            Console.WriteLine("Enter 3 numbers: ");
            //Converts user input to three integer variables for comparison
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            //Stores numbers in array to allow for comparison
            int[] myNumbers = { num1, num2, num3 };
            //Divides space between prompts
            Console.WriteLine("");
            //Outputs largest value from myNumbers array
            Console.WriteLine($"The largest number is: {myNumbers.Max()}");
            //Pauses program to view
            Console.ReadLine();
        }
    }
}
