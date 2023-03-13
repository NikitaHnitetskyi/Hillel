using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Apple
{
    public abstract class BaseFruit
    {
        //поля
        protected string color;
        protected string variety;
        protected int size;
        protected string peel;
        protected double weight;

        //свойства
        public string Color => color;
        public string Grade => variety;
        public int Size => size;
        public string Peel => peel;
        public double Weight => weight;

        //конструктор без параметров
        public BaseFruit()
        {

        }

        //конструктор с параметрами
        public BaseFruit(string Color, string Variety, int Size, string Peel, double Weight)
        {
            this.color = Color;
            this.variety = Variety;
            this.size = Size;
            this.peel = Peel;
            this.weight = Weight;
        }

        //метод(ы)
        public virtual void Seeds()
        {
            Console.WriteLine("I give seeds, but can be not:)");
        }
        public abstract void PrintFruit();
    }
}

