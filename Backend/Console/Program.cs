using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        static void MyFunction(object sender, ConsoleCancelEventArgs e)
        {
            Console.WriteLine("\n\n\n Press Ctrl+C in MyFunction");
        }
        static void Main(string[] args)
        {

            Console.CancelKeyPress += MyFunction;


            //Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ResetColor();

            Console.Title = "My App Name";
            
           if (Console.NumberLock)
                Console.WriteLine("NumberLock is On");

            Console.CursorVisible = false;

            if (Console.CapsLock == true)
                Console.WriteLine("CapsLock is On");

            Console.WriteLine("Hello World!"); // =  Console.Write("Hello World\n");
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write("Hello World");
            Console.ReadLine(); // read a line as string
            Console.Read();

            // Read a key form Keyboard Or mouse
            ConsoleKeyInfo redkeyinfo = Console.ReadKey();
            ConsoleKeyInfo redkeyinfo2 = Console.ReadKey();
            if (redkeyinfo.Modifiers == ConsoleModifiers.Control && redkeyinfo2.Key == ConsoleKey.S)
                Console.WriteLine("Press CTRL+S key");
            else
                Console.WriteLine("Press other key");

            Console.Beep();
            Console.Clear();

            Console.SetWindowSize(20, 20);
            Console.SetWindowPosition(100, 25);

        }
    }
}
