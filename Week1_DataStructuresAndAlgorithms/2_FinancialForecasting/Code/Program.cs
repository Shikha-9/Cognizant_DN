using System;
using System.Collections.Generic;

namespace FinancialForecasting
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<double> monthlyProfits = new List<double> { 12000, 13500, 12800, 14000, 15000, 15500 };

            Console.WriteLine("Last 6 Months Profit:");
            foreach (var profit in monthlyProfits)
            {
                Console.WriteLine($"₹{profit}");
            }

            
            double growth = (monthlyProfits[monthlyProfits.Count - 1] - monthlyProfits[0]) / monthlyProfits.Count;

            
            Console.WriteLine("\nForecasted Profits for Next 3 Months:");
            double lastProfit = monthlyProfits[monthlyProfits.Count - 1];

            for (int i = 1; i <= 3; i++)
            {
                lastProfit += growth;
                Console.WriteLine($"Month {i}: ₹{Math.Round(lastProfit, 2)}");
            }

            Console.ReadLine(); 
        }
    }
}
