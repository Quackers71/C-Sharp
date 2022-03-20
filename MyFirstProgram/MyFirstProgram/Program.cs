using System;

namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("& I Love Nando's");

            string z = "";
            string message = "The answer is " + z;
            Console.WriteLine(message);
                       
            int number = 15;
            number = number + 10;
            number = 36 * 15;
            number = 12 - (42 / 7);
            Console.WriteLine("42 divided by 7 = "+number);
            number += 10;
            number *= 3;
            number = 71 / 3;
            Console.WriteLine("71 divided by 3 = "+number);

            int count = 0;
            count++;
            Console.WriteLine("count++ = " + count);
            count--;
            Console.WriteLine("count-- = " + count);

            string result = "Hello";
            result += " again, " + result;
            Console.WriteLine(result);

            bool yesNo = false;
            bool anotherBool = true;

            yesNo = !anotherBool;
            Console.WriteLine("yesNo = " + yesNo);

            Console.Beep();
        }
    }
}

// pg. 48 - 48/948