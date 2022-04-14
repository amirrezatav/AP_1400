using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Program
    {
        public abstract class AbstractRect
        {
            protected double Width { get; set; }
            protected double Height { get; set; }
            public AbstractRect(double w, double h)
            {
                Width = w;
                Height = h;
            }
            protected double Area()
            {
                return Width * Height;
            }
            public abstract string Display();
            public override string ToString()
            {
                return "Hello";
            }
        }
        public class Tabletop : AbstractRect
        {
            readonly int Cost;
            public Tabletop(int cost, double width, double height)
                : base(width, height)
            {
                this.Cost = cost;
            }
            public double GetCost()
            {
                return Area() * Cost;
            }
            public override string Display()
            {
                return $"Width : {Width},\n" +
                    $"Height : {Height},\n" +
                    $"Area : {Area()},\n" +
                    $"Cost : {GetCost()}";
            }
        }


        static void Main(string[] args)
        {
            AbstractRect rect = new Tabletop(2, 2, 5);
            Console.WriteLine(rect.ToString());
            Console.ReadLine();
        }
    }
}
