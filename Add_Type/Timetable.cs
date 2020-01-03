using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Itenso.TimePeriod;

//+ edit(): String
//+ add(): String
//+ del(): String
//+ addTeachers(): String DONE
//+ delTeachers(): String DONE
//+ GetFreeteachers(DateTime date) : List<Worker> 
//+ getTeachers(DateTime date) : List<Worker> 
//+ findAll(): List<Timetable> 


namespace Add_Type
{
    public class Timetable
    {
        public int ID { get; set; }
        public DateTime Startlesson { get; set; }
        public DateTime Endlesson { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> Deldate { get; set; }
        public Nullable<System.DateTime> Editdate { get; set; }

        public int CabinetID { get; set; }
        public Cabinet Cabinet { get; set; }

        public int CourseID { get; set; }
        public Course Course { get; set; }

        public Timetable Add(ref string answer)
        {
            answer = Сheck(this);
            if (answer == "Данные корректны!")
            {
                using (SampleContext context = new SampleContext())
                {
                    context.Timetables.Add(this);
                    context.SaveChanges();
                }
            }
            return this;
        }

        public List<Timetable> Add(DateTime Endrepeat, string period, Timetable timetable, ref string answer)
        {
            List<Timetable> listtimetable = new List<Timetable>();
            answer = Сheck(this); // Здесь происходит проверка лишь одного начального элемента, а не всех.
            if (answer == "Данные корректны!")
            {
               
                List<TimeRange> listtimerange = new List<TimeRange>();

                DateTime newstart = timetable.Startlesson; // Присваиваем дате начала занятия пока что начальное значение переданное извне, далее эта переменная будет изменяться
                DateTime newend = timetable.Endlesson; // Присваиваем дате окончания занятия пока что начальное значение переданное извне, далее эта переменная будет изменяться


                while (newend <= Endrepeat) // Организуем цикл для перебора всех дат в заданном диапазоне, т.е. до Endrepeat
                {
                    using (SampleContext context = new SampleContext())
                    {
                        Timetable v = context.Timetables.Where(x => x.Startlesson == newstart).FirstOrDefault<Timetable>();

                        // В первом проходе добавляется или не добавляется начальная дата, а дальше уже происходит увеличение дат
                        if (v == null & (period != "Каждый будний день(пн - пт)")) // Добавление для всех вариантов, кроме будних дней, т.к. не нужно учитывать выходные!
                        {
                            Timetable newtimetable = new Timetable(); // Создаем новый экземпляр класса
                            newtimetable.CabinetID = timetable.CabinetID; // Добавляем неизменные атрибуты в новый объект из переданного объекта
                            newtimetable.CourseID = timetable.CourseID;  // Добавляем неизменные атрибуты в новый объект из переданного объекта
                            newtimetable.Note = timetable.Note;  // Добавляем неизменные атрибуты в новый объект из переданного объекта
                            newtimetable.Startlesson = newstart; // Добавляем изменяемые атрибуты (дата начала занятия) в новый объект
                            newtimetable.Endlesson = newend; // Добавляем изменяемые атрибуты (дата окончания занятия) в новый объект
                            listtimetable.Add(newtimetable); // Добавление объекта в лист


                            TimeRange Range = new TimeRange(newstart, newend);
                            listtimerange.Add(Range);
                        }

                        if ((period == "Каждый будний день(пн - пт)") & v == null & (newstart.DayOfWeek != DayOfWeek.Saturday & newstart.DayOfWeek != DayOfWeek.Sunday)) // Добавление для варианта будних дней, т.к. нужно учитывать выходные и не добавлять такие дни в список!
                        {
                            Timetable newtimetable = new Timetable(); // Создаем новый экземпляр класса
                            newtimetable.CabinetID = timetable.CabinetID; // Добавляем неизменные атрибуты в новый объект из переданного объекта
                            newtimetable.CourseID = timetable.CourseID;  // Добавляем неизменные атрибуты в новый объект из переданного объекта
                            newtimetable.Note = timetable.Note;  // Добавляем неизменные атрибуты в новый объект из переданного объекта
                            newtimetable.Startlesson = newstart; // Добавляем изменяемые атрибуты (дата начала занятия) в новый объект
                            newtimetable.Endlesson = newend; // Добавляем изменяемые атрибуты (дата окончания занятия) в новый объект
                            listtimetable.Add(newtimetable); // Добавление объекта в лист

                            TimeRange Range = new TimeRange(newstart, newend);
                            listtimerange.Add(Range);
                        }
                    }

                    if (period == "Ежедневно") // Изменение дат исходя из условия
                    {
                        newstart = newstart.AddDays(1);

                        newend = newend.AddDays(1);
                    }

                    if (period == "Еженедельно") // Изменение дат исходя из условия
                    {
                        newstart = newstart.AddDays(7);

                        newend = newend.AddDays(7);
                    }

                    if (period == "Ежемесячно") // Изменение дат исходя из условия
                    {
                        newstart = newstart.AddMonths(1);

                        newend = newend.AddMonths(1);
                    }

                    if (period == "Каждый год") // Изменение дат исходя из условия
                    {
                        newstart = newstart.AddYears(1);

                        newend = newend.AddYears(1);
                    }

                    if (period == "Каждый будний день(пн - пт)") // Изменение дат исходя из условия
                    {
                        newstart = newstart.AddDays(1);

                        newend = newend.AddDays(1);
                    }
                }

                using (SampleContext context = new SampleContext()) // После завершения цикла нужно добавить значения листа в бд
                {                    
                    foreach( var o in listtimetable) // Цикл для проверки каждого добавляемого элемента
                    {
                        answer = Сheck(o);
                        if (answer != "Данные корректны!")
                        {
                            break;
                        }
                    }
                    if (answer == "Данные корректны!")
                    {
                        context.Timetables.AddRange(listtimetable);
                        context.SaveChanges();
                        if (listtimetable.Count == 0) // Может быть ситуация, при которой ни один объект не был добавлен в бд, пользователь будет осведомлен
                        {
                            answer = "Ни один элемент расписания не был добавлен";
                        }
                    }
                }
            }
            return listtimetable;
        }

        public string Del()
        {
            string o;
            using (SampleContext context = new SampleContext())
            {
                this.Deldate = DateTime.Now;
                context.Entry(this).State = EntityState.Modified;
                context.SaveChanges();
                o = "Удаление элемента расписания прошло успешно";
            }
            return o;
        }

        public string Edit()
        {
            string answer = Сheck(this);
            if (answer == "Данные корректны!")
            {
                using (SampleContext context = new SampleContext())
                {
                    this.Editdate = DateTime.Now;
                    context.Entry(this).State = EntityState.Modified;
                    context.SaveChanges();
                }
                return answer;
            }
            return answer;
        }


        public string addTeacher(Worker w)
        {
            TimetablesTeachers cw = new TimetablesTeachers();
            cw.TimetableID = this.ID;
            cw.TeacherID = w.ID;
            string answer = СheckTeac(cw);
            if (answer == "Данные корректны!")
            {
                using (SampleContext context = new SampleContext())
                {
                    context.TimetablesTeachers.Add(cw);
                    context.SaveChanges();
                    answer = "Добавление преподавателя на это занятие прошло успешно";
                }
                return answer;
            }
            return answer;
        }

        public string delTeacher(Worker w)
        {
            TimetablesTeachers cw = new TimetablesTeachers();
            cw.TimetableID = this.ID;
            cw.TeacherID = w.ID;
            string answer = "";

            using (SampleContext context = new SampleContext())
            {
                TimetablesTeachers v = new TimetablesTeachers();
                v = context.TimetablesTeachers.Where(x => x.TeacherID == cw.TeacherID && x.TimetableID == cw.TimetableID).FirstOrDefault<TimetablesTeachers>();
                context.TimetablesTeachers.Remove(v);
                context.SaveChanges();

                answer = "Удаление преподавателя с этого занятия прошло успешно";
            }
            return answer;
        }

        public string addTheme(Theme w)
        {
            TimetablesThemes cw = new TimetablesThemes();
            cw.TimetableID = this.ID;
            cw.ThemeID = w.ID;
            string answer = СheckTheme(cw);
            if (answer == "Данные корректны!")
            {
                using (SampleContext context = new SampleContext())
                {
                    context.TimetablesThemes.Add(cw);
                    context.SaveChanges();
                    answer = "Добавление темы на это занятие прошло успешно";
                }
                return answer;
            }
            return answer;
        }

        public string delTheme(Theme w)
        {
            TimetablesThemes cw = new TimetablesThemes();
            cw.TimetableID = this.ID;
            cw.ThemeID = w.ID;
            string answer = "";

            using (SampleContext context = new SampleContext())
            {
                TimetablesThemes v = new TimetablesThemes();
                v = context.TimetablesThemes.Where(x => x.ThemeID == cw.ThemeID && x.TimetableID == cw.TimetableID).FirstOrDefault<TimetablesThemes>();
                context.TimetablesThemes.Remove(v);
                context.SaveChanges();

                answer = "Удаление темы с этого занятия прошло успешно";
            }
            return answer;
        }
        public string Сheck(Timetable st)
        {
            if (st.CabinetID == 0)
            { return "Выберите кабинет. Это поле не может быть пустым"; }

            if (st.CourseID == 0)
            { return "Выберите курс. Это поле не может быть пустым"; }

            using (SampleContext context = new SampleContext())
            {
                if (st.ID == 0)       // если мы добавляем новый элемент 
                {
                    Timetable v = context.Timetables.Where(x => x.Startlesson == st.Startlesson & x.CourseID == st.CourseID).FirstOrDefault<Timetable>();
                    if (v != null)
                    { return "Этот курс уже занят элементом расписания №" + v.ID + " в промежутке от " + v.Startlesson + " до " + v.Endlesson; }

                    Timetable c = context.Timetables.Where(x => x.Startlesson == st.Startlesson & x.CabinetID == st.CabinetID).FirstOrDefault<Timetable>();
                    if (c != null)
                    { return "Этот кабинет уже занят элементом расписания №" + c.ID + " в промежутке от " + c.Startlesson + " до " + c.Endlesson; }

                    //Принято решение не проверять занятость учеников вообще - потому что может получиться так, что расписание никогда не сможет быть составлено из - за учеников.
                    // Здесь уже ученик сам решает или договаривается с преподавателями, под него система не будет подстраиваться.
                    //А с курсами останется примитивную проверку. Работа с промежутками пока не имеет смысла, в будущем возможно что-то изменить.

                    //List<Student> liststudents = Courses.CourseID(st.CourseID).GetStudents();
                    //foreach (Student s in liststudents)
                    //{
                    //    List<Course> listcourses = s.GetCourses();
                    //    foreach (Course co in listcourses)
                    //    {
                    //        // Если на этот курс у этого студента есть договор, и он не расторжен ( то есть действует), значит мы должны проверить занятость этого ученика
                    //        Contract con = context.Contracts.Where(x => x.CourseID == co.ID & x.StudentID == s.ID & x.Canceldate == null).FirstOrDefault<Contract>();
                    //        if(con != null)
                    //        {
                    //            Timetable ts = context.Timetables.Where(x => x.Startlesson == st.Startlesson & x.CourseID == co.ID).FirstOrDefault<Timetable>();
                    //            if (ts != null)
                    //            { return "Ученик №" + s.ID + " уже занят на курсе №" + co.ID + " элементом расписания №" + ts.ID + " в промежутке от " + ts.Startlesson + " до " + ts.Endlesson; }
                    //        }
                    //    }
                    //}

                    //Проверка даты занятия и дат занятий курса
                   if (st.Startlesson.Date < Courses.CourseID(st.CourseID).Start.Date | st.Startlesson.Date > Courses.CourseID(st.CourseID).End.Date)
                    { return "Этот курс не может заниматься " + st.Startlesson.ToLongDateString() + ", потому что эта дата не входит в диапазон дат обучения курса"; }
                }
            }
            return "Данные корректны!";
        }


        public static string СheckTeac(TimetablesTeachers stpar)
        {
            using (SampleContext context = new SampleContext())
            {
                TimetablesTeachers v = new TimetablesTeachers();
                v = context.TimetablesTeachers.Where(x => x.TeacherID == stpar.TeacherID && x.TimetableID == stpar.TimetableID).FirstOrDefault<TimetablesTeachers>();
                if (v != null)
                { return "Этот преподаватель уже числится за этим занятием"; }

                Worker t = Workers.WorkerID(stpar.TeacherID);
                if (Roles.RoleID(t.RoleID).Name != "Преподаватель")
                { return " Вам нужно было выбрать преподавателя (тип 3)"; }
            }
            return "Данные корректны!";
        }

        public static string СheckTheme(TimetablesThemes stpar)
        {
            using (SampleContext context = new SampleContext())
            {
                TimetablesThemes v = new TimetablesThemes();
                v = context.TimetablesThemes.Where(x => x.ThemeID == stpar.ThemeID && x.TimetableID == stpar.TimetableID).FirstOrDefault<TimetablesThemes>();
                if (v != null)
                { return "Эта тема уже есть на этом занятии"; }
            }
            return "Данные корректны!";
        }

        public List<Worker> GetFreeteachers(DateTime Endrepeat, string period)  // Поиск свободных на это время преподавателей
        {
            List<TimeRange> listtimerange = new List<TimeRange>();

            DateTime newstart = this.Startlesson; // Присваиваем дате начала занятия пока что начальное значение переданное извне, далее эта переменная будет изменяться
            DateTime newend = this.Endlesson; // Присваиваем дате окончания занятия пока что начальное значение переданное извне, далее эта переменная будет изменяться


            while (newend <= Endrepeat) // Организуем цикл для перебора всех дат в заданном диапазоне, т.е. до Endrepeat
            {
                using (SampleContext context = new SampleContext())
                {
                    // В первом проходе добавляется или не добавляется начальная дата, а дальше уже происходит увеличение дат
                    if(period != "Каждый будний день(пн - пт)") // Добавление для всех вариантов, кроме будних дней, т.к. не нужно учитывать выходные!
                    {
                        TimeRange Range = new TimeRange(newstart, newend);
                        listtimerange.Add(Range);
                    }

                    if ((period == "Каждый будний день(пн - пт)") & (newstart.DayOfWeek != DayOfWeek.Saturday & newstart.DayOfWeek != DayOfWeek.Sunday)) // Добавление для варианта будних дней, т.к. нужно учитывать выходные и не добавлять такие дни в список!
                    {
                        TimeRange Range = new TimeRange(newstart, newend);
                        listtimerange.Add(Range);
                    }
                }

                if (period == "Ежедневно" || period == "Не повторять" || period == "Каждый будний день(пн - пт)") // Изменение дат исходя из условия
                {
                    newstart = newstart.AddDays(1);

                    newend = newend.AddDays(1);
                }

                if (period == "Еженедельно") // Изменение дат исходя из условия
                {
                    newstart = newstart.AddDays(7);

                    newend = newend.AddDays(7);
                }

                if (period == "Ежемесячно") // Изменение дат исходя из условия
                {
                    newstart = newstart.AddMonths(1);

                    newend = newend.AddMonths(1);
                }

                if (period == "Каждый год") // Изменение дат исходя из условия
                {
                    newstart = newstart.AddYears(1);

                    newend = newend.AddYears(1);
                }
            }

            List<Worker> freeteachers = new List<Worker>(); // Лист свободных преподавателей
            using (SampleContext context = new SampleContext())
            {
                StringBuilder s = new StringBuilder("Select Distinct Workers.* from Workers where Workers.RoleID = 3  and  Workers.Deldate IS NULL and Workers.ID not in (Select Distinct Workers.ID from Workers join TimetablesTeachers on TimetablesTeachers.TeacherID = Workers.ID and Workers.RoleID = 3 join Timetables on TimetablesTeachers.TimetableID = Timetables.ID where ");

                List<string> sql = new List<string>();
                string format = "yyyy-MM-dd HH:mm:ss";

                foreach (TimeRange t in listtimerange)
                {

                    sql.Add(String.Format("(Startlesson >= '{0}' and Endlesson <= '{1}' and Startlesson <= '{1}')", t.Start.ToString(format), t.End.ToString(format))); // Внутри
                    sql.Add(String.Format("(Startlesson <= '{0}' and Endlesson >= '{1}' and Startlesson <= '{1}')", t.Start.ToString(format), t.End.ToString(format))); // Снаружи
                    sql.Add(String.Format("(Startlesson >= '{0}' and Endlesson >= '{1}' and Startlesson <= '{1}')", t.Start.ToString(format), t.End.ToString(format))); // верхняя граница
                    sql.Add(String.Format("(Startlesson <= '{0}' and Endlesson <= '{1}' and Endlesson >= '{0}')", t.Start.ToString(format), t.End.ToString(format)));// нижняя граница

                }

                s.Append(String.Join(" or ", sql));

                var query = context.Workers.SqlQuery(s.ToString() + " group by Workers.ID order by Workers.ID)");

                foreach (Worker t in query)
                {
                    freeteachers.Add(t);
                }
            }
            return freeteachers;
        }

        public List<Cabinet> GetFreecabinets(DateTime Endrepeat, string period)  // Поиск свободных на это время кабинетов
        {
            List<TimeRange> listtimerange = new List<TimeRange>();

            DateTime newstart = this.Startlesson; // Присваиваем дате начала занятия пока что начальное значение переданное извне, далее эта переменная будет изменяться
            DateTime newend = this.Endlesson; // Присваиваем дате окончания занятия пока что начальное значение переданное извне, далее эта переменная будет изменяться

            while (newend <= Endrepeat) // Организуем цикл для перебора всех дат в заданном диапазоне, т.е. до Endrepeat
            {
                using (SampleContext context = new SampleContext())
                {
                    // В первом проходе добавляется или не добавляется начальная дата, а дальше уже происходит увеличение дат
                    if ((period != "Каждый будний день(пн - пт)")) // Добавление для всех вариантов, кроме будних дней, т.к. не нужно учитывать выходные!
                    {
                        TimeRange Range = new TimeRange(newstart, newend);
                        listtimerange.Add(Range);
                    }

                    if ((period == "Каждый будний день(пн - пт)") & (newstart.DayOfWeek != DayOfWeek.Saturday & newstart.DayOfWeek != DayOfWeek.Sunday)) // Добавление для варианта будних дней, т.к. нужно учитывать выходные и не добавлять такие дни в список!
                    {
                        TimeRange Range = new TimeRange(newstart, newend);
                        listtimerange.Add(Range);
                    }
                }

                if (period == "Ежедневно" || period == "Не повторять" || period == "Каждый будний день(пн - пт)") // Изменение дат исходя из условия
                {
                    newstart = newstart.AddDays(1);

                    newend = newend.AddDays(1);
                }

                if (period == "Еженедельно") // Изменение дат исходя из условия
                {
                    newstart = newstart.AddDays(7);

                    newend = newend.AddDays(7);
                }

                if (period == "Ежемесячно") // Изменение дат исходя из условия
                {
                    newstart = newstart.AddMonths(1);

                    newend = newend.AddMonths(1);
                }

                if (period == "Каждый год") // Изменение дат исходя из условия
                {
                    newstart = newstart.AddYears(1);

                    newend = newend.AddYears(1);
                }
            }

            List<Cabinet> freecabinets = new List<Cabinet>(); // Лист свободных кабинетов
            using (SampleContext context = new SampleContext())
            {
                StringBuilder s = new StringBuilder("Select Distinct Cabinets.* from Cabinets where Cabinets.Deldate IS NULL and Cabinets.ID not in (Select Distinct Cabinets.ID from Cabinets join Timetables on Cabinets.ID = Timetables.CabinetID where ");

                List<string> sql = new List<string>();
                string format = "yyyy-MM-dd HH:mm:ss";

                foreach (TimeRange t in listtimerange)
                {

                    sql.Add(String.Format("(Startlesson >= '{0}' and Endlesson <= '{1}' and Startlesson <= '{1}')", t.Start.ToString(format), t.End.ToString(format))); // Внутри
                    sql.Add(String.Format("(Startlesson <= '{0}' and Endlesson >= '{1}' and Startlesson <= '{1}')", t.Start.ToString(format), t.End.ToString(format))); // Снаружи
                    sql.Add(String.Format("(Startlesson >= '{0}' and Endlesson >= '{1}' and Startlesson <= '{1}')", t.Start.ToString(format), t.End.ToString(format))); // верхняя граница
                    sql.Add(String.Format("(Startlesson <= '{0}' and Endlesson <= '{1}' and Endlesson >= '{0}')", t.Start.ToString(format), t.End.ToString(format)));// нижняя граница

                }

                s.Append(String.Join(" or ", sql));

                var query = context.Cabinets.SqlQuery(s.ToString() + " group by Cabinets.ID order by Cabinets.ID)");

                foreach (Cabinet c in query)
                {
                    freecabinets.Add(c);
                }
            }
            return freecabinets;
        }

        public List<Worker> GetTeachers()  // Поиск  всех преподавателей у этого элемента расписания
        {
            List<Worker> teachers = new List<Worker>();
            using (SampleContext context = new SampleContext())
            {
                var v = context.TimetablesTeachers.Where(x => x.TimetableID == this.ID).OrderBy(u => u.TimetableID);
                foreach (var o in v)
                {
                    teachers.Add(Workers.WorkerID(o.TeacherID));
                }
                return teachers;
            }
        }

        public List<int> GetThemes()  // Поиск  всех тем у этого элемента расписания
        {
            List<int> themesId = new List<int>();
            using (SampleContext context = new SampleContext())
            {
                var v = context.TimetablesThemes.Where(x => x.TimetableID == this.ID).OrderBy(u => u.TimetableID);
                foreach (var o in v)
                {
                    themesId.Add(o.ThemeID);
                }
                return themesId;
            }
        }

        public List<Visit> GetVisits()  // Поиск  всех посещений у этого элемента расписания
        {
            using (SampleContext context = new SampleContext())
            {
                var v = context.Visits.Where(x => x.TimetableID == this.ID).OrderBy(u => u.ID).ToList<Visit>();
                return v;
            }
        }
    }
    public static class Timetables
    {
        public static Timetable TimetableID(int id)
        {
            using (SampleContext context = new SampleContext())
            {
                Timetable v = context.Timetables.Where(x => x.ID == id).FirstOrDefault<Timetable>();

                return v;
            }
        }

        //////////////////// ОДИН БОЛЬШОЙ ПОИСК !!! Если не введены никакие параметры, функция должна возвращать все элементы расписания //////////////////
        public static List<Timetable> FindAll(Boolean deldate, Branch branch, Cabinet cabinet, Worker teacher, Course course, Student student, DateTime date, String sort, String asсdesс, int page, int count, ref int countrecord) //deldate =false - все и удал и неудал!
        {
            List<Timetable> list = new List<Timetable>();
            using (SampleContext db = new SampleContext())
            {
                var query = from c in db.Cabinets
                            join t in db.Timetables on c.ID equals t.CabinetID
                            join tt in db.TimetablesTeachers on t.ID equals tt.TimetableID
                            join cour in db.Courses on t.CourseID equals cour.ID
                            join sc in db.StudentsCourses on t.CourseID equals sc.CourseID

                            select new { ID = t.ID, StudentID = sc.StudentID, CabinetID = t.CabinetID, CourseID = t.CourseID, Note = t.Note, Startlesson = t.Startlesson, Endlesson = t.Endlesson, Deldate = t.Deldate, Editdate = t.Editdate, BranchID = c.BranchID, TeacherID = tt.TeacherID };

                // Последовательно просеиваем наш список 

                if (deldate != false) // Убираем удаленных, если нужно
                {
                    query = query.Where(x => x.Deldate == null);
                }

                if (branch.ID != 0)
                {
                    query = query.Where(x => x.BranchID == branch.ID);
                }

                if (course.ID != 0)
                {
                    query = query.Where(x => x.CourseID == course.ID);
                }

                if (student.ID != 0)
                {
                    query = query.Where(x => x.StudentID == student.ID);
                }

                if (cabinet.ID != 0)
                {
                    query = query.Where(x => x.CabinetID == cabinet.ID);
                }

                if (teacher.ID != 0)
                {
                    query = query.Where(x => x.TeacherID == teacher.ID);
                }

                if(date != DateTime.MinValue)
                {
                    // Подсчет недели, которую необходимо отобразить!
                    DateTime firstdate = date.AddDays(-((date.DayOfWeek - System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.FirstDayOfWeek + 7) % 7)).Date;
                    DateTime lastdate = firstdate.AddDays(+6);

                    if (firstdate != DateTime.MinValue)
                    {
                        query = query.Where(x => x.Startlesson >= firstdate);
                    }

                    if (lastdate != DateTime.MaxValue)
                    {
                        query = query.Where(x => x.Endlesson <= lastdate);
                    }
                }

                var query2 = query.GroupBy(t => new { t.ID, t.Startlesson, t.Endlesson, t.CabinetID, t.CourseID, t.Note, t.Deldate, t.Editdate }, (key, group) => new
                {
                    ID = key.ID,
                    CourseID = key.CourseID,
                    CabinetID = key.CabinetID,
                    Deldate = key.Deldate,
                    Editdate = key.Editdate, 
                    Note = key.Note, 
                    Startlesson = key.Startlesson,
                    Endlesson = key.Endlesson
                });

                if (sort != null)  // Сортировка, если нужно
                {
                    query2 = Utilit.OrderByDynamic(query2, sort, asсdesс);
                }

                countrecord = query2.GroupBy(u => u.ID).Count();

                query2 = query2.Skip((page - 1) * count).Take(count);
                query2 = query2.Distinct();

                foreach (var p in query2)
                {
                    list.Add(new Timetable { ID = p.ID, CourseID = p.CourseID, CabinetID = p.CabinetID, Startlesson = p.Startlesson, Endlesson = p.Endlesson, Note = p.Note, Deldate = p.Deldate, Editdate = p.Editdate });
                }
                return list;
            }
        }
    }
}
