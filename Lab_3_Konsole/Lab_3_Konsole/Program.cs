using System;
using WageLib;

namespace Lab_3
{
    /// <summary>
    /// Main program
    /// </summary>
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
                        partTime.Shifts = ExceptionHandler
                            (partTime.MAXSHIFTS);
                        Console.Write("Стоимость часа: ");
                        partTime.Salary = ExceptionHandler
                            (partTime.MAXSALARY);
                        Console.WriteLine("Получилось: {0}",
                            partTime.CalculateWage());
                        break;
                    case 2:
                        FullTime fullTime = new FullTime();
                        Console.Write("Введите отработанное количество" +
                            " часов из производственного календаря: ");
                        fullTime.Shifts = ExceptionHandler
                            (fullTime.MAXSHIFTS);
                        Console.Write("Оклад: ");
                        fullTime.Salary = ExceptionHandler
                            (fullTime.MAXSALARY);
                        Console.Write("Cтавка: ");
                        fullTime.Rate = ExceptionHandler
                            (fullTime.MAXRATE);
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

        /// <summary>
        /// Проверка на корректность ввода
        /// </summary>
        /// <param name="input">строка для проверки</param>
        /// <returns>Число</returns>
        static double ExceptionHandler(int constant)
        {
            var temp = 0.0;
            while (true)
            {
                try
                {
                    temp = Math.Round(double.Parse(Console.ReadLine().
                        Replace('.', ',')));
                    if (temp >= 0 & temp <= constant)
                    {
                        return temp;
                    }
                    else
                    {
                        Console.WriteLine("Кажется, Вы вышли " +
                            "за границы допустимого диапазона. " +
                            "Повторите ввод.");  
                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine("Возможно, Вы ввели " +
                        "не численное значение. Повторите ввод.");
                }
            }
        }

    }
}
