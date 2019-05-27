namespace WindowsFormsApp1
{
    partial class Form1
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
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File_StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.FilmYear_Label = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CopyType_Label = new System.Windows.Forms.Label();
            this.SalaryAmount_TextBox = new System.Windows.Forms.TextBox();
            this.Tax_TextBox = new System.Windows.Forms.TextBox();
            this.CopayAmount_TextBox = new System.Windows.Forms.TextBox();
            this.SalaryAmount_Label = new System.Windows.Forms.Label();
            this.Premium_TextBox = new System.Windows.Forms.TextBox();
            this.Tax_Label = new System.Windows.Forms.Label();
            this.VideotapeType_Label = new System.Windows.Forms.Label();
            this.CopayAmount_Label = new System.Windows.Forms.Label();
            this.FilmCountry_Label = new System.Windows.Forms.Label();
            this.Premium_Label = new System.Windows.Forms.Label();
            this.FilmDuration_TextBox = new System.Windows.Forms.TextBox();
            this.FilmDuration_Label = new System.Windows.Forms.Label();
            this.FilmGanre_TextBox = new System.Windows.Forms.TextBox();
            this.FilmGanre_Label = new System.Windows.Forms.Label();
            this.FilmName_TextBox = new System.Windows.Forms.TextBox();
            this.FilmName_Label = new System.Windows.Forms.Label();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Change_Button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Filters_GroupBox = new System.Windows.Forms.GroupBox();
            this.DepartmentSort_RadioButton = new System.Windows.Forms.RadioButton();
            this.WorkDaysSort_RadioButton = new System.Windows.Forms.RadioButton();
            this.FilmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilmGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilmDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilmCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilmYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VideotapeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CopyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OneMinuteRecordCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalRecordCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplyFilter = new System.Windows.Forms.Button();
            this.FilmCountry_TextBox = new System.Windows.Forms.TextBox();
            this.FilmYear_TextBox = new System.Windows.Forms.TextBox();
            this.VideotapeType_ComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.Filters_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilmName,
            this.FilmGenre,
            this.FilmDuration,
            this.FilmCountry,
            this.FilmYear,
            this.VideotapeType,
            this.CopyType,
            this.OneMinuteRecordCost,
            this.RecordCost,
            this.FinalRecordCost});
            this.DataGrid.Location = new System.Drawing.Point(301, 25);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(1044, 323);
            this.DataGrid.TabIndex = 1;
            this.DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_StripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1348, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File_StripMenuItem
            // 
            this.File_StripMenuItem.Name = "File_StripMenuItem";
            this.File_StripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.File_StripMenuItem.Text = "Файл";
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox.Controls.Add(this.VideotapeType_ComboBox);
            this.groupBox.Controls.Add(this.FilmYear_Label);
            this.groupBox.Controls.Add(this.textBox2);
            this.groupBox.Controls.Add(this.CopyType_Label);
            this.groupBox.Controls.Add(this.SalaryAmount_TextBox);
            this.groupBox.Controls.Add(this.Tax_TextBox);
            this.groupBox.Controls.Add(this.CopayAmount_TextBox);
            this.groupBox.Controls.Add(this.SalaryAmount_Label);
            this.groupBox.Controls.Add(this.Premium_TextBox);
            this.groupBox.Controls.Add(this.Tax_Label);
            this.groupBox.Controls.Add(this.VideotapeType_Label);
            this.groupBox.Controls.Add(this.CopayAmount_Label);
            this.groupBox.Controls.Add(this.FilmCountry_Label);
            this.groupBox.Controls.Add(this.Premium_Label);
            this.groupBox.Controls.Add(this.FilmYear_TextBox);
            this.groupBox.Controls.Add(this.FilmCountry_TextBox);
            this.groupBox.Controls.Add(this.FilmDuration_TextBox);
            this.groupBox.Controls.Add(this.FilmDuration_Label);
            this.groupBox.Controls.Add(this.FilmGanre_TextBox);
            this.groupBox.Controls.Add(this.FilmGanre_Label);
            this.groupBox.Controls.Add(this.FilmName_TextBox);
            this.groupBox.Controls.Add(this.FilmName_Label);
            this.groupBox.Location = new System.Drawing.Point(13, 25);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(282, 453);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Добавление";
            this.groupBox.Enter += new System.EventHandler(this.groupBox_Enter);
            // 
            // FilmYear_Label
            // 
            this.FilmYear_Label.AutoSize = true;
            this.FilmYear_Label.Location = new System.Drawing.Point(6, 181);
            this.FilmYear_Label.Name = "FilmYear_Label";
            this.FilmYear_Label.Size = new System.Drawing.Size(71, 13);
            this.FilmYear_Label.TabIndex = 0;
            this.FilmYear_Label.Text = "Год выпуска";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(165, 264);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(111, 20);
            this.textBox2.TabIndex = 1;
            // 
            // CopyType_Label
            // 
            this.CopyType_Label.AllowDrop = true;
            this.CopyType_Label.Location = new System.Drawing.Point(7, 267);
            this.CopyType_Label.Name = "CopyType_Label";
            this.CopyType_Label.Size = new System.Drawing.Size(121, 17);
            this.CopyType_Label.TabIndex = 0;
            this.CopyType_Label.Text = "Тип копии";
            // 
            // SalaryAmount_TextBox
            // 
            this.SalaryAmount_TextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.SalaryAmount_TextBox.Enabled = false;
            this.SalaryAmount_TextBox.Location = new System.Drawing.Point(165, 411);
            this.SalaryAmount_TextBox.Name = "SalaryAmount_TextBox";
            this.SalaryAmount_TextBox.Size = new System.Drawing.Size(111, 20);
            this.SalaryAmount_TextBox.TabIndex = 1;
            this.SalaryAmount_TextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Tax_TextBox
            // 
            this.Tax_TextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Tax_TextBox.Enabled = false;
            this.Tax_TextBox.Location = new System.Drawing.Point(165, 376);
            this.Tax_TextBox.Name = "Tax_TextBox";
            this.Tax_TextBox.Size = new System.Drawing.Size(111, 20);
            this.Tax_TextBox.TabIndex = 1;
            this.Tax_TextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // CopayAmount_TextBox
            // 
            this.CopayAmount_TextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CopayAmount_TextBox.Enabled = false;
            this.CopayAmount_TextBox.Location = new System.Drawing.Point(165, 341);
            this.CopayAmount_TextBox.Name = "CopayAmount_TextBox";
            this.CopayAmount_TextBox.Size = new System.Drawing.Size(111, 20);
            this.CopayAmount_TextBox.TabIndex = 1;
            // 
            // SalaryAmount_Label
            // 
            this.SalaryAmount_Label.AutoSize = true;
            this.SalaryAmount_Label.Location = new System.Drawing.Point(7, 414);
            this.SalaryAmount_Label.Name = "SalaryAmount_Label";
            this.SalaryAmount_Label.Size = new System.Drawing.Size(90, 13);
            this.SalaryAmount_Label.TabIndex = 0;
            this.SalaryAmount_Label.Text = "Сумма к выдаче";
            this.SalaryAmount_Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // Premium_TextBox
            // 
            this.Premium_TextBox.Location = new System.Drawing.Point(165, 303);
            this.Premium_TextBox.Name = "Premium_TextBox";
            this.Premium_TextBox.Size = new System.Drawing.Size(111, 20);
            this.Premium_TextBox.TabIndex = 1;
            // 
            // Tax_Label
            // 
            this.Tax_Label.AutoSize = true;
            this.Tax_Label.Location = new System.Drawing.Point(7, 379);
            this.Tax_Label.Name = "Tax_Label";
            this.Tax_Label.Size = new System.Drawing.Size(118, 13);
            this.Tax_Label.TabIndex = 0;
            this.Tax_Label.Text = "Общая сумма оплаты";
            this.Tax_Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // VideotapeType_Label
            // 
            this.VideotapeType_Label.AllowDrop = true;
            this.VideotapeType_Label.Location = new System.Drawing.Point(6, 221);
            this.VideotapeType_Label.Name = "VideotapeType_Label";
            this.VideotapeType_Label.Size = new System.Drawing.Size(121, 21);
            this.VideotapeType_Label.TabIndex = 0;
            this.VideotapeType_Label.Text = "Тип видеокассеты";
            // 
            // CopayAmount_Label
            // 
            this.CopayAmount_Label.Location = new System.Drawing.Point(7, 338);
            this.CopayAmount_Label.Name = "CopayAmount_Label";
            this.CopayAmount_Label.Size = new System.Drawing.Size(84, 29);
            this.CopayAmount_Label.TabIndex = 0;
            this.CopayAmount_Label.Text = "Общая сумма оплаты";
            // 
            // FilmCountry_Label
            // 
            this.FilmCountry_Label.AutoSize = true;
            this.FilmCountry_Label.Location = new System.Drawing.Point(6, 142);
            this.FilmCountry_Label.Name = "FilmCountry_Label";
            this.FilmCountry_Label.Size = new System.Drawing.Size(123, 13);
            this.FilmCountry_Label.TabIndex = 0;
            this.FilmCountry_Label.Text = "Страна-производитель";
            // 
            // Premium_Label
            // 
            this.Premium_Label.AutoSize = true;
            this.Premium_Label.Location = new System.Drawing.Point(7, 306);
            this.Premium_Label.Name = "Premium_Label";
            this.Premium_Label.Size = new System.Drawing.Size(47, 13);
            this.Premium_Label.TabIndex = 0;
            this.Premium_Label.Text = "Премия";
            // 
            // FilmDuration_TextBox
            // 
            this.FilmDuration_TextBox.Location = new System.Drawing.Point(165, 104);
            this.FilmDuration_TextBox.Name = "FilmDuration_TextBox";
            this.FilmDuration_TextBox.Size = new System.Drawing.Size(111, 20);
            this.FilmDuration_TextBox.TabIndex = 1;
            // 
            // FilmDuration_Label
            // 
            this.FilmDuration_Label.Location = new System.Drawing.Point(7, 98);
            this.FilmDuration_Label.Name = "FilmDuration_Label";
            this.FilmDuration_Label.Size = new System.Drawing.Size(128, 26);
            this.FilmDuration_Label.TabIndex = 0;
            this.FilmDuration_Label.Text = "Длительность фильма (в минутах)";
            // 
            // FilmGanre_TextBox
            // 
            this.FilmGanre_TextBox.Location = new System.Drawing.Point(165, 69);
            this.FilmGanre_TextBox.Name = "FilmGanre_TextBox";
            this.FilmGanre_TextBox.Size = new System.Drawing.Size(111, 20);
            this.FilmGanre_TextBox.TabIndex = 1;
            // 
            // FilmGanre_Label
            // 
            this.FilmGanre_Label.AutoSize = true;
            this.FilmGanre_Label.Location = new System.Drawing.Point(7, 72);
            this.FilmGanre_Label.Name = "FilmGanre_Label";
            this.FilmGanre_Label.Size = new System.Drawing.Size(79, 13);
            this.FilmGanre_Label.TabIndex = 0;
            this.FilmGanre_Label.Text = "Жанр фильма";
            // 
            // FilmName_TextBox
            // 
            this.FilmName_TextBox.Location = new System.Drawing.Point(165, 34);
            this.FilmName_TextBox.Name = "FilmName_TextBox";
            this.FilmName_TextBox.Size = new System.Drawing.Size(111, 20);
            this.FilmName_TextBox.TabIndex = 1;
            // 
            // FilmName_Label
            // 
            this.FilmName_Label.AutoSize = true;
            this.FilmName_Label.Location = new System.Drawing.Point(7, 37);
            this.FilmName_Label.Name = "FilmName_Label";
            this.FilmName_Label.Size = new System.Drawing.Size(100, 13);
            this.FilmName_Label.TabIndex = 0;
            this.FilmName_Label.Text = "Название фильма";
            // 
            // Add_Button
            // 
            this.Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_Button.Location = new System.Drawing.Point(12, 482);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(75, 32);
            this.Add_Button.TabIndex = 4;
            this.Add_Button.Text = "Добавить";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Change_Button
            // 
            this.Change_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change_Button.Location = new System.Drawing.Point(116, 482);
            this.Change_Button.Name = "Change_Button";
            this.Change_Button.Size = new System.Drawing.Size(75, 32);
            this.Change_Button.TabIndex = 4;
            this.Change_Button.Text = "Изменить";
            this.Change_Button.UseVisualStyleBackColor = true;
            this.Change_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_Button.Location = new System.Drawing.Point(220, 482);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(75, 32);
            this.Clear_Button.TabIndex = 4;
            this.Clear_Button.Text = "Очистить";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.button3_Click);
            // 
            // Filters_GroupBox
            // 
            this.Filters_GroupBox.Controls.Add(this.ApplyFilter);
            this.Filters_GroupBox.Controls.Add(this.DepartmentSort_RadioButton);
            this.Filters_GroupBox.Controls.Add(this.WorkDaysSort_RadioButton);
            this.Filters_GroupBox.Location = new System.Drawing.Point(301, 355);
            this.Filters_GroupBox.Name = "Filters_GroupBox";
            this.Filters_GroupBox.Size = new System.Drawing.Size(467, 159);
            this.Filters_GroupBox.TabIndex = 5;
            this.Filters_GroupBox.TabStop = false;
            this.Filters_GroupBox.Text = "Фильтры";
            // 
            // DepartmentSort_RadioButton
            // 
            this.DepartmentSort_RadioButton.Location = new System.Drawing.Point(6, 69);
            this.DepartmentSort_RadioButton.Name = "DepartmentSort_RadioButton";
            this.DepartmentSort_RadioButton.Size = new System.Drawing.Size(227, 65);
            this.DepartmentSort_RadioButton.TabIndex = 0;
            this.DepartmentSort_RadioButton.TabStop = true;
            this.DepartmentSort_RadioButton.Tag = "filter";
            this.DepartmentSort_RadioButton.Text = "Вывести список фильмов, год выпуска которых больше заданного";
            this.DepartmentSort_RadioButton.UseVisualStyleBackColor = true;
            // 
            // WorkDaysSort_RadioButton
            // 
            this.WorkDaysSort_RadioButton.Location = new System.Drawing.Point(6, 11);
            this.WorkDaysSort_RadioButton.Name = "WorkDaysSort_RadioButton";
            this.WorkDaysSort_RadioButton.Size = new System.Drawing.Size(266, 65);
            this.WorkDaysSort_RadioButton.TabIndex = 0;
            this.WorkDaysSort_RadioButton.TabStop = true;
            this.WorkDaysSort_RadioButton.Tag = "filter";
            this.WorkDaysSort_RadioButton.Text = "Вывести список фильмов длительностью более 85 минут";
            this.WorkDaysSort_RadioButton.UseVisualStyleBackColor = true;
            // 
            // FilmName
            // 
            this.FilmName.HeaderText = "Название фильма";
            this.FilmName.Name = "FilmName";
            this.FilmName.ReadOnly = true;
            // 
            // FilmGenre
            // 
            this.FilmGenre.HeaderText = "Жанр фильма";
            this.FilmGenre.Name = "FilmGenre";
            this.FilmGenre.ReadOnly = true;
            // 
            // FilmDuration
            // 
            this.FilmDuration.HeaderText = "Длительность фильма (в минутах)";
            this.FilmDuration.Name = "FilmDuration";
            this.FilmDuration.ReadOnly = true;
            // 
            // FilmCountry
            // 
            this.FilmCountry.HeaderText = "Страна-производитель";
            this.FilmCountry.Name = "FilmCountry";
            this.FilmCountry.ReadOnly = true;
            // 
            // FilmYear
            // 
            this.FilmYear.HeaderText = "Год выпуска";
            this.FilmYear.Name = "FilmYear";
            this.FilmYear.ReadOnly = true;
            // 
            // VideotapeType
            // 
            this.VideotapeType.HeaderText = "Тип видеокассеты";
            this.VideotapeType.Name = "VideotapeType";
            this.VideotapeType.ReadOnly = true;
            // 
            // CopyType
            // 
            this.CopyType.HeaderText = "Тип копии";
            this.CopyType.Name = "CopyType";
            this.CopyType.ReadOnly = true;
            // 
            // OneMinuteRecordCost
            // 
            this.OneMinuteRecordCost.HeaderText = "Стоимоть записи одной минуты";
            this.OneMinuteRecordCost.Name = "OneMinuteRecordCost";
            this.OneMinuteRecordCost.ReadOnly = true;
            // 
            // RecordCost
            // 
            this.RecordCost.HeaderText = "Общая стоимость записи фильма";
            this.RecordCost.Name = "RecordCost";
            this.RecordCost.ReadOnly = true;
            // 
            // FinalRecordCost
            // 
            this.FinalRecordCost.HeaderText = "Стоимость записи с учётом типа копии";
            this.FinalRecordCost.Name = "FinalRecordCost";
            this.FinalRecordCost.ReadOnly = true;
            // 
            // ApplyFilter
            // 
            this.ApplyFilter.Location = new System.Drawing.Point(310, 18);
            this.ApplyFilter.Name = "ApplyFilter";
            this.ApplyFilter.Size = new System.Drawing.Size(131, 44);
            this.ApplyFilter.TabIndex = 1;
            this.ApplyFilter.Text = "Применить фильтр";
            this.ApplyFilter.UseVisualStyleBackColor = true;
            // 
            // FilmCountry_TextBox
            // 
            this.FilmCountry_TextBox.Location = new System.Drawing.Point(165, 139);
            this.FilmCountry_TextBox.Name = "FilmCountry_TextBox";
            this.FilmCountry_TextBox.Size = new System.Drawing.Size(111, 20);
            this.FilmCountry_TextBox.TabIndex = 1;
            // 
            // FilmYear_TextBox
            // 
            this.FilmYear_TextBox.Location = new System.Drawing.Point(165, 178);
            this.FilmYear_TextBox.Name = "FilmYear_TextBox";
            this.FilmYear_TextBox.Size = new System.Drawing.Size(111, 20);
            this.FilmYear_TextBox.TabIndex = 1;
            // 
            // VideotapeType_ComboBox
            // 
            this.VideotapeType_ComboBox.FormattingEnabled = true;
            this.VideotapeType_ComboBox.Location = new System.Drawing.Point(165, 218);
            this.VideotapeType_ComboBox.Name = "VideotapeType_ComboBox";
            this.VideotapeType_ComboBox.Size = new System.Drawing.Size(111, 21);
            this.VideotapeType_ComboBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 517);
            this.Controls.Add(this.Filters_GroupBox);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Change_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SalaryDatabase";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.Filters_GroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File_StripMenuItem;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label FilmYear_Label;
        private System.Windows.Forms.TextBox Premium_TextBox;
        private System.Windows.Forms.Label VideotapeType_Label;
        private System.Windows.Forms.Label FilmCountry_Label;
        private System.Windows.Forms.Label Premium_Label;
        private System.Windows.Forms.TextBox FilmGanre_TextBox;
        private System.Windows.Forms.Label FilmGanre_Label;
        private System.Windows.Forms.TextBox FilmName_TextBox;
        private System.Windows.Forms.Label FilmName_Label;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label CopyType_Label;
        private System.Windows.Forms.TextBox CopayAmount_TextBox;
        private System.Windows.Forms.Label CopayAmount_Label;
        private System.Windows.Forms.TextBox Tax_TextBox;
        private System.Windows.Forms.Label Tax_Label;
        private System.Windows.Forms.TextBox SalaryAmount_TextBox;
        private System.Windows.Forms.Label SalaryAmount_Label;
        private System.Windows.Forms.TextBox FilmDuration_TextBox;
        private System.Windows.Forms.Label FilmDuration_Label;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Change_Button;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.GroupBox Filters_GroupBox;
        private System.Windows.Forms.RadioButton DepartmentSort_RadioButton;
        private System.Windows.Forms.RadioButton WorkDaysSort_RadioButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn VideotapeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CopyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn OneMinuteRecordCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalRecordCost;
        private System.Windows.Forms.Button ApplyFilter;
        private System.Windows.Forms.TextBox FilmCountry_TextBox;
        private System.Windows.Forms.TextBox FilmYear_TextBox;
        private System.Windows.Forms.ComboBox VideotapeType_ComboBox;
    }
}

