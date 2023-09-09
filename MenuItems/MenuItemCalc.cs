using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex01.MenuItems
{
    public class MenuItemCalc : MenuItemCore
    {
        public override string Title { get {return "Calc: Y + sqrt(X % Z)";} }

        public override void Execute()
        {
            Console.WriteLine("Calc: Y + sqrt(X % Z)");
            int Y = 0;
            Console.WriteLine("Enter Integer value of Y:");
            Y = IOUtils.SafeReadInteger(null);
            int X = 0;
            Console.WriteLine("Enter Integer value of X:");
            X = IOUtils.SafeReadInteger(null);
            int Z = 0;
            Console.WriteLine("Enter Integer value of Z:");
            Z = IOUtils.SafeReadInteger(null);
            if(X < 0 || Z <= 0)
            {
                Console.WriteLine("X or Z cannot be negative. Z cannot be 0.");
                Execute();
            }
            else
            {
                Console.WriteLine($"Calc: {Y} + sqrt({X} % {Z})");
                double preanswer = Y + Math.Sqrt(X % Z);
                double answer = Math.Round(preanswer, 3);
                Console.WriteLine($"Answer is: {answer}");
            }
            
        }
    }
}