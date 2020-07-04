using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonsLib;

namespace Lab_4
{
    /// <summary>
    /// Главная точка входа для приложения.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Запуск основной формы
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(mainForm: new WageForm());

            

        }
    }
}
