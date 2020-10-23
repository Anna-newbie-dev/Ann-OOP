﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using WageLib;
using PersonsLib;
using System.ComponentModel;


namespace Lab_4
{
    /// <summary>
    /// Форма ввода данных
    /// </summary>
    public partial class DataInput : Form
    {
        
        WageForm wageForm;

        Person newPerson = new Person();

        public PartTime partTime = new PartTime();
        public FullTime fullTime = new FullTime();

        private readonly List<MaskedTextBox> _partTimeTextBox;

        private readonly List<MaskedTextBox> _fullTimeTextBox;

        /// <summary>
        /// Форма ввода данных
        /// </summary>
        public DataInput()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(900, 700);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            _partTimeTextBox = new List<MaskedTextBox>
            {
                LastNameBox, FirstNameBox, PatroBox, HoursBox, RateBox
            };

            _fullTimeTextBox = new List<MaskedTextBox>
            {
                LastNameBox, FirstNameBox, PatroBox, HoursBox, RateBox, SalaryBox
            };
        }

        /// <summary>
        /// События при загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataInput_Load(object sender, EventArgs e)
        {
            PartTimeRadioButton.Checked = true;
            ButtonCount.Enabled = false;
        }
      
        #region Валидация данных
                
        /// <summary>
        /// Проверка вводимых полей
        /// при помощи ErrorProvider
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="e"></param>
        private bool TextBoxValidatingWithErrorProvider
            (MaskedTextBox textBox)
        {
            var FieldIsOk = false;

            CancelEventArgs e = new CancelEventArgs();
            if (string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider1.SetError(textBox, "Строка не может " +
                    "быть пустой!");
                FieldIsOk = false;
                e.Cancel = true;
                return FieldIsOk;
            }
            else
            {
                errorProvider1.SetError(textBox, string.Empty);
                FieldIsOk = true;
                return FieldIsOk;
            }
        }

        /// <summary>
        /// Проверка на возможность преобразования
        /// вводимого параметра в число
        /// </summary>
        /// <param name="input">Строка для проверки</param>
        /// <returns>Преобразованное из строки число</returns>
        private double CheckInput(string input)
        {
            try
            {
                return Math.Round(double.Parse(input.
                          Replace('.', ',')));
            }
            catch (FormatException)
            {
                throw new FormatException("Возможно, Вы ввели не " +
                    "численное значение. Перепроверьте ввод.");
            }
        }

        #endregion

        #region Запись данных

        /// <summary>
        /// Добавление полей в таблицу на главной форме
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void AddToListButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        outputListBox.Items.Clear();
        //        //list.AddPerson(ReadPerson());
        //        newPerson = ReadPerson();
        //        ((WageForm)this.Tag).dataTable.Rows.Add(
        //        null,
        //        newPerson.LastName,
        //        newPerson.FirstName,
        //        newPerson.LastName,
        //        TotalBox.Text
        //        );
        //    }
        //    catch (Exception exp)
        //    {
        //        outputListBox.Items.Add(exp.Message);
        //        return;
        //    }
        //}

        /// <summary>
        /// Расчет и отображение причитающейся суммы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCount_Click(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();

            try
            {
                outputListBox.Items.Clear();
                newPerson = ReadPerson();

                if (FullTimeRadioButton.Checked)
                {
                    ReadAndCountFullTime();
                }
                else if (PartTimeRadioButton.Checked)
                {
                    ReadAndCountPartTime();
                }

                ((WageForm)this.Tag).dataTable.Rows.Add(
                null,
                newPerson.LastName,
                newPerson.FirstName,
                newPerson.LastName,
                TotalBox.Text
                );
            }
            catch (Exception exp)
            {
                outputListBox.Items.Add(exp.Message);
                return;
            }
        }

        /// <summary>
        /// Получить пользовательский ввод и задать параметр
        /// </summary>
        /// <param name="action">Делегат с заданием параметра</param>
        private void SetValue(Action action)
        {
            try
            {
                action.Invoke();
                return;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Записывает данные в поля
        /// класса PartTime
        /// </summary>
        public void ReadAndCountPartTime()
        {
            PartTime partTime = new PartTime();
            var partTimeActions = new List<Action>()
            {
                new Action( () =>
                {
                    partTime.Shifts = CheckInput(HoursBox.Text);
                }),
                new Action( () =>
                {
                    partTime.Salary = CheckInput(RateBox.Text);
                }),
            };
            partTimeActions.ForEach(SetValue);
            TotalBox.Text = partTime.CalculateWage().ToString();
        }

        /// <summary>
        /// Записывает данные в поля
        /// класса FullTime
        /// </summary>
        public void ReadAndCountFullTime()
        {
            FullTime fullTime = new FullTime();
            var fullTimeActions = new List<Action>()
            {
                new Action( () =>
                {
                    fullTime.Shifts = CheckInput(HoursBox.Text);
                }),
                new Action( () =>
                {
                    fullTime.Salary = CheckInput(RateBox.Text);
                }),
                new Action( () =>
                {
                    fullTime.Rate = CheckInput(SalaryBox.Text);
                }),
            };
            fullTimeActions.ForEach(SetValue);
            TotalBox.Text = fullTime.CalculateWage().ToString();
        }

        /// <summary>
        /// Записывает данные в поля
        /// класса Person
        /// </summary>
        public Person ReadPerson()
        {
            Person newPerson = new Person();
            var newPersonActions = new List<Action>()
            {
                new Action( () =>
                {
                    newPerson.FirstName = FirstNameBox.Text;
                }),
                new Action( () =>
                {
                    newPerson.LastName = LastNameBox.Text;
                }),
                new Action( () =>
                {
                    newPerson.Patronymic = PatroBox.Text;
                }),
            };
            newPersonActions.ForEach(SetValue);
            return newPerson;
        }

        #endregion

        #region Всякая обработка с красотой
         /// <summary>
        /// Проверка поля Фамилия
        /// по мере ввода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LastNameBox_Validating(object sender, CancelEventArgs e)
        {
            AllFieldsOk();
        }

        /// <summary>
        /// Проверка поля Имя
        /// по мере ввода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FirstNameBox_Validating(object sender, CancelEventArgs e)
        {
            AllFieldsOk();
        }

        /// <summary>
        /// Проверка поля Отчество
        /// по мере ввода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PatroBox_Validating(object sender, CancelEventArgs e)
        {
            AllFieldsOk();
        }

        private void HoursBox_Validating(object sender, CancelEventArgs e)
        {
            AllFieldsOk();
        }

        private void RateBox_Validating(object sender, CancelEventArgs e)
        {
            AllFieldsOk();
        }

        private void SalaryBox_Validating(object sender, CancelEventArgs e)
        {
            AllFieldsOk();
        }

        /// <summary>
        /// Игнорирование пробелов
        /// при вводе текста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LastNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            IgnoreSpaces(e);
        }

        private void FirstNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            IgnoreSpaces(e);
        }

        private void PatroBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            IgnoreSpaces(e);
        }

        private void HoursBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            IgnoreSpaces(e);
        }

        private void RateBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            IgnoreSpaces(e);
        }

        private void SalaryBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            IgnoreSpaces(e);
        }

        /// <summary>
        /// Игнорирование пробелов
        /// </summary>
        /// <param name="e"></param>
        private void IgnoreSpaces(KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') e.KeyChar = (char)0;
        }

        private void LastNameBox_Enter(object sender, EventArgs e)
        {
            MoveCursorToTheStartPos(LastNameBox);
        }

        private void FirstNameBox_Enter(object sender, EventArgs e)
        {
            MoveCursorToTheStartPos(FirstNameBox);
        }

        private void PatroBox_Enter(object sender, EventArgs e)
        {
            MoveCursorToTheStartPos(PatroBox);
        }

        private void HoursBox_Enter(object sender, EventArgs e)
        {
            MoveCursorToTheStartPos(HoursBox);
        }

        private void RateBox_Enter(object sender, EventArgs e)
        {
            MoveCursorToTheStartPos(RateBox);
        }

        private void SalaryBox_Enter(object sender, EventArgs e)
        {
            MoveCursorToTheStartPos(SalaryBox);
        }
        
        /// <summary>
        /// Все ли поля заполнены верно
        /// </summary>
        private void AllFieldsOk()
        {
            List<MaskedTextBox> textBoxListTmp = null;
            if (FullTimeRadioButton.Checked)
            {
               textBoxListTmp = _fullTimeTextBox;
            }
            else if (PartTimeRadioButton.Checked)
            {
                textBoxListTmp = _partTimeTextBox;
            }

            var tmpBolean = true;
            foreach(var textBox in textBoxListTmp)
            {
                tmpBolean = tmpBolean && TextBoxValidatingWithErrorProvider(textBox);
            }
            ButtonCount.Enabled = tmpBolean;
        }

        private void HoursBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
               
        /// <summary>
        /// Ставить курсор в начале 
        /// при активации элемента
        /// </summary>
        /// <param name="textbox"></param>
        private void MoveCursorToTheStartPos(MaskedTextBox textBox)
        {
            if (textBox != null)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    int pos = textBox.SelectionStart;

                    if (pos > textBox.Text.Length)
                        pos = textBox.Text.Length;

                    textBox.Select(pos, 0);
                });
            }
        }

        #region Внешний вид формы и ее очистка

        /// <summary>
        /// Очистка всех TextBox на форме
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearInput_Button_Click(object sender,
            EventArgs e)
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
                if (c.GetType() == typeof(MaskedTextBox))
                    c.Text = string.Empty;

                if (c.GetType() == typeof(GroupBox))
                    CleanAllTextBoxesIn(c);
            }
        }

        /// <summary>
        /// Изменяет главную форму
        /// при выборе почасовой
        /// оплаты труда
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PartTimeRadioButton_CheckedChanged(object sender,
            EventArgs e)
        {
            labelWage.Text = "Стоимость часа";
            SalaryBox.Visible = false;
            labelSalary.Visible = false;
        }

        /// <summary>
        /// Изменяет главную форму
        /// при выборе оплаты труда
        /// по окладу и ставке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FullTimeRadioButton_CheckedChanged(object sender,
            EventArgs e)
        {
            labelWage.Text = "Ставка";
            SalaryBox.Visible = true;
            labelSalary.Visible = true;
        }


        #endregion

        #endregion
    }
}
