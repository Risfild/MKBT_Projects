using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;


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
            DataGrid.Rows.RemoveAt(DataGrid.SelectedCells[0].RowIndex);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("file.txt");
            List<string> DatabaseInformation = new List<string>();
            string text = null;

            for (int i = 0; i < DataGrid.Rows.Count - 1; i++)
            {
                for (int j = 0; j < DataGrid.ColumnCount; j++)
                {
                    text += " " + DataGrid.Rows[i].Cells[j].Value;   
                }
                DatabaseInformation.Add(text);
            }
            File.WriteAllLines("text.txt", DatabaseInformation.ToArray());
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
    }
}
