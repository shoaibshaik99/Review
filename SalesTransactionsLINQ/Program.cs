/*
 3)Create a program that reads a collection of sales transactions with properties
 like product name, quantity, and price.
 Use LINQ to group the transactions by product name and calculate
 total sales quantity and revenue for each product. Utilize lambda expressions
 to filter transactions based on specific criteria.
 */

using System.Transactions;

namespace SalesTransactionsLINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<SaleTransaction> salesTransactions = new List<SaleTransaction>
            {
                new SaleTransaction { productName = "ToothPaste", quantity = 100, price = 35 },
                new SaleTransaction { productName = "Shampoo", quantity = 200, price = 10 },
                new SaleTransaction { productName = "Brush", quantity = 150, price = 20 },
                new SaleTransaction { productName = "Soap", quantity = 300, price = 45 },
                new SaleTransaction { productName = "ToothPaste", quantity = 500, price = 35 },
                new SaleTransaction { productName = "Shampoo", quantity = 500, price = 10 },
                new SaleTransaction { productName = "Brush", quantity = 500, price = 20 },
                new SaleTransaction { productName = "Soap", quantity = 500, price = 45 },
            };

            int totalQuantity = 0;
            double totalRevenue = 0;


            var groupedTransactions = salesTransactions.GroupBy(t => t.productName);
            //var groupedTransactions = from I in salesTransactions group I by I.productName into J select J;

            Console.WriteLine("Available Products");
            foreach (var group in groupedTransactions)
            {
                Console.WriteLine($"Product: {group.Key}");
                foreach (var transaction in group)
                {
                    Console.WriteLine($"  Quantity: {transaction.quantity}, Price: {transaction.price}");
                }
            }

            Console.WriteLine("\n\n**Total quantity and total revenue of each product is as follows**");
            foreach (var group in groupedTransactions)
            {
                Console.WriteLine($"Product: {group.Key}");
                totalRevenue = group.Sum(t => t.quantity * t.price);
                totalQuantity = group.Sum(t => t.quantity);
                Console.WriteLine($"  Total Quantity: {totalQuantity}, Total Revenue: {totalRevenue}");
            }

            var filteredTransactions = salesTransactions.Where(t => t.quantity > 300);

            Console.WriteLine("\n\n**Filtered transactions (quantity > 300)**");
            foreach (var transaction in filteredTransactions)
            {
                Console.WriteLine($"Product: {transaction.productName}, Quantity: {transaction.quantity}, Price: {transaction.price}");
            }


        }
    }
}
