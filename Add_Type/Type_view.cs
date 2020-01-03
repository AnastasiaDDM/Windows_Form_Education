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
    public partial class Type_view : Form
    {
        public Type type;   // Глобальная переменная объявляет объект данной формы
        public Type_view()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public Type_view(Type typ) // Конструктор для просмотра объекта
        {
            InitializeComponent();
            this.KeyPreview = true;

            type = typ;
            this.Text = this.Text + type.ID;

            FillForm();
        }

        private void FillForm()
        {   // Заполнение формы известными данными о договоре
            namet.Text = type.Name;
            montht.Text = type.Month.ToString();
            lessont.Text = type.Lessons.ToString();
            costt.Text = type.Cost.ToString();
            notet.Text = type.Note;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bcour_Click(object sender, EventArgs e)
        {
            Course_find f = new Course_find(type); // Передем тип курса
            DialogResult result = f.ShowDialog();
        }

        private void Type_view_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void createtemplate_Click(object sender, EventArgs e)
        {
            string a = type.createTemplate();
            MessageBox.Show(a);
        }

        private void opentemlate_Click(object sender, EventArgs e)
        {
            string answer = type.openTemplate();
            if(answer != "Успешно")
            {
                MessageBox.Show(answer);
            }
        }
    }
}
