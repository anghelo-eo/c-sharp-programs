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
            Console.Write("Enter the first string with fewer than 100 characters:");
            sOne = Console.ReadLine();
            int sOneLen = sOne.Length;
            if (sOneLen > 100)
            {
                Console.WriteLine("ERROR: The entered string is longer than 100 characters.");
                Execute();
            }
            Console.Write("Enter the second string with fewer than 100 characters:");
            sTwo = Console.ReadLine();
            int sTwoLen = sTwo.Length;
            if (sTwoLen > 100)
            {
                Console.WriteLine("ERROR: The entered string is longer than 100 characters.");
                Execute();
            }

            Console.WriteLine("Check against the register.");
            sComparator.Compar(sOne, sTwo, sOneLen, sTwoLen);
            
            Console.WriteLine("Checks case insensitively, double spaces and spaces at the beginning and end of a line.");
            CmpWithoutReg.ComparWReg(sOne.Replace("  ", ""), sTwo.Replace("  ", ""), sOneLen, sTwoLen);

            Palindrome.Palind(sOne.ToLower().Replace(" ", ""), sTwo.ToLower().Replace(" ", ""));
            
            Recognizer.analiysis(sOne.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", ""));
            Recognizer.analiysis(sTwo.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", ""));
        }
    }
}