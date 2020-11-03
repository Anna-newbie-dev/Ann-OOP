using System;

namespace WageLib
{
    /// <summary>
    /// Оплата труда по
    /// окладу и ставке
    /// </summary>
    public class FullTime : IWage
    {

        #region Constants

        private const int MAXSHIFTS = 8600;
        private const int MAXSALARY = 25000;
        private const int MAXRATE = 15000;

        #endregion

        #region Fields
        /// <summary>
        /// Отработанные часы
        /// </summary>
        private double _shifts;

        /// <summary>
        /// Оклад
        /// </summary>
        private double _salary;

        /// <summary>
        /// Ставка
        /// </summary>
        private double _rate;

        #endregion

        #region Properties

        /// <summary>
        /// Отработанные часы
        /// </summary>
        public double Shifts
        {
            get => _shifts;
            set =>
                _shifts = Checker.AutoPropertyCheck(value, MAXSHIFTS, "Количество часов");
        }

        /// <summary>
        /// Оклад
        /// </summary>
        public double Salary
        {
            get => _salary;
            set =>
                _salary = Checker.AutoPropertyCheck(value, MAXSALARY, "Ставка");
        }

        /// <summary>
        /// Ставка
        /// </summary>
        public double Rate
        {
            get => _rate;
            set => _rate = Checker.AutoPropertyCheck(value, MAXRATE, "Оклад");
        }
        #endregion

        #region Methods

        /// <summary>
        /// Calculates wage
        /// </summary>
        public double CalculateWage()
        {
            return Shifts * Rate + Salary;
        }

        #endregion
    }
}