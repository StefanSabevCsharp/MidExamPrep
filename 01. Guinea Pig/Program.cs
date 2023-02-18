using System;

namespace _01._Guinea_Pig
{
    class Program
    {
        static void Main(string[] args)
        {
            // •	On the first line – quantity food in kilograms - a floating-point number in the range [0.0 – 10000.0]
            //•	On the second line – quantity hay in kilograms - a floating-point number in the range [0.0 – 10000.0]
            //•	On the third line – quantity cover in kilograms - a floating-point number in the range [0.0 – 10000.0]
            //•	On the fourth line – guinea's weight in kilograms - a floating-point number in the range [0.0 – 10000.0]

            double foodKG = double.Parse(Console.ReadLine());
            double hayKG = double.Parse(Console.ReadLine());
            double coverKG = double.Parse(Console.ReadLine());
            double pigKG = double.Parse(Console.ReadLine());

            double foodGrams = foodKG * 1000;
            double hayGrams = hayKG * 1000;
            double coverGrams = coverKG * 1000;
            double pigGrams = pigKG * 1000;

            for (int i = 1; i <= 30; i++)
            {
                foodGrams -= 300;
                if (foodGrams <= 0)
                {
                    Information();
                    Environment.Exit(0);

                }
                if (i % 2 == 0)
                {
                   double currentHay = foodGrams * 0.05;
                    hayGrams -= currentHay;
                    if (hayGrams <= 0)
                    {
                        Information();
                        Environment.Exit(0);

                    }
                }
                if (i % 3 == 0)
                {
                    double currentCover = pigGrams / 3;
                    coverGrams -= currentCover;
                    if (coverGrams <= 0)
                    {
                        Information();
                        Environment.Exit(0);
                    }
                }

            }
            double excesFood = foodGrams / 1000;
            double excesHay = hayGrams / 1000;
            double excesCover = coverGrams / 1000;
            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {excesFood:f2}, Hay: {excesHay:f2}, Cover: {excesCover:f2}.");

        }
        static void Information ()
        {
            Console.WriteLine("Merry must go to the pet store!");
        }
    }
}
