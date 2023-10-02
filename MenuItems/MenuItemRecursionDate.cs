using System;
using Ex01;
namespace Ex01.MenuItems
{
    public class MenuItemRecursionDate : MenuItemCore
    {
        public override string Title { get { return "Recursion date"; } }

        public override void Execute()
        {
            uint m = 0;
            Console.WriteLine("You need to enter two time periods (dd.MM.yyyy).");
            DateTime DateOneStart = IOUtils.SafeReadDate("Enter the start of date range number 1:");
            Console.WriteLine("Value is {0}.{1}.{2}", DateOneStart.Day, DateOneStart.Month, DateOneStart.Year);
            DateTime DateOneEnd = IOUtils.SafeReadDate("Enter the end of date range number 1:");
            Console.WriteLine("Value is {0}.{1}.{2}", DateOneEnd.Day, DateOneEnd.Month, DateOneEnd.Year);
            if (DateOneStart > DateOneEnd)
            {
                Console.WriteLine("ERROR: the beginning of the interval is greater than the end.");
                Execute();
            }
            DateTime DateTwoStart = IOUtils.SafeReadDate("Enter the start of date range number 2:");
            Console.WriteLine("Value is {0}.{1}.{2}", DateTwoStart.Day, DateTwoStart.Month, DateTwoStart.Year);
            DateTime DateTwoEnd = IOUtils.SafeReadDate("Enter the end of date range number 2:");
            Console.WriteLine("Value is {0}.{1}.{2}", DateTwoEnd.Day, DateTwoEnd.Month, DateTwoEnd.Year);
            if (DateTwoStart > DateTwoEnd)
            {
                Console.WriteLine("ERROR: the beginning of the interval is greater than the end.");
                Execute();
            }
            var StartIntersection = DateOneStart > DateTwoStart ? DateOneStart : DateTwoStart;
            var EndIntersection = DateOneEnd < DateTwoEnd ? DateOneEnd : DateTwoEnd;
            if (StartIntersection > EndIntersection)
            {
                m = 0;
                Console.WriteLine($"m = {m}");
            }
            else
            {
                var timeSpan = EndIntersection - StartIntersection;
                m = Convert.ToUInt32(timeSpan.TotalDays + 1);
                Console.WriteLine($"m = {m}");
            }
            uint n = 5;
            uint res = Ackermann.Acker(n, m);
            Console.WriteLine($"res = {res}");
        }
    }
}