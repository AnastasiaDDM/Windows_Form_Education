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
    public partial class Contract_view : Form
    {
        public Contract contract;   // Глобальная переменная объявляет объект данной формы
        public Contract_view()
        {
            InitializeComponent();
        }
        public Contract_view(Contract st) // Конструктор для просмотра объекта
        {
            InitializeComponent();

            contract = st;

            FillForm();
            buildDG();
            FillGrid();
        }
        private void buildDG() //Построение грида 
        {
            D.Columns.Clear();
            D.Rows.Clear();

            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.HeaderText = "№";
            DataGridViewTextBoxColumn st = new DataGridViewTextBoxColumn();
            st.HeaderText = "Дата оплаты";
            DataGridViewTextBoxColumn ph = new DataGridViewTextBoxColumn();
            ph.HeaderText = "Оплата";
            DataGridViewTextBoxColumn br = new DataGridViewTextBoxColumn();
            br.HeaderText = "Филиал";
            DataGridViewTextBoxColumn type = new DataGridViewTextBoxColumn();
            type.HeaderText = "Способ оплаты";
            DataGridViewTextBoxColumn pur = new DataGridViewTextBoxColumn();
            pur.HeaderText = "Назначение";

            D.Columns.Add(edit);
            D.Columns.Add(id);
            D.Columns.Add(st);
            D.Columns.Add(ph);
            D.Columns.Add(br);
            D.Columns.Add(type);
            D.Columns.Add(pur);


            DataGridViewButtonColumn remove = new DataGridViewButtonColumn();
            remove.HeaderText = "Удалить?";
            D.Columns.Add(remove);
            D.ReadOnly = true;
        }

        private void FillForm()
        {   // Заполнение формы известными данными о договоре
            this.Text = this.Text + contract.ID;

            managert.Text = contract.ManagerID + ". " + Workers.WorkerID(contract.ManagerID).FIO;
            studentt.Text = contract.StudentID + ". " + Students.StudentID(contract.StudentID).FIO;
            brancht.Text = contract.BranchID + ". " + Branches.BranchID(contract.BranchID).Name;
            courset.Text = contract.CourseID + ". " + Courses.CourseID(contract.CourseID).nameGroup;
            costt.Text = contract.Cost.ToString();
            paymentt.Text = contract.PayofMonth.ToString();
            if(contract.Canceldate != null)
            {
                cancel.Text = "Договор расторжен " + contract.Canceldate;
                addpay.Enabled = false;
                bcancel.Enabled = false;
            }
        }

        private void FillGrid() 
        {
            // Заполняем гриды, комбобоксы
            D.Rows.Clear();
            List<Pay> pays = new List<Pay>();
            pays = contract.GetPays();
            for (int i = 0; i < pays.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                D.Rows.Add(row);

                D.Rows[i].Cells[0].Value = /*(page - 1) * count +*/ i + 1 + "✎";   // Отображение счетчика записей и значок редактирования

                D.Rows[i].Cells[1].Value = pays[i].ID;

                D.Rows[i].Cells[2].Value = pays[i].Date;

                D.Rows[i].Cells[3].Value = pays[i].Payment;

                D.Rows[i].Cells[4].Value = pays[i].BranchID + ". " + Branches.BranchID(pays[i].BranchID).Name;

                D.Rows[i].Cells[5].Value = pays[i].Type;

                D.Rows[i].Cells[6].Value = pays[i].Purpose;

                D.Rows[i].Cells[7].Value = "Удалить";
            }
        }

        private void D_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Просмотр конкретной оплаты по договору
            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex > -1)
                {
                    if (D.RowCount - 1 >= e.RowIndex)
                    {
                        int l = e.RowIndex;
                        int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
                        Pay pay = Pays.PayID(k);

                        Pay_edit f = new Pay_edit(pay);
                        f.Show();
                    }
                }
            }
        }

        private void addpay_Click(object sender, EventArgs e)
        {   // Добавление оплаты по договору
            Pay_edit f = new Pay_edit(contract);
            f.Show();
        }
        private void bcancel_Click(object sender, EventArgs e)
        {
            // Расторжение договора
            const string message = "Вы уверены, что хотите расторгнуть договор?";
            const string caption = "Расторжение договора";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                // Форма не закрывается
                Contract v = Contracts.ContractID(contract.ID);
                string a = v.Cancellation();
                cancel.Text = a + v.Canceldate;
            }
        }
        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void D_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Открытие формы для просмотра данных
            if (e.RowIndex > -1)
            {
                int l = e.RowIndex;
                int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
                Pay_view f = new Pay_view(Pays.PayID(k));
                f.Show();
            }
        }

        private void studentt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Открытие формы для просмотра данных
            Student_view f = new Student_view(Students.StudentID(contract.StudentID));
            f.Show();
        }

        private void courset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Открытие формы для просмотра данных
            Course_view f = new Course_view(Courses.CourseID(contract.CourseID));
            DialogResult result = f.ShowDialog();
            FillGrid();
        }
    }
}
