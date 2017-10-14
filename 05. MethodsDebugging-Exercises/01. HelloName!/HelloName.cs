using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HelloName_
{
    class HelloName
    {
        static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
        static void Main()
        {
            string name = Console.ReadLine();
            PrintName(name);
        }
    }
}
