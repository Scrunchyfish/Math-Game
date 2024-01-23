using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Game
{
    
    internal class GameEngine
    {
        Random rand = new Random();
        internal List<string> history = new();
        internal void AdditionGame()
        {
            int score = 0;
            bool correct = true;
            string? readValueAdd = "";
            Console.WriteLine("Welcome to Addition mode. Type exit to return to the main menu.");
            while (readValueAdd.ToLower() != "exit")
            {

                int a = rand.Next(0, 100), b = rand.Next(0, 100);
                int ans = 0;
                Console.WriteLine($"{a} + {b} =");

                readValueAdd = Console.ReadLine();
                if (readValueAdd.ToLower() == "exit")
                    break;

                if (int.TryParse(readValueAdd, out ans) && ans == a + b)
                {
                    score++;
                    Console.WriteLine($"Correct! Score: {score}");
                    correct = true;

                }
                else
                {
                    Console.WriteLine($"Incorrect, try again. Score: {score}");
                    correct = false;
                }
                history.Add($"{a} + {b} = {readValueAdd} - {(correct ? "correct": "incorrect")}");
            }
        }

        internal void SubtractionGame()
        {
            int score = 0;
            string? readValueAdd = "";
            Console.WriteLine("Welcome to Subtraction mode. Type exit to return to the main menu.");
            while (readValueAdd.ToLower() != "exit")
            {

                int a = rand.Next(0, 100), b = rand.Next(0, 100);
                int ans = 0;
                Console.WriteLine($"{a} - {b} =");

                readValueAdd = Console.ReadLine();
                if (readValueAdd.ToLower() == "exit")
                    break;

                if (int.TryParse(readValueAdd, out ans) && ans == a - b)
                {
                    score++;
                    Console.WriteLine($"Correct! Score: {score}");


                }
                else
                {
                    Console.WriteLine($"Incorrect, try again. Score: {score}");
                }
                history.Add($"{a} - {b} = {readValueAdd}");
            }
        }

        internal void MultiplicationGame()
        {
            int score = 0;
            string? readValueAdd = "";
            Console.WriteLine("Welcome to Multiplication mode. Type exit to return to the main menu.");
            while (readValueAdd.ToLower() != "exit")
            {

                int a = rand.Next(0, 10), b = rand.Next(0, 10);
                int ans = 0;
                Console.WriteLine($"{a} * {b} =");

                readValueAdd = Console.ReadLine();
                if (readValueAdd.ToLower() == "exit")
                    break;

                if (int.TryParse(readValueAdd, out ans) && ans == a * b)
                {
                    score++;
                    Console.WriteLine($"Correct! Score: {score}");

                }
                else
                {
                    Console.WriteLine($"Incorrect, try again. Score: {score}");
                }
                history.Add($"{a} * {b} = {readValueAdd}");
            }
        }

        internal void DivisionGame()
        {
            int score = 0;
            string? readValueAdd = "";
            Console.WriteLine("Welcome to Division mode. Type exit to return to the main menu.");
            while (readValueAdd.ToLower() != "exit")
            {

                int a = rand.Next(1, 100), b = rand.Next(1, 100);
                int ans = 0;
                if (a % b == 0)
                    Console.WriteLine($"{a} / {b} =");
                else continue;

                readValueAdd = Console.ReadLine();
                if (readValueAdd.ToLower() == "exit")
                    break;

                if (int.TryParse(readValueAdd, out ans) && ans == a / b)
                {
                    score++;
                    Console.WriteLine($"Correct! Score: {score}");

                }
                else
                {
                    Console.WriteLine($"Incorrect, try again. Score: {score}");
                }
                history.Add($"{a} / {b} = {readValueAdd}");
            }
        }
    }
}
