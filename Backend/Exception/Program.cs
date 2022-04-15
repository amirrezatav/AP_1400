using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyException
{
    public class Divsion
    {
        public static void DivisionV1()
        {
            decimal a = 0.0M;
            decimal b = 0.0M;
            while (true)
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Enter a : ");
                        a = Convert.ToDecimal(Console.ReadLine());
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.Write("Enter b : ");
                        b = Convert.ToDecimal(Console.ReadLine());
                        break;
                    }
                    catch (Exception babaei)
                    {
                        Console.WriteLine(babaei.ToString());
                    }
                }
                try
                {
                    Console.Write($" - a / b = {a / b}\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
        public static void DivisionV2()
        {
            decimal a = 0.0M;
            decimal b = 0.0M;
            while (true)
            {
                try
                {
                    Console.Write("Enter a : ");
                    a = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Enter b : ");
                    b = Convert.ToDecimal(Console.ReadLine());
                    Console.Write($" - a / b = {a / b}\n");
                }
                catch (FormatException fex)
                {
                    Console.WriteLine($"Input is incorect : {fex.Message}");
                }
                catch(DivideByZeroException)
                {
                    Console.WriteLine($"Divide By Zero Exception.");
                }
                catch
                {
                    Console.WriteLine($"Error");
                }
            }
        }
    }
    public class FileStream
    {
        public static void ReadFile()
        {
            byte[] text = new byte[1024];
            var fs = File.OpenRead(@"C:\Users\Administrator\Desktop\test.txt");
            while (true)
            {
                try
                {
                    int count = fs.Length < 1024 ? (int)fs.Length : 1024;
                    fs.Read(text, 0, count);
                    Console.WriteLine(Encoding.UTF8.GetString(text, 0, count));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    fs.Close();
                }
                Console.ReadLine();
            }

        }
    }
    public class Person
    {
        int _age;
        public int Age { 
            get { return _age; } 
            set {
                if (value >= 18)
                    _age = value;
                else
                    throw new BabaeiException("Min of age in 18.");
            } }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //Divsion.DivisionV1();
            //Divsion.DivisionV2();
            //FileStream.ReadFile();
            try
            {
                Person ps = new Person();
                ps.Age = 12;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Source);
            }
            Console.ReadLine();
        }
    }
}
