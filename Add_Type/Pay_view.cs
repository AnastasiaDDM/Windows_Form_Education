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
            pay = st;
            FillForm();
        }

        private void FillForm()
        {   // Заполнение формы известными данными о договоре
            this.Text = this.Text + pay.ID;

            brancht.Text = pay.BranchID + ". " + Branches.BranchID(pay.BranchID).Name;
            datet.Text = pay.Date.ToString(formattotext);
            paymentt.Text = pay.Payment.ToString();
            typet.Text = pay.Type;
            purposet.Text = pay.Purpose;
            contractt.Text = "№" + pay.ContractID;

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
    }
}
