﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Entity;

//+Student() DONE
//+StudentID(ID: Int) DONE
//+ add(): String DONE
//+ del(): String DONE
//+ edit(): String DONE
//+ getParents(): List<Parent> DONE
//+ getContracts(): List<Contract> DONE
//+ getCourses(): List<Course> DONE
//+ getTimetable(Start: Datetime, End: Datetime): List<Timetable>  DONE
//+ getDebt(Contract: Contract): Double DONE ( можно улучшить процесс, но работает корректно )
//+ addParent() DONE - и возможных нужно тоже тут искать (пока не сделано)
//+ delParent() DONE 
//+ GetPossibleparents() DONE

namespace Add_Type
{
    public class Student
    {
        public int ID { get; set; }
        public string FIO { get; set; }
        public string Phone { get; set; }
        public Nullable<System.DateTime> Deldate { get; set; }
        public Nullable<System.DateTime> Editdate { get; set; }

        public Student()
        {    }

        public string Add()
        {
            string answer = Сheck(this);
            if (answer == "Данные корректны!")
            {
                using (SampleContext context = new SampleContext())
                {
                    context.Students.Add(this);
                    context.SaveChanges();
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
                o = "Удаление ученика прошло успешно";
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

        public string Сheck(Student st)
        {
            if (st.FIO == "")
            { return "Введите ФИО ученика. Это поле не может быть пустым"; }
            if (st.Phone == "")
            { return "Введите номер телефона ученика. Это поле не может быть пустым"; }
            using (SampleContext context = new SampleContext())
            {
                Student v = new Student();
                v = context.Students.Where(x => x.FIO == st.FIO && x.Phone == st.Phone).FirstOrDefault<Student>();
                if (v != null)
                { return "Такой ученик уже существует в базе под номером " + v.ID; }
            }
            return "Данные корректны!";
        }

        public static string СheckPar(StudentsParents stpar)
        {
            using (SampleContext context = new SampleContext())
            {
                StudentsParents v = new StudentsParents();
                v = context.StudentsParents.Where(x => x.StudentID == stpar.StudentID && x.ParentID == stpar.ParentID).FirstOrDefault<StudentsParents>();
                if (v != null)
                { return "Это ответственное лицо уже числится за этим учеником"; }
            }
            return "Данные корректны!";
        }

        public List<Contract> GetContracts()
        {
            //      var context = new SampleContext();
            using (SampleContext context = new SampleContext())
            {
                var v = context.Contracts.Where(x => x.StudentID == this.ID).OrderBy(u => u.ID).ToList<Contract>();
                return v;
            }
        }

        public List<Course> GetCourses()    // Получение списка курсов этого ученика
        {
            List<Course> listcourses = new List<Course>();
            using (SampleContext db = new SampleContext())
            {
                var query = from c in db.Courses
                            join sc in db.StudentsCourses on c.ID equals sc.CourseID
                            select new { ID = c.ID, nameGroup = c.nameGroup, Cost = c.Cost, TypeID = c.TypeID, BranchID = c.BranchID, Start = c.Start, End = c.End, EditDate = c.Editdate, DelDate = c.Deldate, CourID = sc.CourseID, StID = sc.StudentID };

                query = query.Where(x => x.StID == this.ID);
                query = query.Where(x => x.ID == x.CourID);

                foreach (var c in query)
                {
                    listcourses.Add(new Course { ID = c.ID, nameGroup = c.nameGroup, Cost = c.Cost, TypeID = c.TypeID, BranchID = c.BranchID, Start = c.Start, End = c.End, Editdate = c.EditDate, Deldate = c.DelDate });
                }
                return listcourses;
            }
        }

        public List<Course> GetFinishedCourses()    // Получение списка завершенных курсов этого ученика
        {
            List<Course> listcourses = new List<Course>();
            using (SampleContext db = new SampleContext())
            {
                var query = from c in db.Courses
                            join sc in db.StudentsCourses on c.ID equals sc.CourseID
                            select new { ID = c.ID, nameGroup = c.nameGroup, Cost = c.Cost, TypeID = c.TypeID, BranchID = c.BranchID, Start = c.Start, End = c.End, EditDate = c.Editdate, DelDate = c.Deldate, CourID = sc.CourseID, StID = sc.StudentID };

                query = query.Where(x => x.StID == this.ID);
                query = query.Where(x => x.ID == x.CourID & x.End < DateTime.Now);

                foreach (var c in query)
                {
                    listcourses.Add(new Course { ID = c.ID, nameGroup = c.nameGroup, Cost = c.Cost, TypeID = c.TypeID, BranchID = c.BranchID, Start = c.Start, End = c.End, Editdate = c.EditDate, Deldate = c.DelDate });
                }
                return listcourses;
            }
        }

        public List<Parent> GetParents()    // Получение списка родителей этого ученика
        {
            List<Parent> listparents = new List<Parent>();
            using (SampleContext db = new SampleContext())
            {
                var parents = from p in db.Parents
                              join sp in db.StudentsParents on p.ID equals sp.ParentID
                              select new { PID = p.ID, PPhone = p.Phone, PFIO = p.FIO, PDelDate = p.Deldate, ParID = sp.ParentID, StID = sp.StudentID };

                parents = parents.Where(x => x.StID == this.ID & x.PDelDate == null);
                parents = parents.Where(x => x.PID == x.ParID);

                foreach (var p in parents)
                {
                    listparents.Add(new Parent { ID = p.PID, Phone = p.PPhone, Deldate = p.PDelDate, FIO = p.PFIO });
                }
                return listparents;
            }
        }

        public List<Parent> addParent(Parent par, out string answer)
        {
            StudentsParents stpar = new StudentsParents();
            stpar.StudentID = this.ID;
            stpar.ParentID = par.ID;
            List<Parent> possibleparents = new List<Parent>();
            answer = СheckPar(stpar);
            if (answer == "Данные корректны!")
            {
                using (SampleContext context = new SampleContext())
                {
                    context.StudentsParents.Add(stpar);
                    context.SaveChanges();
                    int IDInsert = stpar.ParentID;

                    //  Вызов метода поиска возможных родителей
                    possibleparents = Students.StudentID(stpar.StudentID).GetPossibleparents();
                }
                return possibleparents;
            }
            return possibleparents;
        }

        public string delParent(Parent par)
        {
            StudentsParents stpar = new StudentsParents();
            stpar.StudentID = this.ID;
            stpar.ParentID = par.ID;
            string answer = "";

            using (SampleContext context = new SampleContext())
            {
                StudentsParents v = new StudentsParents();
                v = context.StudentsParents.Where(x => x.StudentID == stpar.StudentID && x.ParentID == stpar.ParentID).FirstOrDefault<StudentsParents>();
                context.StudentsParents.Remove(v);
                context.SaveChanges();

                answer = "Удаление отв.лица у ученика прошло успешно";
            }
            return answer;
        }

        public List<Parent> GetPossibleparents()
        {
            List<Parent> listparents = new List<Parent>();
            using (SampleContext db = new SampleContext())
            {
                var query = from p in db.Parents
                            join sp in db.StudentsParents on p.ID equals sp.ParentID
                            select new { PID = p.ID, PPhone = p.Phone, PFIO = p.FIO, PDelDate = p.Deldate, PEditDate = p.Editdate, ParID = sp.ParentID, StID = sp.StudentID };

                var query1 = query.Where(x => x.StID == this.ID); // Здесь выбираются уже существующие родители конкретного студента


                // Этот запрос выбирает всех учеников у всех найденных выше родителей, кроме переданного ученика из общего запроса query и из первого query1, который является как бы фильтром
                var selectedStudent = query.SelectMany(u => query1,
                    (u, q1) => new { IDpar = u.PID, Lang = q1.PID, IDst = u.StID })
                     .Where(u => u.IDpar == u.Lang & u.IDst != this.ID);

                // Этот запрос выбирает всех родителей, кроме предыдущего(тот, который уже есть) - как раз таки это возможные родители, от всех учеников предыдущего запроса
                // То есть, этот запрос формируется на основе query и запроса selectedStudent, который как бы выполняет роль фильтра - выбирая тех родителей, у которых есть студенты из selectedStudent
                var query2 = query.SelectMany(u => selectedStudent,
                    (u, q1) => new { IDpar = u.PID, FIO = u.PFIO, Phone = u.PPhone, Deldate = u.PDelDate, Editdate = u.PEditDate, IDst = u.StID, Lang = q1.IDst, idPar = q1.IDpar })
                    .Where(u => u.IDst == u.Lang & u.IDst != this.ID & u.IDpar != u.idPar);

                var selectedParents = query2.GroupBy(s => new { s.IDpar, s.Phone, s.FIO, s.Deldate, s.Editdate }, (key, group) => new
                {
                    ID = key.IDpar,
                    Phone = key.Phone,
                    FIO = key.FIO,
                    Deldate = key.Deldate,
                    Editdate = key.Editdate
                });

                // Заполнение листа родителями
                foreach (var p in selectedParents)
                {
                    if (this.GetParents().Find(x => x.ID == p.ID) == null)
                    {
                        listparents.Add(new Parent { ID = p.ID, Phone = p.Phone, Deldate = p.Deldate, Editdate = p.Editdate, FIO = p.FIO });

                        StudentsParents stpar = new StudentsParents();
                        stpar.StudentID = this.ID;
                        stpar.ParentID = p.ID;

                        db.StudentsParents.Add(stpar);
                        db.SaveChanges();
                    }
                }
                return listparents;
            }
        }

        public List<Timetable> getTimetables(DateTime date, bool deldate, int count, int page, string sort, string ascdesc, ref int countrecord)
        {
            Branch branch = new Branch();

            Worker teacher = new Worker();

            Course course = new Course();
            Cabinet cabinet = new Cabinet();

            List<Timetable> timetables = new List<Timetable>();
            return timetables = Timetables.FindAll(deldate, branch, cabinet, teacher, course, this, date, sort, ascdesc, page, count, ref countrecord);
        }

        public double getDebt(Contract contract)
        {
            using (SampleContext db = new SampleContext())
            {
                var pays = db.Pays.Join(db.Contracts, // второй набор
        p => p.ContractID, // свойство-селектор объекта из первого набора
        c => c.ID, // свойство-селектор объекта из второго набора
        (p, c) => new // результат
        {
            ID = p.ID,
            ContractID = p.ContractID,
            Date = p.Date,
            BranchID = p.BranchID,
            Payment = p.Payment,
            Purpose = p.Purpose,
            Type = p.Type,
            Deldate = p.Deldate,
            StudentID = c.StudentID
        });

                var paysst = pays.Where(p => p.StudentID == this.ID & p.ContractID == contract.ID)/* == null ? 0 : pays.Where(p => p.StudentID == this.ID)*/;
                if (paysst.Count() == 0)
                {   // То есть если оплат по договору нет, значит, что и paysst - будет пустым, но переход на договор осуществляется из форма,
                    // а это значит, что договор точно существует, а оплат на него нет - то есть задолженность = Cost = c.Cost
                    // Но есть и такой случай, когда у ученика вообще неот договоров - тогда задолженность = 0
                    var c = db.Contracts.Where(p => p.StudentID == this.ID);
                    if (c.Count() == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return c.Sum(p => p.Cost);
                    }
                }
                else
                {
                    double sumPays = (paysst.Sum(p => p.Payment));
                    return contract.Cost - sumPays;
                }
            }
        }

        public double getDebt()
        {
            using (SampleContext db = new SampleContext())
            {
                var pays = db.Pays.Join(db.Contracts, // второй набор
        p => p.ContractID, // свойство-селектор объекта из первого набора
        c => c.ID, // свойство-селектор объекта из второго набора
        (p, c) => new // результат
        {
            ID = p.ID,
            ContractID = p.ContractID,
            Cost = c.Cost,
            Date = p.Date,
            BranchID = p.BranchID,
            Payment = p.Payment,
            Purpose = p.Purpose,
            Type = p.Type,
            Deldate = p.Deldate,
            StudentID = c.StudentID
        });

                var paysst = pays.Where(p => p.StudentID == this.ID);
                if (paysst.Count() == 0)
                {
                    // То есть если оплат по договору нет, значит, что и paysst - будет пустым, но переход на договор осуществляется из форма,
                    // а это значит, что договор точно существует, а оплат на него нет - то есть задолженность = Cost = c.Cost
                    // Но есть и такой случай, когда у ученика вообще неот договоров - тогда задолженность = 0
                    var c = db.Contracts.Where(p => p.StudentID == this.ID);
                    if (c.Count() == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return c.Sum(p => p.Cost);
                    }
                }
                else
                {
                    var query2 = paysst.GroupBy(s => new { s.ContractID, s.Cost }, (key, group) => new
                    {
                        ContractID = key.ContractID,
                        Cost = key.Cost
                    });
                    double costsAll = (query2.Sum(p => p.Cost));
                    double sumPays = (paysst.Sum(p => p.Payment));
                    return costsAll - sumPays;
                }
            }
        }
    }

    public static class Students
    {
        public static Student StudentID(int id)
        {
            using (SampleContext context = new SampleContext())
            {
                Student v = context.Students.Where(x => x.ID == id).FirstOrDefault<Student>();

                return v;
            }
        }

        public static List<Student> GetSt()
        {
            using (SampleContext context = new SampleContext())
            {
                var students = context.Students.ToList();
                return students;
            }
        }

        ////////////////// ОДИН БОЛЬШОЙ ПОИСК !!! Если не введены никакие параметры, функция должна возвращать всех учеников //////////////////
        public static List<Student> FindAll(Boolean deldate, Parent parent, Student student, Contract contracnt, Course course, String sort, String asсdesс, int page, int count, ref int countrecord) //deldate =false - все и удал и неудал!
        {
            List<Student> stList = new List<Student>();

            using (SampleContext db = new SampleContext())
            {

                var query = from s in db.Students
                            join sp in db.StudentsParents on s.ID equals sp.StudentID
                            into std_prnt_temp
                            from std_prnt in std_prnt_temp.DefaultIfEmpty()
                            join p in db.Parents on std_prnt.ParentID equals p.ID
                            into prnt_temp
                            from prnt in prnt_temp.DefaultIfEmpty()
                            join c in db.Contracts on s.ID equals c.StudentID
                            into cntr_temp
                            from cntr in cntr_temp.DefaultIfEmpty()
                            join scour in db.StudentsCourses on s.ID equals scour.StudentID
                            into std_cour_temp
                            from stcour in std_cour_temp.DefaultIfEmpty()

                            select new { ID = s.ID, Phone = s.Phone, FIO = s.FIO, Deldate = s.Deldate, Editdate = s.Editdate, PID = (prnt == null ? 0 : prnt.ID), CID = (cntr == null ? 0 : cntr.ID), CourseID = (stcour == null ? 0 : stcour.CourseID) };

                // Последовательно просеиваем наш список

                if (deldate != false) // Убираем удаленных, если нужно
                {
                    query = query.Where(x => x.Deldate == null);
                }

                if (student.FIO != null)
                {
                    query = query.Where(x => x.FIO == student.FIO);
                }

                if (student.Phone != null)
                {
                    query = query.Where(x => x.Phone == student.Phone);
                }

                if (parent.ID != 0)
                {
                    query = query.Where(x => x.PID == parent.ID);
                }

                if (contracnt.ID != 0)
                {
                    query = query.Where(x => x.CID == contracnt.ID);
                }

                if (course.ID != 0)
                {
                    query = query.Where(x => x.CourseID == course.ID);
                }

                query = query.Distinct();

                var query2 = query.GroupBy(s => new { s.ID, s.Phone, s.FIO, s.Deldate, s.Editdate }, (key, group) => new
                {
                    ID = key.ID,
                    Phone = key.Phone,
                    FIO = key.FIO,
                    Deldate = key.Deldate,
                    Editdate = key.Editdate
                });

                if (sort != null) // Сортировка, если нужно
                {
                    query2 = Utilit.OrderByDynamic(query2, sort, asсdesс);
                }

                countrecord = query2.Count();             

                query2 = query2.Skip((page - 1) * count).Take(count); // Формирование страниц и кол-во записей на странице

                foreach (var p in query2)
                {
                    stList.Add(new Student { ID = p.ID, Phone = p.Phone, Deldate = p.Deldate, FIO = p.FIO, Editdate = p.Editdate }); // Добавление ученика в лист, если такого еще нет, это для предохранения от дубликатов
                }
                return stList;
            }
        }
    }
}