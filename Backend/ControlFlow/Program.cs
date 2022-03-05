using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^H.{,3}o$";
            string str = "Hyyyyyo";

             if(Regex.IsMatch(str, pattern))
                Console.WriteLine(Regex.Match(str, pattern).Value);
             else
                Console.WriteLine(false);












            Console.ReadLine();












            //int[] BabaeiArr = new int[50];
            //for (int i = 0; i < BabaeiArr.Length; i++)
            //{
            //    BabaeiArr[i] = i * 2;
            //}
            //foreach (var targetBabaei in BabaeiArr)
            //{
            //    Console.WriteLine(targetBabaei);
            //}
            //foreach (int targetBabaei in BabaeiArr)
            //{
            //    Console.WriteLine(targetBabaei);
            //}

            //object obj = 50;
            //dynamic dynamicVar = "50";

            //// Pattern Maching with switch
            //switch (dynamicVar)
            //{
            //    case int Intbabaei: Console.WriteLine("is int"); break;
            //    case double Doublebabaei: Console.WriteLine("is Double"); break;
            //    case string Stringbabaei: Console.WriteLine("is string"); break;
            //    case DateTime DateTimebabaei: Console.WriteLine("is DateTime"); break;
            //    default: Console.WriteLine("error"); break;
            //}
            //// Pattern Maching with if
            //if (dynamicVar is int babaeiint)
            //{
            //    babaeiint++;
            //    Console.WriteLine(babaeiint.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("a is not integer");
            //}
            //if (obj is double doubleVar)
            //{
            //    doubleVar++;
            //    Console.WriteLine(doubleVar.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("d is not integer");
            //}
            //Console.ReadLine();

            ////// 1
            ////if(a==50)
            ////{
            ////    Console.WriteLine(50);
            ////}
            ////// 2
            ////if(a==5)
            ////{
            ////    Console.WriteLine(50);
            ////}
            ////else
            ////{
            ////    Console.WriteLine("error");
            ////}
            ////// 3
            ////if (a==5)
            ////{
            ////    Console.WriteLine(5);
            ////}
            ////else if (a < 6)
            ////{
            ////    Console.WriteLine(5);
            ////}
            ////else if(a>4)
            ////{
            ////    Console.WriteLine(5);
            ////}
            ////else
            ////{
            ////    Console.WriteLine("error");
            ////}

            

        }
    }
}
