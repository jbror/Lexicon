//Updated version of FizzBuzz. This make it possible to play with arguments for Fizz, Buzz and up to any specified number 

Console.WriteLine("Hi hello Lexicon and hey ho World!");
Console.WriteLine("FizzBuzz with custom input! ");
     void FlexibleFizzBuzz(int fizzNumber, int buzzNumber, int upperLimit)
{
    for (int i = 1; i <= upperLimit; i++)
    {
        bool isFizz = (i % fizzNumber == 0);
        bool isBuzz = (i % buzzNumber == 0);

        if (isFizz && isBuzz)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (isFizz)
        {
            Console.WriteLine("Fizz");
        }
        else if (isBuzz)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(i);
        }
    }


}

FlexibleFizzBuzz(7, 15, 150); //In this call: Even divided by 7 for Fizz, 15 for Buzz and count up to 150