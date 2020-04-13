namespace WageLib
{
    public interface IWage
    {
        #region Properties

        /// <summary>
        /// Стоимость часа
        /// </summary>
        double Salary { get; set; }

        /// <summary>
        /// Количество отработанных часов
        /// </summary>
        int Shifts { get; set; }

        #endregion

        #region Methods

		/// <summary>
		/// Calculates wage
		/// </summary>
        double CalculateWage();

        #endregion
    }
}
