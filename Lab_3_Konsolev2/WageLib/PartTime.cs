using System;

namespace WageLib
{
    /// <summary>
    /// Класс, описывающий 
    /// почасовую оплату труда
    /// </summary>
    public class PartTime : IWage
    {
        #region Constants

        private int MAXSHIFTS = 500;
        private int MAXSALARY = 3500;

        #endregion

        #region Variables
        double temp = 0.0;
        #endregion

        #region Fields
        /// <summary>
        /// Отработанные часы
        /// </summary>
        private double _shifts;

        /// <summary>
        /// Стоимость часа
        /// </summary>
        private double _salary;

        #endregion

        #region Properties

        /// <summary>
        /// Отработанные часы
        /// </summary>
        public double Shifts
        {
            get => _shifts;
            set => _shifts = AutoPropertyCheck(value, MAXSHIFTS);

        }

        /// <summary>
        /// Стоимость часа
        /// </summary>
        public double Salary
        {
            get => _salary;
            set => _salary = AutoPropertyCheck(value, MAXSALARY);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Расчет оплаты труда
        /// по отработанным часам
        /// </summary>
        /// <returns>Итоговая оплата труда</returns>
        public double CalculateWage()
        {
            return Shifts * Salary;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param">value to check</param>
        /// <param name="constant">constant value
        /// to compare with</param>
        /// <returns>Checked property</returns>
        public double AutoPropertyCheck(double param, int constant)
        {
            if (param < 0)
            {
                throw new ArgumentOutOfRangeException
                    ("Параметр не может быть отрицательным!");
            }
            else if (param > constant)
            {
                throw new ArgumentOutOfRangeException
                    ("Параметр" +
                    $" не может превышать {constant}");
            }
            else
                return param;
        }

        /// <summary>
        /// Проверка поля требованиям
        /// бизнес-логики при вводе с клавиатуры
        /// </summary>
        /// <param name="bounds">флаг, показывающий
        /// какое поле необходимо проверить</param>
        /// <returns>Checked property</returns>
        public double DataInputAndCheck(Bounds bounds)
        {
            //TODO: СПРЯТАТЬ ПРОВЕРКУ БИЗНЕС-ЛОГИКИ(!)
            switch (bounds)
            {
                case Bounds.MAXSHIFTS:
                    temp = BoundsCheck(MAXSHIFTS);
                    break;
                case Bounds.MAXSALARY:
                    temp = BoundsCheck(MAXSALARY);
                    break;
            }
            return temp;
        }

        /// <summary>
        /// Проверка вводимого значения на нахождение
        /// в допустимом диапазоне
        /// </summary>
        /// <param name="constant">ограничение поля</param>
        /// <returns>Проверенное значение</returns>
        private double BoundsCheck(int constant)
        {
            while (true)
            {
                temp = InputCheck();

                if (temp >= 0 & temp <= constant)
                {
                    return temp;
                }
                else
                {
                    Console.WriteLine("Кажется, Вы вышли " +
                        "за границы допустимого диапазона. " +
                        $"Разрешен ввод не меньше 0 и не " +
                        $"больше {constant}. " +
                        "Повторите ввод параметра:");
                }
            } 
        }

        /// <summary>
        /// Проверка на возможность
        /// преобразования string в double
        /// </summary>
        /// <returns>Преобразованное
        /// число типа double</returns>
        private double InputCheck()
        {
            while(true)
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
        #endregion
    }
}