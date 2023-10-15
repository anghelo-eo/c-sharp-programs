using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex01.MenuItems
{
    public class Palindrome : MenuItemStrings
    {
        public static void Palind(string sOne, string sTwo)
        {
            Console.WriteLine("To detec a palindrome, all the spaces are ignored.");
            char[] array = sOne.ToCharArray();
            Array.Reverse(array);
            string revsOne = new String(array);
            if (sTwo == revsOne)
            {
                Console.WriteLine("The first string is a transposed for the second string.\n");
            }
            else
            {
                Console.WriteLine("The first string is not a transposed for the second string.\n");
            }
        }
    }
}