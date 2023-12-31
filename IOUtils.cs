using Ex01.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex01
{
    public static class IOUtils
    {
        public delegate void ValidationHandler(int value);

        public static int SafeReadInteger(string message, ISpecification<int> specification = null)
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
                    try
                    {
                        if (specification != null)
                        {
                            specification.Validate(iValue);
                        }
                        return iValue;
                    }

                    catch (ValidationException ex)
                    {
                        Console.WriteLine("ERROR: " + ex.Message);
                    }
                }

                else
                {
                    //Console.WriteLine("Ошибка ввода. Введите целое число.");
                    Console.WriteLine("ERROR: Incorrect format. Enter Integer value...");
                }
            }
        }

        public static int SafeReadInteger(string message, ValidationHandler valdator)
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
                    try
                    {
                        if (valdator != null)
                        {
                            valdator(iValue);
                        }
                        return iValue;
                    }

                    catch (ValidationException ex)
                    {
                        Console.WriteLine("ERROR: " + ex.Message);
                    }
                }

                else
                {
                    //Console.WriteLine("Ошибка ввода. Введите целое число.");
                    Console.WriteLine("ERROR: Incorrect format. Enter Integer value...");
                }
            }
        }

        public static DateTime SafeReadDate(string message)
        {
            if(!string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
            while(true)
            {
                string sValue = Console.ReadLine();
                DateTime date;
                if (DateTime.TryParseExact(sValue, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date))
                {
                    return date;
                }
                //Console.WriteLine("Ошибка ввода. Введите дату и время корректно...");
                Console.WriteLine("ERROR: Incorrect format. Enter correct date time...");
            }
        }

        public static string SafeReadString(string message)
        {
            if(!string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
            while(true)
            {
                string tmpStr = Console.ReadLine();
                int tmpStrLen = tmpStr.Length;
                if (tmpStrLen > 100)
                {
                    Console.WriteLine("ERROR: The entered string is longer than 100 characters.");
                }
                else
                {
                    return tmpStr;
                }  
            }
        }
    }
}
