using System;

namespace Package
{
    class Program
    {
        static void Main(string[]args)
        {
            //Start of the program that asks how heavy the package is
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Package weight?");
            int weight = Convert.ToInt32(Console.ReadLine());
            //Stops the program if package weight is over 50
            bool overWeight = weight > 50;
            if (overWeight == true)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }
            //Asks for the dimentions of the package
            Console.WriteLine("Package width?");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Package height?");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Package length?");
            int length = Convert.ToInt32(Console.ReadLine());
            //Stops the program if package dimentions are over 50
            bool tooBig = (width + height + length) > 50;
            if (tooBig == true)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }
            //Gets final price and shows it to the user
            int price = ((width * height * length) * weight) / 100;
            Console.WriteLine("Your package total comes to $" + price + ".00");
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}