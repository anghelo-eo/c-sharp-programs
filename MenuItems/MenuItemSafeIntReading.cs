using Ex01.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex01.MenuItems
{
    public class MenuItemSafeIntReading : MenuItemCore
    {
        public override string Title
        {
            get
            {
                return "Safe read int >= 0";
            }
        }

        public override void Execute()
        {
            Console.WriteLine("This is where I studied the anonymous fuction.5");
            int value = IOUtils.SafeReadInteger("Enter first int value:", new IsNotZero().And(new IsMoreThanZero()));
            Console.WriteLine("Value is {0}", value);

            value = IOUtils.SafeReadInteger("Enter second int value:", (int value) => 
            {
                if (value <= 0)
                {
                    throw new ValidationException("Value must be more than zero.");
                }
            });
            Console.WriteLine("Value is {0}", value);
        }

        private void Validate(int x)
        {
            if (x <= 0)
            {
                throw new ValidationException("Value must be more than zero.");
            }
        }
    }
}