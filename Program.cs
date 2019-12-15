using System;
using static System.Console;

namespace price_by_pound
{
    class Program
    {
        // declare constants at class level
        static double GRAMS_PER_POUND = 453.592;
        static void Main(string[] args)
        {
            // compile-time initializations
            string item = "Poutine";
            double itemCostPerHundredGrams = 1.29,
                   itemCostPerGram = itemCostPerHundredGrams / 100,
                   itemCostPerPound = itemCostPerGram * GRAMS_PER_POUND;
            WriteLine("{0, 16} {1, 8}", "Item:", item);
            WriteLine("{0, 16} {1, 8:C2}", "Cost per 100g:", itemCostPerHundredGrams);
            WriteLine("{0, 16} {1, 8:C2}", "Cost per gram:", itemCostPerGram);
            WriteLine("{0, 16} {1, 8:C2}", "Cost per pound:", itemCostPerPound);
        }
    }
}
