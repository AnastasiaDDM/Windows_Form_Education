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
    public partial class addGrade : Form
    {
        public int grade = 0; // Выбранное значение оценки
        public int indicator; // Отображает добавить(1) или удалить(0) оценку
        public addGrade(int oldgrade)
        {
            InitializeComponent();
            gradet.Value = oldgrade;
        }

        private void add_Click(object sender, EventArgs e)
        {
           if( gradet.Value !=0 )
            {
                indicator = 1;
                grade = Convert.ToInt32(gradet.Value);
                Close();
            }
            else
            {
                errorProvider1.SetError(gradet, "Выберите значение оценки, она не может равняться 0");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            grade = 0;
            Close();
        }

        private void del_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите удалить оценку? Данные возврату не подлежат!", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                indicator = 0;
                grade = Convert.ToInt32(gradet.Value);
                Close();
                //int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
                //D.Rows.Remove(D.Rows[l]);
                //Grade o = Grades.GradeID(k);
                //String ans = o.Del();
            }
        }

        private void addGrade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
