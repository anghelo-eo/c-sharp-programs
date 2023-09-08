using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex01
{
    public static class IOUtils
    {
        public static int SafeReadInteger(string message)
        {
            if(!string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
            while(true)
            {
                string sValue = Console.ReadLine();
                int iValue = 0;
                if(Int32.TryParse(sValue, out iValue))
                {
                    return iValue;
                }
                //Console.WriteLine("Ошибка ввода. Введите целое число.");
                Console.WriteLine("ERROR: Incorrect format. Enter Integer value...");
            }
        }
    }
}
