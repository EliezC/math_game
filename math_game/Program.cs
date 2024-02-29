var date = DateTime.UtcNow;

string name = GetName();

string GetName()
{
    Console.WriteLine("Please type your name");
    var name = Console.ReadLine();
    return name;
}

do
{
    Menu(name, date);
} while (true);

void Menu(string? name, DateTime date)
{
    Console.Clear();
    Console.WriteLine("-----------------------------------");
    Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math's game. That's great that you're working on improving yourself\n");
    Console.WriteLine($@"What game would you like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");
    Console.WriteLine("------------------------------------");
    var gameSelected = Console.ReadLine();

    switch (gameSelected.ToLower().Trim())
    {
        case "a":
            AdditionGame("Addition game selected");
            break;
        case "s":
            SubtractionGame("Subtraction game selected");
            break;
        case "m":
            MultiplicationGame("Multiplication game selected");
            break;
        case "d":
            DivisionGame("Division game selected");
            break;
        case "q":
            Console.WriteLine("See you, bye!");
            Environment.Exit(1);
            break;

        default:
            Console.WriteLine("Please input the correct options.");
            break;
    }
}

void AdditionGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    int firstNumber = random.Next(1, 50);
    int secondNumber = random.Next(1, 50);

    Console.WriteLine($"{firstNumber} + {secondNumber}");    
    int.TryParse(Console.ReadLine(), out int result);

    if(result == firstNumber + secondNumber)
        Console.WriteLine("Your answer was correct!");
    else
        Console.WriteLine("Sorry, your answer was wrong");
    Console.ReadLine();
}

void SubtractionGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    int firstNumber = random.Next(1, 50);
    int secondNumber = random.Next(1, firstNumber);

    Console.WriteLine($"{firstNumber} - {secondNumber}");
    int.TryParse(Console.ReadLine(), out int result);

    if (result == firstNumber - secondNumber)
        Console.WriteLine("Your answer was correct!");
    else
        Console.WriteLine("Sorry, your answer was wrong");
    Console.ReadLine();
}

void MultiplicationGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    int firstNumber = random.Next(1, 20);
    int secondNumber = random.Next(1, 10);

    Console.WriteLine($"{firstNumber} x {secondNumber}");
    int.TryParse(Console.ReadLine(), out int result);

    if (result == firstNumber * secondNumber)
        Console.WriteLine("Your answer was correct!");
    else
        Console.WriteLine("Sorry, your answer was wrong");
    Console.ReadLine();
}

void DivisionGame(string message)
{
    Console.WriteLine(message);

    int firstNumber;
    int secondNumber;
    do {
        var random = new Random();
        firstNumber = random.Next(0, 100);
        secondNumber = random.Next(1, firstNumber);
    } while (firstNumber%secondNumber != 0);

    Console.WriteLine($"{firstNumber} / {secondNumber}");
    int.TryParse(Console.ReadLine(), out int result);

    if (result == firstNumber / secondNumber)
        Console.WriteLine("Your answer was correct!");
    else
        Console.WriteLine("Sorry, your answer was wrong");
    Console.ReadLine();
}