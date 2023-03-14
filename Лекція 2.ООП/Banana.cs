using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Apple
{
    internal class Banana : BaseFruit
    {
        //поля
        private int doesnthavenumberofpips;

        //свойства
        public int DoesntHaveNumberofpips => doesnthavenumberofpips;
        //конструктор без параметров
        public Banana() : base()
        {

        }

        //конструктор с параметрами
        public Banana(int DoesntHaveNumberofpips, string Color, string Variety, int Size, string Peel, double Weight)
            : base(Color, Variety, Size, Peel, Weight)
        {
            this.doesnthavenumberofpips = DoesntHaveNumberofpips;
        }
        //переопределенный метод
        public override void Seeds()
        {
            
        }
        public override void PrintFruit()
        {
            Console.WriteLine($"Number of pips: {DoesntHaveNumberofpips} \nColor: {Color} \nGrade: {Grade} \nSize: {Size} \nPeel: {Peel} \nWeight: {weight}");

        }
    }
}
