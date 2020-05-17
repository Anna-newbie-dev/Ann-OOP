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

        public int MAXSHIFTS = 8600;
        public int MAXSALARY = 25000;
        public int MAXRATE = 15000;

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
                _shifts = AutoPropertyCheck(value, MAXSHIFTS);
        }

        /// <summary>
        /// Оклад
        /// </summary>
        public double Salary
        {
            get => _salary;
            set =>
                _salary = AutoPropertyCheck(value, MAXSALARY);
        }

        /// <summary>
        /// Ставка
        /// </summary>
        public double Rate
        {
            get => _rate;
            set => _rate = AutoPropertyCheck(value, MAXRATE);
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