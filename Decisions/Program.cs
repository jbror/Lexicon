//Watching this video https://learn.microsoft.com/en-us/shows/csharp-fundamentals-for-absolute-beginners/the-if-decision-statement

using System.ComponentModel.Design;

Console.WriteLine("Bror's Big Giveaway...");
Console.WriteLine("Choosee a door: 1, 2 or 3: ");
string userValue = Console.ReadLine();

if (userValue == "1")
{
    string message = "You won a kexchocklad!";
    Console.WriteLine(message);
}
else if (userValue == "2")
{
    string message = "You got a brick to the face!";
    Console.WriteLine(message);
}
else if (userValue== "3")
{
    string message = "You get a banana!";
    Console.WriteLine(message);
}
Console.ReadLine();