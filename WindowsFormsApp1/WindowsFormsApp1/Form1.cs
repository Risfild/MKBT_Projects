using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public List<string> list = new List<string>();
        public int OneMinuteRecordCostValue = 30;

        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            int FilmRecordCost = OneMinuteRecordCostValue * int.Parse(FilmDuration_TextBox.Text);
            double FinalCost;
            if (CopyType_ComboBox.Text == "Лазерная")
                FinalCost = FilmRecordCost * 1.2;
            else if (CopyType_ComboBox.Text == "Первая")
                FinalCost = FilmRecordCost * 1.1;
            else
                FinalCost = FilmRecordCost;

            DataGrid.Rows.Add(FilmName_TextBox.Text, FilmGanre_TextBox.Text, FilmDuration_TextBox.Text, FilmCountry_TextBox.Text, FilmYear_TextBox.Text, VideotapeType_ComboBox.Text, CopyType_ComboBox.Text, "30", FilmRecordCost, FinalCost);

            FilmName_TextBox.Text = null;
            FilmGanre_TextBox.Text = null;
            FilmDuration_TextBox.Text = null;
            FilmCountry_TextBox.Text = null;
            FilmYear_TextBox.Text = null;
            VideotapeType_ComboBox.Text = null;
            CopyType_ComboBox.Text = null;
        }


        private void Clear_Button_Click(object sender, EventArgs e)
        {
            if(DataGrid.SelectedCells != null)
            DataGrid.Rows.RemoveAt(DataGrid.SelectedCells[0].RowIndex);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream stream;
            StreamReader reader;

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                stream = openFileDialog.OpenFile();
                reader = new StreamReader(stream);

                string[] DTStringRows = reader.ReadToEnd().Split('\n');
                DataGrid.RowCount = DTStringRows.Length;


                for (int i = 0; i < DTStringRows.Length - 1; i++)
                {
                    string[] currentRowValues = DTStringRows[i].Split('|');

                    for (int j = 0; j < DataGrid.ColumnCount; j++)
                    {
                        DataGrid.Rows[i].Cells[j].Value = currentRowValues[j];
                    }
                }

                reader.Close();
                stream.Close();
            }

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream stream = saveFileDialog.OpenFile();
                StreamWriter writer = new StreamWriter(stream);
                List<string> DatabaseInformation = new List<string>();
                string text = null;

                for (int i = 0; i < DataGrid.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < DataGrid.ColumnCount; j++)
                    {
                        text += DataGrid.Rows[i].Cells[j].Value + "|";
                    }
                    writer.WriteLine(text);
                    text = null;
                }
                writer.Close();
                stream.Close();
            }
        }

        private void Change_Button_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = DataGrid.Rows[DataGrid.SelectedCells[0].RowIndex];
            FilmName_TextBox.Text = (string)row.Cells[0].Value;
            FilmGanre_TextBox.Text = (string)row.Cells[1].Value;
            FilmDuration_TextBox.Text = (string)row.Cells[2].Value;
            FilmCountry_TextBox.Text = (string)row.Cells[3].Value;
            FilmYear_TextBox.Text = (string)row.Cells[4].Value;
            VideotapeType_ComboBox.Text = (string)row.Cells[5].Value;
            CopyType_ComboBox.Text = (string)row.Cells[6].Value;
            DataGrid.Rows.RemoveAt(DataGrid.SelectedCells[0].RowIndex);
        }

        private void ApplyFilter_Click(object sender, EventArgs e)
        {
            if(MinutsSort_RadioButton.Checked)
            {
                int sortField = 2;
                for (int i = 0; i < DataGrid.RowCount - 1; i++)
                {
                    if (int.Parse(DataGrid.Rows[i].Cells[sortField].Value.ToString()) <= 85)
                        DataGrid.Rows.RemoveAt(i);
                }
            }
            else
            {
                int sortField = 4;

                for (int i = 0; i < DataGrid.RowCount - 1; i++)
                    if (int.Parse(DataGrid.Rows[i].Cells[sortField].Value.ToString()) < int.Parse(YearSort_TextBox.Text))
                        DataGrid.Rows.RemoveAt(i);
            }
        }

        private void Sort1_Click(object sender, EventArgs e)
        {
            //DataGrid.Sort()
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
