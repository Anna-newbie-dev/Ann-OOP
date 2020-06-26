using System;
using System.Collections.Generic;
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
                        ReadPartTime();
                        break;
                    case 2:
                        ReadFullTime();
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
            Console.WriteLine("Нажмите любую кнопку, чтобы выйти.");
            Console.ReadKey();
        }

        /// <summary>
        /// Exception handler
        /// </summary>
        private static int ExceptionHandler()
        {
            while (true)
            {
                try
                {
                    return int.Parse(Console.ReadLine()); 
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

        /// <summary>
        /// Проверка на возможность
        /// преобразования string в double
        /// </summary>
        /// <returns>Преобразованное
        /// число типа double</returns>
        private static double CheckInput()
        {
            while (true)
            {
                try
                {
                    return Math.Round(double.Parse(Console.ReadLine().
                          Replace('.', ',')));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Возможно, Вы ввели " +
                        "не численное значение. Повторите ввод.");
                }

            }
        }

        /// <summary>
        /// Получить пользовательский ввод и задать параметр
        /// </summary>
        /// <param name="action">Делегат с заданием параметра</param>
        public static void SetValue(Action action)
        {
            while (true)
            {
                try
                {
                    action.Invoke();
                    return;
                }
                catch (Exception e)
                {
                    if (e is FormatException 
                        || e is ArgumentOutOfRangeException)
                    {
                        TryAgain();
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Записывает данные в поля
        /// класса PartTime
        /// </summary>
        public static void ReadPartTime()
        {
            PartTime partTime = new PartTime();
            var partTimeActions = new List<Action>()
            {
                new Action( () =>
                {
                    Console.Write("Введите отработанное количество" +
                        " часов: ");
                    partTime.Shifts = CheckInput();
                }),
                new Action( () =>
                {
                    Console.Write("Введите стоимость часа: ");
                    partTime.Salary = CheckInput();;
                }),
            };
            partTimeActions.ForEach(SetValue);
            Console.WriteLine("Получилось: {0}",
                partTime.CalculateWage());
        }

        /// <summary>
        /// Записывает данные в поля
        /// класса FullTime
        /// </summary>
        public static void ReadFullTime()
        {
            FullTime fullTime = new FullTime();
            var fullTimeActions = new List<Action>()
            {
                new Action( () =>
                {
                    Console.Write("Введите отработанное количество" +
                        " часов из производственного календаря: ");
                    fullTime.Shifts = CheckInput();
                }),
                new Action( () =>
                {
                    Console.Write("Введите оклад: ");
                    fullTime.Salary = CheckInput();;
                }),
                new Action( () =>
                {
                    Console.Write("Введите ставку: ");
                    fullTime.Rate = CheckInput();;
                }),
            };
            fullTimeActions.ForEach(SetValue);
            Console.WriteLine("Получилось: {0}",
                fullTime.CalculateWage());
        }

        /// <summary>
        /// Shows a message
        /// to try input again
        /// </summary>
        public static void TryAgain()
        {
            Console.WriteLine("Повторите ввод.");
        }

    }
}
