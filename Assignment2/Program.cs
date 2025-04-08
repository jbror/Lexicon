// Uppgift 2 
Console.WriteLine("Hello, hi and welcome to your local cinema!");
Console.WriteLine("Please help the lovely developers by testing our new software.\nMake a choice by entering a number\n");
var running = true;
while (running)
{
    Console.WriteLine("Main Menu:");
    Console.WriteLine("Press 1 for purchasing tickets");
    Console.WriteLine("Press 2 to enter your favorite word and see it be repeated back to you ten times! ");
    Console.WriteLine("Press 3 to enter your favorite movie quote ");
    Console.WriteLine("Press 0 to exit");

    var userInput = Console.ReadLine();
    switch (userInput)
    {
        case "0":
            running = false;
            break;

        case "1":
            CalculateCinemaCost();
            break;

        case "2":
            RepeatTenTimes();
            break;

        case "3":
            TheThirdWord();
            break;

        default:
            Console.WriteLine("Invalid input!");
            break;

    }
}


void CalculateCinemaCost()
{
    Console.WriteLine("This is case 1. Purchasing tickets");
    var numberOfPersons = UserInputConvert("Enter number of persons: ");

    Console.WriteLine($"Okay, you are {numberOfPersons} persons.");
    var customerAges = new List<int>(); // Här vill jag lägga till alla åldrar 
    var range = Enumerable.Range(1, numberOfPersons); //Skapar en Enumurate att loopa på för antalet personer
    foreach (var i in range)
    {
        var person_age = UserInputConvert($"Enter age of person {i}:");
        customerAges.Add(person_age); //Lägger till personenes ålder i min lista. Första nummreet/int i listan är åldern på första personen and so on

    }
    int totalPrice = 0;
    for (int i = 0; i < customerAges.Count; i++) //Loopar för antalet åldrar som finns i min lista (personer) och skriver ut priset och uppdaterar totalpriset
    {
        string priceGroup;
        int age = customerAges[i];
        int price;
        if (age <= 20)
        {
            price = 100;
            totalPrice += price;
            priceGroup = "Youth";
        }
        else if (age >= 65)
        {
            price = 90;
            totalPrice += price;

            priceGroup = "Senior";
        }
        else
        {
            price = 150;
            totalPrice += price;

            priceGroup = "Standard Price";
        }

        Console.WriteLine($"Person{i + 1}: {price} SEK:- ({priceGroup})");

    }
    Console.WriteLine("Total price to pay: " + totalPrice + " SEK:-\n"); //Alla personer har fått sitt pris och skriver nu ut det totala priset.


}


void RepeatTenTimes()
{
    Console.WriteLine("This is case 2.");
    Console.WriteLine("Type the best word: ");
    var userFavoriteWord = Console.ReadLine();
    for (int i = 0; i < 10; i++)
    {
        Console.Write($"{i + 1}: {userFavoriteWord} ");
    }

    Console.WriteLine();

}
void TheThirdWord()
{
    Console.WriteLine("Enter your favorite movie quote and see some magic");
    Console.WriteLine("The quote has to have at least 3 words.");

    var userInputFavoriteQuote = Console.ReadLine();
    var words = userInputFavoriteQuote.Split(' ');
    if (words.Length > 2)

    {
        var theThirdWord = words[2];
        Console.WriteLine($"The magic word is: {theThirdWord}");
    }
    else
    {
        Console.WriteLine("You need to have at least 3 words");
        Console.WriteLine("Try again or be stuck here forever...");
        TheThirdWord(); // Anropar sig själv och börjar om. Finns ingen annan väg ut ur funktionen
    }

}
int UserInputConvert(string prompt = "Enter a number") // Skapade denna funktion efter lite upprepande i min kod. Här tar jag input och gör om inputen(strängen) till en int. Går det inte frågar jag igen. Prompt har en defaultsträng som används om ingen skickas med.
{
    Console.WriteLine(prompt);
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Invalid input! Only numbers.");
    }
    return number;
}
