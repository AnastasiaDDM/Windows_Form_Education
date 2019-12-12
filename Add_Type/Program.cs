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
//            Application.Run(new Parent_find());
            Application.Run(new Student_find());
        }
    }
}


//<? xml version="1.0" encoding="utf-8"?>
//<configuration>
//  <configSections>
//    <!-- For more information on Entity Framework configuration, visit http://go.microsoft.com/fwlink/?LinkID=237468 -->
//    <section name = "entityFramework" type="System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection, EntityFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" requirePermission="false" />
//    <!-- For more information on Entity Framework configuration, visit http://go.microsoft.com/fwlink/?LinkID=237468 -->
//  </configSections>
//  <startup>
//    <supportedRuntime version = "v4.0" sku=".NETFramework,Version=v4.5.2" />
//  </startup>
//  <entityFramework>
//    <providers>
//      <provider invariantName = "System.Data.SqlClient" type="System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer" />
//      <provider invariantName = "System.Data.SQLite.EF6" type="System.Data.SQLite.EF6.SQLiteProviderServices, System.Data.SQLite.EF6" />
//    </providers>
//    <defaultConnectionFactory type = "System.Data.Entity.Infrastructure.LocalDbConnectionFactory, EntityFramework" >
//      < parameters >
//        < parameter value="mssqllocaldb" />
//      </parameters>
//    </defaultConnectionFactory>
//  </entityFramework>
//  <connectionStrings>
//    <add name = "EducationDB.db" connectionString="Data Source=..\..\..\EducationDB.db" providerName="System.Data.SQLite" />
//  </connectionStrings>
//  <system.data>
//    <DbProviderFactories>
//      <remove invariant = "System.Data.SQLite.EF6" />
//      < add name="SQLite Data Provider (Entity Framework 6)" invariant="System.Data.SQLite.EF6" description=".NET Framework Data Provider for SQLite (Entity Framework 6)" type="System.Data.SQLite.EF6.SQLiteProviderFactory, System.Data.SQLite.EF6" />
//    </DbProviderFactories>
//  </system.data>
//</configuration>