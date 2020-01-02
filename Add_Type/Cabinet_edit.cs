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
    public partial class Cabinet_edit : Form
    {
        bool indicator; // Переменная отвечающая за распределение - или добавляется новый объект, или изменяется существующий
        int idforEdit; // ID для редактируемого объекта
        Boolean deldate = true; // true - неудален false - все!!!
        String sort = "ID";
        String asсdesс = "asc";
        //        bool ascflag = true;
        int page = 1;
        int count = 100;
        Cabinet newcabinet = new Cabinet(); // Глобальная перменная этой формы
        public Cabinet_edit(bool deldate) // Конструктор для добавление нового объекта
        {
            InitializeComponent();
            this.KeyPreview = true;
            numbert.Select();
            indicator = true;

            buildDG();
        }
        public Cabinet_edit(Cabinet cabinet, bool deldate) // Конструктор для редактирования объекта
        {
            InitializeComponent();
            this.KeyPreview = true;
            numbert.Select();
            indicator = false;
            idforEdit = cabinet.ID;

            newcabinet = cabinet;
            this.Text = this.Text + newcabinet.ID;

            buildDG();
            //FillForm(contract);
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
            numbert.Text = newcabinet.Number;
            capacityf.Text = newcabinet.Capacity.ToString();
            branchf.SelectedItem = newcabinet.BranchID + ". " + Branches.BranchID(newcabinet.BranchID).Name;
        }

        private void save_Click(object sender, EventArgs e)
        {
            string Answer = "";

            if (indicator == true) // Значит, что происходит добавление нового
            {
                bool flag = Check(); // Вызовов функции проверки
                if (flag)
                {
                    newcabinet.Number = numbert.Text;
                    newcabinet.Capacity = Convert.ToInt32(capacityf.Text);

                    string[] branchID = (Convert.ToString(branchf.SelectedItem)).Split('.');
                    newcabinet.BranchID = Branches.BranchID(Convert.ToInt32(branchID[0])).ID;

                    Answer = newcabinet.Add();
                }
            }

            if (indicator == false) // Значит, что происходит редактирование
            {
                bool flag = Check(); // Вызовов функции проверки
                if (flag)
                {
                    newcabinet = Cabinets.CabinetID(idforEdit);

                    newcabinet.Number = numbert.Text;
                    newcabinet.Capacity = Convert.ToInt32(capacityf.Text);

                    string[] branchID = (Convert.ToString(branchf.SelectedItem)).Split('.');
                    newcabinet.BranchID = Branches.BranchID(Convert.ToInt32(branchID[0])).ID;

                    Answer = newcabinet.Edit();
                }
            }
            if (Answer == "Данные корректны!")
            {
                this.Close();
            }
            else
            {
                errorProvider1.SetError(save, Answer);
            }
        }

        public bool Check() // Проверка всех введеннных данных 
        {
            errorProvider1.Clear();
            if (numbert.Text == "")
            {
                errorProvider1.SetError(numbert, "Введите номер кабинета. Это поле не может быть пустым.");
                return false;
            }
            if (branchf.SelectedIndex == 0)
            {
                errorProvider1.SetError(branchf, "Выберите филиал. Это поле не может быть не определено.");
                return false;
            }
            if (capacityf.Value <= 0)
            {
                errorProvider1.SetError(capacityf, "Выберите вместимость кабинета.");
                return false;
            }
            return true;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cabinet_edit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
