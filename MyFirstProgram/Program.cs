Console.WriteLine("Please write your name");

var today = DateTime.Today;
string userName = Console.ReadLine();

Console.WriteLine("----------------------------------");

Console.WriteLine($@"Hello {userName}, thank you for using my program to learn more about math on this beautifull {today.DayOfWeek}.

You will be asked nmath questions and there will be a score assigned at the end. Don't worry or stress yourself, treat this as an opportunity.");

Console.WriteLine("----------------------------------");


Console.WriteLine($@"Please chose a game mode:
1 - addition
2 - substraction
3 - multiplication
4 - division
5 - random
6 - chaos mode");

var gameSelected = Console.ReadLine();

if (gameSelected == "1")
{
    Console.WriteLine("Addition game selected.");
}
else if (gameSelected == "2")
{
    Console.WriteLine("SuBsTrAcTiOn SeLeCtEd!");
}
else if (gameSelected == "3")
{
    Console.WriteLine("Multiplication? WoW! Are you sure?");
}
else if (gameSelected == "4")
{
    Console.WriteLine("D-D-D-D-Divisioooooon!");
}
else if (gameSelected == "5")
{
    Console.WriteLine("It's random time. Let's check your mettle. <evil grin>");
}
else if (gameSelected == "6")
{
    Console.WriteLine("Mwahahaha. Mwahahahaha! Let's play.");
}
else
{
    Console.WriteLine("Come again...");
    Environment.Exit(1);
}
