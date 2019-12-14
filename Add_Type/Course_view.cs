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
    public partial class Course_view : Form
    {
        public Course course;   // Глобальная переменная объявляет объект данной формы
        public Course_view()
        {
            InitializeComponent();
        }
        public Course_view(Course st) // Конструктор для просмотра объекта
        {
            InitializeComponent();

            course = st;

            FillForm();
            buildDG();
            FillGrid();
        }
        private void buildDG() //Построение грида 
        {
            // Построение грида преподавателей курса
            gridteacher.Columns.Clear();
            gridteacher.Rows.Clear();

            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            DataGridViewTextBoxColumn idt = new DataGridViewTextBoxColumn();
            idt.HeaderText = "№";
            DataGridViewTextBoxColumn fiot = new DataGridViewTextBoxColumn();
            fiot.HeaderText = "ФИО";
            DataGridViewTextBoxColumn pht = new DataGridViewTextBoxColumn();
            pht.HeaderText = "Телефон";
            DataGridViewTextBoxColumn pos = new DataGridViewTextBoxColumn();
            pos.HeaderText = "Должность";
            DataGridViewTextBoxColumn rate = new DataGridViewTextBoxColumn();
            rate.HeaderText = "Ставка";

            gridteacher.Columns.Add(edit);
            gridteacher.Columns.Add(idt);
            gridteacher.Columns.Add(fiot);
            gridteacher.Columns.Add(pht);
            gridteacher.Columns.Add(pos);
            gridteacher.Columns.Add(rate);


            DataGridViewButtonColumn remove = new DataGridViewButtonColumn();
            remove.HeaderText = "Удалить?";
            gridteacher.Columns.Add(remove);
            gridteacher.ReadOnly = true;

            // Построение грида учеников курса
            gridstudent.Columns.Clear();
            gridstudent.Rows.Clear();

            DataGridViewButtonColumn edit2 = new DataGridViewButtonColumn();
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.HeaderText = "№ ученика";
            DataGridViewTextBoxColumn st = new DataGridViewTextBoxColumn();
            st.HeaderText = "ФИО ученика";
            DataGridViewTextBoxColumn ph = new DataGridViewTextBoxColumn();
            ph.HeaderText = "Телефон";
            DataGridViewButtonColumn remove2 = new DataGridViewButtonColumn();
            remove2.HeaderText = "Удалить?";

            gridstudent.Columns.Add(edit2);
            gridstudent.Columns.Add(id);
            gridstudent.Columns.Add(st);
            gridstudent.Columns.Add(ph);
            gridstudent.Columns.Add(remove2);
            gridstudent.ReadOnly = true;
        }

        private void FillForm()
        {   // Заполнение формы известными данными о договоре
            this.Text = this.Text + course.ID;
            namet.Text = course.nameGroup;
            typet.Text = course.TypeID + ". " + Types.TypeID(course.TypeID).Name;
            brancht.Text = course.BranchID + ". " + Branches.BranchID(course.BranchID).Name;
            costt.Text = course.Cost.ToString();
            datefrom.Value = Convert.ToDateTime(course.Start);
            dateto.Value = Convert.ToDateTime(course.End);
        }

        private void FillGrid()
        {
            // Заполняем гриды, комбобоксы

            gridstudent.Rows.Clear();
            List<Student> students = new List<Student>();
            students = course.GetStudents();
            for (int i = 0; i < students.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                gridstudent.Rows.Add(row);

                gridstudent.Rows[i].Cells[0].Value = /*(page - 1) * count +*/ i + 1 + "✎";   // Отображение счетчика записей и значок редактирования

                gridstudent.Rows[i].Cells[1].Value = students[i].ID;

                gridstudent.Rows[i].Cells[2].Value = students[i].FIO;

                gridstudent.Rows[i].Cells[3].Value = students[i].Phone;

                gridstudent.Rows[i].Cells[4].Value = "Удалить";
            }


            gridteacher.Rows.Clear();
            List<Worker> teachers = new List<Worker>();
            teachers = course.GetTeachers();
            for (int i = 0; i < teachers.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                gridteacher.Rows.Add(row);

                gridteacher.Rows[i].Cells[0].Value = /*(page - 1) * count +*/ i + 1 + "✎";   // Отображение счетчика записей и значок редактирования

                gridteacher.Rows[i].Cells[1].Value = teachers[i].ID;

                gridteacher.Rows[i].Cells[2].Value = teachers[i].FIO;

                gridteacher.Rows[i].Cells[3].Value = teachers[i].Phone;

                gridteacher.Rows[i].Cells[4].Value = teachers[i].Position;

                gridteacher.Rows[i].Cells[5].Value = teachers[i].Rate;

                gridteacher.Rows[i].Cells[6].Value = "Удалить";
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addstudent_Click(object sender, EventArgs e)
        {
            // Добавление
            Contract_edit f = new Contract_edit(course, true);  // Передаем true, так как это означает, что нам нужно отображать только неудаленные объекты
            DialogResult result = f.ShowDialog();
            FillGrid();
        }

        private void timetable_Click(object sender, EventArgs e)
        {
            Timetable_find f = new Timetable_find(course);
            f.Show();
        }

        private void gridstudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    if (gridstudent.RowCount - 1 >= e.RowIndex)
                    {
                        int l = e.RowIndex;
                        const string message = "Вы уверены, что хотите удалить ученика?";
                        const string caption = "Удаление";
                        var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (result == DialogResult.OK)
                        {
                            // Форма не закрывается
                            int k = Convert.ToInt32(gridstudent.Rows[l].Cells[0].Value);
                            gridstudent.Rows.Remove(gridstudent.Rows[l]);
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
                    if (gridstudent.RowCount - 1 >= e.RowIndex)
                    {
                        int l = e.RowIndex;
                        int k = Convert.ToInt32(gridstudent.Rows[l].Cells[1].Value);
                        Student_edit f = new Student_edit(Students.StudentID(k), false);
                        f.Show();
                    }
                }
            }
            //}
        }

        private void gridstudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Открытие формы для просмотра данных
            if (e.RowIndex > -1)
            {
                int l = e.RowIndex;
                int k = Convert.ToInt32(gridstudent.Rows[l].Cells[1].Value);
                Student_view f = new Student_view(Students.StudentID(k));
                f.Show();
            }
        }
    }
}