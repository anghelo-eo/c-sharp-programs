using Ex01.Validation;
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
            Y = IOUtils.SafeReadInteger("Enter Integer value of Y:");
            int X = 0;
            X = IOUtils.SafeReadInteger("Enter Integer value of X:", new AndSpecification<int>(new IsNotZero(), new IsMoreThanZero()));
            int Z = 0;
            Z = IOUtils.SafeReadInteger("Enter Integer value of Z:", new AndSpecification<int>(new IsNotZero(), new IsMoreThanZero()));
            //if(X < 0 || Z <= 0)
            //{
                //Console.WriteLine("X or Z cannot be negative. Z cannot be 0.");
                //Execute();
            //}
            //else
            //{
            Console.WriteLine($"Calc: {Y} + sqrt({X} % {Z})");
            double preanswer = Y + Math.Sqrt(X % Z);
            string answer = string.Format("Answer is:{0: 0.000}",preanswer);
            Console.WriteLine(answer);
            //}
            
        }
    }
}