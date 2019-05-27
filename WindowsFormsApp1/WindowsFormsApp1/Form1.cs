using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
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
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            DataGrid.Rows.RemoveAt(DataGrid.SelectedCells[0].RowIndex);
        }
    }
}
