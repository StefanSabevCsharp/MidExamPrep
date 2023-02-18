using System;
using System.Linq;
namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (command[0] == "swap")
                {
                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);
                    int temporary = numbers[index2];//5  1
                    numbers[index2] = numbers[index1];
                    numbers[index1] = temporary;
                }
                else if (command[0] == "multiply")
                {
                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);
                    int multiplyNum = numbers[index1] * numbers[index2];
                    numbers[index1] = multiplyNum;
                }
                else if (command[0] == "decrease")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] -= 1;
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",numbers));

        }
    }
}
