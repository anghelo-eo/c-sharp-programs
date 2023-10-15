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
            Regex regexPhone = new Regex(@"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$");
            MatchCollection matchesEmail = regexEmail.Matches(sOne);
            MatchCollection matchesPhone = regexPhone.Matches(sOne);
            if (matchesEmail.Count > 0)
            {
                Console.WriteLine($"{sOne} is an email address.");
            }

            if (matchesPhone.Count > 0)
            {
                Console.WriteLine($"{sOne} is an phone number.");
            }
        }
    }
}