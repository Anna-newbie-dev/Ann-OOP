using System;
using System.Collections.Generic;
using System.Text;

namespace WageLib
{
    public class FullTime : IWage
    {
        #region Fields
        /// <summary>
        /// Отработанные часы
        /// </summary>
        private int _shifts;

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
        public int Shifts
        {
            get => _shifts;
            set => _shifts = (value < 0) ? throw new
                ArgumentOutOfRangeException("Число отработанных часов" +
                " из производственного календаря" +
                " не может быть отрицательным!")
                : _shifts = value;
        }

        /// <summary>
        /// Оклад
        /// </summary>
        public double Salary
        {
            get => _salary;
            set => _salary = (value < 0) ? throw new
                ArgumentOutOfRangeException("Оклад не может быть" +
                " отрицательным!") :
                _salary = value;
        }

        /// <summary>
        /// Ставка
        /// </summary>
        public double Rate
        {
            get => _rate;
            set => _rate = (value < 0) ? throw new
                ArgumentOutOfRangeException("Ставка не может быть" +
                " отрицательной!") :
                _rate = value;
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
