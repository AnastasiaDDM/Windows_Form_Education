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
        public Student student; // Объект "ученик" для построения расписания для ученика
        int pages;
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
            Course cour = new Course();
            Cabinet cab = new Cabinet();
            DateTime date = DateTime.Now;

            int countrecord = 0;

            List<Timetable> timetables = new List<Timetable>();
            timetables = Timetables.FindAll(deldate, bran, cab, teach, cour, stud, date, sort, asсdesс, page, count, ref countrecord);
            pages = Convert.ToInt32(Math.Ceiling((double)countrecord / count));
            //for (int p = 1; p <= pages; p++)
            //{
            //    // добавляем один элемент
            //    pagef.Items.Add(p);
            //}

            foreach (var s in timetables)
            {
                Console.WriteLine("ID: {0} \t Deldate: {1}  \t CourseID: {2} \t  CabinetID: {3} \t Startlesson: {4} \t Endlesson: {5} ", s.ID, s.Deldate, s.CourseID, s.CabinetID, s.Startlesson, s.Endlesson);
            }

            for (int i = 0; i < timetables.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                D.Rows.Add(row);

                // Понедельник
                if(timetables[i].Startlesson.DayOfWeek == DayOfWeek.Monday)
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
                    D.Rows[i].Cells[2].Value = timetables[i].ID + ". " + Courses.CourseID(timetables[i].CourseID).nameGroup + "\r\n  " + timetables[i].Startlesson + " - "
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
            LoadAll();
        }
    }
}
