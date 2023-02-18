using System;

namespace MidExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmpl = int.Parse(Console.ReadLine());
            int secondEmpl = int.Parse(Console.ReadLine());
            int thirdEmpl = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            int allEmpl = firstEmpl + secondEmpl + thirdEmpl;
            int hours = 0;

            while (studentsCount > 0)
            {

                studentsCount -= allEmpl;
                hours++;
                if (hours % 4 == 0)
                {
                    hours++;
                    continue;
                }

                if (studentsCount <= 0)
                {

                    break;
                }

            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
