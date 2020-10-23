﻿using System;
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
        //TODO: RSDN
        /// <summary>
        /// Таблица для хранения данных
        /// </summary>
        public DataTable dataTable = new DataTable();

        //TODO: RSDN
        public DataInput dataInput;

        /// <summary>
        /// Инициализация основной формы
        /// </summary>
        public WageForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

#if DEBUG

            randomButton.Visible = true;
            randomButton.Enabled = true;
#else
            randomButton.Visible = false;
            randomButton.Enabled = false;
#endif

            dataTable.Columns.AddRange(new DataColumn[4]
            {
                //new DataColumn("№"),
                new DataColumn("Фамилия"), new DataColumn("Имя"),
                new DataColumn("Отчество"),
                new DataColumn("Сумма к выплате")
            });
            //dataTable.Columns["№"].AutoIncrement = true;
            //dataTable.Columns["№"].AutoIncrementSeed = 1;
            //dataTable.Columns["№"].AutoIncrementStep = 1;
            dataGridView.DataSource = dataTable;
        }


        /// <summary>
        /// Загрузка основной формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WageForm_Load(object sender, EventArgs e)
        {
            SearchBox_SetText();
        }

        /// <summary>
        /// Сохранение таблицы
        /// в файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveFileButton_Click(object sender,
            EventArgs e)
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
                    formatter.Serialize(fileStream, dataTable);
                    MessageBox.Show("File is saved successfully!");
                }
            }
        }

        /// <summary>
        /// Очистка таблицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearReportButton_Click(object sender,
            EventArgs e)
        {
            dataTable.Clear();
        }

        /// <summary>
        /// Показать форму ввода данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewEntryButton_Click(object sender,
            EventArgs e)
        {
            dataInput = new DataInput();
            dataInput.Tag = this;
            dataInput.Show();
        }

        /// <summary>
        /// Поиск по содержимому DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox.Text == "")
            {
                dataGridView.ClearSelection();
            }

            dataGridView.ClearSelection();
            string searchQuery = SearchBox.Text;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    if (row.Cells[i].Value != null && 
                        row.Cells[i].Value.ToString().ToLower().Contains(searchQuery.ToLower()))
                    {
                        int rowIndex = row.Index;
                        dataGridView.Rows[rowIndex].Selected = true;
                        break;
                    }

                }
            }
        }

        /// <summary>
        /// Загрузка информации в таблицу из файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Wage report files(*.wg) | *.wg";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var formatter = new BinaryFormatter();
                    var filePath = openFileDialog.FileName;

                    try
                    {
                        using (var fileStream = new FileStream(filePath,
                        FileMode.OpenOrCreate))
                        {
                            dataGridView.DataSource = (DataTable)formatter.
                                Deserialize(fileStream);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Файл поврежден, " +
                            "невозможно загрузить!");
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBox_Leave(object sender, EventArgs e)
        {
            if (SearchBox.Text.Trim() == "")
            {
                SearchBox_SetText();
            }
        }

        /// <summary>
        /// Отображение надписи по умолчанию
        /// в строке поиска
        /// </summary>
        private void SearchBox_SetText()
        {
            SearchBox.Text = "Найти";
            SearchBox.ForeColor = Color.Gray;
            //SearchBox.Font.Italic
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBox_Enter(object sender, EventArgs e)
        {
            if (SearchBox.ForeColor == Color.Black)
                return;
            SearchBox.Text = "";
            SearchBox.ForeColor = Color.Black;
        }

        /// <summary>
        /// Удаление выбранной записи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int counter = 0;
            if (dataGridView.SelectedRows.Count > dataTable.Rows.Count)
            {
                counter = dataTable.Rows.Count;
                dataGridView.Rows.Clear();
            }

            foreach (DataGridViewRow delRow
                in dataGridView.SelectedRows)
            {
                counter++;
                dataGridView.Rows.Remove(delRow);
            }
        }

        /// <summary>
        /// Добавление произвольных сущностей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomButton_Click(object sender, EventArgs e)
        {
            //TODO: RSDN
            Random random = new Random();
            Person newPerson = new Person();
            newPerson = RandomData.PickPerson();
            
            var randomNumber = random.Next(1, 2);
            switch (randomNumber)
            {
                case 1:
                    {
                        FullTime fullTime = new FullTime();
                        fullTime.Shifts = RandomData.GenerateNumber();
                        fullTime.Salary = RandomData.GenerateNumber();
                        fullTime.Rate = RandomData.GenerateNumber();

                        dataTable.Rows.Add(
                        newPerson.LastName,
                        newPerson.FirstName,
                        newPerson.Patronymic,
                        fullTime.CalculateWage()); 
                        
                        break;
                    }
                case 2:
                    {
                        PartTime partTime = new PartTime();
                        partTime.Shifts = RandomData.GenerateNumber();
                        partTime.Salary = RandomData.GenerateNumber();
 
                        dataTable.Rows.Add(
                        newPerson.LastName,
                        newPerson.FirstName,
                        newPerson.LastName,
                        partTime.CalculateWage());

                        break;
                    }
            }
        }
    }
}
