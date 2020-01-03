using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Entity;


namespace Add_Type
{
    public class SampleContext : DbContext
    {
        // Имя будущей базы данных можно указать через
        // вызов конструктора базового класса
        public SampleContext() : base("EducationDB")
        { }

        //Отражение таблиц базы данных на свойства с типом DbSet
        public DbSet<Student> Students { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<StudentsParents> StudentsParents { get; set; }
        public DbSet<StudentsCourses> StudentsCourses { get; set; }
        public DbSet<TeachersCourses> TeachersCourses { get; set; }
        public DbSet<TimetablesTeachers> TimetablesTeachers { get; set; }
        public DbSet<TimetablesThemes> TimetablesThemes { get; set; }

        public DbSet<Branch> Branches { get; set; }
        public DbSet<Cabinet> Cabinets { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Pay> Pays { get; set; }
        public DbSet<Timetable> Timetables { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Visit> Visits { get; set; }


        //Работа для разделения ролей
        public DbSet<Role> Roles { get; set; }
        public DbSet<Action> Actions { get; set; }
        public DbSet<Prohibition> Prohibitions { get; set; }

        internal void SubmitChanges()
        {
            throw new NotImplementedException();
        }
    }
    static class Program
    {
        private static SQLiteConnection m_dbConn;
       
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            m_dbConn = new SQLiteConnection("Data Sourse=..\\..\\..\\EducationDB.db");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new List());
        }
    }
}
