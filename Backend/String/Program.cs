using System;
using System.Text;
using System.Text.RegularExpressions;
namespace MyString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Noraml String
            string str = "Hello";
            string strpr = "این فایل از طریق برنامه سی شارپ ایجاد شده است و .برای نشان دادن .قابلیت..... پشتیبانی.  پشتیبانی پشتیبانی پشتیبانی از         UTF8 می باشد";
            string str2 = "C:\\Users\\amirr\\Desktop"; // is C:\Users\amirr\Desktop
            string str3 = "\n"; // is new line 
            string str3_1 = "\\n"; // is \n
            string str4 = "\t"; // is tab
            string str4_1 = "\\t"; // is \t
            // Verbatim String / mute string
            string verbatim = @"C:\Users\amirr\Desktop\myString.txt";
            string verbatim1 = @"\n"; // is \n
            string verbatim2 = @"\t"; // is \t
            // \n -> new line 
            // \t -> tab 
            // \\ -> \
            // Interpolation String
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            string Interpolation = $"{{ a  + { b } = { a+b }\n{ a } - { b } = { a - b }";
            //Interpolation is  {{ a  + b value =  a+b value new line a value - b value = a - b value
            var newstr1 = strpr.Substring(5, 5); // 5 - 10
            strpr = strpr.Remove(5, 2); // 5 - 7
            strpr = strpr.Replace("پشتیبانی", ""); // remove پشتیبانی
            // strpr = strpr.Replace('.', '؛');
            strpr = strpr.Trim(); // remove all white space 
            int index = strpr.IndexOf("ش");
            int index2 = strpr.LastIndexOf("ش");
            strpr = strpr.Insert(5, "ش");
            bool end = strpr.EndsWith("است.");
            ///////////////////////////////////////////
            string newstring = "علی | محمدی | 12 | تهران";
            var strarr = newstring.Split('|');
            ////////////////////////////////////////////
            string[] Names = { "Ali", "Mohammad", "Amir", "Hasan" };
            string[] Families = { "Mohammadzadeh", "Kazemi", "Bagheri", "Moradi" };
            string[] Emails = { "AliMohammadzadeh@gmail.com"  ,
                                "Mohammad_Kazemi45@Poroton.com" ,
                                "Amir83_Bagheri@yahoo.com" ,
                                "HasanMoradi_25@shahed.ac.ir"};
            string[] NormalizeNames = new string[Names.Length];
            string[] NormalizeFamilies = new string[Families.Length];
            string[] NormalizeEmails = new string[Emails.Length];
            for (int i = 0; i < Names.Length; i++)
            {
                NormalizeNames[i] = Names[i].ToUpper();
                NormalizeFamilies[i] = Families[i].ToUpper();
                NormalizeEmails[i] = Emails[i].ToUpper();
            }
            Console.WriteLine("Enter Target : ");
            string target = Console.ReadLine();
            target = target.ToUpper();

            foreach (string name in NormalizeNames)
            {
                if (name == target)
                    Console.WriteLine(true);
            }
            foreach (string family in NormalizeFamilies)
            {
                if (family == target)
                    Console.WriteLine(true);
            }
            foreach (string email in NormalizeEmails)
            {
                if (email == target)
                    Console.WriteLine(true);
            }
            Console.WriteLine("End");
            Console.ReadLine();
            // Regex
            // name_123.b@web.ac.ir
            string text = "name_123.b@web.ac.ir";
            string Pattern = @"^[A-Za-z0-9._]{1,256}@[A-Za-z0-9]{1,256}[.][A-Za-z]{2,4}[.]{0,1}[A-Za-z]{0,4}";
            Regex babaei = new Regex(Pattern);
            if (babaei.IsMatch(text))
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
            Console.ReadLine();
        }
    }
}
