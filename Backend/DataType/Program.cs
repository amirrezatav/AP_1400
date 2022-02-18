using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    internal class Program
    {
        static string Getstring()
        {
            return Console.ReadLine();  
        }
        static void Main(string[] args)
        {
            //// string
            //string lit = "D:\\University\\Term 6\\AP\\PDF";
            //string ver = @"D:\University\Term 6\AP\PDF";

            //// Integer 
            //short integer16 = 0;
            //int integer32 = 0;
            //long integer64 = 0;
            //ushort unsigninteger16 = 0;
            //uint unsigninteger32 = 0;
            //ulong unsigninteger64 = 0;

            //// Floating Point
            //float floating_Float = 2.5F;
            //double floating_Double = 0.005;
            //decimal floating_Decimal = 2.5M;

            ////Console.Write(" Size of ");
            ////Console.Write(nameof(floating_Decimal));
            ////Console.Write(" = ");
            ////Console.Write(decimal.MinValue);
            //// Boolean

            //bool Boolean = true;
            //bool Boolean2 = 2 >= 5;


            //// Object
            //Object obj ;
            //obj = "string";
            //obj = 2;
            //obj = 2.5;
            //obj = 2.5M;
            //// obj *= 2; Erorr
            //Console.WriteLine(obj);



            //// Dynamic
            //dynamic dynamic_var;
            //dynamic_var = 2.5M;
            //dynamic_var *= 2;
            //Console.WriteLine(dynamic_var);
            //dynamic_var = "Hello";
            //dynamic_var += " World!";
            //Console.WriteLine(dynamic_var);


            //// var
            //var a = 5;

            // Null
            string str = null;
            int? myint = null;
            Console.WriteLine(myint);
            if(myint != null)
            {
                // do something
            }

            Console.ReadLine();
        }
    }
}
