using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Number_Array
{
    class Program
    {
        static void Main()
        {
            List<int> someNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] command = input.Split().ToArray();

                if (command[0] == "Switch")
                {
                    int index = int.Parse(command[1]);

                    if (index >= 0 && index <= someNumbers.Count - 1)
                    {
                        int target = someNumbers.ElementAt(index);
                        target *= -1;
                        someNumbers.Insert(index, target);
                        someNumbers.RemoveAt(index + 1);
                        continue;
                    }
                }

                else if (command[0] == "Change")
                {
                    int index = int.Parse(command[1]);
                    int newNumber = int.Parse(command[2]);

                    if (index >= 0 && index <= someNumbers.Count -1)
                    {
                        someNumbers.Insert(index, newNumber);
                        someNumbers.RemoveAt(index + 1);
                    }
                }

                else if (command[0] == "Sum")
                {
                    int sum = 0;
                    if (command[1] == "Negative")
                    {
                        for (int i = 0; i < someNumbers.Count; i++)
                        {
                            if (someNumbers[i] < 0)
                            {
                                sum += someNumbers[i];
                            }
                        }
                    }

                    else if (command[1] == "Positive")
                    {
                        for (int i = 0; i < someNumbers.Count; i++)
                        {
                            if (someNumbers[i] > 0)
                            {
                                sum += someNumbers[i];
                            }
                        }
                    }

                    else if (command[1] == "All")
                    {
                        sum = someNumbers.Sum();
                    }

                    Console.WriteLine(sum);
                }

            }
            List<int> positive = new List<int>();
            for (int i = 0; i < someNumbers.Count; i++)
            {
                if (someNumbers[i] >= 0)
                {
                    positive.Add(someNumbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", positive));
        }
    }
}
