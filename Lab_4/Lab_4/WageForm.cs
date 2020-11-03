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
        private DataTable _dataTable = new DataTable();


        /// <summary>
        /// Таблица для хранения данных
        /// </summary>
        public DataTable DataTable 
        {
            get
            {
                return _dataTable;
            }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException($"{nameof(DataTable)} " +
                        $"не может являться пустым.");
                }

                _dataTable = value;
            }
        }
        
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

            DataTable.Columns.AddRange(new DataColumn[4]
            {
                new DataColumn("Фамилия",typeof(string)), 
                new DataColumn("Имя", typeof(string)),
                new DataColumn("Отчество",typeof(string)),
                new DataColumn("Сумма к выплате", typeof(double))
            });
            dataGridView.DataSource = DataTable;
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
        /// Сохранение таблицы в файл
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
                    formatter.Serialize(fileStream, DataTable);
                    MessageBox.Show("Файл был сохранен.");
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
            DataTable.Clear();
        }

        /// <summary>
        /// Показать форму ввода данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewEntryButton_Click(object sender,
            EventArgs e)
        {
            DataInput dataInput = new DataInput();
            dataInput.Tag = this;
            //вызов формы для ввода данных с блокированием главной
            dataInput.ShowDialog();
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
        /// Отображение текста по умолчанию
		/// при потере фокуса SearchBox 
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
            SearchBox.Font = new Font(SearchBox.Font, FontStyle.Italic);
        }

        /// <summary>
        /// Событие
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBox_Enter(object sender, EventArgs e)
        {
            if (SearchBox.ForeColor == Color.Black)
            {
                SearchInDatatable();
                return;
            }

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
            try
            {
                int counter = 0;
                if (dataGridView.SelectedRows.Count > DataTable.Rows.Count)
                {
                    counter = DataTable.Rows.Count;
                    dataGridView.Rows.Clear();
                }

                foreach (DataGridViewRow delRow
                    in dataGridView.SelectedRows)
                {
                    counter++;
                    dataGridView.Rows.Remove(delRow);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// Добавление произвольных сущностей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Person newPerson = RandomData.PickPerson();
            
            var randomNumber = random.Next(1, 2);
            switch (randomNumber)
            {
                case 1:
                {
                    FullTime fullTime = new FullTime();
                    fullTime.Shifts = RandomData.GenerateNumber();
                    fullTime.Salary = RandomData.GenerateNumber();
                    fullTime.Rate = RandomData.GenerateNumber();

                    DataTable.Rows.Add(
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

                    DataTable.Rows.Add(
                    newPerson.LastName,
                    newPerson.FirstName,
                    newPerson.LastName,
                    partTime.CalculateWage());

                    break;
                }
            }
        }

        /// <summary>
        /// Поиск по содержимому DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox.Text == string.Empty)
            {
                dataGridView.ClearSelection();
            }
            else 
            {
                SearchInDatatable();
            }
        }

        /// <summary>
        /// Поиск записи в таблице
        /// по вводимой строке
        /// </summary>
        private void SearchInDatatable()
        {
            dataGridView.ClearSelection();
            string searchQuery = SearchBox.Text;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    if (row.Cells[i].Value != null &&
                        row.Cells[i].Value.ToString()
                            .ToLower().Contains(searchQuery.ToLower()))
                    {
                        int rowIndex = row.Index;
                        dataGridView.Rows[rowIndex].Selected = true;
                        break;
                    }
                }
            }
        }
    }
}
