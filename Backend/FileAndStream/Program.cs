using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileAndStream
{
    public class Program
    {
      
        static void Main(string[] args)
        {
            // Code1();
            //ReadTextFile();
            // WriteTextFile();
            // WorkingWithFileInfo();
            // WorkingWithDirectory();
            // WorkingWithPath();
            WorkingWithStream();
            Console.ReadLine();
        }

        private static void WorkingWithStream()
        {
            // text path 
            string desktoppath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filepath = Path.Combine(desktoppath, "testext.txt");

            // our text 
            string str = "سلام Animations are not the only useful type of timeline. Other timeline classes are provided to help you organize sets of timelines, and to apply timelines to properties. Container timelines derive from the TimelineGroup class, and include ParallelTimeline and Storyboard.A Storyboard is a type of container timeline that provides targeting information for the timelines it contains. A Storyboard can contain any type of Timeline, including other container timelines and animations. Storyboard objects enable you to combine timelines that affect a variety of objects and properties into a single timeline tree, making it easy to organize and control complex timing behaviors. For example, suppose you want a button that does these three things.Grow and change color when the user selects the button.Shrink away and then grow back to its original size when clicked.Shrink and fade to 50 percent opacity when it becomes disabled.In this case, you have multiple sets of animations that apply to the same object, and you want to play at different times, dependent on the state of the button. Storyboard objects enable you to organize animations and apply them in groups to one or more objects.";
            
            // create stream for write 
            using (Stream streamWriter = new FileStream(filepath, FileMode.Create, FileAccess.Write))
            {
                // we want to write 20 byte each time in stream
                const int bufferSize = 20; // 20 Byte
                                           // create buffer 
                byte[] buffer = new byte[bufferSize];

                // 45 Byte -> 25 -> 5 -> error
                int byteRead = 0;

                int Position = 0;
                int remianByte = 0;

                while (Position < str.Length)
                {
                    remianByte = str.Length - byteRead;
                    byteRead = remianByte > bufferSize ? bufferSize : remianByte;

                    string writeStr = str.Substring(Position, byteRead);

                    buffer = Encoding.UTF8.GetBytes(writeStr);
                    streamWriter.Write(buffer, 0, byteRead);

                    Position += byteRead;
                }
            }
        }

        static void Code1()
        {
            // Path , file , Directory , FileStream

            // FileName : Name + Extention

            string root = Directory.GetCurrentDirectory(); // get exe path
            string filename = "MyTextFile.txt";
            string filepath = Path.Combine(root, filename); // Combine exe path with filename 
            // or string filepath = root + "\\" + filename;
            string input;
            input = Console.ReadLine();
            if (!File.Exists(filepath)) // check file existance
            {
                // if not exist 
                StreamWriter streamWriter = File.CreateText(filepath); // create text file 
                streamWriter.WriteLine(input); //  Write input on file + enter
                Console.WriteLine("Do you want to save file ? y : yes , other key : no");
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.Y)
                {
                    streamWriter.Close(); // close and save file
                }
                else
                {
                    streamWriter.Flush(); // clear streamWriter content  
                    streamWriter.Close(); // close and save file
                }
            }
            else
            {
                StreamWriter streamWriter = File.AppendText(filepath); // open file for Appending 
                streamWriter.WriteLine(input); // write input at the end of file
                streamWriter.Close(); // close and save file
            }
        }
        private static void ReadTextFile()
        {
            string root = Directory.GetCurrentDirectory();
            string filename = "MyTextFile.babaei";
            string filepath = Path.Combine(root, filename);
            // Working with Text file 
            if (File.Exists(filepath))
            {
                string text = File.ReadAllText(filepath);
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("File Not Found!");
            }
            //try
            //{
            //    string text = File.ReadAllText(filepath);
            //    Console.WriteLine(text);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }
        private static void WriteTextFile()
        {
            string root = Directory.GetCurrentDirectory();
            string filename = "MyTextFile.babaei";
            string filepath = Path.Combine(root, filename);
            string input;
            input = Console.ReadLine();
            // Working with Text file 
            if (!File.Exists(filepath))
            {
                File.WriteAllText(filepath, input);
            }
            else
            {
                File.AppendAllText(filepath, input);
            }
        }
        private static void WorkingWithFileInfo()
        {
            string root = Directory.GetCurrentDirectory(); // path of application exe
            string filename = "MyTextFile.babaei";
            string filepath = Path.Combine(root, filename);
            FileInfo fileInfo = new FileInfo(filepath);
                                                   // Get Windows Special Folder Like Music , Desktop , Documnet , ...
            string documentDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string getfilename = Path.GetFileName(filepath);
            string filepathdis = Path.Combine(documentDirectory, getfilename);
            fileInfo.CopyTo(filepathdis); // Copy File
            fileInfo.MoveTo(filepathdis); // Cut File
            fileInfo.Delete(); // Delete File
        }
        private static void WorkingWithDirectory()
        {
            string applicationpath = Directory.GetCurrentDirectory();
            var pathes = Directory.GetFiles(applicationpath);// Get All File in directory as array
            foreach (var item in pathes)
                Console.WriteLine(item);
            Console.WriteLine("--------------------------");

            string directoryname = "Babei";
            string DirectoryPath = Path.Combine(applicationpath, directoryname);
            Directory.CreateDirectory(DirectoryPath);
            // Directory.Delete(DirectoryPath);
            // Get All File in directory as list        Get FileName       
            var res = Directory.EnumerateFiles(applicationpath)
                .Where(x => Path.GetFileName(x).ToLower().Contains("ba"))
                .ToList(); // Visual


            string documentDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var res2 = Directory.EnumerateDirectories(documentDirectory)// Get All directories in directory as list
                .Where(x => Path.GetFileName(x).ToLower().Contains("visual"))
                .ToList();
            foreach (var item in res2)
                Console.WriteLine(item);

            if (Directory.Exists(directoryname))
            {
                // Directory Exists
            }
            else
            {
                // Directory does not Exists
            }
            Directory.GetDirectories(directoryname); // Get All directories in directory as array
        }
        private static void WorkingWithPath()
        {
            string path = @"./Babaei";
            //Directory.CreateDirectory(path);
            var Files = Directory.GetFiles(path);
            Console.WriteLine("File in ..");
            foreach (var item in Files)
                Console.WriteLine(item);
            

        }



    }
}
