using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using WageLib;
using PersonsLib;

namespace Lab_4
{
    /// <summary>
    /// Основная форма приложения
    /// </summary>
    public partial class WageForm : Form
    {
        DataTable dt = new DataTable();
        Person newPerson = new Person();

        /// <summary>
        /// Инициализация основной формы
        /// </summary>
        public WageForm()
        {           
            InitializeComponent();   
        }

        /// <summary>
        /// Изменяет главную форму
        /// при выборе почасовой
        /// оплаты труда
        /// </summary>
        private void partTime_CheckedChanged(object sender, EventArgs e)
        {
            labelWage.Text = "Стоимость часа";
            salaryBox.Visible = false;
            labelSalary.Visible = false;
        }

        /// <summary>
        /// Изменяет главную форму
        /// при выборе оплаты труда
        /// по окладу и ставке
        /// </summary>
        private void fullTimeRadioButton_CheckedChanged
            (object sender, EventArgs e)
        {
            labelWage.Text = "Ставка";
            salaryBox.Visible = true;
            labelSalary.Visible = true;
        }

        /// <summary>
        /// Расчет причитающейся суммы
        /// и отображение данных в списке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCount_Click(object sender, EventArgs e)
        {
            newPerson = ReadPerson();

            if (fullTimeRadioButton.Checked)
            {
                ReadAndCountFullTime();
            }
            else if (partTimeRadioButton.Checked)
            {
                ReadAndCountPartTime();
            }
            else 
            {
                MessageBox.Show("Выберите систему оплаты!");
                return;
            }
            
            dt.Columns["№"].AutoIncrement = true;
            dt.Columns["№"].AutoIncrementSeed = 1;
            dt.Columns["№"].AutoIncrementStep = 1;
            dt.Rows.Add(
                null,
                newPerson.LastName,
                newPerson.FirstName,
                newPerson.Patronymic,
                null,
                totalBox.Text);
        }

        /// <summary>
        /// Загрузка основной формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WageForm_Load(object sender, EventArgs e)
        {
            dt.Columns.AddRange(new DataColumn[6]
                {
                new DataColumn("№"),
                new DataColumn("Фамилия"), new DataColumn("Имя"),
                new DataColumn("Отчество"), new DataColumn("Код"),
                new DataColumn("Сумма к выплате")
                });
            dataGridView.DataSource = dt;
        }

        #region Валидация данных

        /// <summary>
        /// Проверка на корректность ввода
        /// </summary>
        /// <param name="input">строка для проверки</param>
        /// <returns>число</returns>
        private static double CheckInput(string input)
        {
            try
            {
                return Math.Round(double.Parse(input.
                          Replace('.', ',')));
            }

            catch (FormatException)
            {
                MessageBox.Show("Возможно, Вы ввели не " +
                    "численное значение. Перепроверьте ввод" +
                    "и рассчитайте заново.");
            }

            catch (Exception e)
            {
                if (e is FormatException
                    || e is ArgumentOutOfRangeException)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return 0;
        }

        /// <summary>
        /// Получить пользовательский ввод и задать параметр
        /// </summary>
        /// <param name="action">Делегат с заданием параметра</param>
        private static void SetValue(Action action)
        {
            try
            {
                action.Invoke();
                return;
            }
            catch (Exception e)
            {
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        /// <summary>
        /// Записывает данные в поля
        /// класса PartTime
        /// </summary>
        private void ReadAndCountPartTime()
        {
            PartTime partTime = new PartTime();
            var partTimeActions = new List<Action>()
            {
                new Action( () =>
                {
                    partTime.Shifts = CheckInput(hoursBox.Text);
                }),
                new Action( () =>
                {
                    partTime.Salary = CheckInput(rateBox.Text);
                }),
            };
            partTimeActions.ForEach(SetValue);
            totalBox.Text = partTime.CalculateWage().ToString();
        }

        /// <summary>
        /// Записывает данные в поля
        /// класса FullTime
        /// </summary>
        private void ReadAndCountFullTime()
        {
            FullTime fullTime = new FullTime();
            var fullTimeActions = new List<Action>()
            {
                new Action( () =>
                {
                    fullTime.Shifts = CheckInput(hoursBox.Text);
                }),
                new Action( () =>
                {
                    fullTime.Salary = CheckInput(rateBox.Text);
                }),
                new Action( () =>
                {
                    fullTime.Rate = CheckInput(salaryBox.Text);
                }),
            };
            fullTimeActions.ForEach(SetValue);
            totalBox.Text = fullTime.CalculateWage().ToString();
        }

        /// <summary>
        /// Записывает данные в поля
        /// класса Person
        /// </summary>
        private Person ReadPerson()
        {
            Person newPerson = new Person();
            var newPersonActions = new List<Action>()
            {
                new Action( () =>
                {
                    newPerson.FirstName = firstNameBox.Text;
                }),
                new Action( () =>
                {
                    newPerson.LastName =lastNameBox.Text;
                }),
                new Action( () =>
                {
                    newPerson.Patronymic = patroBox.Text;
                }),
            };
            newPersonActions.ForEach(SetValue);
            return newPerson;
        }

        #endregion

        /// <summary>
        /// Очистка всех TextBox на форме
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearInput_Button_Click(object sender, EventArgs e)
        {
            CleanAllTextBoxesIn(this); 
        }

        /// <summary>
        /// Очистка всех текстовых полей
        /// </summary>
        /// <param name="parent"></param>
        private static void CleanAllTextBoxesIn(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                    c.Text = string.Empty;

                if (c.GetType() == typeof(GroupBox))
                    CleanAllTextBoxesIn(c);
            }
        }

        /// <summary>
        /// Сохранение таблицы
        /// в файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveFileButton_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDocuments);
            saveFileDialog.InitialDirectory = path;
            saveFileDialog.Filter = "Wage report files(*.wg) | *.wg";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var formatter = new BinaryFormatter();
                var fileSave = saveFileDialog.FileName;
                using (var fileStream = new FileStream(
                    fileSave, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fileStream, dt);
                    MessageBox.Show("File is saved successfully!");
                }
            }
        }

        /// <summary>
        /// Очистка таблицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearReportButton_Click(object sender, EventArgs e)
        {
            dt.Clear();
        }

        /// <summary>
        /// Загрузка отчета из файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadReportButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
