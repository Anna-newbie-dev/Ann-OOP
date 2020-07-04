namespace Lab_4
{
    partial class WageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCount = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.patroBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.newPersonInputWageFormLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hoursBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.fullTimeRadioButton = new System.Windows.Forms.RadioButton();
            this.partTimeRadioButton = new System.Windows.Forms.RadioButton();
            this.rateBox = new System.Windows.Forms.TextBox();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelWage = new System.Windows.Forms.Label();
            this.salaryBox = new System.Windows.Forms.TextBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.countLabel = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.clearInput_Button = new System.Windows.Forms.Button();
            this.programName = new System.Windows.Forms.Label();
            this.clearLabel = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.clearReportButton = new System.Windows.Forms.Button();
            this.loadReportButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCount
            // 
            this.buttonCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCount.Location = new System.Drawing.Point(189, 411);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(115, 33);
            this.buttonCount.TabIndex = 1;
            this.buttonCount.Text = "РАССЧИТАТЬ!";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.patroBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.firstNameBox);
            this.groupBox1.Controls.Add(this.lastNameBox);
            this.groupBox1.Controls.Add(this.newPersonInputWageFormLabel);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(24, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 317);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите исходые данные";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Отчество";
            // 
            // patroBox
            // 
            this.patroBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patroBox.Location = new System.Drawing.Point(87, 77);
            this.patroBox.Multiline = true;
            this.patroBox.Name = "patroBox";
            this.patroBox.Size = new System.Drawing.Size(167, 22);
            this.patroBox.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(283, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Фамилия";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameBox.Location = new System.Drawing.Point(323, 34);
            this.firstNameBox.Multiline = true;
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(167, 22);
            this.firstNameBox.TabIndex = 22;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameBox.Location = new System.Drawing.Point(87, 34);
            this.lastNameBox.Multiline = true;
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lastNameBox.Size = new System.Drawing.Size(166, 22);
            this.lastNameBox.TabIndex = 21;
            // 
            // newPersonInputWageFormLabel
            // 
            this.newPersonInputWageFormLabel.AutoSize = true;
            this.newPersonInputWageFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPersonInputWageFormLabel.Location = new System.Drawing.Point(14, 119);
            this.newPersonInputWageFormLabel.Name = "newPersonInputWageFormLabel";
            this.newPersonInputWageFormLabel.Size = new System.Drawing.Size(375, 26);
            this.newPersonInputWageFormLabel.TabIndex = 17;
            this.newPersonInputWageFormLabel.Text = "ФИО может содержать только латинские или кириллические символы.\rДопускается ввод " +
    "двойного имени/фамилии (через дефис)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.hoursBox);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.rateBox);
            this.groupBox2.Controls.Add(this.labelHours);
            this.groupBox2.Controls.Add(this.labelWage);
            this.groupBox2.Controls.Add(this.salaryBox);
            this.groupBox2.Controls.Add(this.labelSalary);
            this.groupBox2.Location = new System.Drawing.Point(6, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 149);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Данные для расчета суммы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(11, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "часы";
            // 
            // hoursBox
            // 
            this.hoursBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hoursBox.Location = new System.Drawing.Point(133, 31);
            this.hoursBox.Multiline = true;
            this.hoursBox.Name = "hoursBox";
            this.hoursBox.Size = new System.Drawing.Size(166, 22);
            this.hoursBox.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.fullTimeRadioButton);
            this.groupBox4.Controls.Add(this.partTimeRadioButton);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(323, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(153, 114);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Система оплаты труда";
            // 
            // fullTimeRadioButton
            // 
            this.fullTimeRadioButton.AutoSize = true;
            this.fullTimeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullTimeRadioButton.Location = new System.Drawing.Point(12, 77);
            this.fullTimeRadioButton.Name = "fullTimeRadioButton";
            this.fullTimeRadioButton.Size = new System.Drawing.Size(136, 19);
            this.fullTimeRadioButton.TabIndex = 1;
            this.fullTimeRadioButton.TabStop = true;
            this.fullTimeRadioButton.Text = "По окладу и ставке";
            this.fullTimeRadioButton.UseVisualStyleBackColor = true;
            this.fullTimeRadioButton.CheckedChanged += new System.EventHandler(this.fullTimeRadioButton_CheckedChanged);
            // 
            // partTimeRadioButton
            // 
            this.partTimeRadioButton.AutoSize = true;
            this.partTimeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partTimeRadioButton.Location = new System.Drawing.Point(12, 39);
            this.partTimeRadioButton.Name = "partTimeRadioButton";
            this.partTimeRadioButton.Size = new System.Drawing.Size(88, 19);
            this.partTimeRadioButton.TabIndex = 0;
            this.partTimeRadioButton.TabStop = true;
            this.partTimeRadioButton.Text = "Почасовая";
            this.partTimeRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.partTimeRadioButton.UseVisualStyleBackColor = true;
            this.partTimeRadioButton.CheckedChanged += new System.EventHandler(this.partTime_CheckedChanged);
            // 
            // rateBox
            // 
            this.rateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rateBox.Location = new System.Drawing.Point(133, 67);
            this.rateBox.Multiline = true;
            this.rateBox.Name = "rateBox";
            this.rateBox.Size = new System.Drawing.Size(166, 22);
            this.rateBox.TabIndex = 1;
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHours.Location = new System.Drawing.Point(11, 29);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(95, 15);
            this.labelHours.TabIndex = 3;
            this.labelHours.Text = "Отработанные";
            // 
            // labelWage
            // 
            this.labelWage.AutoSize = true;
            this.labelWage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWage.Location = new System.Drawing.Point(11, 71);
            this.labelWage.Name = "labelWage";
            this.labelWage.Size = new System.Drawing.Size(49, 15);
            this.labelWage.TabIndex = 4;
            this.labelWage.Text = "Ставка";
            // 
            // salaryBox
            // 
            this.salaryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salaryBox.Location = new System.Drawing.Point(133, 102);
            this.salaryBox.Multiline = true;
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(166, 22);
            this.salaryBox.TabIndex = 5;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSalary.Location = new System.Drawing.Point(11, 107);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(43, 15);
            this.labelSalary.TabIndex = 6;
            this.labelSalary.Text = "Оклад";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.totalBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(18, 471);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(503, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ИТОГО:";
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(161, 42);
            this.totalBox.Name = "totalBox";
            this.totalBox.ReadOnly = true;
            this.totalBox.Size = new System.Drawing.Size(150, 29);
            this.totalBox.TabIndex = 3;
            this.totalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // countLabel
            // 
            this.countLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countLabel.Location = new System.Drawing.Point(170, 447);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(164, 26);
            this.countLabel.TabIndex = 15;
            this.countLabel.Text = "Расчет причитающейся суммы\rи вывод в таблицу.";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Controls.Add(this.loadReportButton);
            this.groupBox5.Controls.Add(this.clearReportButton);
            this.groupBox5.Controls.Add(this.saveFileButton);
            this.groupBox5.Controls.Add(this.dataGridView);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(533, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(594, 550);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Формирование отчетности";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(17, 38);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(558, 414);
            this.dataGridView.TabIndex = 4;
            // 
            // clearInput_Button
            // 
            this.clearInput_Button.Location = new System.Drawing.Point(377, 408);
            this.clearInput_Button.Name = "clearInput_Button";
            this.clearInput_Button.Size = new System.Drawing.Size(115, 33);
            this.clearInput_Button.TabIndex = 17;
            this.clearInput_Button.Text = "Очистить ввод";
            this.clearInput_Button.UseVisualStyleBackColor = true;
            this.clearInput_Button.Click += new System.EventHandler(this.clearInput_Button_Click);
            // 
            // programName
            // 
            this.programName.AutoSize = true;
            this.programName.BackColor = System.Drawing.Color.Transparent;
            this.programName.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.programName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.programName.Location = new System.Drawing.Point(24, 30);
            this.programName.Name = "programName";
            this.programName.Size = new System.Drawing.Size(402, 32);
            this.programName.TabIndex = 16;
            this.programName.Text = "SIMPLE WAGE CALCULATOR";
            // 
            // clearLabel
            // 
            this.clearLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.clearLabel.AutoSize = true;
            this.clearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearLabel.Location = new System.Drawing.Point(374, 447);
            this.clearLabel.Name = "clearLabel";
            this.clearLabel.Size = new System.Drawing.Size(118, 13);
            this.clearLabel.TabIndex = 18;
            this.clearLabel.Text = "Очистка полей ввода.";
            // 
            // saveFileButton
            // 
            this.saveFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveFileButton.Location = new System.Drawing.Point(247, 492);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(120, 33);
            this.saveFileButton.TabIndex = 19;
            this.saveFileButton.Text = "Сохранить отчет";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // clearReportButton
            // 
            this.clearReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearReportButton.Location = new System.Drawing.Point(17, 492);
            this.clearReportButton.Name = "clearReportButton";
            this.clearReportButton.Size = new System.Drawing.Size(120, 33);
            this.clearReportButton.TabIndex = 20;
            this.clearReportButton.Text = "Очистить таблицу";
            this.clearReportButton.UseVisualStyleBackColor = true;
            this.clearReportButton.Click += new System.EventHandler(this.clearReportButton_Click);
            // 
            // loadReportButton
            // 
            this.loadReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadReportButton.Location = new System.Drawing.Point(455, 492);
            this.loadReportButton.Name = "loadReportButton";
            this.loadReportButton.Size = new System.Drawing.Size(120, 33);
            this.loadReportButton.TabIndex = 21;
            this.loadReportButton.Text = "Загрузить отчет";
            this.loadReportButton.UseVisualStyleBackColor = true;
            this.loadReportButton.Click += new System.EventHandler(this.loadReportButton_Click);
            // 
            // WageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1139, 589);
            this.Controls.Add(this.clearLabel);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.clearInput_Button);
            this.Controls.Add(this.programName);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Name = "WageForm";
            this.Text = "Simple Wage Calculator (alpha version)";
            this.Load += new System.EventHandler(this.WageForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox hoursBox;
        private System.Windows.Forms.TextBox rateBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton fullTimeRadioButton;
        private System.Windows.Forms.RadioButton partTimeRadioButton;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelWage;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TextBox salaryBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label newPersonInputWageFormLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox patroBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label programName;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button clearInput_Button;
        private System.Windows.Forms.Label clearLabel;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button clearReportButton;
        private System.Windows.Forms.Button loadReportButton;
    }
}