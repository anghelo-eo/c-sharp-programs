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
            //Console.WriteLine($"String is {sTwo}");
            int CompRes = sComparator.Compar(sOne, sTwo, sOneLen, sTwoLen);
            if (sOneLen == sTwoLen)
            {
                if (sOneLen == CompRes)
                {
                    Console.WriteLine("Strings are equal characters by characters.");
                }
            }
            Console.WriteLine("Number of matching characters is :{0}", CompRes);
        }
    }
}