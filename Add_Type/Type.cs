using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Diagnostics;
using Microsoft.Office.Interop.Word;
using System.Reflection;


//+ Type() DONE
//+Type(ID: Int) DONE
//+ add(): String DONE
//+ del(): String DONE
//+ edit(): String DONE
//+ getCourses():List<Course> DONE
//+ openTemplate(): String DONE
//+ createTemplate(): String   НЕ СДЕЛАНО!!!!!!!!!

namespace Add_Type
{
    public class Type
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public int Lessons { get; set; }
        public int Month { get; set; }
        public string Note { get; set; }
        public string pathTemplate { get; set; }
        public Nullable<System.DateTime> Deldate { get; set; }
        public Nullable<System.DateTime> Editdate { get; set; }

        public string Add()
        {
            string answer = Сheck(this);
            if (answer == "Данные корректны!")
            {
                using (SampleContext context = new SampleContext())
                {
                    context.Types.Add(this);
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
                o = "Удаление типа курса прошло успешно";
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

        public string Сheck(Type st)
        {
            if (st.Name == "")
            { return "Введите название типа курса. Это поле не может быть пустым"; }
            if (st.Cost <= 99)
            { return "Такое значение не допустимо для стоимости обучения по данному типу курса. Минимально допустимая стоимость обучения - 100 р."; }
            using (SampleContext context = new SampleContext())
            {
                Type v = new Type();
                if (st.ID == 0)       // если мы добавляем новый филиал 
                {
                    v = context.Types.Where(x => x.Name == st.Name && x.Cost == st.Cost && x.Lessons == st.Lessons && x.Month == st.Month && x.Deldate == null).FirstOrDefault<Type>();
                    if (v != null)
                    { return "Такой тип обучения уже существует в базе под номером " + v.ID; }
                }
                else
                {
                    v = context.Types.Where(x => x.Name == st.Name && x.Cost == st.Cost && x.Lessons == st.Lessons && x.Month == st.Month && x.Note == st.Note && x.pathTemplate == st.pathTemplate && x.Deldate == null).FirstOrDefault<Type>();
                    if (v != null)
                    { return "Такой тип обучения уже существует в базе под номером " + v.ID; }
                }
            }
            return "Данные корректны!";
        }

        public List<Course> GetCourses()    // Получение списка курсов этого ученика
        {
            using (SampleContext context = new SampleContext())
            {
                var v = context.Courses.Where(x => x.TypeID == this.ID).OrderBy(u => u.ID).ToList<Course>();
                return v;
            }
        }

        public string openTemplate()
        {
            try
            {
                var application = new Microsoft.Office.Interop.Word.Application();
                var document = new Microsoft.Office.Interop.Word.Document();
                document = application.Documents.Add(Environment.CurrentDirectory + "\\" + this.pathTemplate);
                var s = Environment.CurrentDirectory;

                application.Visible = true;

                return "Успешно";
            }
            catch
            {
                return "Возможно для данного типа курса не выбран шаблон, попробуйте для начала выбрать шаблон. Если ошибка не исправилась - обратитесь к администратору.";
            }
        }

        public string createTemplate()
        {
            string newLocation = " ";
            string folderLocation = "Templates";
            var OFD = new System.Windows.Forms.OpenFileDialog();
            if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileToCopy = OFD.FileName;
                if (System.IO.File.Exists(fileToCopy))
                {
                    var onlyFileName = System.IO.Path.GetFileName(OFD.FileName);
                    newLocation = folderLocation + "\\" + onlyFileName;
                    System.IO.File.Copy(fileToCopy, newLocation, true);

                    // Добавление этого адреса шаблона в  тип курса
                    this.pathTemplate = newLocation;
                    this.Edit();
                    return "Файл успешно скопирован";
                }
                else
                {
                    return "Файл не найден";
                }
            }
            return "Файл успешно скопирован";

        }
    }

    public static class Types
    {

        public static Type TypeID(int id)
        {
            using (SampleContext context = new SampleContext())
            {
                Type v = context.Types.Where(x => x.ID == id).FirstOrDefault<Type>();
                return v;
            }
        }

        //////////////////// ОДИН БОЛЬШОЙ ПОИСК !!! Если не введены никакие параметры, функция должна возвращать все типы //////////////////
        public static List<Type> FindAll(Boolean deldate, Type type, int minLes, int maxLes, double minCost, double maxCost, int minMonth, int maxMonth, String sort, String asсdesс, int page, int count, ref int countrecord) //deldate =false - все и удал и неудал!
        {
            List<Type> list = new List<Type>();
            using (SampleContext db = new SampleContext())
            {

                var query = from t in db.Types
                            select t;

                // Последовательно просеиваем наш список 

                if (deldate != false) // Убираем удаленных, если нужно
                {
                    query = query.Where(x => x.Deldate == null);
                }

                if (type.Name != null)
                {
                    query = query.Where(x => x.Name == type.Name);
                }

                if (minLes != 0)
                {
                    query = query.Where(x => x.Lessons >= minLes);
                }

                if (maxLes != 0)
                {
                    query = query.Where(x => x.Lessons <= maxLes);
                }

                if (minCost != 0)
                {
                    query = query.Where(x => x.Cost >= minCost);
                }

                if (maxCost != 0)
                {
                    query = query.Where(x => x.Cost <= maxCost);
                }

                if (minMonth != 0)
                {
                    query = query.Where(x => x.Month >= minMonth);
                }

                if (maxMonth != 0)
                {
                    query = query.Where(x => x.Month <= maxMonth);
                }

                if (sort != null)  // Сортировка, если нужно
                {
                    query = Utilit.OrderByDynamic(query, sort, asсdesс);
                }

                countrecord = query.GroupBy(u => u.ID).Count();

                query = query.Skip((page - 1) * count).Take(count);
                query = query.Distinct();

                foreach (var p in query)
                {
                    list.Add(new Type { ID = p.ID, Name = p.Name, Cost = p.Cost, Lessons = p.Lessons, Month = p.Month, Note = p.Note, Deldate = p.Deldate, Editdate = p.Editdate });
                }
                return list;
            }
        }
    }
}
