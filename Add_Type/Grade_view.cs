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
    public partial class Grade_view : Form
    {
        string formattotext = "dd.MM.yyyy"; // Формат для отображения даты в текстовые поля
        public Grade grade;   // Глобальная переменная объявляет объект данной формы
        public Theme theme;   // Глобальная переменная объявляет вспомогательный объект данной формы
        public Timetable timetable;   // Глобальная переменная объявляет вспомогательный объект данной формы
        public Course course;   // Глобальная переменная объявляет вспомогательный объект данной формы
        public Grade_view()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public Grade_view(Timetable ti, Theme th, Course c) // Конструктор для просмотра объекта
        {
            InitializeComponent();
            this.KeyPreview = true;

            timetable = ti;
            theme = th;
            course = c;

            FillForm();
            buildDG();
            FillGrid();
        }

        private void buildDG() //Построение грида 
        {
            D.Columns.Clear();
            D.Rows.Clear();

            DataGridViewTextBoxColumn edit = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.HeaderText = "№ ";
            DataGridViewTextBoxColumn st = new DataGridViewTextBoxColumn();
            st.HeaderText = "Ученик";
            DataGridViewTextBoxColumn mark = new DataGridViewTextBoxColumn();
            mark.HeaderText = "Оценка";

            D.Columns.Add(edit);
            D.Columns.Add(id);
            D.Columns.Add(st);
            D.Columns.Add(mark);

            D.ReadOnly = true;

        }

        private void FillForm()
        {   // Заполнение формы 

            datet.Text = timetable.Startlesson.ToString(formattotext);
            themet.Text = theme.ID + ". " + theme.Tema;
            courset.Text = course.ID + ". " + course.nameGroup;

            StringBuilder s = new StringBuilder();
            List<string> teachers = new List<string>();
            foreach (var t in timetable.GetTeachers())
            {
                teachers.Add(t.FIO);
            }
            s.Append(String.Join(", ", teachers));
            teacherst.Text = s.ToString();
        }

        private void FillGrid()
        {
            // Заполняем гриды, комбобоксы
            D.Rows.Clear();
            List<Grade> grades = new List<Grade>();
            grades = theme.GetGrades(course);
            for (int i = 0; i < grades.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                D.Rows.Add(row);

                D.Rows[i].Cells[0].Value = /*(page - 1) * count + */i + 1;   // Отображение счетчика записей

                D.Rows[i].Cells[1].Value = grades[i].ID;

                D.Rows[i].Cells[2].Value = grades[i].StudentID + ". " + Students.StudentID(grades[i].StudentID).FIO;

                D.Rows[i].Cells[3].Value = grades[i].Mark;
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            Grade_edit f = new Grade_edit(timetable, theme, course);
            DialogResult result = f.ShowDialog();
            FillGrid();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Grade_view_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
