using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Type
{
    class Singleton
    {

        //private static Singleton person;
        private static Worker person;


        public static Worker getPerson()
        {
            if (person == null)
            {
                person = new Worker();
            }
            return person;
        }

        public static Worker inputPerson(string phone, string password)
        {
            using (SampleContext context = new SampleContext())
            {
               person = context.Workers.Where( x => x.Phone == phone & x.Password == password).FirstOrDefault<Worker>();

                return person;
            }
        }
    }
}
