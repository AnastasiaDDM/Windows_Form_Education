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
        public static Worker chooseDirector; // Эта переменная для приема значения из вызываемой(дочерней) формы
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
            directorf.Items.Clear();

            int countrecord = 0;

            Branch branch = new Branch();
            Worker wor = new Worker();
            wor.Type = 1;             

            List<Worker> workers = new List<Worker>();
            workers = Workers.FindAll(true, wor, branch, sort, asсdesс, page, count, ref countrecord);

            directorf.Items.Add("Не выбрано");
            foreach (var s in workers)
            {
                // добавляем один элемент
                directorf.Items.Add(s.ID + ". " + s.FIO);
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
                bool flag = Check(); // Вызовов функции проверки
                if (flag)
                {
                    newbranch.Name = namet.Text;
                    newbranch.Address = addresst.Text;

                    string[] dirID = (Convert.ToString(directorf.SelectedItem)).Split('.');
                    newbranch.DirectorBranch = Workers.WorkerID(Convert.ToInt32(dirID[0])).ID;

                    Answer = newbranch.Add();
                }
            }

            if (indicator == false) // Значит, что происходит редактирование
            {
                bool flag = Check(); // Вызовов функции проверки
                if (flag)
                {
                    newbranch = Branches.BranchID(idforEdit);

                    newbranch.Name = namet.Text;
                    newbranch.Address = addresst.Text;

                    string[] dirID = (Convert.ToString(directorf.SelectedItem)).Split('.');
                    newbranch.DirectorBranch = Workers.WorkerID(Convert.ToInt32(dirID[0])).ID;

                    Answer = newbranch.Edit();
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
            if (namet.Text == "")
            {
                errorProvider1.SetError(namet, "Введите наименование филиала. Это поле не может быть пустым.");
                return false;
            }
            if (addresst.Text == "")
            {
                errorProvider1.SetError(addresst, "Введите адрес. Это поле не может быть пустым.");
                return false;
            }
            if (directorf.SelectedIndex == 0)
            {
                errorProvider1.SetError(directorf, "Выберите директора или добавьте нового. Это поле не может быть пустым.");
                return false;
            }
            return true;
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

        private void adddirector_Click(object sender, EventArgs e)
        {
            // Добавление
            Worker_edit f = new Worker_edit(1, newbranch, true);  // Передаем true, так как это означает, что нам нужно отображать только неудаленные объекты
            DialogResult result = f.ShowDialog();
            chooseDirector = f.chooseDir;
            buildDG();
            if (chooseDirector != null)
            {
                this.directorf.SelectedItem = chooseDirector.ID + ". " + chooseDirector.FIO;
            }
            //FillForm();
        }
    }
}
