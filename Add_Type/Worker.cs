using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

//+ Worker()  DONE
//+ WorkerID(ID : Int) DONE
//+ del(): String DONE
//+ add(): String DONE
//+ edit(): String DONE
//+ getContracts(): List<Contract> DONE
//+ getTimetable(Start: Datetime, End: Datetime): List<Timetable> DONE
//+ Salary(Start: Datetime, End: Datetime, Rate: Double): Double DONE ( Мне кажется, что-то тут можно сделать лучше)

namespace Add_Type
{
    public class Worker
    {
        public int ID { get; set; }
        public string FIO { get; set; }
        public string Phone { get; set; }
        public string Position { get; set; }

        public int RoleID { get; set; } // 1 - это директор, 2 - менеджер, 3 -преподаватель
        public Role Role { get; set; }

        public Nullable<int> BranchID { get; set; }
        public string Password { get; set; }
        public Nullable<double> Rate { get; set; }
        public Nullable<System.DateTime> Deldate { get; set; }
        public Nullable<System.DateTime> Editdate { get; set; }

        public ICollection<Contract> Contracts { get; set; }

        public Worker()
        { }
        public string Add()
        {
            string answer = Сheck(this);
            if (answer == "Данные корректны!")
            {
                using (SampleContext context = new SampleContext())
                {
                    context.Workers.Add(this);
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
                o = "Удаление договора прошло успешно";
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

        public string Сheck(Worker st)
        {
            if (st.FIO == "")
            { return "Введите ФИО работника. Это поле не может быть пустым"; }
            if (st.Phone == "")
            { return "Введите номер телефона. Это поле не может быть пустым"; }
            using (SampleContext context = new SampleContext())
            {
                Worker v = new Worker();
                if (st.ID == 0)       // если мы добавляем нового работника 
                {
                    v = context.Workers.Where(x => x.FIO == st.FIO && x.Phone == st.Phone && x.RoleID == st.RoleID && x.Phone == st.Phone && x.Deldate == null).FirstOrDefault<Worker>();
                    if (v != null)
                    { return "Такой работник уже существует в базе под номером " + v.ID; }
                }
                else
                {
                    v = context.Workers.Where(x => x.FIO == st.FIO && x.Phone == st.Phone && x.RoleID == st.RoleID && x.Position == st.Position && x.Rate == st.Rate && x.Password == st.Password && x.BranchID == st.BranchID && x.Deldate == null).FirstOrDefault<Worker>();
                    if (v != null)
                    { return "Такой работник уже существует в базе под номером " + v.ID; }
                }
                
            }
            return "Данные корректны!";
        }


        public List<Contract> GetContracts()
        {
            using (SampleContext context = new SampleContext())
            {
                var v = context.Contracts.Where(x => x.ManagerID == this.ID).OrderBy(u => u.ID).ToList<Contract>();
                return v;
            }
        }

        public List<Timetable> getTimetables(DateTime date, bool deldate, int count, int page, string sort, string ascdesc, ref int countrecord)
        {
            Branch branch = new Branch();
            Course course = new Course();
            Cabinet cabinet = new Cabinet();
            Student student = new Student();

            List<Timetable> timetables = new List<Timetable>();
            return timetables = Timetables.FindAll(deldate, branch, cabinet, this, course, student, date, sort, ascdesc, page, count, ref countrecord);
        }

        public List<Timetable> getTimetables()
        {
            List<Timetable> list = new List<Timetable>();
            using (SampleContext db = new SampleContext())
            {    
                var timetableID = db.TimetablesTeachers.Where(p => p.TeacherID == this.ID);

                foreach (var p in timetableID)
                {
                    list.Add(Timetables.TimetableID(p.TimetableID));
                }
                return list;
            }
        }
        public double Salary(Timetable timetable)
        {
            using (SampleContext db = new SampleContext())
            {
                var paysst = db.Pays.Where(p => p.WorkerID == this.ID & p.TimetableID == timetable.ID)/* == null ? 0 : pays.Where(p => p.StudentID == this.ID)*/;
                if (paysst.Count() == 0)
                {
                    return Convert.ToDouble(this.Rate); /// Если у этого работника нет оплат по этому занятию
                }
                else
                {
                    double sumPays = (paysst/*.Where(p => p.ContractID == contract.ID)*/.Sum(p => p.Payment));
                    return Convert.ToDouble(this.Rate) + sumPays;
                }
            }
        }

        public double getDebt()
        {
            double costsAll = 0;
            using (SampleContext db = new SampleContext())
            {
                var pays = db.Pays.Join(db.TimetablesTeachers, // второй набор
        p => p.WorkerID, // свойство-селектор объекта из первого набора
        w => w.TeacherID,
        // свойство-селектор объекта из второго набора
        (p, w) => new // результат
        {
            ID = p.ID,
            WorkerID = p.WorkerID,
            Date = p.Date,
            BranchID = p.BranchID,
            Payment = p.Payment,
            Purpose = p.Purpose,
            Type = p.Type,
            Deldate = p.Deldate,
            TimetableID = w.TimetableID,
            TeacherID = w.TeacherID
        });

                var c = db.TimetablesTeachers.Where(p => p.TeacherID == this.ID);
                if (c.Count() == 0)
                {
                    costsAll = 0;
                }
                else
                {
                    costsAll = Convert.ToDouble(c.Count() * this.Rate); // Долг равен всей сумме долга(потому что еще не было ни одной оплаты)
                }

                var paysst = pays.Where(p => p.WorkerID == this.ID);
                if (paysst.Count() == 0)
                {                  
                    return costsAll;
                }
                else
                {
                    var paysAll = db.Pays.Where(p => p.WorkerID == this.ID)/* == null ? 0 : pays.Where(p => p.StudentID == this.ID)*/;
                    double sumPays = (paysAll.Sum(p => p.Payment));
                    return costsAll + sumPays;
                }
            }
        }
    }

    public static class Workers
    {
        public static Worker WorkerID(int id)
        {
            using (SampleContext context = new SampleContext())
            {
                Worker v = context.Workers.Where(x => x.ID == id).FirstOrDefault<Worker>();

                return v;
            }
        }

        //////////////////// ОДИН БОЛЬШОЙ ПОИСК !!! Если не введены никакие параметры, функция должна возвращать все филиалы //////////////////
        public static List<Worker> FindAll(Boolean deldate, Worker worker, Branch branch, String sort, String asсdesс, int page, int count, ref int countrecord) //deldate =false - все и удал и неудал!
        {
            List<Worker> list = new List<Worker>();
            using (SampleContext db = new SampleContext())
            {
                var query = from w in db.Workers
                            select w;

                //Убираем из списка данные об администраторе
                int admin = Roles.RoleName("Администратор").ID;
                query = query.Where(x => x.RoleID != admin);

                // Последовательно просеиваем наш список 

                if (deldate != false) // Убираем удаленных, если нужно
                {
                    query = query.Where(x => x.Deldate == null);
                }

                if (worker.FIO != null)
                {
                    query = query.Where(x => x.FIO == worker.FIO);
                }

                if (worker.Position != null)
                {
                    query = query.Where(x => x.Position == worker.Position);
                }

                if (worker.RoleID != 0)
                {
                    query = query.Where(x => x.RoleID == worker.RoleID);
                }

                if (branch.ID != 0)
                {
                    query = query.Where(x => x.BranchID == branch.ID);
                }

                if (sort != null)  // Сортировка, если нужно
                {
                    query = Utilit.OrderByDynamic(query, sort, asсdesс);
                }

                countrecord = query.GroupBy(u => u.ID).Count();

                query = query.Skip((page - 1) * count).Take(count);

                foreach (var p in query)
                {
                    list.Add(new Worker { ID = p.ID, FIO = p.FIO, RoleID = p.RoleID, Rate = p.Rate, Phone = p.Phone, Password = p.Password,  Position = p.Position, BranchID = p.BranchID, Deldate = p.Deldate, Editdate = p.Editdate });
                }
                return list;
            }
        }
    }
}
