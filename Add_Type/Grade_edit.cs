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
    public partial class Grade_edit : Form
    {
        string formattotext = "dd.MM.yyyy"; // Формат для отображения даты в текстовые поля
        public Grade grade;   // Глобальная переменная объявляет объект данной формы
        public Theme theme;   // Глобальная переменная объявляет вспомогательный объект данной формы
        public Timetable timetable;   // Глобальная переменная объявляет вспомогательный объект данной формы
        public Course course;   // Глобальная переменная объявляет вспомогательный объект данной формы
        bool indicator; // Переменная отвечающая за распределение - или добавляется новый объект, или изменяется существующий
        int idforEdit; // ID для редактируемого объекта
        Grade newgrade = new Grade(); // Глобальная перменная этой формы
        public Grade_edit()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public Grade_edit(bool deldate) // Конструктор для добавление нового объекта
        {
            InitializeComponent();
            this.KeyPreview = true;
            indicator = true;

            //buildDG();
        }
        public Grade_edit(Grade grade, bool deldate) // Конструктор для редактирования объекта
        {
            InitializeComponent();
            this.KeyPreview = true;
            indicator = false;
            idforEdit = grade.ID;

            newgrade = grade;
            //buildDG();
            //FillForm();
        }
        public Grade_edit(Timetable ti, Theme th, Course c) // Конструктор для просмотра объекта
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
        private void FillForm()
        {   // Заполнение формы известными данными о договоре
            //this.Text = this.Text + contract.ID;

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
        private void buildDG() //Построение грида 
        {
            D.Columns.Clear();
            D.Rows.Clear();

            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.HeaderText = "№ ";
            DataGridViewTextBoxColumn st = new DataGridViewTextBoxColumn();
            st.HeaderText = "Ученик";
            DataGridViewTextBoxColumn mark1 = new DataGridViewTextBoxColumn();
            mark1.HeaderText = "Оценка";
            DataGridViewTextBoxColumn mark2 = new DataGridViewTextBoxColumn();
            mark2.HeaderText = "Оценка";
            DataGridViewTextBoxColumn mark3 = new DataGridViewTextBoxColumn();
            mark3.HeaderText = "Оценка";
            DataGridViewTextBoxColumn mark4 = new DataGridViewTextBoxColumn();
            mark4.HeaderText = "Оценка";
            DataGridViewTextBoxColumn mark5 = new DataGridViewTextBoxColumn();
            mark5.HeaderText = "Оценка";

            D.Columns.Add(edit);
            D.Columns.Add(st);
            D.Columns.Add(mark1);
            D.Columns.Add(mark2);
            D.Columns.Add(mark3);
            D.Columns.Add(mark4);
            D.Columns.Add(mark5);

            D.ReadOnly = true;
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

            List<Grade> grades = new List<Grade>();
            grades = theme.GetGrades(course);

            for (int i = 0; i < stud.Count; i++) 
            {
                DataGridViewRow row = new DataGridViewRow();

                D.Rows.Add(row);

                D.Rows[i].Cells[0].Value = /*(page - 1) * count + */i + 1;   // Отображение счетчика записей

                D.Rows[i].Cells[1].Value = stud[i].ID + ". " + stud[i].FIO;

                int nextcell = 2;
                List<Grade> gradestud = grades.FindAll(x => x.StudentID == stud[i].ID);

                if (gradestud != null)
                {
                    for (int j = 0; j < gradestud.Count; j++)
                    {
                        D.Rows[i].Cells[nextcell].Value = gradestud[j].Mark;
                        nextcell++;
                    }
                }
            }
        }
    }
}
