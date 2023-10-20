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
                Console.WriteLine("WARNINIG: The program checks the strings in the following order:\n");
                Console.WriteLine("1)comparation without register and spaces");
                Console.WriteLine("2)symbolic comparation");
                Console.WriteLine("3)whether the first string is the reverse of the second");
                Console.WriteLine("4)whether the string is an email address or a phone number or an IP adress\n");
                Console.WriteLine("If one check has generated an exception, the following checks are not executed!\n");
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

                try
                {
                    Console.WriteLine("Checks case insensitively, double spaces and spaces at the beginning and end of a line.");
                    CmpWithoutReg.ComparWReg(sOne.Replace("  ", ""), sTwo.Replace("  ", ""), sOneLen, sTwoLen);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception:{e.Message}");
                    break;
                }

                try
                {
                    Console.WriteLine("Check against the register.");
                    sComparator.Compar(sOne, sTwo, sOneLen, sTwoLen);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception:{e.Message}");
                    break;
                }

                try
                {
                    Palindrome.Palind(sOne.ToLower().Replace(" ", ""), sTwo.ToLower().Replace(" ", ""));
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception:{e.Message}");
                    break;
                }
                
                try
                {
                    Recognizer.analiysis(sOne.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", ""));
                    Recognizer.analiysis(sTwo.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", ""));
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception:{e.Message}");
                    break;
                }
                
                break;
            }
        }
    }
}