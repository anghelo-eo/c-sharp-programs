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
            Console.Write("Enter the first string with fewer than 20 characters:");
            string? stringone = Console.ReadLine();
            Console.WriteLine($"String is {stringone}");
            Console.Write("Enter the second string with fewer than 20 characters:");
            string? stringtwo = Console.ReadLine();
            Console.WriteLine($"String is {stringtwo}");
        }
    }
}