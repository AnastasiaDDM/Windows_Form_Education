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
    public partial class payAll : Form
    {
        public Student student;
        public Worker teacher;
        public payAll()
        {
            InitializeComponent();
        }
        public payAll(Student stud)
        {
            InitializeComponent();
            this.KeyPreview = true;
            student = stud;
            paymentt.Text = student.getDebt().ToString();
            datet.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            lableperson.Text = "Ученик";
            labelpay.Text = "Оплата";
            person.Text = student.FIO;
            buildDG();
        }

        public payAll(Worker wor)
        {
            InitializeComponent();
            this.KeyPreview = true;
            teacher = wor;
            paymentt.Text = teacher.getDebt().ToString();
            datet.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            lableperson.Text = "Работник";
            labelpay.Text = "Оплата";
            person.Text = teacher.FIO;
            buildDG();
        }
        public void buildDG()
        {
            this.typef.SelectedIndex = 0;

            Branch branch = new Branch();
            Worker director = new Worker();
            int countrecord = 0;

            List<Branch> branches = new List<Branch>();
            branches = Branches.FindAll(true, branch, director, "ID", "asc", 1, 100, ref countrecord);

            branchf.Items.Add("Не выбрано");
            foreach (var s in branches)
            {
                // добавляем один элемент
                branchf.Items.Add(s.ID + ". " + s.Name);
            }
            this.branchf.SelectedIndex = 0;

            if (Convert.ToInt32(Singleton.getPerson().BranchID) != 0 | Singleton.getPerson().BranchID != null) // выбор филиала. если у авторизированного менеджера есть филиал
            {
                if (Branches.BranchID(Convert.ToInt32(Singleton.getPerson().BranchID)) != null) // Вот с этой строкой работает . но почему не работает предыдущее условие 
                {
                    this.branchf.SelectedItem = Singleton.getPerson().BranchID + ". " + Branches.BranchID(Convert.ToInt32(Singleton.getPerson().BranchID)).Name;
                }

            }
        }

        private void bpay_Click(object sender, EventArgs e)
        {
            bool flag = Check(); // Вызовов функции проверки
            if (flag)
            {
                string Answer = "";
                string[] branchID = (Convert.ToString(branchf.SelectedItem)).Split('.');
                int BranchID = Branches.BranchID(Convert.ToInt32(branchID[0])).ID;
                DateTime Date = DateTime.Now;
                String Type = typef.SelectedItem.ToString();

                if(student != null) // Оплата всех договоров учеником
                {
                    List<Contract> contracts = student.GetContracts();
                    foreach (var c in contracts)
                    {
                        Pay pay = new Pay();
                        pay.BranchID = BranchID;
                        pay.Date = Date;
                        pay.Type = Type;
                        pay.ContractID = c.ID;
                        pay.Indicator = 1;
                        if (c.getDebt() > 0) // Добавляем оплату только тогда, когда задолженность больше 0
                        {
                            pay.Payment = c.getDebt();
                            Answer = pay.Add();
                        }
                    }
                }
                if(teacher != null) // Оплата зп преподавателю
                {
                    List<Timetable> timetables = teacher.getTimetables();
                    foreach (var c in timetables)
                    {
                        Pay pay = new Pay();
                        pay.BranchID = BranchID;
                        pay.Date = Date;
                        pay.Type = Type;
                        pay.WorkerID = teacher.ID;
                        pay.TimetableID = c.ID;
                        pay.Indicator = 2;
                        if (teacher.Salary(c) > 0) // Добавляем оплату только тогда, когда задолженность больше 0
                        {
                            pay.Payment = -teacher.Salary(c);
                            Answer = pay.Add();
                        }
                    }
                }
               
                if (Answer == "Данные корректны!")
                {
                    this.Close();
                }
                else
                {
                    errorProvider1.SetError( bpay, Answer );
                }
            }
        }

        public bool Check() // Проверка всех введеннных данных 
        {
            errorProvider1.Clear();
            if (branchf.SelectedIndex == 0)
            {
                errorProvider1.SetError(branchf, "Выберите филиал. Это поле не может быть не определено.");
                return false;
            }
            if (typef.SelectedIndex == 0)
            {
                errorProvider1.SetError(typef, "Выберите способ оплаты. Это поле не может быть пустым.");
                return false;
            }
            return true;
        }
    }
}
