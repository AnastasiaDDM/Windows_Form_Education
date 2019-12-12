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
    public partial class Timetable_find : Form
    {
        Boolean deldate = true; // true - неудален false - все!!!
        int count = 20;
        int page = 1;
        String sort = "ID";
        String asсdesс = "asc";
        int pages;
        string formattotext = "dd.MM.yyyy"; // Формат для отображения даты в текстовые поля
        public Student student; // Объект "ученик" для построения расписания для ученика
        DateTime date = DateTime.Now; // Неделя показала расписания ( при загрузке подставляется дата сейчас)
        public Timetable_find()
        {
            InitializeComponent();
        }
        public Timetable_find(Student st) // Конструктор для просмотра объекта
        {
            InitializeComponent();

            student = st;

            LoadAll();
        }

        private void LoadAll()
        {
            FillGrid();
        }

        private void FillGrid() // Заполняем гриды
        {
            D.Rows.Clear();

            Branch bran = new Branch();
            Worker teach = new Worker();
            Student stud = new Student();
            stud = student;
            Parent parent = new Parent();
            if (stud != null)
            {
                studentf.Text = stud.ID + ". " + stud.FIO;
                //parent = Parents.ParentID(chooseParent.ID);
            }
            Course cour = new Course();
            Cabinet cab = new Cabinet();

            int countrecord = 0;

            List<Timetable> timetables = new List<Timetable>();
            timetables = Timetables.FindAll(deldate, bran, cab, teach, cour, stud, date, sort, asсdesс, page, count, ref countrecord);
            pages = Convert.ToInt32(Math.Ceiling((double)countrecord / count));

            var firstdate = date.AddDays(-((date.DayOfWeek - System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.FirstDayOfWeek + 7) % 7)).Date;           // Самая правильная функция!
 //           DateTime firstdate = date.AddDays(-((date.DayOfWeek - System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.FirstDayOfWeek + 7) % 7)).Date;
            DateTime lastdate = firstdate.AddDays(+6);

            //string format = "yyyy-MM-dd";


            mondayt.Text = firstdate.ToString(formattotext);
            sundayt.Text = lastdate.ToString(formattotext);
            countimetables.Text = "Количестов занятий в неделю: " + countrecord;

            for (int i = 0; i < timetables.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                D.Rows.Add(row);
                //D.Rows[i].Height = 50;
                // Понедельник
                if (timetables[i].Startlesson.DayOfWeek == DayOfWeek.Monday)
                {
                    D.Rows[i].Cells[0].Value = timetables[i].ID + ". " + Courses.CourseID(timetables[i].CourseID).nameGroup + "\r  " + timetables[i].Startlesson + " - "
                        + timetables[i].Endlesson + "  " + Cabinets.CabinetID(timetables[i].CabinetID).Number;
                }

                // Вторник
                if (timetables[i].Startlesson.DayOfWeek == DayOfWeek.Tuesday)
                {
                    D.Rows[i].Cells[1].Value = timetables[i].ID + ". " + Courses.CourseID(timetables[i].CourseID).nameGroup + "  " + timetables[i].Startlesson + " - "
                        + timetables[i].Endlesson + "  " + Cabinets.CabinetID(timetables[i].CabinetID).Number;
                   
                }

                // Среда
                if (timetables[i].Startlesson.DayOfWeek == DayOfWeek.Wednesday)
                {
                    D.Rows[i].Cells[2].Value = timetables[i].ID + ". " + Courses.CourseID(timetables[i].CourseID).nameGroup + "\r" +" \n  " + timetables[i].Startlesson + " - "
                        + timetables[i].Endlesson + "  " + Cabinets.CabinetID(timetables[i].CabinetID).Number;
                }

                // Четверг
                if (timetables[i].Startlesson.DayOfWeek == DayOfWeek.Thursday)
                {
                    D.Rows[i].Cells[3].Value = timetables[i].ID + ". " + Courses.CourseID(timetables[i].CourseID).nameGroup + "  " + timetables[i].Startlesson + " - "
                        + timetables[i].Endlesson + "  " + Cabinets.CabinetID(timetables[i].CabinetID).Number;
                }

                // Пятница
                if (timetables[i].Startlesson.DayOfWeek == DayOfWeek.Friday)
                {
                    D.Rows[i].Cells[4].Value = timetables[i].ID + ". " + Courses.CourseID(timetables[i].CourseID).nameGroup + "  " + timetables[i].Startlesson + " - "
                        + timetables[i].Endlesson + "  " + Cabinets.CabinetID(timetables[i].CabinetID).Number;
                }

                // Суббота
                if (timetables[i].Startlesson.DayOfWeek == DayOfWeek.Saturday)
                {
                    D.Rows[i].Cells[5].Value = timetables[i].ID + ". " + Courses.CourseID(timetables[i].CourseID).nameGroup + "  " + timetables[i].Startlesson + " - "
                        + timetables[i].Endlesson + "  " + Cabinets.CabinetID(timetables[i].CabinetID).Number;
                }

                // Воскресенье
                if (timetables[i].Startlesson.DayOfWeek == DayOfWeek.Sunday)
                {
                    D.Rows[i].Cells[6].Value = timetables[i].ID + ". " + Courses.CourseID(timetables[i].CourseID).nameGroup + "  " + timetables[i].Startlesson + " - "
                        + timetables[i].Endlesson + "  " + Cabinets.CabinetID(timetables[i].CabinetID).Number;
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
            LoadAll();
        }

        private void next_Click(object sender, EventArgs e)
        {
            date = date.AddDays(+7);
            LoadAll();
        }
    }
}
