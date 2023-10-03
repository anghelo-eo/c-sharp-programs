using System;
using System.Threading.Tasks;
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
            }
            else
            {
                var timeSpan = EndIntersection - StartIntersection;
                m = Convert.ToUInt32(timeSpan.TotalDays + 1);
            }

            uint n = 5;
            if(m >= 1)
            {
                Console.WriteLine($"It is not possible to calculate Acker({n}, {m})");
                Execute();
            }

            if(m == 0)
            {
                Console.WriteLine($"Acker({n}, {m})");
                Console.WriteLine("If the calculation takes longer than 3 seconds, the program will return to the main menu.");
                Task t = Task.Run( () => {
                    uint result = Ackermann.Acker(n, m);
                    Console.WriteLine($"The result of the Ackermann function = {result}");
                    } );
                if (! t.Wait(3000))
                {
                    Console.WriteLine("The time is up.");
                    Menu.Execute();
                    //Environment.Exit(0);
                }
            }
        }
    }
}