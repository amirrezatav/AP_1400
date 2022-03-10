using System;
using System.Text.RegularExpressions;

namespace RegExApplication
{
    class Program
    {

        static void Main(string[] args)
        {
            // Get all matches    
            MatchCollection matchedAuthors = rg.Matches(authors);
            //To find the matches collection we will use the For loop 
            // Print all matched authors    
            for (int count = 0; count < matchedAuthors.Count; count++)
                Console.WriteLine(matchedAuthors[count].Value);
        }
    }
}