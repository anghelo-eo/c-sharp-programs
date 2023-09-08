using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex01.MenuItems
{
    public class MenuItemCalc : MenuItemCore
    {
        //public override string Title { get {return "Привет, мир!";} }
        public override string Title { get {return "Calc: Y + sqrt(X % Z)";} }

        public override void Execute()
        {
            Console.WriteLine("Calc: Y + sqrt(X % Z)");
            Console.WriteLine("Enter Integer value of X:");
            int X = IOUtils.SafeReadInteger(null);
            Console.WriteLine("Enter Integer value of Z:");
            int Z = IOUtils.SafeReadInteger(null);
            Console.WriteLine("Enter Integer value of Y:");
            int Y = IOUtils.SafeReadInteger(null);
            if(X < 0 || Z < 0)
            {
                Console.WriteLine("X or Z cannot be negative.");
                Execute();
            }

            double preanswer = Y + Math.Sqrt(X % Z);
            double answer = Math.Round(preanswer, 3);
            Console.WriteLine($"Answer is: {answer}");
        }
    }
}