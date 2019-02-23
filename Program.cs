using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molodoy
{
    class Program
    {
        static void Main()
        /*Даны даты рождения 5 человек. Вывести даты рождения самого младшего из них. 
    Напишите функцию для сравнения двух дат для решения этой задачи.
        
    Начальные данные: 5 строчек по 3 числа на каждой - день, месяц и год рождения (через пробел)
    Вывод результата: 3 числа - дата рождения самого младшего - день, месяц и год.*/
        {

            DateTime younger;
            younger = InputDate();
            younger = YoungerDate(younger, InputDate());
            younger = YoungerDate(younger, InputDate());
            younger = YoungerDate(younger, InputDate());
            younger = YoungerDate(younger, InputDate());
            Console.WriteLine("{0} {1} {2}", younger.Day, younger.Month, younger.Year);
        }

        static DateTime InputDate()
        {
            string[] line = Console.ReadLine().Split();
            DateTime date = new DateTime(
                        int.Parse(line[2]),
                        int.Parse(line[1]),
                        int.Parse(line[0]));
            return date;
        }

        static DateTime YoungerDate(DateTime date1, DateTime date2)
        {
            return date1.CompareTo(date2) < 0 ? date2 : date1;

        }
    }
}
