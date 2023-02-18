using System;
using System.Linq;
using System.Collections.Generic;
namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine().Split("!").ToList();
            string input = Console.ReadLine();
            while (input != "Go Shopping!")
            {
                string[] command = input.Split().ToArray();

                if (command[0] == "Urgent")
                {
                    if (shoppingList.Contains(command[1]))
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    shoppingList.Insert(0, command[1]);
                }
                else if (command[0] == "Unnecessary")
                {
                    if (shoppingList.Contains(command[1]))
                    {
                        int indexOfObject = 0;
                        for (int i = 0; i < shoppingList.Count; i++)
                        {
                            if (command[1] == shoppingList[i])
                            {
                                indexOfObject = i;

                            }
                        }
                        shoppingList.RemoveAt(indexOfObject);
                    }
                }
                else if (command[0] == "Correct")
                {
                    if (shoppingList.Contains(command[1]))
                    {
                        int indexOfObject = 0;
                        for (int i = 0; i < shoppingList.Count; i++)
                        {
                            if (command[1] == shoppingList[i])
                            {
                                indexOfObject = i;

                            }
                        }
                        shoppingList[indexOfObject] = command[2];
                    }
                }
                else if (command[0] == "Rearrange")
                {
                    if (shoppingList.Contains(command[1]))
                    {
                        int indexOfObject = 0;
                        for (int i = 0; i < shoppingList.Count; i++)
                        {
                            if (command[1] == shoppingList[i])
                            {
                                indexOfObject = i;

                            }
                        }
                        string currentProduct = shoppingList[indexOfObject];
                        shoppingList.RemoveAt(indexOfObject);
                        shoppingList.Add(currentProduct);
                        
                    }

                }


                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",shoppingList));
        }
    }
}
