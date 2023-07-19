var today = DateTime.Today;

string userName = GetName();
string GetName()
{
    Console.WriteLine("Please write your name");
    string userName = Console.ReadLine();
    return userName;
}

Menu(userName);
void Menu(string userName)
{

    Console.WriteLine("----------------------------------");

    Console.WriteLine($@"Hello {userName.ToUpper()}, thank you for using my program to learn more about math on this beautifull {today.DayOfWeek}.

You will be asked nmath questions and there will be a score assigned at the end. Don't worry or stress yourself, treat this as an opportunity.");

    Console.WriteLine("----------------------------------");

    Console.WriteLine($@"Please chose a game mode:
1 - addition
2 - substraction
3 - multiplication
4 - division
5 - random
6 - chaos mode
");

    var gameSelected = Console.ReadLine();

    switch (gameSelected.Trim().ToLower())
    {
        case "1":
            AdditionGame();
            break;
        case "2":
            SubstractionGame();
            break;
        case "3":
            MultiplicationGame();
            break;
        case "4":
            DivisionGame();
            break;
        case "5":
            RandomGame();
            break;
        case "6":
            ChaosMode();
            break;
        default:
            Console.WriteLine("Come again...");
            Environment.Exit(1);
            break;
    }
}

void AdditionGame()
{
    Console.Clear();
    Console.WriteLine("Addition game selected.");
    var myRandom = new Random();
    int firstNumber;
    int secondNumber;
    int score = 0;

    for(int i = 0; i < 5; i++)
    {
        firstNumber = myRandom.Next(1, 100);
        secondNumber = myRandom.Next(1, 100);

        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var Result = Console.ReadLine();

        if (int.Parse(Result) == firstNumber + secondNumber)
        {
            Console.WriteLine($"Good answer! Now click something to progress.");
            score++;
            Console.ReadLine();
        }
        else
        {
         Console.WriteLine($"Wroooooong. Click something, so you can try again.");
            //score--;
            Console.ReadLine();
        }

        if (i == 4)
        {
            Console.WriteLine($"Your final score is {score}. Thank you for playing!");
        }
    }    
}

void SubstractionGame()
{
    Console.Clear();
    Console.WriteLine("SuBsTrAcTiOn SeLeCtEd!");
    var myRandom = new Random();
    int firstNumber;
    int secondNumber;
    int score = 0;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = myRandom.Next(50, 100);
        secondNumber = myRandom.Next(1, 50);

        Console.WriteLine($"{firstNumber} - {secondNumber}");
        var Result = Console.ReadLine();

        if (int.Parse(Result) == firstNumber - secondNumber)
        {
            Console.WriteLine($"Good answer! Now click something to progress.");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine($"Wroooooong. Click something, so you can try again.");
            //score--;
            Console.ReadLine();
        }

        if (i == 4)
        {
            Console.WriteLine($"Your final score is {score}. Thank you for playing!");
        }
    }
}

void MultiplicationGame()
{
    Console.Clear();
    Console.WriteLine("Multiplication? WoW! Are you sure?");
    var myRandom = new Random();
    int firstNumber;
    int secondNumber;
    int score = 0;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = myRandom.Next(1, 10);
        secondNumber = myRandom.Next(1, 20);

        Console.WriteLine($"{firstNumber} * {secondNumber}");
        var Result = Console.ReadLine();

        if (int.Parse(Result) == firstNumber * secondNumber)
        {
            Console.WriteLine($"Good answer! Now click something to progress.");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine($"Wroooooong. Click something, so you can try again.");
            //score--;
            Console.ReadLine();
        }

        if (i == 4)
        {
            Console.WriteLine($"Your final score is {score}. Thank you for playing!");
        }
    }
}

void DivisionGame()
{
    Console.Clear();
    Console.WriteLine("D-D-D-D-Divisioooooon!");

    var divisionNumbers = GetDivisionNumbers();

    int firstNumber = divisionNumbers[0];
    int secondNumber = divisionNumbers[1];
    int score = 0;

    for (int i = 0; i < 5; i++)
    {

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var Result = Console.ReadLine();

        if (int.Parse(Result) == firstNumber / secondNumber)
        {
            Console.WriteLine($"Good answer! Now click something to progress.");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine($"Wroooooong. Click something, so you can try again.");
            //score--;
            Console.ReadLine();
        }

        if (i == 4)
        {
            Console.WriteLine($"Your final score is {score}. Thank you for playing!");
        }

        divisionNumbers = GetDivisionNumbers();
        firstNumber = divisionNumbers[0];
        secondNumber = divisionNumbers[1];
    }
}

void RandomGame()
{
    Console.WriteLine("It's random time. Let's check your mettle. <evil grin>");
}

void ChaosMode()
{
    Console.WriteLine("Mwahahaha. Mwahahahaha! Let's play.");
}

int[] GetDivisionNumbers()
{
    var random = new Random();
    var firstNumber = random.Next(1, 99);
    var secondNumber = random.Next(1, 99);

    var result = new int[2];
    result[0] = firstNumber;
    result[1] = secondNumber;

    while (firstNumber % secondNumber != 0)
    {
        firstNumber = random.Next(1, 99);
        secondNumber = random.Next(1, 99);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;
    return result;
}

