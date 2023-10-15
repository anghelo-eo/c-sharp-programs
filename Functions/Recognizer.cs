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
            Regex regexIpv4 = new Regex(@"(\b25[0-5]|\b2[0-4][0-9]|\b[01]?[0-9][0-9]?)(\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}");
            Regex regexIpv6 = new Regex(@"(([0-9a-fA-F]{1,4}:){7,7}[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,7}:|([0-9a-fA-F]{1,4}:){1,6}:[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,5}(:[0-9a-fA-F]{1,4}){1,2}|([0-9a-fA-F]{1,4}:){1,4}(:[0-9a-fA-F]{1,4}){1,3}|([0-9a-fA-F]{1,4}:){1,3}(:[0-9a-fA-F]{1,4}){1,4}|([0-9a-fA-F]{1,4}:){1,2}(:[0-9a-fA-F]{1,4}){1,5}|[0-9a-fA-F]{1,4}:((:[0-9a-fA-F]{1,4}){1,6})|:((:[0-9a-fA-F]{1,4}){1,7}|:)|fe80:(:[0-9a-fA-F]{0,4}){0,4}%[0-9a-zA-Z]{1,}|::(ffff(:0{1,4}){0,1}:){0,1}((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])|([0-9a-fA-F]{1,4}:){1,4}:((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]))");
            MatchCollection matchesEmail = regexEmail.Matches(sOne);
            MatchCollection matchesPhone = regexPhone.Matches(sOne);
            MatchCollection matchesIpv4 = regexIpv4.Matches(sOne);
            MatchCollection matchesIpv6 = regexIpv6.Matches(sOne);
            if (matchesEmail.Count > 0)
            {
                Console.WriteLine($"{sOne} is a email address.");
            }

            if (matchesPhone.Count > 0)
            {
                Console.WriteLine($"{sOne} is a phone number.");
            }

            if (matchesIpv4.Count > 0)
            {
                Console.WriteLine($"{sOne} is a IPv4 address.");
            }

            if (matchesIpv6.Count > 0)
            {
                Console.WriteLine($"{sOne} is a IPv6 address.");
            }
        }
    }
}