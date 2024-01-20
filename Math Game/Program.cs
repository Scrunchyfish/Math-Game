//menu
string? readValue;
Random rand = new Random();
void GameLoop()
{
    do
    {
        Console.WriteLine("Welcome to the maths game./n");
        Console.WriteLine("Choose what mode you want to play.");
        Console.WriteLine("1 - Addition");
        Console.WriteLine("2 - Subtraction");
        Console.WriteLine("3 - Multiplication");
        Console.WriteLine("4 - Division");
        readValue = Console.ReadLine();

        switch (readValue)
        {
            case "1":
                AdditionGame();
        }
    } while (readValue.ToLower() != "exit");

};

void AdditionGame()
{
    do
    {
        Console.WriteLine("Welcome to Addtion mode. Type exit to return to main menu.");
        int a = rand.Next(0, 100), b = rand.Next(0, 100);
        int ans = 0;
        Console.WriteLine($"{a} + {b} =");

        readValue = Console.ReadLine();
        if (readValue.ToLower() == "exit")
            break;
        
        if (int.TryParse(readValue, out ans) && ans == a + b)
        {
            Console.WriteLine("Correct!");
            AdditionGame();
        }
        else
        {
            Console.WriteLine("Incorrect, try again.");
            
        }
    } while (readValue.ToLower() != "exit");

};
//loop
//gmae loop per operand
//way to exit game mode + game


//+
//rand num + rand num = ?
//check ans valid

//_
//*
//"/
GameLoop();