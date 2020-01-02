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
        public static Contract chooseContract; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public static Worker chooseTeacher; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public static Timetable chooseTimetable; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public Contract contract;   // Глобальная переменная объявляет договор данной формы
        public Timetable timetable;   // Глобальная переменная объявляет занятие данной формы
        public Worker teacher;   // Глобальная переменная объявляет преподавателя данной формы
        public Pay pay = new Pay();
        int idforEdit; // ID для редактируемого объекта
        Boolean deldate = true; // true - неудален false - все!!!
        int count = 20;
        int page = 1;
        String sort = "ID";
        String asсdesс = "asc";
        bool indicator; // Переменная отвечающая за распределение - или добавляется новый объект, или изменяется существующий
        double maxvalue;

        string format2 = "HH:mm"; // Формат для отображения даты 

        string format = "dd.MM.yy HH:mm"; // Формат для отображения даты 

        public Pay_edit()
        {
            InitializeComponent();
            this.KeyPreview = true;
            indicator = true;

            // Блокировка кнопок, которые нельзя использовать
            bcon.Enabled = false;
            contractf.Enabled = false;
            bteach.Enabled = false;
            teacherf.Enabled = false;
            btime.Enabled = false;
            timetablef.Enabled = false;
            this.indicatorf.SelectedIndex = 0;
            this.typef.SelectedIndex = 0;

            FillForm();
        }
        public Pay_edit(Contract con, double max) // Конструктор для добавления объекта по договору
        {
            InitializeComponent();
            this.KeyPreview = true;
            indicator = true;
            contract = con;
            // Блокировка кнопок, которые нельзя использовать
            bcon.Enabled = false;
            contractf.Enabled = false;
            bteach.Enabled = false;
            teacherf.Enabled = false;
            btime.Enabled = false;
            timetablef.Enabled = false;
            maxvalue = max;
            incomef.Checked = true;
            indicatorf.Enabled = false;
            this.indicatorf.SelectedIndex = 0;
            this.typef.SelectedIndex = 0;

            if (contract.Canceldate != null) // Договор расторжен, нужно установить максимальную сумму возврата!
            {
                incomef.Checked = false;
                incomef.Enabled = false;

                maxvalue = contract.Cost - max; // Максимал. сумма  = сумме выплат клиента
            }

                FillForm();
        }

        public Pay_edit(Worker teach, Timetable timetab, double max) // Конструктор для добавления объекта по занятию и работнику
        {
            InitializeComponent();
            this.KeyPreview = true;
            indicator = true;
            teacher = teach;
            timetable = timetab;
            // Блокировка кнопок, которые нельзя использовать
            bcon.Enabled = false;
            contractf.Enabled = false;
            bteach.Enabled = false;
            teacherf.Enabled = false;
            btime.Enabled = false;
            timetablef.Enabled = false;
            indicatorf.Enabled = false;
            this.indicatorf.SelectedIndex = 0;
            this.typef.SelectedIndex = 0;
            maxvalue = max;
            incomef.Checked = false;
            incomef.Enabled = false;

            FillForm();
        }
        public Pay_edit(Pay p) // Конструктор для редактирования объекта
        {
            InitializeComponent();
            idforEdit = p.ID;
            this.KeyPreview = true;
            indicator = false;
            pay = p;
            this.Text = this.Text + pay.ID;

            this.indicatorf.SelectedIndex = 0;
            this.typef.SelectedIndex = 0;

            FillForm();
        }
        private void FillForm()
        {
            Branch branch = new Branch();
            Worker director = new Worker();
            int countrecord = 0;

            List<Branch> branches = new List<Branch>();
            branches = Branches.FindAll(deldate, branch, director, sort, asсdesс, page, count, ref countrecord);
            int pages = Convert.ToInt32(Math.Ceiling((double)countrecord / count));

            branchf.Items.Add("Не выбрано");
            foreach (var s in branches)
            {
                // добавляем один элемент
                branchf.Items.Add(s.ID + ". " + s.Name);
            }
            this.branchf.SelectedIndex = 0;
            //if (Singleton.getPerson().ID != 0 | Singleton.getPerson().BranchID != 0 | Singleton.getPerson().BranchID != null) // выбор филиала. если у авторизированного менеджера есть филиал
            //{
            //    this.branchf.SelectedItem = Singleton.getPerson().BranchID + ". " + Branches.BranchID(Convert.ToInt32(Singleton.getPerson().BranchID)).Name;
            //}

            // Установление общих данных для добавления и редактирования
            if (contract != null | pay.ContractID != null)
            {
                indicatorf.SelectedIndex = 1;
                pay.Indicator = 1;
            }
            if (teacher != null | pay.WorkerID != null)
            {
                indicatorf.SelectedIndex = 2;
                pay.Indicator = 2;
            }


            if (indicator == true) // Для добавления
            {
                if(contract != null)
                {
                    branchf.SelectedItem = contract.BranchID + ". " + Branches.BranchID(contract.BranchID).Name;
                    pay.ContractID = contract.ID;
                    contractf.Text = "№ " + contract.ID;
                }
                if(teacher != null)
                {
                    branchf.SelectedItem = Cabinets.CabinetID(timetable.CabinetID).BranchID + ". " + Branches.BranchID(Cabinets.CabinetID(timetable.CabinetID).BranchID).Name;
                    pay.WorkerID = teacher.ID;
                    teacherf.Text = teacher.ID + ". " + teacher.FIO ;

                    pay.TimetableID = timetable.ID;
                    timetablef.Text = timetable.ID + ". " + timetable.Startlesson.ToString(format) + " - " + timetable.Endlesson.ToString(format2);
                }

                // Это для выбора договора по конпке поиска договоров
                if (chooseContract != null)
                {
                    contractf.Text = "№ " + chooseContract.ID;
                    chooseContract = null;
       //             contract = Contracts.ContractID(chooseContract.ID);
                }
                // Это для выбора по конпке поиска преподавателя
                if (chooseTeacher != null)
                {
                    teacherf.Text = chooseTeacher.ID + ". " + chooseTeacher.FIO;
                    chooseTeacher = null;
        //            contract = Wo.ContractID(chooseTeacher.ID);
                }
                // Это для выбора по конпке поиска занятия
                if (chooseTimetable != null)
                {
                    timetablef.Text = chooseTimetable.ID + ". " + chooseTimetable.Startlesson.ToString(format) + " - " + chooseTimetable.Endlesson.ToString(format2);
                    chooseTimetable = null;
                }
            }
            else // Для редактирования
            {
                branchf.SelectedItem = pay.BranchID + ". " + Branches.BranchID(pay.BranchID).Name;
                datef.Value = pay.Date;
                if (pay.Payment < 0) // Выбор приход это или убыток
                {
                    incomef.Checked = false;
                }
                else
                {
                    incomef.Checked = true;
                }
                paymentt.Text = pay.Payment.ToString();
                typef.SelectedItem = pay.Type;
                purposef.Text = pay.Purpose;
                if (pay.ContractID != null)
                {
                    contractf.Text = "№ " + pay.ContractID;
                }
                if (pay.WorkerID != null)
                {
                    teacherf.Text = pay.WorkerID.ToString() + ". " + Workers.WorkerID(Convert.ToInt32(pay.WorkerID)).FIO;
                    timetablef.Text = pay.TimetableID + ". " + Timetables.TimetableID(Convert.ToInt32(pay.TimetableID)).Startlesson.ToString(format) + " - " + Timetables.TimetableID(Convert.ToInt32(pay.TimetableID)).Endlesson.ToString(format2);
                }


                    ////             pay.ContractID = pay.ContractID;
                    //contractt.Text = "№" + pay.ContractID;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string Answer = "";

            bool flag = Check(); // Вызовов функции проверки
            if (flag)
            {
                string[] branchID = (Convert.ToString(branchf.SelectedItem)).Split('.');
                pay.BranchID = Branches.BranchID(Convert.ToInt32(branchID[0])).ID;
                pay.Date = DateTime.Now;
                pay.Purpose = purposef.Text;
                pay.Type = typef.SelectedItem.ToString();

                if (contractf.Text != "")
                {
                    string[] contrID = (Convert.ToString(contractf.Text)).Split(' ');
                    pay.ContractID = Convert.ToInt32(contrID[1]);

                    if (incomef.Checked == true)
                    {
                        pay.Payment = Convert.ToDouble(paymentt.Text);
                    }
                    else
                    {
                        pay.Payment = -Convert.ToDouble(paymentt.Text);
                    }

                }
                else
                {
                    string[] teachID = (Convert.ToString(teacherf.Text)).Split('.');
                    pay.WorkerID = Convert.ToInt32(teachID[0]);

                    string[] timeID = (Convert.ToString(timetablef.Text)).Split('.');
                    pay.TimetableID = Convert.ToInt32(timeID[0]);

                    pay.Payment = -Convert.ToDouble(paymentt.Text);
                }

                if (indicator == true) // Значит, что происходит добавление нового
                {
                    Answer = pay.Add();
                }

                if (indicator == false) // Значит, что происходит редактирование
                {
                    Answer = pay.Edit();
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
            if (indicatorf.SelectedIndex == 0)
            {
                errorProvider1.SetError(indicatorf, "Выберите индикатор оплаты. Это поле не может быть пустым.");
                return false;
            }
            if (indicatorf.SelectedIndex == 1) // оплата по договору
            {
                if (contractf.Text == "")
                {
                    errorProvider1.SetError(label1, "Выберите договор. Это поле не может быть пустым.");
                    return false;
                }
            }
            if (indicatorf.SelectedIndex == 2) // оплата зп преподавателю
            {
                if (teacherf.Text == "")
                {
                    errorProvider1.SetError(label7, "Выберите преподавателя. Это поле не может быть пустым.");
                    return false;
                }
                if (timetablef.Text == "")
                {
                    errorProvider1.SetError(label10, "Выберите занятие. Это поле не может быть пустым.");
                    return false;
                }
            }
            if (branchf.SelectedIndex == 0)
            {
                errorProvider1.SetError(branchf, "Выберите филиал. Это поле не может быть не определено.");
                return false;
            }
            if (paymentt.Text == "")
            {
                errorProvider1.SetError(paymentt, "Введите размер оплаты. Это поле не может быть пустым.");
                return false;
            }
            if (typef.SelectedIndex == 0)
            {
                errorProvider1.SetError(typef, "Выберите способ оплаты. Это поле не может быть пустым.");
                return false;
            }
            return true;
        }

        private void bcon_Click(object sender, EventArgs e)
        {
            Contract_find f = new Contract_find("choose", "b"); // Передем choose - это означает, что нужно добавить кнопку выбора родителя
            DialogResult result = f.ShowDialog();
            chooseContract = f.chooseCon; // Передаем ссылку форме родителей на переменную в этой форме
            if(chooseContract != null)
            {
                chooseTeacher = null;
                teacherf.Clear();
            }
            FillForm();
        }

        private void bteach_Click(object sender, EventArgs e)
        {
            Worker_find f = new Worker_find("choose", 3); // Передем choose - это означает, что нужно добавить кнопку выбора родителя
            DialogResult result = f.ShowDialog();
            chooseTeacher = f.chooseWor; // Передаем ссылку форме родителей на переменную в этой форме
            if (chooseTeacher != null)
            {
                chooseContract = null;
                contractf.Clear();
            }
            FillForm();
        }

        private void btime_Click(object sender, EventArgs e)
        {
            string[] teachID = (Convert.ToString(teacherf.Text)).Split('.');

            Timetable_find f = new Timetable_find(Workers.WorkerID(Convert.ToInt32(teachID[0])), "choose"); // Передем choose - это означает, что нужно добавить кнопку выбора 
            DialogResult result = f.ShowDialog();
            chooseTimetable = f.chooseTime; // Передаем ссылку форме родителей на переменную в этой форме
            FillForm();
        }

        private void paymentt_TextChanged(object sender, EventArgs e)
        {
            if (paymentt.Text != "" & maxvalue != 0)
            {
                if (Convert.ToDouble(paymentt.Text) > maxvalue)
                {
                    erpay.SetError(paymentt, "Размер оплаты не может быть больше размера долга") ;
                    paymentt.Text = maxvalue.ToString();
                }
                //else
                //{
                //    erpay.Clear();
                //}
            }
        }

        private void indicatorf_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(indicatorf.SelectedIndex == 1)
            {
                bcon.Enabled = true;
                contractf.Enabled = true;
                bteach.Enabled = false;
                teacherf.Enabled = false;
                btime.Enabled = false;
                timetablef.Enabled = false;
                incomef.Checked = true;
                incomef.Enabled = true;
            }
            if (indicatorf.SelectedIndex == 2)
            {
                bcon.Enabled = false;
                contractf.Enabled = false;
                bteach.Enabled = true;
                teacherf.Enabled = true;
                //btime.Enabled = true;
                //timetablef.Enabled = true;
                incomef.Checked = false;
                incomef.Enabled = false;
            }
        }

        private void incomef_CheckedChanged(object sender, EventArgs e)
        {
            //if(incomef.Checked == true)
            //{

            //}
        }

        private void Pay_edit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void teacherf_TextChanged(object sender, EventArgs e)
        {
            if(teacherf.Text == "")
            {
                btime.Enabled = false;
                timetablef.Enabled = false;
            }
            else
            {
                btime.Enabled = true;
                timetablef.Enabled = true;
            }
        }
    }
}
