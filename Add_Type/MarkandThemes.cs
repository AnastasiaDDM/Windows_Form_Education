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
    public partial class MarkandThemes : Form
    {
        String sort = "ID";
        String asсdesс = "asc";
        int page = 1;
        int count = 100;
        int pages;
        string formattotext = "dd.MM.yyyy"; // Формат для отображения даты в текстовые поля
        public Course course; // Объект "ученик" для построения расписания для ученика
        public Worker teacher; // Объект "преподаватель" для построения расписания для преподавателя
        public Student student; // Объект "ученик" для построения расписания для ученика
        public Branch branch; // Объект "филиал" для построения расписания для филиала

        public Timetable timetable; // Объект "расписание" для построения списка тем по конкретному занятию
        public MarkandThemes()
        {
            InitializeComponent();
        }
        public MarkandThemes(Worker te, Course co, Student st, int br) // Конструктор для просмотра занятий преподавателя
        {
            InitializeComponent();
            this.KeyPreview = true;

            teacher = te;
            course = co;
            student = st;

            if (br != 0)
            {
                branch = Branches.BranchID(br);
            }
            else
            {
                branch = null;
            }

            LoadAll();
        }
        public MarkandThemes(Course st) // Конструктор для просмотра занятий курса
        {
            InitializeComponent();
            this.KeyPreview = true;

            course = st;

            LoadAll();
        }

        public MarkandThemes(Timetable tim, Worker te, Course co, Student st, int br) // Конструктор для просмотра тем конкретного занятия
        {
            InitializeComponent();
            this.KeyPreview = true;

            timetable = tim;

            teacher = te;
            course = co;
            student = st;

            if (br != 0)
            {
                branch = Branches.BranchID(br);
            }
            else
            {
                branch = null;
            }

            buildDG();
            FillGridOneTimetable();
        }

        private void LoadAll()
        {
            buildDG();
            FillGrid();
        }

        private void buildDG() //Построение грида 
        {
            D.Columns.Clear();
            D.Rows.Clear();

            DataGridViewTextBoxColumn edit = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn idtime = new DataGridViewTextBoxColumn();
            idtime.HeaderText = "Занятие";

            DataGridViewTextBoxColumn idcourse = new DataGridViewTextBoxColumn();
            idcourse.HeaderText = "Курс";

            DataGridViewTextBoxColumn idtheme = new DataGridViewTextBoxColumn();
            idtheme.HeaderText = "Тема";

            DataGridViewButtonColumn tomark = new DataGridViewButtonColumn();
            tomark.HeaderText = "Оценивание";

            DataGridViewButtonColumn visit = new DataGridViewButtonColumn();
            visit.HeaderText = "Посещение";

            D.Columns.Add(edit);
            D.Columns.Add(idtime);
            D.Columns.Add(idcourse);
            D.Columns.Add(idtheme);
            D.Columns.Add(tomark);
            D.Columns.Add(visit);

            D.ReadOnly = true;
        }

        private void FillGrid() // Заполняем гриды
        {
            D.Rows.Clear();

            Branch bran = new Branch();
            if (branch != null)
            {
                bran = branch;
                label4.Text = "Занятия филиала ";
                brant.Text = bran.ID + ". " + bran.Name;
            }

            Student stud = new Student();
            if (student != null)
            {
                stud = student;
                label3.Text = "Занятия ученика ";
                studt.Text = stud.ID + ". " + stud.FIO;
            }

            Worker teach = new Worker();
            if (teacher != null)
            {
                teach = teacher;
                label1.Text = "Занятия преподавателя ";
                teacht.Text = teach.ID + ". " + teach.FIO;
            }

            Course cour = new Course();
            if (course != null)
            {
                cour = course;
                label2.Text = "Занятия курса ";
                court.Text = cour.ID + ". " + cour.nameGroup;
            }

            Cabinet cab = new Cabinet();

            DateTime date = DateTime.MinValue;

            int countrecord = 0;

            List<Timetable> timetables = new List<Timetable>();
            timetables = Timetables.FindAll(true, bran, cab, teach, cour, stud, date, sort, asсdesс, page, count, ref countrecord);
            pages = Convert.ToInt32(Math.Ceiling((double)countrecord / count));

            int nextrow = 0;

            for (int i = 0; i < timetables.Count; i++)
            {
                List<int> themesthistimetable = timetables[i].GetThemes();
                foreach ( var theme in themesthistimetable )
                {
                    DataGridViewRow row = new DataGridViewRow();

                    D.Rows.Add(row);

                    D.Rows[nextrow].Cells[0].Value = /*(page - 1) * count +*/ nextrow + 1;   // Отображение счетчика записей и значок редактирования

                    D.Rows[nextrow].Cells[1].Value = timetables[i].ID + ". " + timetables[i].Startlesson.ToString(formattotext);

                    D.Rows[nextrow].Cells[2].Value = timetables[i].CourseID + ". " + Courses.CourseID(timetables[i].CourseID).nameGroup;

                    D.Rows[nextrow].Cells[3].Value = theme + ". " + Themes.ThemeID(theme).Tema;

                    D.Rows[nextrow].Cells[4].Value = "Оценить";

                    D.Rows[nextrow].Cells[5].Value = "Присутствие";
                    nextrow++;
                }
            }
        }


        private void FillGridOneTimetable() // Заполняем гриды
        {
            D.Rows.Clear();

            Branch bran = new Branch();
            if (branch != null)
            {
                bran = branch;
                label4.Text = "Занятия филиала ";
                brant.Text = bran.ID + ". " + bran.Name;
            }

            Student stud = new Student();
            if (student != null)
            {
                stud = student;
                label3.Text = "Занятия ученика ";
                studt.Text = stud.ID + ". " + stud.FIO;
            }

            Worker teach = new Worker();
            if (teacher != null)
            {
                teach = teacher;
                label1.Text = "Занятия преподавателя ";
                teacht.Text = teach.ID + ". " + teach.FIO;
            }

            Course cour = new Course();
            if (course != null)
            {
                cour = course;
                label2.Text = "Занятия курса ";
                court.Text = cour.ID + ". " + cour.nameGroup;
            }

            int nextrow = 0;

            List<int> themesthistimetable = timetable.GetThemes();
            foreach (var theme in themesthistimetable)
            {
                DataGridViewRow row = new DataGridViewRow();

                D.Rows.Add(row);

                D.Rows[nextrow].Cells[0].Value = nextrow + 1;   // Отображение счетчика записей и значок редактирования

                D.Rows[nextrow].Cells[1].Value = timetable.ID + ". " + timetable.Startlesson.ToString(formattotext);

                D.Rows[nextrow].Cells[2].Value = timetable.CourseID + ". " + Courses.CourseID(timetable.CourseID).nameGroup;

                D.Rows[nextrow].Cells[3].Value = theme + ". " + Themes.ThemeID(theme).Tema;

                D.Rows[nextrow].Cells[4].Value = "Оценить";

                D.Rows[nextrow].Cells[5].Value = "Присутствие";
                nextrow++;
            }
        }

        private void D_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Оценивание
            if (e.ColumnIndex == 4)
            {
                if (e.RowIndex > -1)
                {
                    if (D.RowCount - 1 >= e.RowIndex)
                    {
                        int l = e.RowIndex;

                        string[] timeID = (Convert.ToString(D.Rows[l].Cells[1].Value)).Split('.');
                        Timetable time = Timetables.TimetableID(Convert.ToInt32(timeID[0]));

                        string[] themeID = (Convert.ToString(D.Rows[l].Cells[3].Value)).Split('.');
                        Theme theme = Themes.ThemeID(Convert.ToInt32(themeID[0]));

                        string[] courseID = (Convert.ToString(D.Rows[l].Cells[2].Value)).Split('.');
                        Course course = Courses.CourseID(Convert.ToInt32(courseID[0]));

                        Grade_view f = new Grade_view(time, theme, course);
                        DialogResult result = f.ShowDialog();

                        // Условие для того, чтобы определить какое заполнение грида нужно использовать
                        if (timetable != null) // Условие для вывода всех тем только одного занятия
                        {
                            FillGridOneTimetable();
                        }
                        else // Выводятся все темы нескольких занятий
                        {
                            FillGrid();
                        }
                    }
                }
            }

            // Присутствие
            if (e.ColumnIndex == 5)
            {
                if (e.RowIndex > -1)
                {
                    if (D.RowCount - 1 >= e.RowIndex)
                    {
                        int l = e.RowIndex;

                        string[] timeID = (Convert.ToString(D.Rows[l].Cells[1].Value)).Split('.');
                        Timetable time = Timetables.TimetableID(Convert.ToInt32(timeID[0]));

                        string[] themeID = (Convert.ToString(D.Rows[l].Cells[3].Value)).Split('.');
                        Theme theme = Themes.ThemeID(Convert.ToInt32(themeID[0]));

                        string[] courseID = (Convert.ToString(D.Rows[l].Cells[2].Value)).Split('.');
                        Course course = Courses.CourseID(Convert.ToInt32(courseID[0]));

                        Visit_view f = new Visit_view(time, theme, course);
                        DialogResult result = f.ShowDialog();

                        // Условие для того, чтобы определить какое заполнение грида нужно использовать
                        if (timetable != null) // Условие для вывода всех тем только одного занятия
                        {
                            FillGridOneTimetable();
                        }
                        else // Выводятся все темы нескольких занятий
                        {
                            FillGrid();
                        }
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
                        Contract_edit f = new Contract_edit(Contracts.ContractID(k), false);
                        DialogResult result = f.ShowDialog();

                        // Условие для того, чтобы определить какое заполнение грида нужно использовать
                        if (timetable != null) // Условие для вывода всех тем только одного занятия
                        {
                            FillGridOneTimetable();
                        }
                        else // Выводятся все темы нескольких занятий
                        {
                            FillGrid();
                        }
                    }
                }
            }
        }

        private void brant_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Открытие формы для просмотра данных
            Branch_view f = new Branch_view(branch);
            DialogResult result = f.ShowDialog();
        }

        private void court_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Открытие формы для просмотра данных
            Course_view f = new Course_view(course);
            DialogResult result = f.ShowDialog();

            // Условие для того, чтобы определить какое заполнение грида нужно использовать
            if (timetable != null) // Условие для вывода всех тем только одного занятия
            {
                FillGridOneTimetable();
            }
            else // Выводятся все темы нескольких занятий
            {
                FillGrid();
            }
        }

        private void studt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Открытие формы для просмотра данных
            Student_view f = new Student_view(student);
            DialogResult result = f.ShowDialog();
        }

        private void teacht_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Открытие формы для просмотра данных
            Worker_view f = new Worker_view(teacher);
            DialogResult result = f.ShowDialog();
        }

        private void MarkandThemes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
