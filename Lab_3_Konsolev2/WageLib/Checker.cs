using System;
using System.Collections.Generic;
using System.Text;

namespace WageLib
{
    public class Checker
    {
        /// <summary>
        /// Проверка записываемого в
        /// поле класса значения
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
    }
}
