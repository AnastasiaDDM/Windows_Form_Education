using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add_Type
{
    public partial class Cabinet_view : Form
    {
        public Cabinet cabinet;   // Глобальная переменная объявляет объект данной формы
        public Cabinet_view()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public Cabinet_view(Cabinet st) // Конструктор для просмотра объекта
        {
            InitializeComponent();
            this.KeyPreview = true;

            cabinet = st;

            FillForm();
        }
        private void FillForm()
        {   // Заполнение формы известными данными о филиале
            this.Text = this.Text + cabinet.ID;
            numbert.Text = cabinet.Number;
            capacityt.Text = cabinet.Capacity.ToString();
            brancht.Text = cabinet.BranchID + ". " + Branches.BranchID(cabinet.BranchID).Name;
        }

        private void brancht_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Открытие формы для просмотра данных
            Branch_view f = new Branch_view(Branches.BranchID(Convert.ToInt32(cabinet.BranchID)));
            DialogResult result = f.ShowDialog();
            FillForm();
        }

        private void timetable_Click(object sender, EventArgs e)
        {
            Timetable_find f = new Timetable_find(cabinet);
            DialogResult result = f.ShowDialog();
        }

        private void Cabinet_view_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
