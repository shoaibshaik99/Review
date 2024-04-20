/*
1)Build a program that calculates shipping costs based on the weight and destination of a package.

For packages under 5 pounds:
Domestic(within the country) shipping costs $5.
International shipping costs $10.
For packages weighing 5 pounds or more:
Domestic shipping costs $10.
International shipping costs $20.*/

namespace ShippingCosts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the weight of the package");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose the type of destination" +
                "\n1. Domestic" +
                "\n2. International");
            int destChoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Cost of shipping {ShippingCosts.Calculate(weight, destChoice)}");
        }
    }
}
