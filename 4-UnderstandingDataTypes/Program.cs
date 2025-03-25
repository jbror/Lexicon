//From the ToK material at Lexicon
//This is the video related to this project https://learn.microsoft.com/en-us/shows/csharp-fundamentals-for-absolute-beginners/understanding-data-types-and-variables

Console.WriteLine("Hej Hello Lexicon!\n");




//int x = 7;
//int y = x + 3;
//Console.WriteLine(x);
//Console.WriteLine(y);

//Console.Write(y);
//Console.Read();

/*
int x;
int y;

x = 7;
y = x + 3;

Console.WriteLine(y);
Console.ReadLine();
*/


// About strings, concatenate and basic syntax

Console.WriteLine("What is your name?");
Console.WriteLine("Type your first name");
string MyFirstName;
MyFirstName = Console.ReadLine();

//string myLastName;
//Console.Write("Type your last name : ");
//myLastName = Console.ReadLine();

Console.WriteLine("Type your last name: ");
string myLastName = Console.ReadLine(); 


Console.WriteLine("Hello, " + MyFirstName + " " + myLastName);
Console.ReadLine();
