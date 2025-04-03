//Uppgift 2
Console.WriteLine("Hello, World!");
var running = true;
while (running)
{
    Console.WriteLine("You are now at the menu. Enter a number: ");
    var userInput = Console.ReadLine();
    switch (userInput)
    {
        case "0":
            running = false;
            break;

        default:
            Console.WriteLine("Invalid input!");
            break;

    }

}
