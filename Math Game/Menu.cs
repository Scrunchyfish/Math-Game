using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Game
{
    internal class Menu
    {
        internal GameEngine gameEngine = new GameEngine();

        public void RunMenu()
        {
            string? readValue;

            do
            {
                Console.WriteLine("Welcome to the maths game.\n");
                Console.WriteLine("Choose what mode you want to play.");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multiplication");
                Console.WriteLine("4 - Division");
                Console.WriteLine("5 - History");
                readValue = Console.ReadLine();

                switch (readValue)
                {
                    case "1":
                        gameEngine.AdditionGame();
                        break;

                    case "2":
                        gameEngine.SubtractionGame();
                        break;

                    case "3":
                        gameEngine.MultiplicationGame();
                        break;

                    case "4":
                        gameEngine.DivisionGame();
                        break;

                    case "5":
                        foreach (string s in gameEngine.history)
                            Console.WriteLine(s);
                        break;

                }
            } while (readValue.ToLower() != "exit");
        }
    }
}
