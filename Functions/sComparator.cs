using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex01.MenuItems
{
    public class sComparator : MenuItemStrings
    {
        public static void Compar(string sOne, string sTwo, int sOneLen, int sTwoLen)
        {
            var count = -1;
            if (sOne.Take(sTwoLen).All(e => sOne[++count] == sTwo[count]))
            {
                ++count;
            }
            if (count <= 0)
            {
                throw new Exception("Strings are different.");
            }

            if (sOneLen == sTwoLen)
            {
                if (sOneLen == count)
                {
                    Console.WriteLine("Strings are equal characters by characters.");
                }
            }
            else if (sOneLen > sTwoLen)
            {
                throw new Exception("The first string is bigger than the second.");
            }
            else
            {
                throw new Exception("The first string is smaller than the second.");
            }
            Console.WriteLine("Number of matching characters is :{0}\n", count);
        }
    }
}