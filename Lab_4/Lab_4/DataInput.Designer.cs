namespace Lab_4
{
    partial class DataInput
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
            this.components = new System.ComponentModel.Container();
            this.ClearInput_Button = new System.Windows.Forms.Button();
            this.TotalBox = new System.Windows.Forms.TextBox();
            this.ButtonCount = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.PatroBox = new System.Windows.Forms.MaskedTextBox();
            this.FirstNameBox = new System.Windows.Forms.MaskedTextBox();
            this.LastNameBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newPersonInputWageFormLabel = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.SalaryBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RateBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.FullTimeRadioButton = new System.Windows.Forms.RadioButton();
            this.PartTimeRadioButton = new System.Windows.Forms.RadioButton();
            this.HoursBox = new System.Windows.Forms.MaskedTextBox();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelWage = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ClearInput_Button
            // 
            this.ClearInput_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearInput_Button.Location = new System.Drawing.Point(25, 149);
            this.ClearInput_Button.Name = "ClearInput_Button";
            this.ClearInput_Button.Size = new System.Drawing.Size(112, 33);
            this.ClearInput_Button.TabIndex = 23;
            this.ClearInput_Button.Text = "Очистить ввод";
            this.ClearInput_Button.UseVisualStyleBackColor = true;
            this.ClearInput_Button.Click += new System.EventHandler(this.ClearInput_Button_Click);
            // 
            // TotalBox
            // 
            this.TotalBox.Cursor = System.Windows.Forms.Cursors.No;
            this.TotalBox.Enabled = false;
            this.TotalBox.Location = new System.Drawing.Point(454, 160);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.ReadOnly = true;
            this.TotalBox.Size = new System.Drawing.Size(150, 22);
            this.TotalBox.TabIndex = 3;
            this.TotalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButtonCount
            // 
            this.ButtonCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCount.Location = new System.Drawing.Point(190, 149);
            this.ButtonCount.Name = "ButtonCount";
            this.ButtonCount.Size = new System.Drawing.Size(109, 33);
            this.ButtonCount.TabIndex = 20;
            this.ButtonCount.Text = "Рассчитать сумму";
            this.ButtonCount.UseVisualStyleBackColor = true;
            this.ButtonCount.Click += new System.EventHandler(this.ButtonCount_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GroupBox1.Controls.Add(this.PatroBox);
            this.GroupBox1.Controls.Add(this.FirstNameBox);
            this.GroupBox1.Controls.Add(this.LastNameBox);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.newPersonInputWageFormLabel);
            this.GroupBox1.Controls.Add(this.GroupBox2);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBox1.Location = new System.Drawing.Point(14, 20);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(627, 330);
            this.GroupBox1.TabIndex = 19;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Введите исходные данные";
            // 
            // PatroBox
            // 
            this.PatroBox.Location = new System.Drawing.Point(407, 47);
            this.PatroBox.Mask = "???????????????????";
            this.PatroBox.Name = "PatroBox";
            this.PatroBox.PromptChar = ' ';
            this.PatroBox.Size = new System.Drawing.Size(203, 22);
            this.PatroBox.TabIndex = 30;
            this.PatroBox.Enter += new System.EventHandler(this.PatroBox_Enter);
            this.PatroBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatroBox_KeyPress);
            this.PatroBox.Validating += new System.ComponentModel.CancelEventHandler(this.PatroBox_Validating);
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(220, 47);
            this.FirstNameBox.Mask = "???????????????????";
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.PromptChar = ' ';
            this.FirstNameBox.Size = new System.Drawing.Size(158, 22);
            this.FirstNameBox.TabIndex = 29;
            this.FirstNameBox.Enter += new System.EventHandler(this.FirstNameBox_Enter);
            this.FirstNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstNameBox_KeyPress);
            this.FirstNameBox.Validating += new System.ComponentModel.CancelEventHandler(this.FirstNameBox_Validating);
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(20, 47);
            this.LastNameBox.Mask = "???????????????????";
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.PromptChar = ' ';
            this.LastNameBox.Size = new System.Drawing.Size(159, 22);
            this.LastNameBox.TabIndex = 28;
            this.LastNameBox.Enter += new System.EventHandler(this.LastNameBox_Enter);
            this.LastNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastNameBox_KeyPress);
            this.LastNameBox.Validating += new System.ComponentModel.CancelEventHandler(this.LastNameBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(414, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(226, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Фамилия";
            // 
            // newPersonInputWageFormLabel
            // 
            this.newPersonInputWageFormLabel.AutoSize = true;
            this.newPersonInputWageFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPersonInputWageFormLabel.Location = new System.Drawing.Point(17, 79);
            this.newPersonInputWageFormLabel.Name = "newPersonInputWageFormLabel";
            this.newPersonInputWageFormLabel.Size = new System.Drawing.Size(375, 13);
            this.newPersonInputWageFormLabel.TabIndex = 17;
            this.newPersonInputWageFormLabel.Text = "ФИО может содержать только латинские или кириллические символы.";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.SalaryBox);
            this.GroupBox2.Controls.Add(this.label5);
            this.GroupBox2.Controls.Add(this.ClearInput_Button);
            this.GroupBox2.Controls.Add(this.RateBox);
            this.GroupBox2.Controls.Add(this.label4);
            this.GroupBox2.Controls.Add(this.groupBox4);
            this.GroupBox2.Controls.Add(this.TotalBox);
            this.GroupBox2.Controls.Add(this.HoursBox);
            this.GroupBox2.Controls.Add(this.ButtonCount);
            this.GroupBox2.Controls.Add(this.labelHours);
            this.GroupBox2.Controls.Add(this.labelWage);
            this.GroupBox2.Controls.Add(this.labelSalary);
            this.GroupBox2.Location = new System.Drawing.Point(6, 121);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(615, 198);
            this.GroupBox2.TabIndex = 13;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = " Данные для расчета суммы";
            // 
            // SalaryBox
            // 
            this.SalaryBox.Location = new System.Drawing.Point(133, 104);
            this.SalaryBox.Mask = "000000000";
            this.SalaryBox.Name = "SalaryBox";
            this.SalaryBox.PromptChar = ' ';
            this.SalaryBox.Size = new System.Drawing.Size(166, 22);
            this.SalaryBox.TabIndex = 33;
            this.SalaryBox.Enter += new System.EventHandler(this.SalaryBox_Enter);
            this.SalaryBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SalaryBox_KeyPress);
            this.SalaryBox.Validating += new System.ComponentModel.CancelEventHandler(this.SalaryBox_Validating);
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
            // RateBox
            // 
            this.RateBox.Location = new System.Drawing.Point(133, 68);
            this.RateBox.Mask = "00000000";
            this.RateBox.Name = "RateBox";
            this.RateBox.PromptChar = ' ';
            this.RateBox.Size = new System.Drawing.Size(166, 22);
            this.RateBox.TabIndex = 32;
            this.RateBox.Enter += new System.EventHandler(this.RateBox_Enter);
            this.RateBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RateBox_KeyPress);
            this.RateBox.Validating += new System.ComponentModel.CancelEventHandler(this.RateBox_Validating);
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(385, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "ИТОГО:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.FullTimeRadioButton);
            this.groupBox4.Controls.Add(this.PartTimeRadioButton);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(389, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(215, 114);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Система оплаты труда";
            // 
            // FullTimeRadioButton
            // 
            this.FullTimeRadioButton.AutoSize = true;
            this.FullTimeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullTimeRadioButton.Location = new System.Drawing.Point(12, 73);
            this.FullTimeRadioButton.Name = "FullTimeRadioButton";
            this.FullTimeRadioButton.Size = new System.Drawing.Size(136, 19);
            this.FullTimeRadioButton.TabIndex = 1;
            this.FullTimeRadioButton.TabStop = true;
            this.FullTimeRadioButton.Text = "По окладу и ставке";
            this.FullTimeRadioButton.UseVisualStyleBackColor = true;
            this.FullTimeRadioButton.CheckedChanged += new System.EventHandler(this.FullTimeRadioButton_CheckedChanged);
            // 
            // PartTimeRadioButton
            // 
            this.PartTimeRadioButton.AutoSize = true;
            this.PartTimeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PartTimeRadioButton.Location = new System.Drawing.Point(12, 35);
            this.PartTimeRadioButton.Name = "PartTimeRadioButton";
            this.PartTimeRadioButton.Size = new System.Drawing.Size(88, 19);
            this.PartTimeRadioButton.TabIndex = 0;
            this.PartTimeRadioButton.TabStop = true;
            this.PartTimeRadioButton.Text = "Почасовая";
            this.PartTimeRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PartTimeRadioButton.UseVisualStyleBackColor = true;
            this.PartTimeRadioButton.CheckedChanged += new System.EventHandler(this.PartTimeRadioButton_CheckedChanged);
            // 
            // HoursBox
            // 
            this.HoursBox.Location = new System.Drawing.Point(133, 30);
            this.HoursBox.Mask = "00000000";
            this.HoursBox.Name = "HoursBox";
            this.HoursBox.PromptChar = ' ';
            this.HoursBox.Size = new System.Drawing.Size(166, 22);
            this.HoursBox.TabIndex = 31;
            this.HoursBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.HoursBox_MaskInputRejected);
            this.HoursBox.Enter += new System.EventHandler(this.HoursBox_Enter);
            this.HoursBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HoursBox_KeyPress);
            this.HoursBox.Validating += new System.ComponentModel.CancelEventHandler(this.HoursBox_Validating);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.Location = new System.Drawing.Point(14, 356);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(627, 95);
            this.outputListBox.TabIndex = 25;
            // 
            // DataInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 462);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.GroupBox1);
            this.MaximizeBox = false;
            this.Name = "DataInput";
            this.Text = "Ввод данных работника";
            this.Load += new System.EventHandler(this.DataInput_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ClearInput_Button;
        private System.Windows.Forms.TextBox TotalBox;
        private System.Windows.Forms.Button ButtonCount;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label newPersonInputWageFormLabel;
        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton FullTimeRadioButton;
        private System.Windows.Forms.RadioButton PartTimeRadioButton;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelWage;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox PatroBox;
        private System.Windows.Forms.MaskedTextBox FirstNameBox;
        private System.Windows.Forms.MaskedTextBox LastNameBox;
        private System.Windows.Forms.MaskedTextBox SalaryBox;
        private System.Windows.Forms.MaskedTextBox RateBox;
        private System.Windows.Forms.MaskedTextBox HoursBox;
        private System.Windows.Forms.ListBox outputListBox;
    }
}