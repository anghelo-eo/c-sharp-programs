using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Ex01.MenuItems
{
    public class Recognizer : MenuItemStrings
    {
        public static void analiysis(string sOne)
        {
            Regex regexEmail = new Regex(@"[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+");
            MatchCollection matchesEmail = regexEmail.Matches(sOne);
            if (matchesEmail.Count > 0)
            {
                Console.WriteLine($"{sOne} is an email address.");
            }
            else
            {
                Console.WriteLine($"{sOne} is not an email address.");
            }
        }
    }
}