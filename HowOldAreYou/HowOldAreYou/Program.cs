using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowOldAreYou
{
    class Program
    {

        //less than 16: you can't drive

        //greater than or equal to 16, but less than or equal to 17: you can drive but not vote

        //greater than 17, but less than or equal to 24: you can vote but not rent a car

        //greater than 24: you can do pretty much anything

        static void Main(string[] args)
        {
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello {0}, how old are you?", name);

            int age = int.Parse(Console.ReadLine());

            if (age < 16)
            {
                Console.WriteLine("You can't drive quite yet.");
            }
            if (age >= 16 & age <= 17 )
            {
                Console.WriteLine("You can drive but you can't vote quite yet.");
            }
            if (age > 17 & age <= 24)
            {
                Console.WriteLine("You can vote but you can't rent a car quite yet.");
            }
            if (age > 24)
            {
                Console.WriteLine("You can do just about anything.");
            }
            Console.ReadLine();

        }
    }
}
