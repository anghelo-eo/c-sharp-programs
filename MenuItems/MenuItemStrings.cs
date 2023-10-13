using Ex01.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex01.MenuItems
{
    public class MenuItemStrings : MenuItemCore
    {
        public override string Title { get {return "Strings";} }

        public override void Execute()
        {
            string? sOne = "";
            string? sTwo = "";
            Console.Write("Enter the first string with fewer than 40 characters:");
            sOne = Console.ReadLine();
            int sOneLen = sOne.Length;
            //Console.WriteLine($"String is {sOne}");
            Console.WriteLine(sOneLen);
            if (sOneLen > 39)
            {
                Console.WriteLine("ERROR: The entered string is longer than 40 characters.");
                Execute();
            }
            Console.Write("Enter the second string with fewer than 40 characters:");
            sTwo = Console.ReadLine();
            int sTwoLen = sTwo.Length;
            Console.WriteLine(sTwoLen);
            if (sTwoLen > 39)
            {
                Console.WriteLine("ERROR: The entered string is longer than 40 characters.");
                Execute();
            }
            Console.WriteLine("Check against the register.");
            int checkOne = sComparator.Compar(sOne, sTwo, sTwoLen);
            if (sOneLen == sTwoLen)
            {
                if (sOneLen == checkOne)
                {
                    Console.WriteLine("Strings are equal characters by characters.");
                }
            }
            else if (sOneLen > sTwoLen)
            {
                Console.WriteLine("The first string is bigger than the second.");
            }
            else
            {
                Console.WriteLine("The first string is smaller than the second.");
            }
            Console.WriteLine("Number of matching characters is :{0}", checkOne);
            Console.WriteLine("");
            Console.WriteLine("Check without register and spaces at the beginning and end of the string.");
            int checkTwo = CmpWithoutReg.ComparWReg(sOne, sTwo, sTwoLen);
            Console.WriteLine("Number of matching characters is :{0}", checkTwo);
        }
    }
}