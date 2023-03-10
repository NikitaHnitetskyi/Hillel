using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    public class Program
    {
        static void Main(string[] args)
        {
            //this is my first home task
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int result = number1 + number2;

            if(result <= 100)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
