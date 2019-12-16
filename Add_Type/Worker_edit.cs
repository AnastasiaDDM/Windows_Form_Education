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
    public partial class Worker_edit : Form
    {
        bool indicator; // Переменная отвечающая за распределение - или добавляется новый объект, или изменяется существующий
        int idforEdit; // ID для редактируемого объекта
        Boolean deldate = true; // true - неудален false - все!!!
        String sort = "ID";
        String asсdesс = "asc";
        //        bool ascflag = true;
        int page = 1;
        int count = 100;
        Worker newworker = new Worker(); // Глобальная перменная этой формы
        public static Student chooseStudent; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public static Course chooseCourse; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public Worker_edit()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public Worker_edit(bool deldate) // Конструктор для добавление нового объекта
        {
            InitializeComponent();
            this.KeyPreview = true;
            indicator = true;

            buildDG();
        }
        public Worker_edit(Worker worker, bool deldate) // Конструктор для редактирования объекта
        {
            InitializeComponent();
            this.KeyPreview = true;
            indicator = false;
            idforEdit = worker.ID;

            newworker = worker;
            buildDG();
            FillForm();
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
        private void FillForm()
        {
            this.Text = this.Text + newworker.ID;
            fiot.Text = newworker.FIO;
            phonet.Text = newworker.Phone;
            positiont.Text = newworker.Position;
            ratet.Text = newworker.Rate.ToString();
            passwordt.Text = newworker.Password.ToString();

            if(newworker.Type == 1)
            {
                typef.SelectedIndex = 0;
            }
            if (newworker.Type == 2)
            {
                typef.SelectedIndex = 1;
            }
            if (newworker.Type == 3)
            {
                typef.SelectedIndex = 2;
            }


            if (newworker.BranchID == 0)
            {
                branchf.SelectedIndex = 0;
            }
            else
            {
                branchf.SelectedItem = newworker.BranchID + ". " + Branches.BranchID(Convert.ToInt32(newworker.BranchID)).Name;
            }
        }
        private void save_Click(object sender, EventArgs e)
        {
            string Answer = "";

            newworker.FIO = fiot.Text;

            if(ratet.Text == "")
            {
                newworker.Rate = null;
            }
            else
            {
                newworker.Rate = Convert.ToDouble(ratet.Text);
            }
            
            newworker.Phone = phonet.Text;
            newworker.Position = positiont.Text;
            newworker.Password = passwordt.Text;

            if (branchf.SelectedIndex == 0)
            {
                newworker.BranchID = 0;
            }
            else
            {
                string[] branchID = (Convert.ToString(branchf.SelectedItem)).Split('.');
                newworker.BranchID = Branches.BranchID(Convert.ToInt32(branchID[0])).ID;
            }

            if (typef.SelectedIndex == 0)
            {
                newworker.Type = 1;
            }
            if (typef.SelectedIndex == 1)
            {
                newworker.Type = 2;
            }
            if (typef.SelectedIndex == 2)
            {
                newworker.Type = 3;
            }

            // Проверка действий
            if (indicator == true) // Значит, что происходит добавление нового
            {
                Answer = newworker.Add();
            }

            if (indicator == false) // Значит, что происходит редактирование
            {
                Answer = newworker.Edit();
            }

            label9.Text = Answer;
            if (Answer == "Данные корректны!")
            {
                this.Close();
            }
        }

        private void positiont_TextChanged(object sender, EventArgs e)
        { 
            foreach(var o in this.typef.Items)
            {
                if(positiont.Text.ToLower().Contains(o.ToString().ToLower()))
                {
                    typef.SelectedItem = o;
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
