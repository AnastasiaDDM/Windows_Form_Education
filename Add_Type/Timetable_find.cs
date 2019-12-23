﻿using System;
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
    public partial class Timetable_find : Form
    {
        Boolean deldate = true; // true - неудален false - все!!!
        int count = 20;
        int page = 1;
        String sort = "ID";
        String asсdesс = "asc";
        int pages;
        string formattotext = "dd.MM.yyyy"; // Формат для отображения даты в текстовые поля

        string formathour = "HH:mm"; // Время для ячеек
        public Student student; // Объект "ученик" для построения расписания для ученика
        public Course course; // Объект "ученик" для построения расписания для ученика
        public Worker teacher; // Объект "преподаватель" для построения расписания для преподавателя
        public Cabinet cabinet; // Объект "кабинет" для построения расписания для кабинета
        DateTime date = DateTime.Now; // Неделя показала расписания ( при загрузке подставляется дата сейчас)

        public static Worker chooseTeacher; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public static Student chooseStudent; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public static Course chooseCourse; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public Timetable_find() // Дли просмотра расписания
        {
            InitializeComponent();
            this.KeyPreview = true;

            LoadAll();
        }
        public Timetable_find(string tomark) // Для оценивания и тем
        {
            InitializeComponent();
            this.KeyPreview = true;

            LoadAll();
            if(tomark == "toMark")
            {
                MessageBox.Show("Для оценивания вам нужно выбрать какой-либо фильтр из Поиска и нажать кнопку в правом нижнем углу");
            }
        }
        public Timetable_find(Student st) // Конструктор для просмотра объекта
        {
            InitializeComponent();
            this.KeyPreview = true;

            student = st;

            LoadAll();
        }

        public Timetable_find(Course st) // Конструктор для просмотра объекта
        {
            InitializeComponent();
            this.KeyPreview = true;

            course = st;

            LoadAll();
        }

        public Timetable_find(Worker st) // Конструктор для просмотра объекта
        {
            InitializeComponent();
            this.KeyPreview = true;

            teacher = st;

            LoadAll();
        }

        public Timetable_find(Cabinet st) // Конструктор для просмотра объекта
        {
            InitializeComponent();
            this.KeyPreview = true;

            cabinet = st;

            LoadAll();
        }

        private void LoadAll()
        {
            buildDG();
            FillGrid();
        }

        private void buildDG() //Построение грида 
        {
            // Построение комбобокса филиалов
            Branch branch = new Branch();
            Worker director = new Worker();
            int countrecord = 0;

            List<Branch> branches = new List<Branch>();
            branches = Branches.FindAll(true, branch, director, "ID", "asc", page, count, ref countrecord);

            branchf.Items.Clear();
            branchf.Items.Add("Не выбрано");
            foreach (var s in branches)
            {
                // добавляем один элемент
                branchf.Items.Add(s.ID + ". " + s.Name);
            }
            this.branchf.SelectedIndex = 0;

            // Построение комбобокса кабинетов
            Cabinet cab = new Cabinet();

            List<Cabinet> cabinets = new List<Cabinet>();
            cabinets = Cabinets.FindAll(true, cab, branch, 0, 0, "ID", "asc", page, count, ref countrecord);

            cabinetf.Items.Clear();
            cabinetf.Items.Add("Не выбрано");
            foreach (var s in cabinets)
            {
                // добавляем один элемент
                cabinetf.Items.Add(s.ID + ". " + s.Number);
            }
            this.cabinetf.SelectedIndex = 0;
        }

        private void FillGrid() // Заполняем гриды
        {
            D.Rows.Clear();

            Branch bran = new Branch();
            if (branchf.SelectedItem != null)
            {
                if (branchf.SelectedIndex == 0)
                {
                    bran.ID = 0;
                }
                else
                {
                    string[] branchID = (Convert.ToString(branchf.SelectedItem)).Split('.');
                    bran.ID = Branches.BranchID(Convert.ToInt32(branchID[0])).ID;
                }
            }

            Cabinet cab = new Cabinet();
            if (cabinet != null)
            {
                cab = cabinet;
                cabinetf.SelectedItem = cab.ID + ". " + cab.Number;
            }


            if (cabinetf.SelectedItem != null)
            {
                if (cabinetf.SelectedIndex == 0)
                {
                    cab.ID = 0;
                }
                else
                {
                    string[] cabID = (Convert.ToString(cabinetf.SelectedItem)).Split('.');
                    cab = Cabinets.CabinetID(Convert.ToInt32(cabID[0]));
                    cabinetf.SelectedItem = cab.ID + ". " + cab.Number;
                }
            }

            Student stud = new Student();
            if(student != null)
            {
                stud = student;
                studentf.Text = stud.ID + ". " + stud.FIO;
            }

            Course cour = new Course();
            if (course != null)
            {
                cour = course;
                coursef.Text = cour.ID + ". " + cour.nameGroup;
            }

            Worker teach = new Worker();
            if (teacher != null)
            {
                teach = teacher;
                teacherf.Text = teach.ID + ". " + teach.FIO;
            }

            // Установление значений для полей, которые выбирались по средствам кнопок поиска
            if (chooseStudent != null)
            {
                studentf.Text = chooseStudent.ID + ". " + chooseStudent.FIO;
                stud = chooseStudent;
            }

            if (chooseCourse != null)
            {
                coursef.Text = chooseCourse.ID + ". " + chooseCourse.nameGroup;
                cour = chooseCourse;
            }

            if (chooseTeacher != null)
            {
                teacherf.Text = chooseTeacher.ID + ". " + chooseTeacher.FIO;
                teach = chooseTeacher;
            }

            int countrecord = 0;

            List<Timetable> timetables = new List<Timetable>();
            timetables = Timetables.FindAll(deldate, bran, cab, teach, cour, stud, date, "Startlesson", "asc", page, count, ref countrecord);
            pages = Convert.ToInt32(Math.Ceiling((double)countrecord / count));

            var firstdate = date.AddDays(-((date.DayOfWeek - System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.FirstDayOfWeek + 7) % 7)).Date;           // Самая правильная функция!
 //           DateTime firstdate = date.AddDays(-((date.DayOfWeek - System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.FirstDayOfWeek + 7) % 7)).Date;
            DateTime lastdate = firstdate.AddDays(+6);




            mondayt.Text = firstdate.ToString(formattotext);
            sundayt.Text = lastdate.ToString(formattotext);

            // Заполнение заголовков днем недели и датой
            D.Columns[0].HeaderText = "Понедельник" + "\r" + firstdate.ToString(formattotext);
            D.Columns[1].HeaderText = "Вторник" + "\r" + firstdate.AddDays(1).ToString(formattotext);
            D.Columns[2].HeaderText = "Среда" + "\r" + firstdate.AddDays(2).ToString(formattotext);
            D.Columns[3].HeaderText = "Четверг" + "\r" + firstdate.AddDays(3).ToString(formattotext);
            D.Columns[4].HeaderText = "Пятница" + "\r" + firstdate.AddDays(4).ToString(formattotext);
            D.Columns[5].HeaderText = "Суббота" + "\r" + firstdate.AddDays(5).ToString(formattotext);
            D.Columns[6].HeaderText = "Воскресенье" + "\r" + firstdate.AddDays(6).ToString(formattotext);
            countimetables.Text = "Количестов занятий в неделю: " + countrecord;

            for (int i = 0; i < timetables.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                D.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                D.RowHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;


                D.Rows.Add(row);
                //D.Rows[i].Height = 50;
                // Понедельник
                if (timetables[i].Startlesson.DayOfWeek == DayOfWeek.Monday)
                {
//                    D.Columns[0].HeaderText = "Понедельник" + "\r  " + timetables[i].Startlesson.ToString(formattotext);
                    D.Rows[i].Cells[0].Value = timetables[i].ID + ". " + Courses.CourseID(timetables[i].CourseID).nameGroup + "\r  " + timetables[i].Startlesson.ToString(formathour) + " - "
                        + timetables[i].Endlesson.ToString(formathour) + "  " + Cabinets.CabinetID(timetables[i].CabinetID).Number;
                }

                // Вторник
                if (timetables[i].Startlesson.DayOfWeek == DayOfWeek.Tuesday)
                {
 //                   D.Columns[1].HeaderText = "Вторник" + /*"\r" + */" \n " + timetables[i].Startlesson.ToString(formattotext);
                    D.Rows[i].Cells[1].Value = timetables[i].ID + ". " + Courses.CourseID(timetables[i].CourseID).nameGroup + "\r  " + "  " + timetables[i].Startlesson.ToString(formathour) + " - "
                        + timetables[i].Endlesson.ToString(formathour) + "  " + Cabinets.CabinetID(timetables[i].CabinetID).Number;
                   
                }

                // Среда
                if (timetables[i].Startlesson.DayOfWeek == DayOfWeek.Wednesday)
                {
                    D.Rows[i].Cells[2].Value = timetables[i].ID + ". " + Courses.CourseID(timetables[i].CourseID).nameGroup + "\r  " + timetables[i].Startlesson.ToString(formathour) + " - "
                        + timetables[i].Endlesson.ToString(formathour) + "  " + Cabinets.CabinetID(timetables[i].CabinetID).Number;
                }

                // Четверг
                if (timetables[i].Startlesson.DayOfWeek == DayOfWeek.Thursday)
                {
                    D.Rows[i].Cells[3].Value = timetables[i].ID + ". " + Courses.CourseID(timetables[i].CourseID).nameGroup + "\r  " + "  " + timetables[i].Startlesson.ToString(formathour) + " - "
                        + timetables[i].Endlesson.ToString(formathour) + "  " + Cabinets.CabinetID(timetables[i].CabinetID).Number;
                }

                // Пятница
                if (timetables[i].Startlesson.DayOfWeek == DayOfWeek.Friday)
                {
                    D.Rows[i].Cells[4].Value = timetables[i].ID + ". " + Courses.CourseID(timetables[i].CourseID).nameGroup + "\r  " + "  " + timetables[i].Startlesson.ToString(formathour) + " - "
                        + timetables[i].Endlesson.ToString(formathour) + "  " + Cabinets.CabinetID(timetables[i].CabinetID).Number;
                }

                // Суббота
                if (timetables[i].Startlesson.DayOfWeek == DayOfWeek.Saturday)
                {
                    D.Rows[i].Cells[5].Value = timetables[i].ID + ". " + Courses.CourseID(timetables[i].CourseID).nameGroup + "\r  " + "  " + timetables[i].Startlesson.ToString(formathour) + " - "
                        + timetables[i].Endlesson.ToString(formathour) + "  " + Cabinets.CabinetID(timetables[i].CabinetID).Number;
                }

                // Воскресенье
                if (timetables[i].Startlesson.DayOfWeek == DayOfWeek.Sunday)
                {
                    D.Rows[i].Cells[6].Value = timetables[i].ID + ". " + Courses.CourseID(timetables[i].CourseID).nameGroup + "\r  " + "  " + timetables[i].Startlesson.ToString(formathour) + " - "
                        + timetables[i].Endlesson.ToString(formathour) + "  " + Cabinets.CabinetID(timetables[i].CabinetID).Number;
                }
            }
        }

        private void Timetable_find_Load(object sender, EventArgs e)
        {
            date = DateTime.Now;
            LoadAll();
        }

        private void prev_Click(object sender, EventArgs e)
        {
            date = date.AddDays(-7);
            FillGrid();
        }

        private void next_Click(object sender, EventArgs e)
        {
            date = date.AddDays(+7);
            FillGrid();
        }

        private void bwor_Click(object sender, EventArgs e)
        {
            Worker_find f = new Worker_find("choose", 3); // Передем choose - это означает, что нужно добавить кнопку выбора родителя
            DialogResult result = f.ShowDialog();
            chooseTeacher = f.chooseWor; // Передаем ссылку форме родителей на переменную в этой форме
            FillGrid();
        }

        private void find_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void bcour_Click(object sender, EventArgs e)
        {
            Course_find f = new Course_find("choose"); // Передем choose - это означает, что нужно добавить кнопку выбора 
            DialogResult result = f.ShowDialog();
            chooseCourse = f.chooseCour; // Передаем ссылку форме родителей на переменную в этой форме
            FillGrid();
        }

        private void bstud_Click(object sender, EventArgs e)
        {
            Student_find f = new Student_find("choose"); // Передем choose - это означает, что нужно добавить кнопку выбора родителя
            DialogResult result = f.ShowDialog();
            chooseStudent = f.chooseSt; // Передаем ссылку форме родителей на переменную в этой форме
            FillGrid();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            // Сброс всех выбранных значений в значения по умолчанию
            this.branchf.SelectedIndex = 0;
            this.cabinetf.SelectedIndex = 0;
            datef.Value = DateTime.Now;
            teacherf.Clear();
            chooseTeacher = null;
            studentf.Clear();
            chooseStudent = null;
            coursef.Clear();
            chooseCourse = null;
            FillGrid();
        }

        private void toMarkandThemes_Click(object sender, EventArgs e)
        {
            if(chooseTeacher != null | chooseCourse != null | chooseStudent != null | this.branchf.SelectedIndex != 0)
            {
                MarkandThemes f = new MarkandThemes(chooseTeacher, chooseCourse, chooseStudent, this.branchf.SelectedIndex); // Передаем 
                DialogResult result = f.ShowDialog();
      //          chooseStudent = f.chooseSt; // Передаем ссылку форме родителей на переменную в этой форме
                FillGrid();
            }
            else
            {
                MessageBox.Show("Для начала вам нужно выбрать какой-либо фильтр из Поиска.");
            }
        }

        private void cabinetf_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //if (cabinetf.SelectedItem != null)
            //{
            //    if (cabinetf.SelectedIndex == 0)
            //    {
            //    }
            //    else
            //    {
            //        string[] cabID = (Convert.ToString(cabinetf.SelectedItem)).Split('.');
            //        Cabinet cab = Cabinets.CabinetID(Convert.ToInt32(cabID[0]));
            //        branchf.SelectedItem = cab.ID + ". " + Branches.BranchID(Convert.ToInt32(cab.ID)).Name;
            //        //cabinetf.SelectedItem = cab.ID + ". " + cab.Number;
            //    }
            //}
        }

        private void D_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Открытие формы для просмотра данных
            if (e.RowIndex > -1)
            {
                int l = e.RowIndex;
                int k = e.ColumnIndex;
                if(D.Rows[l].Cells[k].Value != null)
                {
                    string[] timeID = (Convert.ToString(D.Rows[l].Cells[k].Value)).Split('.');
                    Timetable timet = Timetables.TimetableID(Convert.ToInt32(timeID[0]));
                    Timetable_view f = new Timetable_view(timet);
                    DialogResult result = f.ShowDialog();
                    FillGrid();
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            // Добавление нового
            Timetable_edit f = new Timetable_edit(true); // Значит, что происходит добавление нового
            DialogResult result = f.ShowDialog();
            FillGrid();
        }

        private void Timetable_find_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
