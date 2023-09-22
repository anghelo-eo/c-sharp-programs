using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex01.MenuItems
{
    public class MenuItemHelloWorld : MenuItemCore
    {
        //public override string Title { get {return "Hello world!";} }
        public static string HELLO_WORLD = "Hello world!";
        public string _HelloWorld = "Hello world!"; 
        //public override string Title { get {return "Привет, мир!";} }
        public override string Title {
            get 
            {
                if (_HelloWorld == null)
                {
                    _HelloWorld = HELLO_WORLD;
                }
                return _HelloWorld;
            }

             
        }

        public void setTitle(string value)
        {
            if (value == null)
            {
                _HelloWorld = HELLO_WORLD;
            }

            else
            {
                _HelloWorld = value;
            }
        }

        public override void Execute()
        {
            this.setTitle ("New Hello world!"); 
            Console.WriteLine("Hello world!");
            //Console.WriteLine("Привет, мир!");
        }
    }
}