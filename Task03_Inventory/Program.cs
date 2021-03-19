using System;
using System.Collections.Generic;
using System.Linq;

namespace Task03_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string[] comand = Console.ReadLine().Split(new string[] { " - ", ":"}, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if(comand[0].ToUpper() == "CRAFT!")
                {
                    break;
                }

                string typeComand = comand[0].ToUpper();
                //string item = string.Empty;
                
                switch (typeComand)
                {
                    case "COLLECT":
                        string item = comand[1];

                        if (!inventory.Contains(item))
                        {
                            inventory.Add(item);
                        }

                        break;

                    case "DROP":
                        item = comand[1];

                        if (inventory.Contains(item))
                        {
                            inventory.Remove(item);
                        }

                        break;

                    case "COMBINE ITEMS":
                        
                        string oldItem = comand[1];
                        string newItem = comand[2];
                        if(inventory.Contains(oldItem))
                        {
                            int index = inventory.IndexOf(oldItem);
                            inventory.Insert(index + 1, newItem);
                        }

                        break;

                    case "RENEW":
                        item = comand[1];
                        if(inventory.Contains(item))
                        {
                            inventory.Remove(item);
                            inventory.Add(item);
                        }

                        break;

                    default:
                        break;
                }

            }
            
            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}
