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
        public static Worker chooseTeacher; // Эта переменная для приема значения из вызываемой(дочерней) формы

        bool WeditBan; // Перменная для хранения доступа к редактированию
        bool WdelBan; // Перменная для хранения доступа к удалению

        bool SeditBan; // Перменная для хранения доступа к редактированию
        bool SdelBan; // Перменная для хранения доступа к удалению
        public Course_view()
        {
            InitializeComponent();
            this.KeyPreview = true;
            Access();
        }
        public Course_view(Course st) // Конструктор для просмотра объекта
        {
            InitializeComponent();
            this.KeyPreview = true;

            course = st;
            this.Text = this.Text + course.ID;

            Access();
            FillForm();
            buildDG();
            FillGrid();
        }

        private void Access() // Реализация разделения ролей
        {
            // Заперт на добавление и удаление одиннаковый
            WdelBan = Prohibition.Banned("add_del_worker");
            addteacher.Enabled = WdelBan;
            WeditBan = Prohibition.Banned("edit_worker");

            SdelBan = Prohibition.Banned("add_del_student");
            addstudent.Enabled = SdelBan;
            SeditBan = Prohibition.Banned("edit_student");
        }
        private void buildDG() //Построение грида 
        {
            // Построение грида преподавателей курса
            gridteacher.Columns.Clear();
            gridteacher.Rows.Clear();

            if (WeditBan == false)
            {
                DataGridViewTextBoxColumn edit = new DataGridViewTextBoxColumn();
                gridteacher.Columns.Add(edit);
            }
            else
            {
                DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
                gridteacher.Columns.Add(edit);
            }

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

            gridteacher.Columns.Add(idt);
            gridteacher.Columns.Add(fiot);
            gridteacher.Columns.Add(pht);
            gridteacher.Columns.Add(pos);
            gridteacher.Columns.Add(rate);


            DataGridViewButtonColumn remove = new DataGridViewButtonColumn();
            remove.HeaderText = "Удалить?";
            gridteacher.Columns.Add(remove);
            gridteacher.Columns[6].Visible = WdelBan;

            gridteacher.ReadOnly = true;

            // Построение грида учеников курса
            gridstudent.Columns.Clear();
            gridstudent.Rows.Clear();

            if (SeditBan == false)
            {
                DataGridViewTextBoxColumn edit1 = new DataGridViewTextBoxColumn();
                gridstudent.Columns.Add(edit1);
            }
            else
            {
                DataGridViewButtonColumn edit1 = new DataGridViewButtonColumn();
                gridstudent.Columns.Add(edit1);
            }

            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.HeaderText = "№ ученика";
            DataGridViewTextBoxColumn st = new DataGridViewTextBoxColumn();
            st.HeaderText = "ФИО ученика";
            DataGridViewTextBoxColumn ph = new DataGridViewTextBoxColumn();
            ph.HeaderText = "Телефон";
            DataGridViewButtonColumn remove2 = new DataGridViewButtonColumn();
            remove2.HeaderText = "Удалить?";

            gridstudent.Columns.Add(id);
            gridstudent.Columns.Add(st);
            gridstudent.Columns.Add(ph);

            gridstudent.Columns.Add(remove2);
            gridstudent.Columns[4].Visible = SdelBan;
            gridstudent.ReadOnly = true;
        }

        private void FillForm()
        {   // Заполнение формы известными данными о договоре
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

        private void timetable_Click(object sender, EventArgs e)
        {
            Timetable_find f = new Timetable_find(course);
            DialogResult result = f.ShowDialog();
        }

        private void gridstudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (SdelBan == true) // Запрета нет
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
                                const string message2 = "Вы собираетесь удалить ученика с курса, нужно ли расторгать договор?";
                                const string caption2 = "Удаление";
                                var result2 = MessageBox.Show(message2, caption2, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                if (result2 == DialogResult.OK)
                                {
                                    int k = Convert.ToInt32(gridstudent.Rows[l].Cells[1].Value);
                                    gridstudent.Rows.Remove(gridstudent.Rows[l]);
                                    Student o = Students.StudentID(k);
                                    String ans = course.delStudent(o);
                                    String answercancel = (Contracts.ContractID(o, course)).Cancellation();
                                }
                                else
                                {
                                    int k = Convert.ToInt32(gridstudent.Rows[l].Cells[1].Value);
                                    gridstudent.Rows.Remove(gridstudent.Rows[l]);
                                    Student o = Students.StudentID(k);
                                    String ans = course.delStudent(o);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Эту строку нельзя удалить, в ней нет данных!");
                        }
                    }
                }
            }
            // Редактирование
            if (e.ColumnIndex == 0)
            {
                if (SeditBan == true) // Запрета нет
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
            }
        }

        private void gridstudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Открытие формы для просмотра данных
            if (e.RowIndex > -1)
            {
                int l = e.RowIndex;
                int k = Convert.ToInt32(gridstudent.Rows[l].Cells[1].Value);
                Student_view f = new Student_view(Students.StudentID(k));
                DialogResult result = f.ShowDialog();
            }
        }

        private void typet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Type_view f = new Type_view(Types.TypeID(course.TypeID));
            DialogResult result = f.ShowDialog();
        }

        private void brancht_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Branch_view f = new Branch_view(Branches.BranchID(course.BranchID));
            DialogResult result = f.ShowDialog();
        }

        private void addteacher_Click(object sender, EventArgs e)
        {
            Worker_find f = new Worker_find("choose"); // Передаем choose - это означает, что нужно добавить кнопку выбора 
            DialogResult result = f.ShowDialog();
            chooseTeacher = f.chooseWor; // Передаем ссылку форме родителей на переменную в этой форме
            if(chooseTeacher != null)
            {
                string a = course.addTeacher(chooseTeacher);
            }
            FillGrid();
        }

        private void addstudent_Click(object sender, EventArgs e)
        {
            // Добавление
            Contract_edit f = new Contract_edit(course, true);  // Передаем true, так как это означает, что нам нужно отображать только неудаленные объекты
            DialogResult result = f.ShowDialog();
            FillGrid();
        }
        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Course_view_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void gridteacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (WdelBan == true) // Запрета нет
                {
                    if (e.RowIndex > -1)
                    {
                        if (gridteacher.RowCount - 1 >= e.RowIndex)
                        {
                            int l = e.RowIndex;
                            const string message = "Вы уверены, что хотите удалить преподавателя с курса?";
                            const string caption = "Удаление";
                            var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                            if (result == DialogResult.OK)
                            {
                                int k = Convert.ToInt32(gridteacher.Rows[l].Cells[1].Value);
                                gridteacher.Rows.Remove(gridteacher.Rows[l]);
                                Worker o = Workers.WorkerID(k);
                                String ans = course.delTeacher(o);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Эту строку нельзя удалить, в ней нет данных!");
                        }
                    }
                }
            }
            // Редактирование
            if (e.ColumnIndex == 0)
            {
                if (WeditBan == true) // Запрета нет
                {
                    if (e.RowIndex > -1)
                    {
                        if (gridteacher.RowCount - 1 >= e.RowIndex)
                        {
                            int l = e.RowIndex;
                            int k = Convert.ToInt32(gridteacher.Rows[l].Cells[1].Value);
                            Worker_edit f = new Worker_edit(Workers.WorkerID(k), false);
                            f.Show();
                        }
                    }
                }
            }
        }
    }
}