using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    /// <summary>
    /// This class for learing function calling
    /// </summary>
    internal struct MyClass
    {
        public int a;
        public int b;
        public int c;
    }
    internal class Program
    {
        /// <summary>
        /// This class for learing function calling
        /// </summary>
        public static bool IsEven(int nummber)
        {
            return nummber % 2 == 0;
        }
        // public static bool IsEven(int nummber) => nummber % 2 == 0;
        static void sum(out MyClass my1, out MyClass my2, out MyClass my3)
        {
            my1 = new MyClass();
            my3 = new MyClass();
            my2 = new MyClass();
            my1.a = 5;
        }
        int Inc(int a)
        {
            a++;
            return a;
        }
        char Inc(int a , bool flag)
        {
            a++;
            return (char)a;
        }
        static void Main(string[] args)
        {
            IsEven(1);
        }
    }
}