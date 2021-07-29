using System;

namespace CheckDigitOrAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;

            Console.WriteLine("Enter a character");
            str = Console.ReadLine();
            char ch = str[0];
            if ((ch >= 65 && ch <= 90) || (ch >= 97 && ch <= 122)) { 
                Console.WriteLine("Alphabet");
            }
            else if (ch >= 48 && ch <= 57) { 
                Console.WriteLine("Digit");
            }
        }
    }
}
