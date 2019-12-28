using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Type
{
    public class TimetablesThemes
    {
        public int ID { get; set; }
        public int ThemeID { get; set; }
        public int TimetableID { get; set; }

        public static TimetablesThemes TimetablesThemesID(int id)
        {
            using (SampleContext context = new SampleContext())
            {
                TimetablesThemes v = context.TimetablesThemes.Where(x => x.ID == id).FirstOrDefault<TimetablesThemes>();
                return v;
            }
        }

        public static TimetablesThemes TimetablesThemesID(Timetable time, Theme theme)
        {
            using (SampleContext context = new SampleContext())
            {
                var v = context.TimetablesThemes.Where(x => x.ThemeID == theme.ID & x.TimetableID == time.ID).FirstOrDefault<TimetablesThemes>();
                return v;
            }
        }
    }
}
