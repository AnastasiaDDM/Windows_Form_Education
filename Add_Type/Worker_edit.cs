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
        int page = 1;
        int count = 100;
        Worker newworker = new Worker(); // Глобальная перменная этой формы
        public static Student chooseStudent; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public static Course chooseCourse; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public Worker chooseDir; // Эта переменная для пересылке своего значения в вызывающую форму
        public Worker_edit()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public Worker_edit(bool deldate) // Конструктор для добавление нового объекта
        {
            InitializeComponent();
            this.KeyPreview = true;
            fiot.Select(); // Установка курсора
            indicator = true;

            buildDG();
        }

        public Worker_edit(int type, Branch br, bool deldate) // Конструктор для добавление нового объекта с заданным типом (например, директор) 
            // и с заданным значение филиала
        {
            InitializeComponent();
            this.KeyPreview = true;
            fiot.Select(); // Установка курсора
            indicator = true;

            buildDG();
            if (type == Roles.RoleName("Директор").ID || type == Roles.RoleName("Директор филиала").ID)
            {
                typef.SelectedItem = Roles.RoleID(type).Name;
                typef.Enabled = false;
                ratet.Visible = false;
                lrate.Visible = false;
                lrate2.Visible = false;
                positiont.Text = Roles.RoleID(type).Name;
 //             branchf.SelectedItem = ?
 //  ПУСТЬ БУДЕТ ТАК, ЧТО ДИРЕКТОР ВООБЩЕ МОЖЕТ БЫТЬ ФИЛИАЛА, НО РУКОВОДИТЬ НЕСКОЛЬКИМИ ФИЛИАЛАМИ
            }
        }
        public Worker_edit(Worker worker, bool deldate) // Конструктор для редактирования объекта
        {
            InitializeComponent();
            this.KeyPreview = true;
            fiot.Select(); // Установка курсора
            indicator = false;
            idforEdit = worker.ID;

            newworker = worker;
            this.Text = this.Text + newworker.ID;

            if ( newworker.RoleID != 3)
            {
                ratet.Visible = false;
                lrate.Visible = false;
                lrate2.Visible = false;
            }
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

            // Построение комбобокса ролей, типов
            List<Role> roles = Roles.GetRoles();

            typef.Items.Add("Не выбрано");
            foreach (var s in roles)
            {
                // добавляем один элемент
                typef.Items.Add(s.Name);
            }
            this.typef.SelectedIndex = 0;
        }
        private void FillForm()
        {
            fiot.Text = newworker.FIO;
            phonet.Text = newworker.Phone;
            positiont.Text = newworker.Position;
            ratet.Text = newworker.Rate.ToString();
            passwordt.Text = newworker.Password.ToString();

            typef.SelectedItem = Roles.RoleID(newworker.RoleID).Name;

            if (newworker.BranchID == 0 || newworker.BranchID == null)
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

            bool flag = Check(); // Вызовов функции проверки
            if (flag)
            {
                newworker.FIO = fiot.Text;

                if (ratet.Text == "")
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

                newworker.RoleID = Roles.RoleName(typef.SelectedItem.ToString()).ID;

                // Проверка действий
                if (indicator == true) // Значит, что происходит добавление нового
                {
                    chooseDir = newworker;
                    Answer = newworker.Add();
                }

                if (indicator == false) // Значит, что происходит редактирование
                {
                    Answer = newworker.Edit();
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
            if (fiot.Text == "")
            {
                errorProvider1.SetError(fiot, "Введите ФИО. Это поле не может быть пустым.");
                return false;
            }
            if (positiont.Text == "")
            {
                errorProvider1.SetError(positiont, "Введите должность. Это поле не может быть пустым.");
                return false;
            }
            if (typef.SelectedItem == null)
            {
                errorProvider1.SetError(typef, "Выберите тип должности. Это поле не может быть не определено.");
                return false;
            }
            if (typef.SelectedIndex == 0)
            {
                errorProvider1.SetError(typef, "Выберите тип должности. Это поле не может быть не определено.");
                return false;
            }
            if (typef.SelectedItem.ToString() == "Преподаватель")
            {
                errorProvider1.SetError(ratet, "Введите ставку преподавателя. Это поле не может быть не определено.");
                return false;
            }
            if (phonet.Text == "+7(   )    -")
            {
                errorProvider1.SetError(phonet, "Введите номер телефона. Это поле не может быть пустым.");
                return false;
            }
            if (passwordt.Text == "")
            {
                errorProvider1.SetError(passwordt, "Введите пароль. Он будет использоваться при входе в систему.");
                return false;
            }
            return true;
        }
        private void positiont_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            foreach (var o in this.typef.Items)
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

        private void Worker_edit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void fiot_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void typef_SelectionChangeCommitted(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void phonet_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void passwordt_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void ratet_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
