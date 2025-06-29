using System;

class Program
{
    static void Main()
    {
        double currentValue = 10000;
        double growthRate = 0.05;
        int years = 5;

        double future = Predict(currentValue, growthRate, years);
        Console.WriteLine($"Predicted value after {years} years: {future:F2}");
    }

    static double Predict(double current, double rate, int years)
    {
        if (years == 0)
            return current;
        return Predict(current * (1 + rate), rate, years - 1);
    }
}
