using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Type
{
    class Singleton
    {
        private static Worker person;
        public static Worker getPerson()
        {
            if (person == null)
            {
                person = new Worker();
            }
            return person;
        }

        public static Worker delPerson()
        {
            person = null;
            return person;
        }
        public static Worker inputPerson(string phone, string password)
        {
            using (SampleContext context = new SampleContext())
            {
                person = context.Workers.Where(x => x.Phone == phone & x.Password == password).FirstOrDefault<Worker>();

                return person;
            }
        }
    }

    public class Role
    {
        public int ID { get; set; }
        public String Name { get; set; }
    }

    public class Roles
    {
        public static List<Role> GetRoles()
        {
            using (SampleContext context = new SampleContext())
            {
                // Список ролей у центра, не считая Администратора
                var roles = context.Roles.Where(x => x.Name != "Администратор").ToList();
                return roles;
            }
        }
        public static Role RoleID(int id)
        {
            using (SampleContext context = new SampleContext())
            {
                Role v = context.Roles.Where(x => x.ID == id).FirstOrDefault<Role>();

                return v;
            }
        }

        public static Role RoleName(string name)
        {
            using (SampleContext context = new SampleContext())
            {
                Role v = context.Roles.Where(x => x.Name == name).FirstOrDefault<Role>();

                return v;
            }
        }
    }

    public class Action
    {
        public int ID { get; set; }
        public String Name { get; set; }
    }
    public class Prohibition
    {
        public int ID { get; set; }
        public int RoleID { get; set; }
        public int ActionID { get; set; }


        public static  bool Banned(string name) // Возвращает true -  если запрета нет, false - запрет есть
        {
            using (SampleContext context = new SampleContext())
            {
                Worker worker = Singleton.getPerson();
                Action action = new Action();
                action = context.Actions.Where(x => x.Name == name).FirstOrDefault<Action>();
                if (action != null)
                {
                    Prohibition v = new Prohibition();
                    v = context.Prohibitions.Where(x => x.RoleID == worker.RoleID && x.ActionID == action.ID).FirstOrDefault<Prohibition>();
                    if (v != null) // Если v - пустое значение, значит запрета нет! возвращаем true
                    {
                        return false;
                    }
                }  
            }
            return true;
        }
    }
}
