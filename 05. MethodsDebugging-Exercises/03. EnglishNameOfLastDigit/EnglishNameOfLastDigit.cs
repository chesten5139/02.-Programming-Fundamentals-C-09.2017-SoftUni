using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnglishNameOfLastDigit
{
    class EnglishNameOfLastDigit
    {
        static long GetLastDigit(long numberInput)
        {
            byte lastDigit = (byte)(numberInput % 10);
            return lastDigit;
        }
        static string EnglishNameLastDigit(long numberInput)
        {
            string englishNameLastDigit = "";
            switch (GetLastDigit(numberInput))
            {
                case 0:
                    englishNameLastDigit = "zero";
                    break;
                case 1:
                    englishNameLastDigit = "one";
                    break;
                case 2:
                    englishNameLastDigit = "two";
                    break;
                case 3:
                    englishNameLastDigit = "three";
                    break;
                case 4:
                    englishNameLastDigit = "four";
                    break;
                case 5:
                    englishNameLastDigit = "five";
                    break;
                case 6:
                    englishNameLastDigit = "six";
                    break;
                case 7:
                    englishNameLastDigit = "seven";
                    break;
                case 8:
                    englishNameLastDigit = "eight";
                    break;
                case 9:
                    englishNameLastDigit = "nine";
                    break;
            }
            return englishNameLastDigit;
        }
        static void Main()
        {
            long numberInput = Math.Abs(long.Parse(Console.ReadLine()));
            Console.WriteLine(EnglishNameLastDigit(numberInput));
        }
    }
}
