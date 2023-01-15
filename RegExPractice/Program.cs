using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegExPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Escape sequences with backslash
            //var string_1 = "Hi\nLoser!";
            //var string_2 = @"Hi\nLoser!";
            //Console.WriteLine(string_1 + " " + string_2);

            //// @ sign in the beginning if the string makes string Verbatim (ignores escape characters

            //// Escape sequence with quotes
            //var string_3 = "\"Richard\", not \"Dick\"";
            //var string_4 = @"""Richard"", not ""Dick""";
            //Console.WriteLine(string_3 + "\n" + string_4);

            // Regular Expression

            string RegExString = "[a-z],";
            var regex = new Regex(RegExString);

            var probeString = "a,b,";

            var listOfStrings = regex.Matches(probeString).OfType<Match>().ToList().Select<Match,string>(match => match.Value);
            foreach(var match in listOfStrings)
            {
                Console.WriteLine(match);
            }

            Console.ReadKey();
        }
    }
}
