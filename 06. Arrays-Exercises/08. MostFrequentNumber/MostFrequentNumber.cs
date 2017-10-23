using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main()
        {

            int[] userInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 0;
            int max = 0;
            int maximumNumber = 0;
            for (int i = 0; i < userInput.Length; i++)
            {
                for (int j = 0; j < userInput.Length; j++)
                {
                    if (userInput[i] == userInput[j])
                    {
                        counter++;
                        if (counter > max)
                        {
                            max = counter;
                            maximumNumber = userInput[i];
                        }
                    }
                }
                counter = 0;
            }

            Console.WriteLine(maximumNumber);


            //{

            //    With Dictionary

            //    int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //    var result = new Dictionary<int, int>();

            //    foreach (int value in numbers)
            //    {
            //        if (result.ContainsKey(value))
            //        {
            //            result[value]++;
            //        }
            //        else
            //        {
            //            result.Add(value, 1);
            //        }
            //    }

            //    int mostCommonValue = 0;
            //    int highestCount = 0;

            //    foreach (var pair in result)
            //    {
            //        if (pair.Value > highestCount)
            //        {
            //            mostCommonValue = pair.Key;
            //            highestCount = pair.Value;
            //        }
            //    }

            //    Console.WriteLine(string.Join(" ", mostCommonValue));
            //}
        }
    }
}
