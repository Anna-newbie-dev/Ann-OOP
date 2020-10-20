using System;
using System.Collections.Generic;
using System.Text;

namespace WageLib
{
    /// <summary>
    /// Класс, содержащий проверку
    /// бизнес-логики
    /// </summary>
    public class Checker
    {
        /// <summary>
        /// Проверка записываемого в
        /// поле класса значения на предмет
        /// соответсвия бизнес-логике
        /// </summary>
        /// <param name="param">value to check</param>
        /// <param name="constant">Ограничение логики</param>
        /// <returns>Проверенное значение</returns>
        public double AutoPropertyCheck(double param, int constant)
        {
            if (param <= 0)
            {
                throw new Exception
                    ("Параметр не может быть отрицательным" +
                    " или равным 0!");
            }
            else if (param > constant)
            {
                throw new Exception
                    ("Параметр" +
                    $" не может превышать {constant}");
            }
            else
                return param;
        }

    }
}