using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add_Type
{
    public partial class List : Form
    {
        Worker inputperson = Singleton.getPerson(); // Авторизированный объект
        public List()
        {
            InitializeComponent();
            this.KeyPreview = true;

            // Реализация разделения ролей
            if(inputperson.Type == 1 ) // Директор
            {
                btomark.Enabled = false;
            }
            if (inputperson.Type == 2) // Менеджер
            {
                btomark.Enabled = false;
            }
            if (inputperson.Type == 3) // Преподаватель
            {
            }


            ////// Реализация разделения ролей
            ////if (inputperson.Type == 1) // Директор
            ////{

            ////}
            ////if (inputperson.Type == 2) // Менеджер
            ////{

            ////}
            ////if (inputperson.Type == 3) // Преподаватель
            ////{

            ////}

        }

        private void bcabinet_Click(object sender, EventArgs e)
        {
            Cabinet_find f = new Cabinet_find();
            DialogResult result = f.ShowDialog();
            //chooseContract = f.chooseCon; // Передаем ссылку форме родителей на переменную в этой форме
            //FillGrid();
        }

        private void bworker_Click(object sender, EventArgs e)
        {
            Worker_find f = new Worker_find(); 
            DialogResult result = f.ShowDialog();
        }

        private void bbranch_Click(object sender, EventArgs e)
        {
            Branch_find f = new Branch_find();
            DialogResult result = f.ShowDialog();
        }

        private void bstudent_Click(object sender, EventArgs e)
        {
            Student_find f = new Student_find();
            DialogResult result = f.ShowDialog();
        }

        private void bcontract_Click(object sender, EventArgs e)
        {
            Contract_find f = new Contract_find();
            DialogResult result = f.ShowDialog();
        }

        private void bpay_Click(object sender, EventArgs e)
        {
            Pay_find f = new Pay_find();
            DialogResult result = f.ShowDialog();
        }

        private void btype_Click(object sender, EventArgs e)
        {
            Type_find f = new Type_find();
            DialogResult result = f.ShowDialog();
        }

        private void bcourse_Click(object sender, EventArgs e)
        {
            Course_find f = new Course_find();
            DialogResult result = f.ShowDialog();
        }

        private void btheme_Click(object sender, EventArgs e)
        {
            Theme_find f = new Theme_find();
            DialogResult result = f.ShowDialog();
        }

        private void btimetable_Click(object sender, EventArgs e)
        {
            Timetable_find f = new Timetable_find();
            DialogResult result = f.ShowDialog();
        }

        private void bgrade_Click(object sender, EventArgs e)
        {
            Grade_find f = new Grade_find();
            DialogResult result = f.ShowDialog();
        }

        private void bvisit_Click(object sender, EventArgs e)
        {
            Visit_find f = new Visit_find();
            DialogResult result = f.ShowDialog();
        }

        private void btomark_Click(object sender, EventArgs e)
        {
            Timetable_find f = new Timetable_find("toMark");
            DialogResult result = f.ShowDialog();
        }

        private void bparent_Click(object sender, EventArgs e)
        {
            Parent_find f = new Parent_find();
            DialogResult result = f.ShowDialog();
        }
        private void List_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void List_Load(object sender, EventArgs e)
        {
            //DialogResult result = DialogResult.Cancel;







            Input f = new Input();
            while (Singleton.getPerson().ID == 0)
            {
                f.ShowDialog();
            }








            //while (result != DialogResult.OK)
            //{
            //    result = f.ShowDialog();

            //    if (Singleton.getPerson() ==null && f.isEmpty())
            //    {
            //        Environment.Exit(0);
            //    }
            //    if (Singleton.getPerson() != null)
            //    {
            //        break;
            //    }
            //}

        }

        private void bcountcontract_Click(object sender, EventArgs e)
        {
            Statistic f = new Statistic("count");
            DialogResult result = f.ShowDialog();
        }

        private void bprofit_Click(object sender, EventArgs e)
        {
            Statistic f = new Statistic("profit");
            DialogResult result = f.ShowDialog();
        }

        private void brevenue_Click(object sender, EventArgs e)
        {
            Statistic f = new Statistic("revenue");
            DialogResult result = f.ShowDialog();
        }
    }
}
