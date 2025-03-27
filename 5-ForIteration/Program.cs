//On Lexicons Course
//Doing this video https://learn.microsoft.com/en-us/shows/csharp-fundamentals-for-absolute-beginners/for-iteration-statement
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5ForIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(i);
                if (i == 7)
                {
                    Console.WriteLine("Found seven, yes!");
                    break;
                }
                
            }

            Console.ReadLine();
        }
    }
}
