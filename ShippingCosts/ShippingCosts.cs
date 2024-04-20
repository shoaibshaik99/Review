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
    public class ShippingCosts
    {
        public static int Calculate(int weight, int destChoice)
        {
            int shippingCost = 0;
            if (weight < 0)
            {
                Console.WriteLine("Invalid Weight!");
                return 0;
            }
            if (destChoice != 1 || destChoice != 2)
            {
                Console.WriteLine("Invalid Destination type");
                return 0;
            }

            if (weight < 5)
            {
                if (destChoice == 1)
                {
                    shippingCost = 5;
                }
                else if (destChoice == 2)
                {
                    shippingCost = 10;
                }
            }
            else if (weight >= 5)
            {
                if (destChoice == 1)
                {
                    shippingCost = 10;
                }
                else if (destChoice == 2)
                {
                    shippingCost = 20;
                }
                
            }
            return shippingCost;

        }
    }
}
