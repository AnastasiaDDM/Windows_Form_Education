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
    public partial class Contract_edit : Form
    {
        bool indicator; // Переменная отвечающая за распределение - или добавляется новый объект, или изменяется существующий
        int idforEdit; // ID для редактируемого объекта
        Boolean deldate; // true - неудален false - все!!!
        String sort = "ID";
        String asсdesс = "asc";
//        bool ascflag = true;
        int page = 1;
        int count = 100;
        Contract newcontract = new Contract();
        public Contract_edit()
        {
            InitializeComponent();
        }
        public Contract_edit(bool deldate) // Конструктор для добавление нового объекта
        {
            InitializeComponent();
            indicator = true;

            buildDG();
        }
        public Contract_edit(Contract contract, bool deldate) // Конструктор для редактирования объекта
        {
            InitializeComponent();
            indicator = false;
            idforEdit = contract.ID;

            buildDG();
            FillForm(contract);
        }
        private void LoadAll()
        {

 //           buildDG();
 ////           FillForm(contract);
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
        }
        private void FillForm(Contract s)
        {
            this.Text = this.Text + s.ID;
            datef.Value = s.Date;
            studentt.Text = s.StudentID + ". " + Students.StudentID(s.StudentID).FIO;
            courset.Text = s.CourseID + ". " + Courses.CourseID(s.CourseID).nameGroup;
            costt.Text = s.Cost.ToString();
            payt.Text = s.PayofMonth.ToString();
            branchf.SelectedItem = s.BranchID + ". " + Branches.BranchID(s.BranchID).Name;
        }

        private void save_Click(object sender, EventArgs e)
        {
            string Answer = "";

            if (indicator == true) // Значит, что происходит добавление нового
            {
                newcontract.Date = datef.Value;
                string[] branchID = (Convert.ToString(branchf.SelectedItem)).Split('.');
                newcontract.BranchID = Branches.BranchID(Convert.ToInt32(branchID[0])).ID;

                string[] studentID = (Convert.ToString(studentt.Text)).Split('.');
                newcontract.StudentID = Students.StudentID(Convert.ToInt32(studentID[0])).ID;

                string[] courseID = (Convert.ToString(courset.Text)).Split('.');
                newcontract.CourseID = Courses.CourseID(Convert.ToInt32(courseID[0])).ID;
                newcontract.Cost = Convert.ToDouble(costt.Text);
                newcontract.PayofMonth = Convert.ToDouble(payt.Text);
                // еЩЕ нужно добавить менеджера!!!!!!!!!!!!!!!!!!!!1 от из формы авторизации!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                Answer = newcontract.Add();
            }

            if (indicator == false) // Значит, что происходит редактирование
            {
                newcontract = Contracts.ContractID(idforEdit);

                newcontract.Date = datef.Value;
                string[] branchID = (Convert.ToString(branchf.SelectedItem)).Split('.');
                newcontract.BranchID = Branches.BranchID(Convert.ToInt32(branchID[0])).ID;

                string[] studentID = (Convert.ToString(studentt.Text)).Split('.');
                newcontract.StudentID = Students.StudentID(Convert.ToInt32(studentID[0])).ID;

                string[] courseID = (Convert.ToString(courset.Text)).Split('.');
                newcontract.CourseID = Courses.CourseID(Convert.ToInt32(courseID[0])).ID;
                newcontract.Cost = Convert.ToDouble(costt.Text);
                newcontract.PayofMonth = Convert.ToDouble(payt.Text);
                // еЩЕ нужно добавить менеджера!!!!!!!!!!!!!!!!!!!! от из формы авторизации!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                Answer = newcontract.Edit();
            }

            label9.Text = Answer;
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
