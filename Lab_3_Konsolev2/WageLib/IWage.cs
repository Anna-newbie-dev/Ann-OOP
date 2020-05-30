using System;
namespace WageLib
{
    /// <summary>
    /// Интерфейс, реализующий
    /// расчет заработной платы
    /// </summary>
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
        double Shifts { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Calculates wage
        /// </summary>
        double CalculateWage();

        /// <summary>
        /// Проверка данных
        /// при записи в поле класса
        /// </summary>
        double AutoPropertyCheck(double param, int constant);

        #endregion
    }
}
