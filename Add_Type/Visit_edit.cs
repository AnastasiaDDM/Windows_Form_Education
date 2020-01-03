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
    public partial class Visit_edit : Form
    {
        string formattotext = "dd.MM.yyyy"; // Формат для отображения даты в текстовые поля
        public Grade grade;   // Глобальная переменная объявляет объект данной формы
        public Theme theme;   // Глобальная переменная объявляет вспомогательный объект данной формы
        public Timetable timetable;   // Глобальная переменная объявляет вспомогательный объект данной формы
        public Course course;   // Глобальная переменная объявляет вспомогательный объект данной формы
        bool indicator; // Переменная отвечающая за распределение - или добавляется новый объект, или изменяется существующий
        int idforEdit; // ID для редактируемого объекта
        Grade newgrade = new Grade(); // Глобальная перменная этой формы
        public Visit_edit()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public Visit_edit(Timetable ti, Theme th, Course c) // Конструктор для редактирования объекта
        {
            InitializeComponent();
            this.KeyPreview = true;

            timetable = ti;
            this.Text = this.Text + "   " + timetable.ID + ". " + timetable.Startlesson.ToString(formattotext);
            theme = th;
            course = c;

            FillForm();
            buildDG();
            FillGrid();
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
            D.Columns.Add(id);
            D.Columns.Add(mark);
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
                D.Rows[i].Cells[0].ReadOnly = true;

                D.Rows[i].Cells[1].Value = stud[i].ID + ". " + stud[i].FIO;
                D.Rows[i].Cells[1].ReadOnly = true;

                Visit studvisit = visits.Find(x => x.StudentID == stud[i].ID);

                if (studvisit != null)
                {
                    D.Rows[i].Cells[2].Value = studvisit.ID;
                    D.Rows[i].Cells[2].ReadOnly = true;

                    if (studvisit.Vis == 2)
                    {
                        D.Rows[i].Cells[3].Value = true;
                        D.Rows[i].Cells[3].ReadOnly = false;
                    }
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            ////if (D.RowCount > 1)
            ////{
            ////    for (int i = 0; i < D.RowCount - 1; i++)
            ////    {
            ////        if( D.Rows[i].Cells[2].Value != null ) // редактирование посещаемости
            ////        {
            ////            Visit updatevisit = Visits.VisitID(Convert.ToInt32(D.Rows[i].Cells[2].Value));
            ////            if((Boolean)D.Rows[i].Cells[3].Value == true)        //  НЕ РАБОТАЕТ !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            ////            {
            ////                updatevisit.Vis = 2;
            ////            }
            ////            else
            ////            {
            ////                updatevisit.Vis = 1;
            ////            }

            ////            string answer = updatevisit.Edit();
            ////        }
            ////        else // Добавление посещения
            ////        {
            ////            Visit newvisit = new Visit();
            ////            string[] studID = (Convert.ToString(D.Rows[i].Cells[1].Value)).Split('.');
            ////            newvisit.StudentID = Convert.ToInt32(studID[0]);

            ////            newvisit.TimetableID = timetable.ID;

            ////            if (D.Rows[i].Cells[3].Selected == true)    //  НЕ РАБОТАЕТ !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            ////            {
            ////                newvisit.Vis = 2;
            ////            }
            ////            else
            ////            {
            ////                newvisit.Vis = 1;
            ////            }

            ////            string answer = newvisit.Add();
            ////        }
            ////    }
            ////}




            // if (D.RowCount > 1) // Что за хрень?
            if (D.RowCount > 0)
            {
                //  for (int i = 0; i < D.RowCount - 1; i++) // Что за хрень?
                for (int i = 0; i < D.RowCount; i++)
                {
                    if (D.Rows[i].Cells[2].Value != null) // редактирование посещаемости
                    {
                        Visit updatevisit = Visits.VisitID(Convert.ToInt32(D.Rows[i].Cells[2].Value));
                        //if ((Boolean)D.Rows[i].Cells[3].Value == true)        //  НЕ РАБОТАЕТ !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                        if ((Boolean?)D.Rows[i].Cells[3].Value == true)
                        {
                            updatevisit.Vis = 2;
                        }
                        else
                        {
                            updatevisit.Vis = 1;
                        }

                        updatevisit.Edit();
                    }
                    else // Добавление посещения
                    {
                        Visit newvisit = new Visit();
                        string[] studID = (Convert.ToString(D.Rows[i].Cells[1].Value)).Split('.');
                        newvisit.StudentID = Convert.ToInt32(studID[0]);

                        newvisit.TimetableID = timetable.ID;

                        //if (D.Rows[i].Cells[3].Selected == true)    //  НЕ РАБОТАЕТ !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                        if ((Boolean?)D.Rows[i].Cells[3].Value == true)
                        {
                            newvisit.Vis = 2;
                        }
                        else
                        {
                            newvisit.Vis = 1;
                        }

                        newvisit.Add();
                    }
                }
            }
            Close();





            //List<Visit> oldvisits = timetable.GetVisits();
            //String answer = timetable.delOldVisits();

            //List<Visit> newvisits = new List<Visit>();

            ////if (D.RowCount > 1)
            ////{
            //    for (int i = 0; i <= D.RowCount - 1; i++)
            //    {
            //        //if (D.Rows[i].Cells[2].Value != null) // редактирование посещаемости
            //        //{

            //            Visit newvisit = new Visit();
            //            string[] studID = (Convert.ToString(D.Rows[i].Cells[1].Value)).Split('.');
            //            newvisit.StudentID = Convert.ToInt32(studID[0]);

            //            newvisit.TimetableID = timetable.ID;

            //            if (D.Rows[i].Cells[3].Selected == true)    //  НЕ РАБОТАЕТ !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //            {
            //                newvisit.Vis = 2;
            //            }
            //            else
            //            {
            //                newvisit.Vis = 1;
            //            }

            //            newvisits.Add(newvisit);
            //        //}
            //    }
            //String answertwo = timetable.addNewVisits(newvisits);
            ////}

            //if(answertwo == "Успешно")
            //{
            //    Close();
            //}
        }

        private void Visit_edit_KeyDown(object sender, KeyEventArgs e)
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

        private void allf_Click(object sender, EventArgs e)
        {
            if (D.RowCount > 0)
            {
                for (int i = 0; i < D.RowCount; i++)
                {
                    if ((Boolean?)D.Rows[i].Cells[3].Value == false | (Boolean?)D.Rows[i].Cells[3].Value == null)
                    {
                        D.Rows[i].Cells[3].Value = true;
                    }
                }
            }
        }

        private void nobodyf_Click(object sender, EventArgs e)
        {
            if (D.RowCount > 0)
            {
                for (int i = 0; i < D.RowCount; i++)
                {
                    if ((Boolean?)D.Rows[i].Cells[3].Value == true | (Boolean?)D.Rows[i].Cells[3].Value == null)
                    {
                        D.Rows[i].Cells[3].Value = false;
                    }
                }
            }
        }
    }
}
