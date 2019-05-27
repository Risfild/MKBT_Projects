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
            this.CopyType_ComboBox = new System.Windows.Forms.ComboBox();
            this.VideotapeType_ComboBox = new System.Windows.Forms.ComboBox();
            this.FilmYear_Label = new System.Windows.Forms.Label();
            this.CopyType_Label = new System.Windows.Forms.Label();
            this.FilmRecordCostWithCopy_TextBox = new System.Windows.Forms.TextBox();
            this.FilmRecordCost_TextBox = new System.Windows.Forms.TextBox();
            this.OneMinuteRecordCost_TextBox = new System.Windows.Forms.TextBox();
            this.FilmRecordCostWithCopy_Label = new System.Windows.Forms.Label();
            this.FilmRecordCost_Label = new System.Windows.Forms.Label();
            this.VideotapeType_Label = new System.Windows.Forms.Label();
            this.FilmCountry_Label = new System.Windows.Forms.Label();
            this.OneMinuteRecordCost_Label = new System.Windows.Forms.Label();
            this.FilmYear_TextBox = new System.Windows.Forms.TextBox();
            this.FilmCountry_TextBox = new System.Windows.Forms.TextBox();
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
            this.FilterYear = new System.Windows.Forms.Label();
            this.YearSort_TextBox = new System.Windows.Forms.TextBox();
            this.ApplyFilter = new System.Windows.Forms.Button();
            this.YearSort_RadioButton = new System.Windows.Forms.RadioButton();
            this.MinutsSort_RadioButton = new System.Windows.Forms.RadioButton();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
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
            this.Exit_Button = new System.Windows.Forms.Button();
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
            this.File_StripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.File_StripMenuItem.Name = "File_StripMenuItem";
            this.File_StripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.File_StripMenuItem.Text = "Файл";
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox.Controls.Add(this.CopyType_ComboBox);
            this.groupBox.Controls.Add(this.VideotapeType_ComboBox);
            this.groupBox.Controls.Add(this.FilmYear_Label);
            this.groupBox.Controls.Add(this.CopyType_Label);
            this.groupBox.Controls.Add(this.FilmRecordCostWithCopy_TextBox);
            this.groupBox.Controls.Add(this.FilmRecordCost_TextBox);
            this.groupBox.Controls.Add(this.OneMinuteRecordCost_TextBox);
            this.groupBox.Controls.Add(this.FilmRecordCostWithCopy_Label);
            this.groupBox.Controls.Add(this.FilmRecordCost_Label);
            this.groupBox.Controls.Add(this.VideotapeType_Label);
            this.groupBox.Controls.Add(this.FilmCountry_Label);
            this.groupBox.Controls.Add(this.OneMinuteRecordCost_Label);
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
            this.groupBox.Size = new System.Drawing.Size(282, 406);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Добавление";
            // 
            // CopyType_ComboBox
            // 
            this.CopyType_ComboBox.FormattingEnabled = true;
            this.CopyType_ComboBox.Items.AddRange(new object[] {
            "Лазерная",
            "Первая",
            "Вторая"});
            this.CopyType_ComboBox.Location = new System.Drawing.Point(165, 256);
            this.CopyType_ComboBox.Name = "CopyType_ComboBox";
            this.CopyType_ComboBox.Size = new System.Drawing.Size(111, 21);
            this.CopyType_ComboBox.TabIndex = 7;
            // 
            // VideotapeType_ComboBox
            // 
            this.VideotapeType_ComboBox.FormattingEnabled = true;
            this.VideotapeType_ComboBox.Items.AddRange(new object[] {
            "VHS",
            "VHS-C",
            "Video8",
            "Hi8",
            "MiniDV"});
            this.VideotapeType_ComboBox.Location = new System.Drawing.Point(165, 218);
            this.VideotapeType_ComboBox.Name = "VideotapeType_ComboBox";
            this.VideotapeType_ComboBox.Size = new System.Drawing.Size(111, 21);
            this.VideotapeType_ComboBox.TabIndex = 6;
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
            // CopyType_Label
            // 
            this.CopyType_Label.AllowDrop = true;
            this.CopyType_Label.Location = new System.Drawing.Point(7, 259);
            this.CopyType_Label.Name = "CopyType_Label";
            this.CopyType_Label.Size = new System.Drawing.Size(121, 17);
            this.CopyType_Label.TabIndex = 0;
            this.CopyType_Label.Text = "Тип копии";
            // 
            // FilmRecordCostWithCopy_TextBox
            // 
            this.FilmRecordCostWithCopy_TextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.FilmRecordCostWithCopy_TextBox.Enabled = false;
            this.FilmRecordCostWithCopy_TextBox.Location = new System.Drawing.Point(165, 364);
            this.FilmRecordCostWithCopy_TextBox.Name = "FilmRecordCostWithCopy_TextBox";
            this.FilmRecordCostWithCopy_TextBox.Size = new System.Drawing.Size(111, 20);
            this.FilmRecordCostWithCopy_TextBox.TabIndex = 1;
            // 
            // FilmRecordCost_TextBox
            // 
            this.FilmRecordCost_TextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.FilmRecordCost_TextBox.Enabled = false;
            this.FilmRecordCost_TextBox.Location = new System.Drawing.Point(165, 329);
            this.FilmRecordCost_TextBox.Name = "FilmRecordCost_TextBox";
            this.FilmRecordCost_TextBox.Size = new System.Drawing.Size(111, 20);
            this.FilmRecordCost_TextBox.TabIndex = 1;
            // 
            // OneMinuteRecordCost_TextBox
            // 
            this.OneMinuteRecordCost_TextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.OneMinuteRecordCost_TextBox.Enabled = false;
            this.OneMinuteRecordCost_TextBox.Location = new System.Drawing.Point(165, 292);
            this.OneMinuteRecordCost_TextBox.Name = "OneMinuteRecordCost_TextBox";
            this.OneMinuteRecordCost_TextBox.Size = new System.Drawing.Size(111, 20);
            this.OneMinuteRecordCost_TextBox.TabIndex = 1;
            // 
            // FilmRecordCostWithCopy_Label
            // 
            this.FilmRecordCostWithCopy_Label.Location = new System.Drawing.Point(7, 362);
            this.FilmRecordCostWithCopy_Label.Name = "FilmRecordCostWithCopy_Label";
            this.FilmRecordCostWithCopy_Label.Size = new System.Drawing.Size(122, 30);
            this.FilmRecordCostWithCopy_Label.TabIndex = 0;
            this.FilmRecordCostWithCopy_Label.Text = "Стоимость записи с учетом типа копии";
            // 
            // FilmRecordCost_Label
            // 
            this.FilmRecordCost_Label.Location = new System.Drawing.Point(7, 328);
            this.FilmRecordCost_Label.Name = "FilmRecordCost_Label";
            this.FilmRecordCost_Label.Size = new System.Drawing.Size(128, 27);
            this.FilmRecordCost_Label.TabIndex = 0;
            this.FilmRecordCost_Label.Text = "Общая стоимость записи фильма";
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
            // FilmCountry_Label
            // 
            this.FilmCountry_Label.AutoSize = true;
            this.FilmCountry_Label.Location = new System.Drawing.Point(6, 142);
            this.FilmCountry_Label.Name = "FilmCountry_Label";
            this.FilmCountry_Label.Size = new System.Drawing.Size(123, 13);
            this.FilmCountry_Label.TabIndex = 0;
            this.FilmCountry_Label.Text = "Страна-производитель";
            // 
            // OneMinuteRecordCost_Label
            // 
            this.OneMinuteRecordCost_Label.Location = new System.Drawing.Point(7, 288);
            this.OneMinuteRecordCost_Label.Name = "OneMinuteRecordCost_Label";
            this.OneMinuteRecordCost_Label.Size = new System.Drawing.Size(120, 29);
            this.OneMinuteRecordCost_Label.TabIndex = 0;
            this.OneMinuteRecordCost_Label.Text = "Стоимость записи одной минуты";
            // 
            // FilmYear_TextBox
            // 
            this.FilmYear_TextBox.Location = new System.Drawing.Point(165, 178);
            this.FilmYear_TextBox.Name = "FilmYear_TextBox";
            this.FilmYear_TextBox.Size = new System.Drawing.Size(111, 20);
            this.FilmYear_TextBox.TabIndex = 5;
            // 
            // FilmCountry_TextBox
            // 
            this.FilmCountry_TextBox.Location = new System.Drawing.Point(165, 139);
            this.FilmCountry_TextBox.Name = "FilmCountry_TextBox";
            this.FilmCountry_TextBox.Size = new System.Drawing.Size(111, 20);
            this.FilmCountry_TextBox.TabIndex = 4;
            // 
            // FilmDuration_TextBox
            // 
            this.FilmDuration_TextBox.Location = new System.Drawing.Point(165, 104);
            this.FilmDuration_TextBox.Name = "FilmDuration_TextBox";
            this.FilmDuration_TextBox.Size = new System.Drawing.Size(111, 20);
            this.FilmDuration_TextBox.TabIndex = 3;
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
            this.FilmGanre_TextBox.TabIndex = 2;
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
            this.Add_Button.Location = new System.Drawing.Point(11, 437);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(75, 43);
            this.Add_Button.TabIndex = 8;
            this.Add_Button.Text = "Добавить";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Change_Button
            // 
            this.Change_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change_Button.Location = new System.Drawing.Point(115, 437);
            this.Change_Button.Name = "Change_Button";
            this.Change_Button.Size = new System.Drawing.Size(75, 43);
            this.Change_Button.TabIndex = 4;
            this.Change_Button.Text = "Изменить";
            this.Change_Button.UseVisualStyleBackColor = true;
            this.Change_Button.Click += new System.EventHandler(this.Change_Button_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_Button.Location = new System.Drawing.Point(219, 437);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(75, 43);
            this.Clear_Button.TabIndex = 4;
            this.Clear_Button.Text = "Очистить";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Filters_GroupBox
            // 
            this.Filters_GroupBox.Controls.Add(this.FilterYear);
            this.Filters_GroupBox.Controls.Add(this.YearSort_TextBox);
            this.Filters_GroupBox.Controls.Add(this.ApplyFilter);
            this.Filters_GroupBox.Controls.Add(this.YearSort_RadioButton);
            this.Filters_GroupBox.Controls.Add(this.MinutsSort_RadioButton);
            this.Filters_GroupBox.Location = new System.Drawing.Point(301, 355);
            this.Filters_GroupBox.Name = "Filters_GroupBox";
            this.Filters_GroupBox.Size = new System.Drawing.Size(388, 125);
            this.Filters_GroupBox.TabIndex = 5;
            this.Filters_GroupBox.TabStop = false;
            this.Filters_GroupBox.Text = "Фильтры";
            // 
            // FilterYear
            // 
            this.FilterYear.AutoSize = true;
            this.FilterYear.Location = new System.Drawing.Point(244, 95);
            this.FilterYear.Name = "FilterYear";
            this.FilterYear.Size = new System.Drawing.Size(25, 13);
            this.FilterYear.TabIndex = 3;
            this.FilterYear.Text = "Год";
            // 
            // YearSort_TextBox
            // 
            this.YearSort_TextBox.Location = new System.Drawing.Point(278, 92);
            this.YearSort_TextBox.Name = "YearSort_TextBox";
            this.YearSort_TextBox.Size = new System.Drawing.Size(75, 20);
            this.YearSort_TextBox.TabIndex = 2;
            // 
            // ApplyFilter
            // 
            this.ApplyFilter.Location = new System.Drawing.Point(247, 19);
            this.ApplyFilter.Name = "ApplyFilter";
            this.ApplyFilter.Size = new System.Drawing.Size(131, 44);
            this.ApplyFilter.TabIndex = 1;
            this.ApplyFilter.Text = "Применить фильтр";
            this.ApplyFilter.UseVisualStyleBackColor = true;
            this.ApplyFilter.Click += new System.EventHandler(this.ApplyFilter_Click);
            // 
            // YearSort_RadioButton
            // 
            this.YearSort_RadioButton.Location = new System.Drawing.Point(6, 69);
            this.YearSort_RadioButton.Name = "YearSort_RadioButton";
            this.YearSort_RadioButton.Size = new System.Drawing.Size(227, 65);
            this.YearSort_RadioButton.TabIndex = 0;
            this.YearSort_RadioButton.TabStop = true;
            this.YearSort_RadioButton.Tag = "filter";
            this.YearSort_RadioButton.Text = "Вывести список фильмов, год выпуска которых больше заданного";
            this.YearSort_RadioButton.UseVisualStyleBackColor = true;
            // 
            // MinutsSort_RadioButton
            // 
            this.MinutsSort_RadioButton.Location = new System.Drawing.Point(6, 11);
            this.MinutsSort_RadioButton.Name = "MinutsSort_RadioButton";
            this.MinutsSort_RadioButton.Size = new System.Drawing.Size(266, 65);
            this.MinutsSort_RadioButton.TabIndex = 0;
            this.MinutsSort_RadioButton.TabStop = true;
            this.MinutsSort_RadioButton.Tag = "filter";
            this.MinutsSort_RadioButton.Text = "Вывести список фильмов длительностью более 85 минут";
            this.MinutsSort_RadioButton.UseVisualStyleBackColor = true;
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Text files (*.txt)|*.txt";
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
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(1224, 441);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(112, 34);
            this.Exit_Button.TabIndex = 9;
            this.Exit_Button.Text = "Выход";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 485);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Filters_GroupBox);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Change_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "FilmDatabase";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.Filters_GroupBox.ResumeLayout(false);
            this.Filters_GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File_StripMenuItem;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label FilmYear_Label;
        private System.Windows.Forms.Label VideotapeType_Label;
        private System.Windows.Forms.Label FilmCountry_Label;
        private System.Windows.Forms.Label OneMinuteRecordCost_Label;
        private System.Windows.Forms.TextBox FilmGanre_TextBox;
        private System.Windows.Forms.Label FilmGanre_Label;
        private System.Windows.Forms.TextBox FilmName_TextBox;
        private System.Windows.Forms.Label FilmName_Label;
        private System.Windows.Forms.Label CopyType_Label;
        private System.Windows.Forms.TextBox OneMinuteRecordCost_TextBox;
        private System.Windows.Forms.TextBox FilmRecordCost_TextBox;
        private System.Windows.Forms.Label FilmRecordCost_Label;
        private System.Windows.Forms.TextBox FilmRecordCostWithCopy_TextBox;
        private System.Windows.Forms.Label FilmRecordCostWithCopy_Label;
        private System.Windows.Forms.TextBox FilmDuration_TextBox;
        private System.Windows.Forms.Label FilmDuration_Label;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Change_Button;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.GroupBox Filters_GroupBox;
        private System.Windows.Forms.RadioButton YearSort_RadioButton;
        private System.Windows.Forms.RadioButton MinutsSort_RadioButton;
        private System.Windows.Forms.Button ApplyFilter;
        private System.Windows.Forms.TextBox FilmCountry_TextBox;
        private System.Windows.Forms.TextBox FilmYear_TextBox;
        private System.Windows.Forms.ComboBox VideotapeType_ComboBox;
        private System.Windows.Forms.Label FilterYear;
        private System.Windows.Forms.TextBox YearSort_TextBox;
        private System.Windows.Forms.ComboBox CopyType_ComboBox;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
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
        private System.Windows.Forms.Button Exit_Button;
    }
}

