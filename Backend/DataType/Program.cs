using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    public class MyClass
    {
        int a;
        int b;
        int c;
        // Constructor
        public MyClass()
        {

        }
        public MyClass(int a)
        {

        }
        public MyClass(int a , int b)
        {

        }
        public MyClass(int a , int b , int c)
        {

        }
        // Property
        public MyClass test { 
            get
            {
                MyClass myClass = new MyClass(2);
                // do somting with myClass
                return myClass;
            }
        }
        // Fucntion
        public static MyClass test2()
        {
             MyClass myClass = new MyClass(2);   
             return myClass;
        }
    }
    public class Program
    {
        static string Getstring()
        {
            return Console.ReadLine();  
        }
        static void Main(string[] args)
        {
            MyClass babaei1; // just define
            babaei1 = new MyClass(); // construct
            var babaei2 = new MyClass(1); // define and construct
            MyClass babaei3 = new MyClass(1,2);  // define and construct
            MyClass babaei4 = new MyClass(1,2,3);  // define and construct
            MyClass babaei5 = MyClass.test;
            babaei5 = MyClass.test2();

            //// string
            string litstr = "D:\\University\\Term 6\\AP\\PDF";
            string verstr = @"D:\University\Term 6\AP\PDF";
            string str = "12iuh3";
            
            // Integer 
            short integer16 = 0;
            int integer32 = 0;
            long integer64 = 0;
            ushort unsigninteger16 = 0;
            uint unsigninteger32 = 0;
            ulong unsigninteger64 = 0;

            // Floating Point
            float floating_Float = 2.5F;
            double floating_Double = 0.005;
            decimal floating_Decimal = 2.5M;

            floating_Double = integer32; // int to double imp
            floating_Double = (double)integer32; // int to double exp
            integer32 = (int)floating_Double; // double to int
            // integer32 = floating_Double; // double to int error
            integer32 = Convert.ToInt32(floating_Double); // double to int with function

            integer32 = Int32.TryParse(str); // string to long without any error
            integer32 = Convert.ToInt32(str); // string to long 
            str = floating_Double.ToString(); // any type to string

            // Boolean
            bool Boolean = true;
            bool Boolean2 = 2 >= 5;

            // Object
            Object obj ;
            obj = "string";
            obj = 2;
            obj = 2.5;
            obj = 2.5M;
            // obj *= 2; Erorr
            Console.WriteLine(obj);

            // Dynamic
            dynamic dynamic_var;
            dynamic_var = 2.5M;
            dynamic_var *= 2;
            Console.WriteLine(dynamic_var);
            dynamic_var = "Hello";
            dynamic_var += " World!";
            Console.WriteLine(dynamic_var);

            //// var
            var a = 5;

            // Null
            string str = null;
            int? myint = null;
            Console.WriteLine(myint);
            if(myint != null)
            {
                // do something
            }
            if(string.IsNullOrEmpty(str) == true)
            {
                Console.WriteLine("str is null");
            }

            // Byte
            byte[] b = new byte[50*1000]; // for binary data size : 50 kbyte
            Console.ReadLine();            

            // DateTime
            var date1 = new DateTime();
            DateTime date2 = new DateTime(2022 , 3 , 3 , 12 , 25 , 30 );
            DateTime date3 = new DateTime(202,3,3);
            date3.AddHours(3);

            string nowstr = DateTime.Now.ToString();

            DateTime now = DateTime.Now;
            int year = now.Year;
            int month = now.Month;
            int day = now.Day;
            int hour = now.Hour;
            int minute = now.Minute;
            int second = now.Second;
            now.AddDays(5); // add five day
            int dayofweek = now.DayOfWeek();
            Console.ReadLine();
        }
    }
}
