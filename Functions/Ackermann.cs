using Ex01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex01.MenuItems
{
    public class Ackermann : MenuItemRecursionDate
    {
        public static uint Acker(uint n, uint m)
        {
            if (n == 0)
            {
                return m + 1;
            }

            else
            {
                if ((n != 0) && (m == 0))
                {
                    return Acker(n - 1, 1);
                }
                
                else
                {
                    return Acker(n - 1, Acker(n, m - 1));
                }
            }
        }
    }
}