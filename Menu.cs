using Ex01.MenuItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex01
{
    public class Menu
    {
        private static List<MenuItemCore> MenuItems = new List<MenuItemCore>();
        public static void ClearItems()
        {
            Menu.MenuItems.Clear();
        }

        public static void AddItem(MenuItemCore  menuItem)
        {
            Menu.MenuItems.Add(menuItem);
        }

        public static void AddItem(string title, MenuItemDelegate.ExecuteHandler handler)
        {
            Menu.MenuItems.Add(new MenuItemDelegate(title, handler));
        }

        public static void Execute()
        {               
            ShowMenu();
            int iMenu = IOUtils.SafeReadInteger(null);// было - 1
            /*if (iMenu >= 0 && iMenu < Menu.MenuItems.Count)
            {
                Menu.MenuItems.ToArray()[iMenu].Execute();
            }

            else
            {
                Console.WriteLine("Menu item not found.");
                //Console.WriteLine("Пункт меню не найден.");
            }*/
            switch (iMenu)
            {
                case 0:
                    Menu.MenuItems.ToArray()[iMenu].Execute();
                    break;
                case 1:
                    Menu.MenuItems.ToArray()[iMenu].Execute();
                    break;
                case 2:
                    Menu.MenuItems.ToArray()[iMenu].Execute();
                    break;
                case 3:
                    Menu.MenuItems.ToArray()[iMenu].Execute();
                    break;
                case 4:
                    Menu.MenuItems.ToArray()[iMenu].Execute();
                    break;
                case 5:
                    Menu.MenuItems.ToArray()[iMenu].Execute();
                    break;
                default:
                    Console.WriteLine("Menu item not found.");
                    break;
            }
        }

        private static void ShowMenu()
        {
            
            Console.WriteLine("---MENU---");
            int iMenuItem = 0;
            foreach (MenuItemCore menuItem in Menu.MenuItems)
            {
                Console.WriteLine("[{0}] {1}", iMenuItem++, menuItem.Title);
            }
        }
    }
}
