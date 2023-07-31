using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Message = "\n\nPress some button..."; // Press button message

            int PointsPerClick = 1;

            while (true) // infinite cicle of choose
            {
                Console.Write("Choose action:\n\n[1] Start\n\n[2] Options\n\n[3] Exit\n\nChoose: ");
                int Choose = Convert.ToInt32(Console.ReadLine());

                switch (Choose)
                {
                    case 1: // start game

                        Console.Clear();

                        int Points = 0;

                        int Clicks = 0;

                        while (true) // start of game(infinite cicle start)
                        {
                            Console.WriteLine("Points: " + Points);

                            Console.Write("Clicks: " + Clicks);

                            Console.Write("\n\n" + Message);

                            Console.ReadKey();

                            Points += PointsPerClick;

                            Clicks++;

                            Console.Clear();

                        }

                        break;

                    case 2: // Options(Change press button message)

                        Console.Write("\n\nChoose action:\n\n[1] Change press button message\n\n[2] Change points per click\n\nChoose: ");
                        int option = Convert.ToInt32(Console.ReadLine());

                        switch (option)
                        {
                            case 1:

                                Console.Write("\n\nEnter press button message: ");
                                Message = Console.ReadLine();

                                break;

                            case 2:

                                Console.Write("\n\nEnter points per click: ");
                                PointsPerClick = Convert.ToInt32(Console.ReadLine());

                                break;

                            default:

                                Console.Write("\n\nIncorrect choose!");

                                break;

                        }

                        break;

                    case 3: // Exit

                        Console.WriteLine();

                        return;

                    default:

                        Console.Write("\n\nIncorrect choose!");

                        break;
                }

                // Clear output

                Console.Write("\n\nPress some button to clear output...");
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
