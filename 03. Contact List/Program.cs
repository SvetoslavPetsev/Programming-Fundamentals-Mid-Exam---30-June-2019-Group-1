using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Contact_List
{
    class Program
    {
        static void Main()
        {
            List<string> contactList = Console.ReadLine().Split().ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                if (command[0] == "Print")
                {
                    if (command[1] == "Reversed")
                    {
                       contactList.Reverse();
                    }
                    Console.WriteLine("Contacts: " + string.Join(" ", contactList));
                    return;
                }

                else if (command[0] == "Add")
                {
                    string contact = command[1];
                    int index = int.Parse(command[2]);

                    bool chekIn = false;
                    chekIn = contactList.Any(x => x == contact);
                    if (chekIn == false)
                    {
                        contactList.Add(contact);
                        continue;
                    }
                    else if ((index >= 0 && index <= contactList.Count - 1) && chekIn == true)
                    {
                        contactList.Insert(index, contact);
                    }
                }

                else if (command[0] == "Remove")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index <= contactList.Count - 1)
                    {
                        contactList.RemoveAt(index);
                    }
                }

                else if (command[0] == "Export")
                {
                    int startIndex = int.Parse(command[1]);
                    int count = int.Parse(command[2]);
                    int endIndex = startIndex + count - 1;
                    if (endIndex > contactList.Count - 1)
                    {
                        endIndex = contactList.Count - 1;
                    }

                    List<string> sortedList = new List<string>();
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        string currContact = contactList[i];
                        sortedList.Add(currContact);
                    }

                    Console.WriteLine(string.Join(" ", sortedList));
                }
            }
        }
    }
}
