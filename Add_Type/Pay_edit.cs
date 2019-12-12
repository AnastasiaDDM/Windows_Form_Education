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
    public partial class Pay_edit : Form
    {
        public Contract contract;   // Глобальная переменная объявляет договор данной формы
        public Pay pay = new Pay();
        Boolean deldate = true; // true - неудален false - все!!!
        int count = 20;
        int page = 1;
        String sort = "ID";
        String asсdesс = "asc";
        bool indicator; // Переменная отвечающая за распределение - или добавляется новый объект, или изменяется существующий
        public Pay_edit()
        {
            InitializeComponent();
        }
        public Pay_edit(Contract con) // Конструктор для добавления объекта
        {
            InitializeComponent();
            indicator = true;
            contract = con;

            FillForm();
  //          FillGrid();
        }
        private void FillForm()
        {
            Branch branch = new Branch();
            Worker director = new Worker();
            int countrecord = 0;

            List<Branch> branches = new List<Branch>();
            branches = Branches.FindAll(deldate, branch, director, sort, asсdesс, page, count, ref countrecord);
            int pages = Convert.ToInt32(Math.Ceiling((double)countrecord / count));

            foreach (var s in branches)
            {
                // добавляем один элемент
                branchf.Items.Add(s.ID + ". " + s.Name);
            }

            branchf.SelectedItem = contract.BranchID + ". " + Branches.BranchID(contract.BranchID).Name;
            indicatorf.SelectedIndex = 0;
            pay.Indicator = 1;
            pay.ContractID = contract.ID;



            contractt.Text = "№" + contract.ID;

            
            //fiot.Text = student.FIO;
            //debtt.Text = student.getDebt().ToString();
            //phonet.Text = student.Phone;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Pay_edit_Load(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            string Answer = "";

            if (indicator == true) // Значит, что происходит добавление нового
            {
                string[] branchID = (Convert.ToString(branchf.SelectedItem)).Split('.');
                pay.BranchID = Branches.BranchID(Convert.ToInt32(branchID[0])).ID;
                pay.Date = DateTime.Now;
                pay.Payment = Convert.ToDouble(paymentf.Text);
                pay.Purpose = purposef.Text;
                pay.Type = typef.SelectedItem.ToString();

                Answer = pay.Add();
            }

            //if (indicator == false) // Значит, что происходит редактирование
            //{
            //    Student st = Students.StudentID(idforEdit);

            //    st.FIO = fiof.Text;
            //    st.Phone = phonef.Text;
            //    Answer = st.Edit();
            //}

            label6.Text = Answer;
            if (Answer == "Данные корректны!")
            {
                this.Close();
            }
        }
    }
}
