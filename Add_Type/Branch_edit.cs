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
    public partial class Branch_edit : Form
    {
        bool indicator; // Переменная отвечающая за распределение - или добавляется новый объект, или изменяется существующий
        int idforEdit; // ID для редактируемого объекта
        Boolean deldate = true; // true - неудален false - все!!!
        String sort = "ID";
        String asсdesс = "asc";
        //        bool ascflag = true;
        int page = 1;
        int count = 100;
        Branch newbranch = new Branch(); // Глобальная перменная этой формы
        public static Student chooseStudent; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public static Course chooseCourse; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public Branch_edit()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public Branch_edit(bool deldate) // Конструктор для добавление нового объекта
        {
            InitializeComponent();
            this.KeyPreview = true;
            indicator = true;

            buildDG();
        }
        public Branch_edit(Branch branch, bool deldate) // Конструктор для редактирования объекта
        {
            InitializeComponent();
            this.KeyPreview = true;
            indicator = false;
            idforEdit = branch.ID;

            newbranch = branch;
            buildDG();
            //FillForm(contract);
            FillForm();
        }

        private void buildDG() //Построение комбобоксов, гридов 
        {
            // Построение комбобокса директоров
            Branch branch = new Branch();
            Worker director = new Worker();
            int countrecord = 0;

            List<Branch> branches = new List<Branch>();
            branches = Branches.FindAll(deldate, branch, director, sort, asсdesс, page, count, ref countrecord);

            foreach (var s in branches)
            {
                // добавляем один элемент
                directorf.Items.Add(s.DirectorBranch + ". " + Workers.WorkerID(s.DirectorBranch).FIO);
            }
            this.directorf.SelectedIndex = 0;
        }
        private void FillForm()
        {
            this.Text = this.Text + newbranch.ID;
            namet.Text = newbranch.Name;
            addresst.Text = newbranch.Address;
            directorf.SelectedItem = newbranch.DirectorBranch + ". " + Workers.WorkerID(newbranch.DirectorBranch).FIO;
        }

        private void save_Click(object sender, EventArgs e)
        {
            string Answer = "";

            if (indicator == true) // Значит, что происходит добавление нового
            {
                newbranch.Name = namet.Text;
                newbranch.Address = addresst.Text;

                string[] dirID = (Convert.ToString(directorf.SelectedItem)).Split('.');
                newbranch.DirectorBranch = Workers.WorkerID(Convert.ToInt32(dirID[0])).ID;

                Answer = newbranch.Add();
            }

            if (indicator == false) // Значит, что происходит редактирование
            {
                newbranch = Branches.BranchID(idforEdit);

                newbranch.Name = namet.Text;
                newbranch.Address = addresst.Text;

                string[] dirID = (Convert.ToString(directorf.SelectedItem)).Split('.');
                newbranch.DirectorBranch = Workers.WorkerID(Convert.ToInt32(dirID[0])).ID;

                Answer = newbranch.Edit();
            }

            label4.Text = Answer;
            if (Answer == "Данные корректны!")
            {
                this.Close();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Branch_edit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
