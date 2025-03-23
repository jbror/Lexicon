//Watching this video https://learn.microsoft.com/en-us/shows/csharp-fundamentals-for-absolute-beginners/the-if-decision-statement


// PART 1
//Console.WriteLine("Bror's Big Giveaway...");
//Console.WriteLine("Choosee a door: 1, 2 or 3: ");
//string userValue = Console.ReadLine();


//string message = "";


//if (userValue == "1")
//{
//    string message = "You won a kexchocklad!";
//    Console.WriteLine(message);
//}
//else if (userValue == "2")
//{
//    string message = "You got a brick to the face!";
//    Console.WriteLine(message);
//}
//else if (userValue == "3")
//{
//    string message = "You get a banana!";
//    Console.WriteLine(message);
//}
//else
//{
//    string message = "Sorry, i didn't understand that part..";
//    Console.WriteLine(message);
//}

//Console.ReadLine();




//Part 2

//Console.WriteLine("Bror's Big Giveaway...");
//Console.WriteLine("Choosee a door: 1, 2 or 3: ");
//string userValue = Console.ReadLine();

//string message = "";


//if (userValue == "1")
//    message = "You won a kexchocklad!";
//else if (userValue == "2")
//    message = "You got a brick to the face!";
//else if (userValue == "3")
//    message = "You get a banana!";
//else
//{
//    message = "Sorry, i didn't understand that part.. ";
//    message += "Game is over buddy";
//}
//Console.WriteLine(message);
//Console.ReadLine();




Console.WriteLine("Bror's Big Giveaway...");
Console.WriteLine("Choosee a door: 1, 2 or 3: ");
string userValue = Console.ReadLine();

string message = (userValue == "1") ? "boat" : "strand of lint";

//Console.Write("You won a ");
//Console.Write(message);
//Console.Write(".");

Console.WriteLine("You entered : {0}, therefore you won a {1}.",userValue, message);

Console.ReadLine();
