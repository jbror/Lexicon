//Uppgift 2
using System.Reflection.Metadata;

Console.WriteLine("Hello, hi and welcome to your local cinema!");
Console.WriteLine("Please help the lovely developers by testing our new software.\nMake a choice by entering a number\n");
var running = true;
while (running)
{
    // Console.WriteLine("\nYou are now at the main menu. Please help the lovely developers by testing our new software.\nMake a choice by entering a number");
    Console.WriteLine("Main Menu:");
    Console.WriteLine("Press 1 for purchasing tickets");
    Console.WriteLine("Press 2 to enter your favorite word and see it be repeated back to you ten times! ");

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
    var customerAges = new List<int>();
    var range = Enumerable.Range(1, numberOfPersons);
    foreach (var i in range)
    {
        //Console.WriteLine($"Enter age of person {i}:");
        var person_age = UserInputConvert($"Enter age of person {i}:");
        customerAges.Add(person_age);

    }
    int totalPrice = 0;
    for (int i = 0; i < customerAges.Count; i++)
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
    Console.WriteLine("Total price to pay: " + totalPrice + " SEK:-\n");
    int UserInputConvert(string prompt)
    {
        Console.WriteLine(prompt);
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid input! Only numbers.");
        }
        return number;
    }



}


void RepeatTenTimes()
{

}
void TheThirdWord()
{

}
