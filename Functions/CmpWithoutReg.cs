using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex01.MenuItems
{
    public class CmpWithoutReg : MenuItemStrings
    {
        public static void ComparWReg(string sOne, string sTwo, int sOneLen, int sTwoLen)
        {
            sComparator.Compar(sOne.ToLower().Trim(), sTwo.ToLower().Trim(), sOneLen, sTwoLen);
        }
    }
}