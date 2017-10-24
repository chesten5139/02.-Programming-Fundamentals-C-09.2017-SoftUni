using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SearchForANumber
{
    class SearchForANumber
    {
        static void Main()
        {
            var firstLine = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var secondLine = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var newArray = new List<int>();

            for (int i = 0; i < secondLine[0]; i++)
            {
                newArray.Add(firstLine[i]);
            }

            newArray.RemoveRange(0, secondLine[1]);

            bool isInList = newArray.Contains(secondLine[2]);
            if (isInList)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
