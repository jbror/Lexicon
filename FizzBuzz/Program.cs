//Lexicon ToK
//Hej Lexicon och hej världen! 

Console.WriteLine("Hi, this is Bror speaking from inside the terminal.. I'm stuck in here and all I can do is to write some code.."); //Skriver ut text i terminalen
await Task.Delay(2000); // Väntar i 2 sekunder 

Console.WriteLine("Can I show you...? (enter y for yes)"); //Skriver ut text och instruktioner
string input = Console.ReadLine(); //Tar in input(sträng) från användaren, sparar i min variabel input

if (input.ToLower() == "y") // Gör om inputen till lowercas och kollar om det är y!
{
    for (int i = 1; i <= 100; i++)
    {
        if (i % 3 == 0 && i % 5 == 0) //Om delbart med 3 och 5 skrivs FizzBuzz ut
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (i % 3 == 0) //Om  delbart med 3
        {
            Console.WriteLine("Fizz");
        }
        else if (i % 5 == 0) //Om  delbart med 5
        {
            Console.WriteLine("Buzz"); 
        }
        else //Skriver ut siffran om inte jämt delbart med 3 eller 5
        {
            Console.WriteLine(i); 
        }
    }
    await Task.Delay(1500); // Väntar i 1,5 sekunder för häftig effekt och timing.
    Console.WriteLine("BOOM! That was my FizzBuzz! And just found my way out of the terminal.. Farewell and Good Night...");
}
else //Om inputen inte är y skrivs detta ut
{
    Console.WriteLine("You are boring, hejdå"); 
}