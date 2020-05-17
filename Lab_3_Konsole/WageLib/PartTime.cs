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

        public int MAXSHIFTS = 500;
        public int MAXSALARY = 3500;

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

        #endregion
    }
}