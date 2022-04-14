using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamp
{
    public class Rect
    {
        protected double Width { get; set; }
        protected double Height { get; set; }
        public Rect(double w, double h)
        {
            Width = w;
            Height = h;
        }
        protected double Area()
        {
            return Width * Height;
        }
        public virtual string Display()
        {
            return $"Width : {Width},\n" +
                $"Height : {Height},\n" +
                $"Area : {Area()},\n";
        }

    }
    public class Tabletop : Rect
    {
        readonly int Cost;
        public Tabletop(int cost , double width,double height) 
            : base(width , height)
        {
            this.Cost = cost;
        }
        public double GetCost()
        {
            return Area() * Cost;
        }
        public override string Display()
        {
            //return $"Width : {Width},\n" +
            //    $"Height : {Height},\n" +
            //    $"Area : {Area()},\n" +
            //    $"Cost : {GetCost()}";
            return base.Display() + $"Cost : {GetCost()}";
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Rect rect = new Rect(5.5,3.75);
            Console.WriteLine($"Display in Rect = { rect.Display()}");
            rect = new Tabletop(50, 5.5, 3.75);
            Console.WriteLine($"Display in Tabletop = { rect.Display()}");
            Console.ReadLine();
        }
    }
}
