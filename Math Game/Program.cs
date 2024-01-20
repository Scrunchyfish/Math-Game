//menu
string? readValue;
Random rand = new Random();
void GameLoop()
{
    do
    {
        Console.WriteLine("Welcome to the maths game.\n");
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
                break;

            case "2":
                SubtractionGame();
                break;

            case "3":
                MultiplicationGame();
                break;

            case "4":
                DivisionGame();
                break;


        }
    } while (readValue.ToLower() != "exit");

};

void AdditionGame()
{
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
            Console.WriteLine("Correct!");
            continue;
        }
        else
        {
            Console.WriteLine("Incorrect, try again.");
        }
    }
}

void SubtractionGame()
{
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
            Console.WriteLine("Correct!");
            continue;
        }
        else
        {
            Console.WriteLine("Incorrect, try again.");
        }
    }
}

void MultiplicationGame()
{
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
            Console.WriteLine("Correct!");
            continue;
        }
        else
        {
            Console.WriteLine("Incorrect, try again.");
        }
    }
}

void DivisionGame()
{
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
            Console.WriteLine("Correct!");
            continue;
        }
        else
        {
            Console.WriteLine("Incorrect, try again.");
        }
    }
}

GameLoop();