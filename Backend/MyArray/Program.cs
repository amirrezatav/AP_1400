using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "\\n";
            Console.WriteLine(str);
            string str2 = @"\t\n";
            Console.WriteLine(str2);
            int a = 5;
            int b = 6;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            string str3 = $"{a} + {b} = {a + b}";

            Console.WriteLine($"{a} + {b} = {a + b}");

            Console.ReadLine();



            // Jagged Array
            //double[][][] arrd = new double[][][]
            //{
            //    new double[][]
            //    {
            //        new double[] { 1, 2},
            //        new double[] { 6, 5 , 3 , 4}
            //    },
            //    new double[][]
            //    {
            //        new double[] { 10, 23 ,56},
            //        new double[] {45, 25 , 75 , 58 , 65},
            //        new double[] { 508 , 605},
            //    }
            //};
            //var babaei = arrd[0][1][2];// babaei is 3
            //// 2-d array
            //double[,] mat1;
            //double[,] mat2;
            //double[,] mat3;

            //int row1 , row2 , col1 , col2 ;
            //row1 = Convert.ToInt32(Console.ReadLine());
            //row2 = Convert.ToInt32(Console.ReadLine());
            //col1 = Convert.ToInt32(Console.ReadLine());
            //col2 = Convert.ToInt32(Console.ReadLine());
            //mat1 = new double[row1,col1];
            //mat2 = new double[row2,col2];
            //mat3 = new double[row1,col1];

            //if (row1 != row2 || col1 != col2)
            //    return;

            //for (int i = 0; i < row1; i++)
            //    for (int j = 0; j < col1; j++)
            //        mat3[i, j] = mat1[i, j] + mat2[i, j];

            //for (int i = 0; i < row1; i++)
            //    for (int j = 0; j < col1; j++)
            //        Console.WriteLine(mat3[i, j]);

            //double[] arr1 = {1.5 , 3.2 , 0.24 ,  2.6 , 7 , 0.25 };
            //double[] arr2 = {0,1,5.6,3,4,5,5.6,7,8,9,10};

            //Array.Copy(arr1,2,arr2,3,4);
            //// arr2 = {0,1,2,0.24 ,2.6,7,0.25,7,8,9,10};
            //Array.Clear(arr1,0,arr1.Length);

            //Array.Sort(arr1);

            //Array.Reverse(arr2);

            //double target = 5.6;
            //var searchRes  = Array.BinarySearch(arr2, target);
            //searchRes = Array.IndexOf(arr1, target, 2 , 5);
            //searchRes = Array.LastIndexOf(arr1, target, 2, 5);
        }
    }
}
