using System;
using Ex01;
namespace Ex01.MenuItems
{
    public class MenuItemRecursionDate : MenuItemCore
    {
        public override string Title { get { return "Recursion date"; } }

        public override void Execute()
        {
            DateTime firstdate = IOUtils.SafeReadDate("Enter first date:");
            Console.WriteLine("Value is {0}.{1}.{2}", firstdate.Day, firstdate.Month, firstdate.Year);
            DateTime seconddate = IOUtils.SafeReadDate("Enter second date:");
            Console.WriteLine("Value is {0}.{1}.{2}", seconddate.Day, seconddate.Month, seconddate.Year);
        }
    }
}