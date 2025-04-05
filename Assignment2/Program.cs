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

}


void RepeatTenTimes()
{

}
void TheThirdWord()
{

}