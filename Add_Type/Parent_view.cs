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

            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.HeaderText = "№ ученика";
            DataGridViewTextBoxColumn st = new DataGridViewTextBoxColumn();
            st.HeaderText = "ФИО ученика";
            DataGridViewTextBoxColumn ph = new DataGridViewTextBoxColumn();
            ph.HeaderText = "Телефон";
            DataGridViewButtonColumn remove = new DataGridViewButtonColumn();
            remove.HeaderText = "Удалить?";

            D.Columns.Add(edit);
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

                D.Rows[i].Cells[0].Value = i + 1 + "✎";   // Отображение счетчика записей и значок редактирования

                D.Rows[i].Cells[1].Value = students[i].ID;

                D.Rows[i].Cells[2].Value = students[i].FIO;

                D.Rows[i].Cells[3].Value = students[i].Phone;

                D.Rows[i].Cells[4].Value = "Удалить";
            }
        }

        private void choosestudent_Click(object sender, EventArgs e)
        {
            Student_find f = new Student_find("choose", "b"); // Передем choose - это означает, что нужно добавить кнопку выбора ученика
            DialogResult result = f.ShowDialog();
            if(f.chooseSt != null)
            {
                chooseStudent = f.chooseSt; // Передаем ссылку форме родителя на переменную из формы поиска учеников
                String answ = parent.addStudent(chooseStudent);
                FillGrid();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void D_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //// Обрабатывается событие нажатия на кнопку "Выбрать"
            //if (purpose == "choose")
            //{
            //    if (e.ColumnIndex == 4)
            //    {
            //        if (e.RowIndex > -1)
            //        {
            //            if (D.RowCount - 1 >= e.RowIndex)
            //            {
            //                int l = e.RowIndex;
            //                int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
            //                chooseSt = Students.StudentID(k);

            //                this.Close();
            //            }
            //        }
            //    }
            //}
            // Обрабатывается событие нажатия на кнопку "Удалить"
            //else
            //{
                if (e.ColumnIndex == 4)
                {
                    if (e.RowIndex > -1)
                    {
                        if (D.RowCount - 1 >= e.RowIndex)
                        {
                            int l = e.RowIndex;
                            const string message = "Вы уверены, что хотите удалить ученика?";
                            const string caption = "Удаление";
                            var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                            if (result == DialogResult.OK)
                            {
                                // Форма не закрывается
                                int k = Convert.ToInt32(D.Rows[l].Cells[0].Value);
                                D.Rows.Remove(D.Rows[l]);
                                Student o = Students.StudentID(k);
                                String ans = o.Del();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Эту строку нельзя удалить, в ней нет данных!");
                        }
                    }
                }
                // Редактирование
                if (e.ColumnIndex == 0)
                {
                    if (e.RowIndex > -1)
                    {
                        if (D.RowCount - 1 >= e.RowIndex)
                        {
                            int l = e.RowIndex;
                            int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
                            Student_edit f = new Student_edit(Students.StudentID(k), false);
                            f.Show();
                        }
                    }
                }
            //}
        }

        private void D_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Открытие формы для просмотра данных
            if (e.RowIndex > -1)
            {
                int l = e.RowIndex;
                int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
                Student_view f = new Student_view(Students.StudentID(k));
                f.Show();
            }
        }
    }
}
