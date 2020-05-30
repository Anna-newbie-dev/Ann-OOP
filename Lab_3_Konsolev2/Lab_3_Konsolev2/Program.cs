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
                switch (ExceptionHandler())
                {
                    case 1:
                        PartTime partTime = new PartTime();
                        Console.Write("Введите отработанное количество" +
                            " часов: ");
                        // создано перечисление констант, которые 
                        // передаются в метод проверки
                        // и указывают методу, какое именно поле 
                        // мы заполняем
                        partTime.Shifts = partTime.DataInputAndCheck
                            (Bounds.MAXSHIFTS);
                        Console.Write("Стоимость часа: ");
                        partTime.Salary = partTime.DataInputAndCheck
                            (Bounds.MAXSALARY);
                        Console.WriteLine("Получилось: {0}",
                            partTime.CalculateWage());
                        break;
                    case 2:
                        FullTime fullTime = new FullTime();
                        Console.Write("Введите отработанное количество" +
                            " часов из производственного календаря: ");
                        fullTime.Shifts = fullTime.DataInputAndCheck
                            (Bounds.MAXSHIFTS);
                        Console.Write("Введите оклад:");
                        fullTime.Salary = fullTime.DataInputAndCheck
                            (Bounds.MAXSALARY);
                        Console.Write("Cтавка: ");
                        fullTime.Rate = fullTime.DataInputAndCheck
                            (Bounds.MAXRATE);
                        Console.WriteLine("Получилось: {0}",
                            fullTime.CalculateWage());
                        break;
                    case 0:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Неожиданный ввод. " +
                            "Повторите попытку:");
                        break;
                }
            }
            Console.WriteLine("Все, пока! Нажмите любую кнопку.");
            
            Console.ReadKey();
        }

        /// <summary>
        /// Exception handler
        /// </summary>
        private static int ExceptionHandler()
        {
            int option = 0;
            while (true)
            {
                try
                {
                    option = int.Parse(Console.ReadLine());
                    return option;
                }
                catch (FormatException)
                {
                    WrongFormatMessage();
                }
            }
        }

        /// <summary>
        /// Displays a message
        /// to try input again
        /// </summary>
        private static void WrongFormatMessage()
        {
            Console.WriteLine("Неверный формат ввода. Повторите ввод.");
            Console.WriteLine("Что будем рассчитывать?");
            Console.WriteLine("1 - PartTime; 2 - FullTime; 0 -exit.");
        }
        

    }
}
