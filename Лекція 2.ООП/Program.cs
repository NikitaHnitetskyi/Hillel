using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Apple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple(10, "Red", "Pinova", 5, "Hard", 98.34);
            apple.PrintFruit();
            apple.Seeds();
        }
    }
}
