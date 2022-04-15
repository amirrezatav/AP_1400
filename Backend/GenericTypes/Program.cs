using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    public class Number <T>
    {
        T num1 = default(T);

        public override string ToString()
        {
            return num1.ToString();
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Number<int> n = new Number<int>();
            Console.WriteLine(n.ToString());
            Console.ReadLine();
        }
    }
}
