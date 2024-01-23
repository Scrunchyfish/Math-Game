
Random rand = new Random();
List<string> history = new List<string> ();    

void GameLoop()
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

            case "5":
                foreach(string s in history)
                Console.WriteLine(s);
                break;
           

        }
    } while (readValue.ToLower() != "exit");

};

void AdditionGame()
{
    int score = 0;
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
            
        }
        else
        {
            Console.WriteLine($"Incorrect, try again. Score: {score}");
        }
        history.Add($"{a} + {b} = {readValueAdd}");
    }
}

void SubtractionGame()
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
    }
}

void MultiplicationGame()
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
    }
}

void DivisionGame()
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
    }
}



GameLoop();