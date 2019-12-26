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

        bool editBan; // Перменная для хранения доступа к редактированию
        bool delBan; // Перменная для хранения доступа к удалению
        public Contract_view()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public Contract_view(Contract st) // Конструктор для просмотра объекта
        {
            InitializeComponent();
            this.KeyPreview = true;

            contract = st;

            Access();
            FillForm();
            buildDG();
            FillGrid();
        }

        private void Access() // Реализация разделения ролей
        {
            // Заперт на добавление и удаление одиннаковый
            delBan = Prohibition.Banned("add_del_pay");
            addpay.Enabled = delBan;
            bcancel.Visible = Prohibition.Banned("cancellation_contract");
            editBan = Prohibition.Banned("edit_pay");
        }
        private void buildDG() //Построение грида 
        {
            D.Columns.Clear();
            D.Rows.Clear();

            if (editBan == false)
            {
                DataGridViewTextBoxColumn edit = new DataGridViewTextBoxColumn();
                D.Columns.Add(edit);
            }
            else
            {
                DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
                D.Columns.Add(edit);
            }

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

            D.Columns.Add(id);
            D.Columns.Add(st);
            D.Columns.Add(ph);
            D.Columns.Add(br);
            D.Columns.Add(type);
            D.Columns.Add(pur);


            DataGridViewButtonColumn remove = new DataGridViewButtonColumn();
            remove.HeaderText = "Удалить?";
            D.Columns.Add(remove);
            D.Columns[7].Visible = delBan;
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
            debtt.Text = contract.getDebt().ToString();
            if(contract.Canceldate != null)
            {
                cancel.Text = "Договор расторжен " + contract.Canceldate;
                //addpay.Enabled = false;
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
            // Редактирование конкретной оплаты по договору
            if (e.ColumnIndex == 0)
            {
                if (editBan == true) // Запрета нет
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
            if (e.ColumnIndex == 7)
            {
                if (delBan == true) // Запрета нет
                {
                    if (e.RowIndex > -1)
                    {
                        if (D.RowCount - 1 >= e.RowIndex)
                        {
                            int l = e.RowIndex;
                            const string message = "Вы уверены, что хотите удалить оплату?";
                            const string caption = "Удаление";
                            var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                            if (result == DialogResult.OK)
                            {
                                // Форма не закрывается
                                int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
                                D.Rows.Remove(D.Rows[l]);
                                Pay o = Pays.PayID(k);
                                String ans = o.Del();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Эту строку нельзя удалить, в ней нет данных!");
                        }
                    }
                }
            }
        }

        private void addpay_Click(object sender, EventArgs e)
        {   // Добавление оплаты по договору
            Pay_edit f = new Pay_edit(contract, contract.getDebt());
            DialogResult result = f.ShowDialog();
            FillForm();
            FillGrid();
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
            DialogResult result = f.ShowDialog();
        }

        private void courset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Открытие формы для просмотра данных
            Course_view f = new Course_view(Courses.CourseID(contract.CourseID));
            DialogResult result = f.ShowDialog();
            FillGrid();
        }

        private void brancht_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Branch_view f = new Branch_view(Branches.BranchID(contract.BranchID));
            DialogResult result = f.ShowDialog();
        }

        private void managert_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Worker_view f = new Worker_view(Workers.WorkerID(contract.ManagerID));
            DialogResult result = f.ShowDialog();
        }

        private void Contract_view_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
