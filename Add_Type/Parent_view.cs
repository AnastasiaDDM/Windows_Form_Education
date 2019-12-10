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
    public partial class Parent_view : Form
    {
        public Parent parent;   // Глобальная переменная объявляет родителя данной формы
        public Student chooseStudent;
        public Parent_view()
        {
            InitializeComponent();
        }
        public Parent_view(Parent par) // Конструктор для просмотра объекта
        {
            InitializeComponent();

            parent = par;

            FillForm();
            buildDG();
            FillGrid();
        }

        private void FillForm()
        {
            this.Text = this.Text + parent.ID;
            fiot.Text = parent.FIO;
            phonet.Text = parent.Phone;
        }

        private void buildDG() //Построение грида 
        {
            D.Columns.Clear();
            D.Rows.Clear();

            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.HeaderText = "№ ученика";
            DataGridViewTextBoxColumn st = new DataGridViewTextBoxColumn();
            st.HeaderText = "ФИО ученика";
            DataGridViewTextBoxColumn ph = new DataGridViewTextBoxColumn();
            ph.HeaderText = "Телефон";
            DataGridViewButtonColumn remove = new DataGridViewButtonColumn();
            remove.HeaderText = "Удалить?";

            D.Columns.Add(id);
            D.Columns.Add(st);
            D.Columns.Add(ph);
            D.Columns.Add(remove);
            D.ReadOnly = true;
        }

        private void FillGrid() // Заполняем гриды
        {
            D.Rows.Clear();
            List<Student> students = new List<Student>();
            students = parent.GetStudents();
            for (int i = 0; i < students.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                D.Rows.Add(row);

                D.Rows[i].Cells[0].Value = students[i].ID;

                D.Rows[i].Cells[1].Value = students[i].FIO;

                D.Rows[i].Cells[2].Value = students[i].Phone;

                D.Rows[i].Cells[3].Value = "Удалить";
            }
        }

        private void choosestudent_Click(object sender, EventArgs e)
        {
            Student_find f = new Student_find("choose"); // Передем choose - это означает, что нужно добавить кнопку выбора ученика
            DialogResult result = f.ShowDialog();
            chooseStudent = f.chooseSt; // Передаем ссылку форме родителя на переменную из формы поиска учеников
            String answ = parent.addStudent(chooseStudent);
            FillGrid();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
