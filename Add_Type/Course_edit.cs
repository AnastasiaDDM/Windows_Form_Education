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
    public partial class Course_edit : Form
    {
        bool indicator; // Переменная отвечающая за распределение - или добавляется новый объект, или изменяется существующий
        int idforEdit; // ID для редактируемого объекта
        Boolean deldate; // true - неудален false - все!!!
        String sort = "ID";
        String asсdesс = "asc";
        //        bool ascflag = true;
        int page = 1;
        int count = 100;
        Course newcourse = new Course();
        public Course_edit()
        {
            InitializeComponent();
        }
        public Course_edit(bool deldate) // Конструктор для добавление нового объекта
        {
            InitializeComponent();
            indicator = true;

            buildDG();
        }
        public Course_edit(Course cour, bool deldate) // Конструктор для редактирования объекта
        {
            InitializeComponent();
            indicator = false;
            idforEdit = cour.ID;
            //        newcourse = cour;
            buildDG();
            FillForm(cour);
        }
        private void buildDG() //Построение комбобоксов, гридов 
        {
            // Построение комбобокса филиалов
            Branch branch = new Branch();
            Worker director = new Worker();
            int countrecord = 0;

            List<Branch> branches = new List<Branch>();
            branches = Branches.FindAll(deldate, branch, director, sort, asсdesс, page, count, ref countrecord);

            branchf.Items.Add("Не выбрано");
            foreach (var s in branches)
            {
                // добавляем один элемент
                branchf.Items.Add(s.ID + ". " + s.Name);
            }
            this.branchf.SelectedIndex = 0;

            // Построение комбобокса типов курсов
            Type type = new Type();
            int minLes = 0;
            int maxLes = 0;
            double minCost = 0;
            double maxCost = 0;
            int minMonth = 0;
            int maxMonth = 0;

            List<Type> types = new List<Type>();
            types = Types.FindAll(deldate, type, minLes, maxLes, minCost, maxCost, minMonth, maxMonth, sort, asсdesс, page, count, ref countrecord);

            typef.Items.Add("Не выбрано");
            foreach (var s in types)
            {
                // добавляем один элемент
                typef.Items.Add(s.ID + ". " + s.Name);
            }
            this.typef.SelectedIndex = 0;
        }
        private void FillForm(Course s)
        {
            this.Text = this.Text + s.ID;
            typef.SelectedItem = s.TypeID + ". " + Types.TypeID(s.TypeID).Name; ;
            namet.Text = s.nameGroup;
            costt.Text = s.Cost.ToString();
            branchf.SelectedItem = s.BranchID + ". " + Branches.BranchID(s.BranchID).Name;
            datefrom.Value = Convert.ToDateTime(s.Start);
            dateto.Value = Convert.ToDateTime(s.End);
        }

        private void save_Click(object sender, EventArgs e)
        {
            string Answer = "";

            if (indicator == true) // Значит, что происходит добавление нового
            {
                newcourse.nameGroup = namet.Text;
                newcourse.Start = datefrom.Value;
                newcourse.End = dateto.Value;
                newcourse.Cost = Convert.ToDouble(costt.Text);

                string[] branchID = (Convert.ToString(branchf.SelectedItem)).Split('.');
                newcourse.BranchID = Branches.BranchID(Convert.ToInt32(branchID[0])).ID;

                string[] typeID = (Convert.ToString(typef.Text)).Split('.');
                newcourse.TypeID = Types.TypeID(Convert.ToInt32(typeID[0])).ID;

                Answer = newcourse.Add();
            }

            if (indicator == false) // Значит, что происходит редактирование
            {
                newcourse = Courses.CourseID(idforEdit);

                newcourse.nameGroup = namet.Text;
                newcourse.Start = datefrom.Value;
                newcourse.End = dateto.Value;
                newcourse.Cost = Convert.ToDouble(costt.Text);

                string[] branchID = (Convert.ToString(branchf.SelectedItem)).Split('.');
                newcourse.BranchID = Branches.BranchID(Convert.ToInt32(branchID[0])).ID;

                string[] typeID = (Convert.ToString(typef.Text)).Split('.');
                newcourse.TypeID = Types.TypeID(Convert.ToInt32(typeID[0])).ID;

                Answer = newcourse.Edit();
            }

            label8.Text = Answer;
            if (Answer == "Данные корректны!")
            {
                this.Close();
            }
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
