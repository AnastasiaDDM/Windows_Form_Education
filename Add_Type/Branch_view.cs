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
    public partial class Branch_view : Form
    {
        public Branch branch;   // Глобальная переменная объявляет объект данной формы
        public Branch_view()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public Branch_view(Branch st) // Конструктор для просмотра объекта
        {
            InitializeComponent();
            this.KeyPreview = true;

            branch = st;

            FillForm();
            buildDG();
            FillGrid();
        }
        private void buildDG() //Построение грида 
        {
            // Преподаватели
            gridworker.Columns.Clear();
            gridworker.Rows.Clear();

            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.HeaderText = "№";
            DataGridViewTextBoxColumn fio = new DataGridViewTextBoxColumn();
            fio.HeaderText = "ФИО";
            DataGridViewTextBoxColumn ph = new DataGridViewTextBoxColumn();
            ph.HeaderText = "Телефон";
            DataGridViewTextBoxColumn pos = new DataGridViewTextBoxColumn();
            pos.HeaderText = "Должность";
            DataGridViewTextBoxColumn rate = new DataGridViewTextBoxColumn();
            rate.HeaderText = "Ставка";

            gridworker.Columns.Add(edit);
            gridworker.Columns.Add(id);
            gridworker.Columns.Add(fio);
            gridworker.Columns.Add(ph);
            gridworker.Columns.Add(pos);
            gridworker.Columns.Add(rate);


            DataGridViewButtonColumn remove = new DataGridViewButtonColumn();
            remove.HeaderText = "Удалить?";
            gridworker.Columns.Add(remove);
            gridworker.ReadOnly = true;

            // Кабинеты
            gridcabinet.Columns.Clear();
            gridcabinet.Rows.Clear();

            DataGridViewButtonColumn edit0 = new DataGridViewButtonColumn();
            DataGridViewTextBoxColumn id0 = new DataGridViewTextBoxColumn();
            id0.HeaderText = "№";
            DataGridViewTextBoxColumn num = new DataGridViewTextBoxColumn();
            num.HeaderText = "Наименование кабинета";
            DataGridViewTextBoxColumn cap = new DataGridViewTextBoxColumn();
            cap.HeaderText = "Вместимость";

            gridcabinet.Columns.Add(edit0);
            gridcabinet.Columns.Add(id0);
            gridcabinet.Columns.Add(num);
            gridcabinet.Columns.Add(cap);

            DataGridViewButtonColumn remove1 = new DataGridViewButtonColumn();
            remove.HeaderText = "Удалить?";
            gridcabinet.Columns.Add(remove1);
            gridcabinet.ReadOnly = true;

            // Курсы
            gridcourse.Columns.Clear();
            gridcourse.Rows.Clear();
            DataGridViewButtonColumn edit1 = new DataGridViewButtonColumn();
            DataGridViewTextBoxColumn idc = new DataGridViewTextBoxColumn();
            idc.HeaderText = "№";
            DataGridViewTextBoxColumn group = new DataGridViewTextBoxColumn();
            group.HeaderText = "Группа";
            DataGridViewTextBoxColumn cost = new DataGridViewTextBoxColumn();
            cost.HeaderText = "Стоимость";
            DataGridViewTextBoxColumn type = new DataGridViewTextBoxColumn();
            type.HeaderText = "Тип курса";
            DataGridViewTextBoxColumn start = new DataGridViewTextBoxColumn();
            start.HeaderText = "Начало курса";
            DataGridViewTextBoxColumn end = new DataGridViewTextBoxColumn();
            end.HeaderText = "Окончание курса";

            gridcourse.Columns.Add(edit1);
            gridcourse.Columns.Add(idc);
            gridcourse.Columns.Add(group);
            gridcourse.Columns.Add(type);
            gridcourse.Columns.Add(cost);
            gridcourse.Columns.Add(start);
            gridcourse.Columns.Add(end);
            gridcourse.ReadOnly = true;

            // Договоры
            gridcontract.Columns.Clear();
            gridcontract.Rows.Clear();
            DataGridViewButtonColumn edit2 = new DataGridViewButtonColumn();
            DataGridViewTextBoxColumn idcon = new DataGridViewTextBoxColumn();
            idcon.HeaderText = "№";
            DataGridViewTextBoxColumn date = new DataGridViewTextBoxColumn();
            date.HeaderText = "Дата";
            DataGridViewTextBoxColumn course = new DataGridViewTextBoxColumn();
            course.HeaderText = "Курс";
            DataGridViewTextBoxColumn cost2 = new DataGridViewTextBoxColumn();
            cost2.HeaderText = "Стоимость";
            DataGridViewTextBoxColumn payment = new DataGridViewTextBoxColumn();
            payment.HeaderText = "Оплата за месяц";
            DataGridViewTextBoxColumn manager = new DataGridViewTextBoxColumn();
            manager.HeaderText = "Менеджер";

            gridcontract.Columns.Add(edit2);
            gridcontract.Columns.Add(idcon);
            gridcontract.Columns.Add(date);
            gridcontract.Columns.Add(course);
            gridcontract.Columns.Add(cost2);
            gridcontract.Columns.Add(payment);
            gridcontract.Columns.Add(manager);
            gridcontract.ReadOnly = true;
        }

        private void FillForm()
        {   // Заполнение формы известными данными о филиале

            this.Text = this.Text + branch.ID;
            namet.Text = branch.Name;
            addresst.Text = branch.Address;
            directort.Text = branch.DirectorBranch + ". " + Workers.WorkerID(branch.DirectorBranch).FIO;
        }

        private void FillGrid()
        {
            // Заполняем гриды, комбобоксы
            gridworker.Rows.Clear();
            List<Worker> teachers = new List<Worker>();
            teachers = branch.GetWorkers();
            for (int i = 0; i < teachers.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                gridworker.Rows.Add(row);

                gridworker.Rows[i].Cells[0].Value = i + 1 + "✎";   // Отображение счетчика записей и значок редактирования

                gridworker.Rows[i].Cells[1].Value = teachers[i].ID;

                gridworker.Rows[i].Cells[2].Value = teachers[i].FIO;

                gridworker.Rows[i].Cells[3].Value = teachers[i].Phone;

                gridworker.Rows[i].Cells[4].Value = teachers[i].Position;

                gridworker.Rows[i].Cells[5].Value = teachers[i].Rate;

                gridworker.Rows[i].Cells[6].Value = "Удалить";
            }

            gridcabinet.Rows.Clear();
            List<Cabinet> cabinets = new List<Cabinet>();
            cabinets = branch.GetCabinets();
            for (int i = 0; i < cabinets.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                gridcabinet.Rows.Add(row);

                gridcabinet.Rows[i].Cells[0].Value = i + 1 + "✎";   // Отображение счетчика записей и значок редактирования

                gridcabinet.Rows[i].Cells[1].Value = cabinets[i].ID;

                gridcabinet.Rows[i].Cells[2].Value = cabinets[i].Number;

                gridcabinet.Rows[i].Cells[3].Value = cabinets[i].Capacity;

                gridcabinet.Rows[i].Cells[4].Value = "Удалить";
            }


            gridcontract.Rows.Clear();
            List<Contract> contracts = new List<Contract>();
            contracts = branch.GetContracts();
            for (int i = 0; i < contracts.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                gridcontract.Rows.Add(row);

                gridcontract.Rows[i].Cells[0].Value = i + 1 + "✎";   // Отображение счетчика записей и значок редактирования

                gridcontract.Rows[i].Cells[1].Value = contracts[i].ID;

                gridcontract.Rows[i].Cells[2].Value = contracts[i].Date;

                gridcontract.Rows[i].Cells[3].Value = contracts[i].CourseID + ". " + Courses.CourseID(contracts[i].CourseID).nameGroup;

                gridcontract.Rows[i].Cells[4].Value = contracts[i].Cost;

                gridcontract.Rows[i].Cells[5].Value = contracts[i].PayofMonth;

                gridcontract.Rows[i].Cells[6].Value = contracts[i].ManagerID + ". " + Workers.WorkerID(contracts[i].ManagerID).FIO;
            }


            gridcourse.Rows.Clear();
            List<Course> courses = new List<Course>();
            courses = branch.GetCourses();
            for (int i = 0; i < courses.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                gridcourse.Rows.Add(row);

                gridcourse.Rows[i].Cells[0].Value = i + 1 + "✎";   // Отображение счетчика записей и значок редактирования

                gridcourse.Rows[i].Cells[1].Value = courses[i].ID;

                gridcourse.Rows[i].Cells[2].Value = courses[i].nameGroup;

                gridcourse.Rows[i].Cells[3].Value = Types.TypeID(courses[i].TypeID).Name;

                gridcourse.Rows[i].Cells[4].Value = courses[i].Cost;

                gridcourse.Rows[i].Cells[5].Value = courses[i].Start;

                gridcourse.Rows[i].Cells[6].Value = courses[i].End;

                //gridcourse.Rows[i].Cells[8].Value = "Удалить";
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Branch_view_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void gridcontract_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Редактирование
            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex > -1)
                {
                    if (gridcontract.RowCount - 1 >= e.RowIndex)
                    {
                        int l = e.RowIndex;
                        int k = Convert.ToInt32(gridcontract.Rows[l].Cells[1].Value);
                        Contract_edit f = new Contract_edit(Contracts.ContractID(k), false);
                        DialogResult result = f.ShowDialog();
                        FillGrid();
                    }
                }
            }
        }

        private void gridcourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Редактирование
            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex > -1)
                {
                    if (gridcourse.RowCount - 1 >= e.RowIndex)
                    {
                        int l = e.RowIndex;
                        int k = Convert.ToInt32(gridcourse.Rows[l].Cells[1].Value);
                        Course_edit f = new Course_edit(Courses.CourseID(k), false);
                        DialogResult result = f.ShowDialog();
                        FillGrid();
                    }
                }
            }
        }

        private void gridworker_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridcabinet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridcontract_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Открытие формы для просмотра данных
            if (e.RowIndex > -1)
            {
                int l = e.RowIndex;
                int k = Convert.ToInt32(gridcontract.Rows[l].Cells[1].Value);
                Contract_view f = new Contract_view(Contracts.ContractID(k));
                DialogResult result = f.ShowDialog();
                FillGrid();
            }
        }

        private void gridcourse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Открытие формы для просмотра данных
            if (e.RowIndex > -1)
            {
                int l = e.RowIndex;
                int k = Convert.ToInt32(gridcourse.Rows[l].Cells[1].Value);
                Course_view f = new Course_view(Courses.CourseID(k));
                DialogResult result = f.ShowDialog();
                FillGrid();
            }
        }

        private void gridcabinet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Открытие формы для просмотра данных
            if (e.RowIndex > -1)
            {
                int l = e.RowIndex;
                int k = Convert.ToInt32(gridcourse.Rows[l].Cells[1].Value);
                Course_view f = new Course_view(Courses.CourseID(k));
                DialogResult result = f.ShowDialog();
                FillGrid();
            }
        }

        private void gridworker_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Открытие формы для просмотра данных
            if (e.RowIndex > -1)
            {
                int l = e.RowIndex;
                int k = Convert.ToInt32(gridcourse.Rows[l].Cells[1].Value);
                Course_view f = new Course_view(Courses.CourseID(k));
                DialogResult result = f.ShowDialog();
                FillGrid();
            }
        }

        private void directort_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //DialogResult result = f.ShowDialog();
        }
    }
}
