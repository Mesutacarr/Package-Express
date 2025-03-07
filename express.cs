using System;

namespace SwiftCargo
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateShippingFee();
        }

        static void CalculateShippingFee()
        {
            Console.WriteLine("Welcome to SwiftCargo! Please follow the instructions below to estimate your shipping cost.");

            // Prompt user for package weight
            Console.Write("Please enter the weight of your item (lbs): ");
            double itemWeight = double.Parse(Console.ReadLine());

            // Check weight limit
            if (itemWeight > 50)
            {
                Console.WriteLine("We’re sorry, but your item exceeds our maximum weight limit. Thank you for considering SwiftCargo!");
                return;
            }

            // Prompt user for package dimensions
            Console.Write("Please enter the width of your package (inches): ");
            double packageWidth = double.Parse(Console.ReadLine());

            Console.Write("Please enter the height of your package (inches): ");
            double packageHeight = double.Parse(Console.ReadLine());

            Console.Write("Please enter the length of your package (inches): ");
            double packageLength = double.Parse(Console.ReadLine());

            // Check total dimensions
            if ((packageWidth + packageHeight + packageLength) > 60)
            {
                Console.WriteLine("Unfortunately, your package is too large for SwiftCargo. We apologize for any inconvenience!");
                return;
            }

            // Calculate shipping fee
            double shippingFee = (packageWidth * packageHeight * packageLength * itemWeight) / 120;

            // Display the estimated shipping cost
            Console.WriteLine($"Your estimated shipping fee is: ${shippingFee:F2}");
            Console.WriteLine("Thank you for choosing SwiftCargo for your shipping needs!");
        }
    }
}
