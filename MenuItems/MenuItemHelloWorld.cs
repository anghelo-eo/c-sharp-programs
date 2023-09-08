using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex01.MenuItems
{
    public class MenuItemHelloWorld : MenuItemCore
    {
        //public override string Title { get {return "Привет, мир!";} }
        public override string Title { get {return "Hello world!";} }

        public override void Execute()
        {
            Console.WriteLine("Hello world!");
            //Console.WriteLine("Привет, мир!");
        }
    }
}