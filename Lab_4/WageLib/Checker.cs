using System;
using System.Collections.Generic;
using System.Text;

namespace WageLib
{
    /// <summary>
    /// Класс, содержащий проверку
    /// бизнес-логики
    /// </summary>
    public static class Checker
    {
        /// <summary>
        /// Проверка записываемого в
        /// поле класса значения на предмет
        /// соответсвия бизнес-логике
        /// </summary>
        /// <param name="param">value to check</param>
        /// <param name="constant">Ограничение логики</param>
        /// <returns>Проверенное значение</returns>
        public static double AutoPropertyCheck(double param, int constant, string field)
        {
            if (param <= 0)
            {
                throw new Exception
                    ($"{field} не может быть отрицательным" +
                    " или равным 0!");
            }
            else if (param > constant)
            {
                throw new Exception
                    (field  + $" не может превышать {constant}");
            }
            else
                return param;
        }
    }
}