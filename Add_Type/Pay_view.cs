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
    public partial class Pay_view : Form
    {
        public Pay pay;   // Глобальная переменная объявляет объект данной формы
        string formattotext = "dd.MM.yyyy HH:mm"; // Формат для отображения даты в текстовые поля
        public Pay_view()
        {
            InitializeComponent();
        }
        public Pay_view(Pay st) // Конструктор для просмотра объекта
        {
            InitializeComponent();
            this.KeyPreview = true;
            pay = st;
            this.Text = this.Text + pay.ID;

            FillForm();
        }

        private void FillForm()
        {   // Заполнение формы известными данными о договоре
            brancht.Text = pay.BranchID + ". " + Branches.BranchID(pay.BranchID).Name;
            datet.Text = pay.Date.ToString(formattotext);
            paymentt.Text = pay.Payment.ToString();
            typet.Text = pay.Type;
            purposet.Text = pay.Purpose;
            
            if(pay.ContractID != null)
            {
                contractt.Text = "№" + pay.ContractID;
            }
            else
            {
                teachert.Text = "№" + pay.WorkerID + " " + Workers.WorkerID(Convert.ToInt32(pay.WorkerID)).FIO;
                timetabt.Text = "№" + pay.TimetableID + " " + Timetables.TimetableID(Convert.ToInt32(pay.TimetableID)).Startlesson;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void contractt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Открытие формы для просмотра данных
            Contract_view f = new Contract_view(Contracts.ContractID(Convert.ToInt32(pay.ContractID)));
            f.Show();
        }

        private void brancht_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Branch_view f = new Branch_view(Branches.BranchID(pay.BranchID));
            DialogResult result = f.ShowDialog();
        }

        private void Pay_view_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void teachert_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Worker_view f = new Worker_view(Workers.WorkerID(Convert.ToInt32(pay.WorkerID)));
            DialogResult result = f.ShowDialog();
        }

        private void timetabt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Timetable_view f = new Timetable_view(Timetables.TimetableID(Convert.ToInt32(pay.TimetableID)));
            DialogResult result = f.ShowDialog();
        }
    }
}
