﻿using System;

class Program
{
    static void Main()
    {
        double presentValue = 3000;  
        double growthRate = 0.05;    
        int years = 6;               

        double futureValue = CalculateFutureValue(presentValue, growthRate, years);
        Console.WriteLine($"Future value after {years} years = {futureValue:C2}");
    }

    static double CalculateFutureValue(double presentValue, double rate, int years)
    {
        if (years == 0)
            return presentValue;
        return CalculateFutureValue(presentValue * (1 + rate), rate, years - 1);
    }
}