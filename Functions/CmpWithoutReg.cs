using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Ex01.MenuItems
{
    public class CmpWithoutReg : MenuItemStrings
    {
        public static void ComparWReg(string sOne, string sTwo)
        {
            sOne = Regex.Replace(sOne, @"\s+", " ");
            sTwo = Regex.Replace(sTwo, @"\s+", " ");
            sOne = sOne.ToLower().Trim();
            sTwo = sTwo.ToLower().Trim();
            int sOneLen = sOne.Length;
            int sTwoLen = sTwo.Length;
            Console.WriteLine(sOne);
            Console.WriteLine(sTwo);
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
                    Console.WriteLine("Strings are equal.");
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