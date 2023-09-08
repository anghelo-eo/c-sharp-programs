using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex01.MenuItems
{
    public class MenuItemExit : MenuItemCore
    {
        public override string Title { get {return "Exit";} }
        //public override string Title { get {return "Выход";} }

        public override void Execute()
        {
            Console.WriteLine("Exit...");
            //Console.WriteLine("Программа завершается...");
            Environment.Exit(0);
        }
    }
}