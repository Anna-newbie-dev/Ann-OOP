namespace WageLib
{
    /// <summary>
    /// Класс, описывающий 
    /// почасовую оплату труда
    /// </summary>
    public class PartTime : IWage
    {
        #region Constants

		private const int MAXSHIFTS = 500;
        private const int MAXSALARY = 3500;

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
            set => _shifts = Checker.AutoPropertyCheck(value, MAXSHIFTS, "Количество часов");

        }

        /// <summary>
        /// Стоимость часа
        /// </summary>
        public double Salary
        {
            get => _salary;
            set => _salary = Checker.AutoPropertyCheck(value, MAXSALARY, "Стоимость часа");
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