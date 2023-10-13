using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex01.MenuItems
{
    public class sComparator : MenuItemStrings
    {
        public static int Compar(string sOne, string sTwo, int sTwoLen)
        {
            var count = -1;
            if (sOne.Take(sTwoLen).All(e => sOne[++count] == sTwo[count]))
            {
                ++count;
            }
            return count;
        }
    }
}