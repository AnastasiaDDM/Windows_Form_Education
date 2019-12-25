using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;
using System.Data;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


//+Contract() DONE
//+Contract(ID: Int) DONE
//+ add(): String DONE
//+ del(): String DONE
//+ edit(): String DONE
//+ Cancellation(): String DONE
//+ addPay(Payment: Double): String DONE
//+ getPays() DONE


namespace Add_Type
{
    public class Contract
    {
        public int ID { get; set; }
        public System.DateTime Date { get; set; }
        public double Cost { get; set; }
        public double PayofMonth { get; set; }
        public Nullable<System.DateTime> Deldate { get; set; }
        public Nullable<System.DateTime> Editdate { get; set; }
        public Nullable<System.DateTime> Canceldate { get; set; }
        
        public int StudentID { get; set; }
        public Student Student { get; set; }

        public int CourseID { get; set; }
        public Course Course { get; set; }

        public int ManagerID { get; set; }
        public Worker Manager { get; set; }

        public int BranchID { get; set; }
        public Branch Branch { get; set; }

        public Contract()
        { } 
        public string Add()
        {
            string answer = Сheck(this);
            if (answer == "Данные корректны!")
            {
                using (SampleContext context = new SampleContext())
                { // При добавлении договора ученик добавляется автоматически на курс
                    StudentsCourses stpar = new StudentsCourses();
                    stpar.StudentID = this.StudentID;
                    stpar.CourseID = this.CourseID;
                    context.Contracts.Add(this);
                    context.StudentsCourses.Add(stpar);
                    context.SaveChanges();

 //                   answer = "Добавление договора прошло успешно";
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
//                    answer = "Редактирование договора прошло успешно";
                }
                return answer;
            }
            return answer;
        }

        public string Cancellation()
        {
            string o;
            using (SampleContext context = new SampleContext())
            {
                this.Canceldate = DateTime.Now;
                context.Entry(this).State = EntityState.Modified;
                context.SaveChanges();
                o = "Договор расторжен ";
            }
            return o;
        }
        public string Сheck(Contract st)
        {
            using (SampleContext context = new SampleContext())
            {
                if (st.ID == 0)       // если мы добавляем новый 
                {
                    StudentsCourses v = new StudentsCourses();
                    v = context.StudentsCourses.Where(x => x.StudentID == st.StudentID && x.CourseID == st.CourseID).FirstOrDefault<StudentsCourses>();
                    if (v != null)
                    { return "Этот ученик уже числится на этом курсе"; }
                    if (st.Cost <= 99)
                    { return "Такое значение не допустимо для стоимости курса. Минимально допустимая стоимость обучения - 100 р."; }
                    if (st.Cost < st.PayofMonth)
                    { return "Стоимость обучения не можеть быть меньше, чем плата за месяц."; }
                }
                else
                {
                    if (st.Cost <= 99)
                    { return "Такое значение не допустимо для стоимости курса. Минимально допустимая стоимость обучения - 100 р."; }
                    if (st.Cost < st.PayofMonth)
                    { return "Стоимость обучения не можеть быть меньше, чем плата за месяц."; }
                }
            }

            return "Данные корректны!";      
        }

        public string addPay(Pay p)
        {
            p.ContractID = this.ID;
            string ans = p.Add();
            return ans;
        }

        public List<Pay> GetPays()
        {
            using (SampleContext context = new SampleContext())
            {
                var v = context.Pays.Where(x => x.ContractID == this.ID & x.Deldate == null).OrderBy(u => u.ID).ToList<Pay>();
                return v;
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
            Date = p.Date,
            BranchID = p.BranchID,
            Payment = p.Payment,
            Purpose = p.Purpose,
            Type = p.Type,
            Deldate = p.Deldate,
            StudentID = c.StudentID,
            Cost = c.Cost
        });
                //double sumPays = (pays.Where(p => p.StudentID == this.ID & p.ContractID == contract.ID)).Count() == 0 ? 0 : pays.Where(p => p.StudentID == this.ID & p.ContractID == contract.ID).Sum(p => p.Payment);

                var paysst = pays.Where(p => p.ContractID == this.ID)/* == null ? 0 : pays.Where(p => p.StudentID == this.ID)*/;
                if (paysst.Count() == 0)
                {// То есть если оплат по договору нет, значит, что и paysst - будет пустым, но переход на договор осуществляется из форма,
                    // а это значит, что договор точно существует, а оплат на него нет - то есть задолженность = Cost = c.Cost
                    // Но есть и такой случай, когда у ученика вообще неот договоров - тогда задолженность = 0
                    //var c = db.Contracts.Where(p => p.StudentID == this.ID);
                    //if (c.Count() == 0)
                    //{
                    //    return 0;
                    //}
                    //else
                    //{
                    //    return c.Sum(p => p.Cost);
                    //}
                    return this.Cost;
                }
                else
                {
                    double sumPays = (paysst.Sum(p => p.Payment));
                    return this.Cost - sumPays;
                }
            }
        }
    }

    public static class Contracts
    {
        public static Contract ContractID(int id)
        {
            using (SampleContext context = new SampleContext())
            {
                Contract v = context.Contracts.Where(x => x.ID == id).FirstOrDefault<Contract>();
                return v;
            }
        }

        public static Contract ContractID(Student s, Course c)
        {
            using (SampleContext context = new SampleContext())
            {
                Contract v = context.Contracts.Where(x => x.CourseID == c.ID & x.StudentID == s.ID).FirstOrDefault<Contract>();
                return v;
            }
        }

        //public static List<Contract> GetCo()      // Просто так, для получения нефильтрованного списка
        //{
        //    //      var context = new SampleContext();
        //    using (SampleContext db = new SampleContext())
        //    {
        //        var contracts = db.Contracts.ToList();
        //        return contracts;
        //    }
        //}

        //////////////////// ОДИН БОЛЬШОЙ ПОИСК !!! Если не введены никакие параметры, функция должна возвращать все договоры //////////////////
        public static List<Contract> FindAll(Boolean deldate, Student student, Worker manager, Branch branch, Course course, DateTime mindate, DateTime maxdate, int min, int max, String sort, String asсdesс, int page, int count, ref int countrecord) //deldate =false - все и удал и неудал!
        {
            List<Contract> list = new List<Contract>();
            using (SampleContext db = new SampleContext())
            {

                //var query = from b in db.Branches
                //            join w in db.Workers on b.DirectorBranch equals w.ID
                //            select new { BID = b.ID, BName = b.Name, BAddress = b.Address, BDeldate = b.Deldate, BEditdate = b.Editdate, BDirectorID = b.DirectorBranch, WID = w.ID };

                var query = from c in db.Contracts
                            select c;

                                // Последовательно просеиваем наш список 

                if (deldate != false) // Убираем удаленных, если нужно
                {
                    query = query.Where(x => x.Deldate == null);
                }

                if (branch.ID != 0)
                {
                    query = query.Where(x => x.BranchID == branch.ID);
                }

                if (student.ID != 0)
                {
                    query = query.Where(x => x.StudentID == student.ID);
                }
                if (manager.ID != 0)
                {
                    query = query.Where(x => x.ManagerID == manager.ID);
                }

                if (course.ID != 0)
                {
                    query = query.Where(x => x.CourseID == course.ID);
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
                    query = query.Where(x => x.Cost >= min);
                }

                if (max != 0)
                {
                    query = query.Where(x => x.Cost <= max);
                }

                if (sort != null)  // Сортировка, если нужно
                {
                    query = Utilit.OrderByDynamic(query, sort, asсdesс);
                }

                // Я перепроверила все варианты - это должно работать правильно!
                countrecord = query.GroupBy(u => u.ID).Count();

                query = query.Skip((page - 1) * count).Take(count);
                query = query.Distinct();

                foreach (var p in query)
                {
                    list.Add(new Contract { ID = p.ID, Date = p.Date, StudentID = p.StudentID, CourseID = p.CourseID, BranchID = p.BranchID, ManagerID = p.ManagerID, Cost = p.Cost, PayofMonth = p.PayofMonth, Canceldate = p.Canceldate, Deldate = p.Deldate, Editdate = p.Editdate });
                }
                return list;
            }
        }
    }
}
