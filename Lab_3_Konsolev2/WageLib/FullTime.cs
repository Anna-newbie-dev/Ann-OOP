using System;

namespace WageLib
{
    /// <summary>
    /// Оплата труда по
    /// окладу и ставке
    /// </summary>
    public class FullTime : IWage
    {
        private Checker checker = new Checker();
        #region Constants

        private int MAXSHIFTS = 8600;
        private int MAXSALARY = 25000;
        private int MAXRATE = 15000;

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
                _shifts = checker.AutoPropertyCheck(value, MAXSHIFTS);
        }

        /// <summary>
        /// Оклад
        /// </summary>
        public double Salary
        {
            get => _salary;
            set =>
                _salary = checker.AutoPropertyCheck(value, MAXSALARY);
        }

        /// <summary>
        /// Ставка
        /// </summary>
        public double Rate
        {
            get => _rate;
            set => _rate = checker.AutoPropertyCheck(value, MAXRATE);
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