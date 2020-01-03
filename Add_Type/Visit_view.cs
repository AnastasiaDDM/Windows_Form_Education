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
    public partial class Visit_view : Form
    {
        string formattotext = "dd.MM.yyyy"; // Формат для отображения даты в текстовые поля
        public Grade grade;   // Глобальная переменная объявляет объект данной формы
        public Theme theme;   // Глобальная переменная объявляет вспомогательный объект данной формы
        public Timetable timetable;   // Глобальная переменная объявляет вспомогательный объект данной формы
        public Course course;   // Глобальная переменная объявляет вспомогательный объект данной формы
        public Visit_view()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        public Visit_view(Timetable ti, Theme th, Course c) // Конструктор для просмотра объекта
        {
            InitializeComponent();
            this.KeyPreview = true;

            timetable = ti;
            this.Text = this.Text + "   " + timetable.ID + ". " + timetable.Startlesson.ToString(formattotext);
            theme = th;
            course = c;

            Access();
            FillForm();
            buildDG();
            FillGrid();
        }

        public Visit_view(Timetable ti, Course c) // Конструктор для просмотра объекта
        {
            InitializeComponent();
            this.KeyPreview = true;

            timetable = ti;
            this.Text = this.Text + "   " + timetable.ID + ". " + timetable.Startlesson.ToString(formattotext);
            course = c;

            Access();
            FillForm();
            buildDG();
            FillGrid();
        }
        private void Access() // Реализация разделения ролей
        {
            // Заперт на добавление и удаление одиннаковый
            update.Visible = Prohibition.Banned("edit_visit");
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
            DataGridViewCheckBoxColumn mark = new DataGridViewCheckBoxColumn();
            mark.HeaderText = "Присутствие";

            D.Columns.Add(edit);
            D.Columns.Add(st);
            D.Columns.Add(mark);

            D.ReadOnly = true;

        }

        private void FillForm()
        {  
            datet.Text = timetable.Startlesson.ToString(formattotext);
            courset.Text = course.ID + ". " + course.nameGroup;
            cabinett.Text = timetable.CabinetID + ". " + Cabinets.CabinetID(timetable.CabinetID).Number;

            // Список преподавателей
            StringBuilder s = new StringBuilder();
            List<string> teachers = new List<string>();
            foreach (var t in timetable.GetTeachers())
            {
                teachers.Add(t.FIO);
            }
            s.Append(String.Join(", ", teachers));
            teacherst.Text = s.ToString();
             
            // Список тем
            StringBuilder th = new StringBuilder();
            List<string> themes = new List<string>();
            foreach (var y in timetable.GetThemes())
            {
                themes.Add(Themes.ThemeID(y).Tema);
            }
            th.Append(String.Join(", ", themes));
            themest.Text = th.ToString();
        }

        private void FillGrid()
        {
            // Заполняем гриды, комбобоксы
            D.Rows.Clear();

            // Поиск списка всех учеников курса
            Parent parent = new Parent();
            Student student = new Student();
            Contract contract = new Contract();
            int countrecord = 0;
            int page = 1;
            int count = 100;

            List<Student> stud = new List<Student>();
            stud = Students.FindAll(true, parent, student, contract, course, "FIO", "asc", page, count, ref countrecord);

            List<Visit> visits = new List<Visit>();
            visits = timetable.GetVisits();

            for (int i = 0; i < stud.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                D.Rows.Add(row);

                D.Rows[i].Cells[0].Value = i + 1;   // Отображение счетчика записей

                D.Rows[i].Cells[1].Value = stud[i].ID + ". " + stud[i].FIO;

                Visit studvisit = visits.Find(x => x.StudentID == stud[i].ID);

                if (studvisit != null)
                {

                    if (studvisit.Vis == 2)
                    {
                        D.Rows[i].Cells[2].Value = true;
                    }
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            Visit_edit f = new Visit_edit(timetable, theme, course);
            DialogResult result = f.ShowDialog();
            FillGrid();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Visit_view_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void cabinett_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Открытие формы для просмотра данных
            Cabinet_view f = new Cabinet_view(Cabinets.CabinetID(timetable.CabinetID));
            DialogResult result = f.ShowDialog();
            FillGrid();
        }

        private void courset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Открытие формы для просмотра данных
            Course_view f = new Course_view(Courses.CourseID(timetable.CourseID));
            DialogResult result = f.ShowDialog();
            FillGrid();
        }
    }
}
