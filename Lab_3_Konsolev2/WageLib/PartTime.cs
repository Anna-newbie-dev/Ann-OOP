namespace WageLib
{
    /// <summary>
    /// Класс, описывающий 
    /// почасовую оплату труда
    /// </summary>
    public class PartTime : IWage
    {
        private Checker checker = new Checker();   
        
        #region Constants

        private int MAXSHIFTS = 500;
        private int MAXSALARY = 3500;

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
            set => _shifts = checker.AutoPropertyCheck(value, MAXSHIFTS);

        }

        /// <summary>
        /// Стоимость часа
        /// </summary>
        public double Salary
        {
            get => _salary;
            set => _salary = checker.AutoPropertyCheck(value, MAXSALARY);
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