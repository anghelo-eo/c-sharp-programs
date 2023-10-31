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
            while(true)
            {
                string? sOne = "";
                string? sTwo = "";
                sOne = IOUtils.SafeReadString("Enter the first string with fewer than 100 characters:");
                sTwo = IOUtils.SafeReadString("Enter the second string with fewer than 100 characters:");
                
                int sOneLen = sOne.Length;
                int sTwoLen = sTwo.Length;
                try
                {
                    Console.WriteLine("Check against the register.");
                    sComparator.Compar(sOne, sTwo, sOneLen, sTwoLen);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                }

                try
                {
                    Console.WriteLine("Checks case insensitively, double spaces and spaces at the beginning and end of a line.");
                    CmpWithoutReg.ComparWReg(sOne, sTwo);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                }

                try
                {
                    Palindrome.Palind(sOne.ToLower(), sTwo.ToLower());
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                }
                
                try
                {
                    Recognizer.analiysis(sOne.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", ""));
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                }
                
                try
                {
                    Recognizer.analiysis(sTwo.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", ""));
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                }
                break;
            }
        }
    }
}