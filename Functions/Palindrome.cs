using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex01.MenuItems
{
    public class Palindrome : MenuItemStrings
    {
        public static int Palind(string sOne, string sTwo)
        {
            char[] array = sOne.ToCharArray();
            Array.Reverse(array);
            string revsOne = new String(array);
            if (sTwo == revsOne)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}