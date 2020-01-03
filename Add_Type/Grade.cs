using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

//+ edit(Grade: Grade): String DONE
//+ add(Grade: Grade): Int DONE
//+ del(ID: Int): String DONE
//+ findAll(Start:	DateTime, End:	DateTime, visitNumber: Int, Date:	DateTime,
//                    editDate:	DateTime, delDate:	DateTime, Gradeot: Int, Gradedo: Int, 
//                    Student: Student, Course: Course, Theme: String, sorting : String, ASKorDESK : String, count : Int, page : Int): List<Grade>

namespace Add_Type
{
    public class Grade
    {
        public int ID { get; set; }
        public int Mark { get; set; }
        public Nullable<System.DateTime> Deldate { get; set; }
        public Nullable<System.DateTime> Editdate { get; set; }

        public int StudentID { get; set; }
        public Student Student { get; set; }

        public int TimetablesThemesID { get; set; }
        public TimetablesThemes TimetablesThemes { get; set; }

        public string Add()
        {
            string answer = Сheck(this);
            if (answer == "Данные корректны!")
            {
                using (SampleContext context = new SampleContext())
                {
                    context.Grades.Add(this);
                    context.SaveChanges();
                    answer = "Добавление оценки прошло успешно";
                }
                return answer;
            }
            return answer;
        }

        public string Del()
        {
            string o;
            using (SampleContext context = new SampleContext())
            {
                this.Deldate = DateTime.Now;
                context.Entry(this).State = EntityState.Modified;
                context.SaveChanges();
                o = "Удаление оценки прошло успешно";
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
                    answer = "Редактирование оценки прошло успешно";
                }
                return answer;
            }
            return answer;
        }

        public string Сheck(Grade st)
        {
            return "Данные корректны!";
        }
    }

    public static class Grades
    {
        public static Grade GradeID(int id)
        {
            using (SampleContext context = new SampleContext())
            {
                Grade v = context.Grades.Where(x => x.ID == id).FirstOrDefault<Grade>();
                return v;
            }
        }

        //////////////////// ОДИН БОЛЬШОЙ ПОИСК !!! Если не введены никакие параметры, функция должна возвращать все темы //////////////////
        public static List<Grade> FindAll(Boolean deldate, Grade grade, Theme theme, Course course, Student student, DateTime mindate, DateTime maxdate, int min, int max, String sort, String asсdesс, int page, int count, ref int countrecord) //deldate =false - все и удал и неудал!
        {
            List<Grade> list = new List<Grade>();
            using (SampleContext db = new SampleContext())
            {
                var query = from g in db.Grades 
                            join s in db.Students on g.StudentID equals s.ID
                            join sc in db.StudentsCourses on s.ID equals sc.StudentID
                            join tt in db.TimetablesThemes on g.TimetablesThemesID equals tt.ID
                            join time in db.Timetables on tt.TimetableID equals time.ID
                            join t in db.Themes on tt.ThemeID equals t.ID

                            select new { ID = g.ID, StudentID = g.StudentID, ThemeID = t.ID, TimetablesThemesID = g.TimetablesThemesID, Mark = g.Mark, Deldate = g.Deldate, Editdate = g.Editdate, Date = time.Startlesson, Course = sc.CourseID, TimetableCourse = time.CourseID };

                // Последовательно просеиваем наш список 

                if (deldate != false) // Убираем удаленных, если нужно
                {
                    query = query.Where(x => x.Deldate == null);
                }

                if (theme.ID != 0)
                {
                    query = query.Where(x => x.ThemeID == theme.ID);
                }

                if (course.ID != 0)
                {
                    query = query.Where(x => x.Course == course.ID & x.Course == x.TimetableCourse); // Второе условие для того, чтобы при выборе курса выбирались
                                                                                                     //не просто все ученика этого курса со всеми своими оценками(даже по другим курсам),
                                                                                                     //а чтобы выбирались ученики и их оценки только за один выбранный курс
                }

                if (student.ID != 0)
                {
                    query = query.Where(x => x.StudentID == student.ID);
                }

                if (mindate != DateTime.MinValue)
                {
                    query = query.Where(x => x.Date >= mindate);
                }

                if (maxdate != DateTime.MaxValue)
                {
                    query = query.Where(x => x.Date <= maxdate);
                }

                if (min != 0)
                {
                    query = query.Where(x => x.Mark >= min);
                }

                if (max != 0)
                {
                    query = query.Where(x => x.Mark <= max);
                }
                query = query.Distinct();


                var query2 = query.GroupBy(s => new { s.ID, s.StudentID, s.TimetablesThemesID, s.Mark, s.Editdate, s.Deldate }, (key, group) => new
                {
                    ID = key.ID,
                    Mark = key.Mark,
                    StudentID = key.StudentID,
                    TimetablesThemesID = key.TimetablesThemesID,
                    Editdate = key.Editdate,
                    Deldate = key.Deldate,
                });

                if (sort != null) // Сортировка, если нужно
                {
                    query2 = Utilit.OrderByDynamic(query2, sort, asсdesс);
                }

                countrecord = query2.GroupBy(u => u.ID).Count();

                query2 = query2.Skip((page - 1) * count).Take(count); // Формирование страниц и кол-во записей на странице

                foreach (var p in query2)
                {
                    list.Add(new Grade { ID = p.ID, StudentID = p.StudentID, TimetablesThemesID = p.TimetablesThemesID, Mark = p.Mark, Deldate = p.Deldate, Editdate = p.Editdate });
                }
                return list;
            }
        }
    }
}
