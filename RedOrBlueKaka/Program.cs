//ToK Lexicon , Bror Johansson

Console.Write("Vad är ditt namn? ");
string namn = Console.ReadLine();

Console.Write("Vill du ta den röda kakan " + namn + " eller den blåa kakan? (ange röd eller blå för att välja) \n");
string val = Console.ReadLine().ToLower();

if (val == "röd")
{
    Console.WriteLine(namn + " IS now blessed by the gods at Lexicons empire! Eat the cake " + namn + " and kneel before Jonathan, Håkan, Pontus next time you see them.");
    Console.WriteLine("31 mars it all begins. Hallelujah!");
}
else if (val == "blå")
{
    Console.WriteLine("Vem fan äter den blåa kakan? Se Matrix och prova igen!");
}
else
{
    Console.WriteLine("Du valde inget alls, inget jag ser som giltligt i alla fall. Hejdå!"); //Om inga giltliga val görs! 
}