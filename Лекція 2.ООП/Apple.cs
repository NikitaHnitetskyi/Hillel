using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Apple
{
    public class Apple : BaseFruit
    {
        //поля
        private int numberofpips;

        //свойства
        public int Numberofpips => numberofpips;

        //конструктор без параметров
        public Apple() : base()
        {

        }

        //конструктор с параметрами
        public Apple(int Numberofpips, string Color, string Variety, int Size, string Peel, double Weight) 
            : base(Color, Variety, Size, Peel, Weight)
        {
            this.numberofpips = Numberofpips;
        }        
        //переопределенный метод
        public override void Seeds()
        {
            Console.WriteLine("Givin seeds apple!");
        }
        public override void PrintFruit()
        {
            Console.WriteLine($"Number of pips: {Numberofpips} \nColor: {Color} \nGrade: {Grade} \nSize: {Size} \nPeel: {Peel} \nWeight: {weight}");
            
        }
    }
}
