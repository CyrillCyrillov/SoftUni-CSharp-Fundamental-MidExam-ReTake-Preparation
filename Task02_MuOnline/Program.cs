using System;
// using System.Linq;

namespace Task02_MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            double health = 100;
            double bitcoins = 0;
            int curentRoom = 0;

            string[] roomsInfo = Console.ReadLine().Split(new char[] { ' ', '|', }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i <= roomsInfo.Length - 1; i+=2)
            {
                string typeAction = roomsInfo[i];
                curentRoom ++;
                double curentNumber = double.Parse(roomsInfo[i + 1]);

                switch (typeAction.ToUpper())
                {
                    case "POTION":
                        if(health + curentNumber > 100)
                        {
                            curentNumber = 100 - health;
                        }
                        health += curentNumber;
                        Console.WriteLine($"You healed for {curentNumber} hp.");
                        Console.WriteLine($"Current health: {health} hp.");

                        break;

                    case "CHEST":
                        bitcoins += curentNumber;
                        Console.WriteLine($"You found {curentNumber} bitcoins.");

                        break;
                    
                    default:
                        health -= curentNumber;
                        if(health > 0)
                        {
                            Console.WriteLine($"You slayed {typeAction}.");
                        }
                        else
                        {
                            Console.WriteLine($"You died! Killed by {typeAction}.");
                            Console.WriteLine($"Best room: {(curentRoom)}");
                            break;
                        }
                        break;
                }

                if (health <= 0)
                {
                    break;
                }
            }

            if (health > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }

        }
    }
}
