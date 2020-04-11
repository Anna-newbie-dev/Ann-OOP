using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Text;
using WageLib;

namespace Lab_3
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        static void Main()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Что будем рассчитывать?");
                Console.WriteLine("1 - PartTime; 2 - FullTime; 0 -exit.");
                var option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        PartTime partTime = new PartTime();
                        Console.Write("Введите отработанное количество" +
                            " часов: ");
                        partTime.Shifts = int.Parse(Console.ReadLine());
                        Console.Write("Стоимость часа: ");
                        partTime.Salary = int.Parse(Console.ReadLine());
                        Console.WriteLine("Получилось: {0}",
                            partTime.CalculateWage());
                        break;
                    case 2:
                        FullTime fullTime = new FullTime();
                        Console.Write("Введите отработанное количество" +
                            " часов из производственного календаря: ");
                        fullTime.Shifts = int.Parse(Console.ReadLine());
                        Console.Write("Оклад: ");
                        fullTime.Salary = int.Parse(Console.ReadLine());
                        Console.Write("Cтавка: ");
                        fullTime.Rate = int.Parse(Console.ReadLine());
                        Console.WriteLine("Получилось: {0}",
                            fullTime.CalculateWage());
                        break;
                    case 0:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("???");
                        break;
                }
            }
            Console.WriteLine("Все, пока! Нажмите любую кнопку.");
            Console.ReadKey();
        }
    }
}
