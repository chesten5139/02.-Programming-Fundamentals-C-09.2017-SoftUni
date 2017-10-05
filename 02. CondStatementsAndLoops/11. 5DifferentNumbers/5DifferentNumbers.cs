using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5DifferentNumbers
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int n1 = a;
            int n2 = n1 + 1;
            int n3 = n2 + 1;
            int n4 = n3 + 1;
            int n5 = n4 + 1;

            if (a <= n1 && n1 < n2 && n2 < n3 && n3 < n4 && n4 < n5 && n5 <= b)
            {
                for (int i = a; i < b; i++)
                {
                    for (int j = a + 1; j < b; j++)
                    {
                        for (int k = j + 1; k < b; k++)
                        {
                            for (int y = k +1; y < b; y++)
                            {
                                for (int z = y + 1; i < b; z++)
                                {
                                    if (a <= i && i < j && j < k && k < y && y < z && z <= b)
                                    {
                                        Console.WriteLine(i + " " + j + " " + k + " " + y + " " + z);
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
