using System;

namespace WageLib
{
    /// <summary>
    /// Класс, описывающий 
    /// почасовую оплату труда
    /// </summary>
    public class PartTime : IWage
    {
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
            set => _shifts = (value < 0) ? throw new
                ArgumentOutOfRangeException("Число отработанных часов" +
                " не может быть отрицательным!")
                : _shifts = value;

        }

        /// <summary>
        /// Стоимость часа
        /// </summary>
        public double Salary
        {
            get => _salary;
            set => _salary = (value < 0) ? throw new
                ArgumentOutOfRangeException("Стоимость часа не может быть" +
                " отрицательной!") :
                _salary = value;
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

        #endregion
    }
}