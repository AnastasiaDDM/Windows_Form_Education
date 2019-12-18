﻿using System;
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
    public partial class Worker_view : Form
    {
        public Worker worker;   // Глобальная переменная объявляет ученика данной формы
        public Parent chooseParent; //  Родитель для того, чтобы передать в эту переменную значение из дочерней формы выбора

        public Worker_view()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public Worker_view(Worker st) // Конструктор для просмотра объекта
        {
            InitializeComponent();
            this.KeyPreview = true;

            worker = st;

            // Эти проверки организованиы для сокрытия тех данных, которые не нужны для катрточек отдельных типов работников
            if(worker.Type == 1)
            {
                timetable.Visible = false;
                bcon.Visible = false;
                payAll.Visible = false;
                tabcontrol.Visible = false;
                this.Size = new Size(580, 220);
                close.Location = new Point(260, 140); 
            }
            if (worker.Type == 2)
            {
                timetable.Visible = false;
                payAll.Visible = false;
                tabcontrol.Visible = false;
                this.Size = new Size(580, 250);
                close.Location = new Point(260, 173);
            }
            if (worker.Type == 3)
            {
                bcon.Visible = false;
                //Заполнение таблиц
                buildDG();
                FillGrid();
            }

            FillForm();
        }
        private void buildDG() //Построение грида 
        {
            // История оплат
            gridpay.Columns.Clear();
            gridpay.Rows.Clear();

            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.HeaderText = "№";
            DataGridViewTextBoxColumn st = new DataGridViewTextBoxColumn();
            st.HeaderText = "Дата оплаты";
            DataGridViewTextBoxColumn time = new DataGridViewTextBoxColumn();
            time.HeaderText = "Занятие";
            DataGridViewTextBoxColumn ph = new DataGridViewTextBoxColumn();
            ph.HeaderText = "Оплата";
            DataGridViewTextBoxColumn br = new DataGridViewTextBoxColumn();
            br.HeaderText = "Филиал";
            DataGridViewTextBoxColumn type = new DataGridViewTextBoxColumn();
            type.HeaderText = "Способ оплаты";
            DataGridViewTextBoxColumn pur = new DataGridViewTextBoxColumn();
            pur.HeaderText = "Назначение";

            gridpay.Columns.Add(edit);
            gridpay.Columns.Add(id);
            gridpay.Columns.Add(st);
            gridpay.Columns.Add(time);
            gridpay.Columns.Add(ph);
            gridpay.Columns.Add(br);
            gridpay.Columns.Add(type);
            gridpay.Columns.Add(pur);


            //DataGridViewButtonColumn remove = new DataGridViewButtonColumn();
            //remove.HeaderText = "Удалить?";
            //gridpay.Columns.Add(remove);
            gridpay.ReadOnly = true;



            // Оплаченные часы
            gridpaid.Columns.Clear();
            gridpaid.Rows.Clear();

            DataGridViewButtonColumn edit1 = new DataGridViewButtonColumn();
            DataGridViewTextBoxColumn id1 = new DataGridViewTextBoxColumn();
            id1.HeaderText = "№";
            //DataGridViewTextBoxColumn st1 = new DataGridViewTextBoxColumn();
            //st1.HeaderText = "Дата занятия";
            DataGridViewTextBoxColumn time1 = new DataGridViewTextBoxColumn();
            time1.HeaderText = "Занятие";
            DataGridViewTextBoxColumn ph1 = new DataGridViewTextBoxColumn();
            ph1.HeaderText = "Курс";
            DataGridViewTextBoxColumn br1 = new DataGridViewTextBoxColumn();
            br1.HeaderText = "Филиал";
            //DataGridViewTextBoxColumn type1 = new DataGridViewTextBoxColumn();
            //type1.HeaderText = "Способ оплаты";
            //DataGridViewTextBoxColumn pur1 = new DataGridViewTextBoxColumn();
            //pur1.HeaderText = "Назначение";

            gridpaid.Columns.Add(edit1);
            gridpaid.Columns.Add(id1);
            //gridpaid.Columns.Add(st1);
            gridpaid.Columns.Add(time1);
            gridpaid.Columns.Add(ph1);
            gridpaid.Columns.Add(br1);
            //gridpaid.Columns.Add(type1);
            //gridpaid.Columns.Add(pur1);
  

            
            // Неоплаченные часы
            gridunpaid.Columns.Clear();
            gridunpaid.Rows.Clear();

            DataGridViewButtonColumn edit2 = new DataGridViewButtonColumn();
            DataGridViewTextBoxColumn id2 = new DataGridViewTextBoxColumn();
            id2.HeaderText = "№";
            //DataGridViewTextBoxColumn st2 = new DataGridViewTextBoxColumn();
            //st2.HeaderText = "Дата занятия";
            DataGridViewTextBoxColumn time2 = new DataGridViewTextBoxColumn();
            time2.HeaderText = "Занятие";
            DataGridViewTextBoxColumn ph2 = new DataGridViewTextBoxColumn();
            ph2.HeaderText = "Курс";
            DataGridViewTextBoxColumn br2 = new DataGridViewTextBoxColumn();
            br2.HeaderText = "Филиал";
            DataGridViewTextBoxColumn debt = new DataGridViewTextBoxColumn();
            debt.HeaderText = "Долг";
            //DataGridViewTextBoxColumn pur2 = new DataGridViewTextBoxColumn();
            //pur2.HeaderText = "Назначение";

            gridunpaid.Columns.Add(edit2);
            gridunpaid.Columns.Add(id2);
            //gridunpaid.Columns.Add(st2);
            gridunpaid.Columns.Add(time2);
            gridunpaid.Columns.Add(ph2);
            gridunpaid.Columns.Add(br2);
            gridunpaid.Columns.Add(debt);
            //gridunpaid.Columns.Add(pur2);

            DataGridViewButtonColumn pay2 = new DataGridViewButtonColumn();
            pay2.HeaderText = "Оплатить?";
            gridunpaid.Columns.Add(pay2);
            gridunpaid.ReadOnly = true;
        }

        private void FillForm()
        {
            this.Text = this.Text + worker.ID;
            fiot.Text = worker.FIO;
            phonet.Text = worker.Phone;
            positiont.Text = worker.Position;
            ratet.Text = worker.Rate.ToString();
            passwordt.Text = worker.Password.ToString();

            if (worker.Type == 1)
            {
                typet.Text = "1. Директор";
            }
            if (worker.Type == 2)
            {
                typet.Text = "2. Менеджер";
            }
            if (worker.Type == 3)
            {
                typet.Text = "3. Преподаватель";
            }


            if (worker.BranchID == 0)
            {
                brancht.Text = "Филиал не выбран";
                brancht.Enabled = false;
            }
            else
            {
                brancht.Text = worker.BranchID + ". " + Branches.BranchID(Convert.ToInt32(worker.BranchID)).Name;
            }
        }

        private void FillGrid() // Заполняем гриды
        {
            //  Служебные переменные
            Boolean deldate = true; // true - неудален false - все!!!
            String sort = "ID";
            String asсdesс = "asc";
            //bool ascflag = true;
            int page = 1;
            int count = 100;
            //int pageindex;
            //int pages;
            int countrecord = 0;

            string format2 = "HH:mm"; // Формат для отображения даты 

            string format = "dd.MM.yy HH:mm"; // Формат для отображения даты 

            // Значимые перменные
            Pay pay = new Pay();
            pay.Indicator = 2;
            Contract contract = new Contract();

            Worker teacher = new Worker();
            teacher = Workers.WorkerID(worker.ID);


            Timetable timetable = new Timetable();
            Branch branch = new Branch();

            Student student = new Student();
            Course course = new Course();
            Cabinet cabinet = new Cabinet();

            DateTime mindate = DateTime.MinValue;
            DateTime maxdate = DateTime.MaxValue;
            int min = 0;
            int max = 0;
            DateTime date = DateTime.MinValue;

            // Заполняем историю оплат
            gridpay.Rows.Clear();


            List<Pay> pays = new List<Pay>();
            pays = Pays.FindAll(deldate, pay, contract, teacher, timetable, branch, mindate, maxdate, min, max, sort, asсdesс, page, count, ref countrecord);
            for (int i = 0; i < pays.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                gridpay.Rows.Add(row);

                gridpay.Rows[i].Cells[0].Value = /*(page - 1) * count +*/ i + 1 + "✎";   // Отображение счетчика записей и значок редактирования

                gridpay.Rows[i].Cells[1].Value = pays[i].ID;

                gridpay.Rows[i].Cells[2].Value = pays[i].Date;

                gridpay.Rows[i].Cells[3].Value = pays[i].TimetableID + ". " + Timetables.TimetableID(Convert.ToInt32(pays[i].TimetableID)).Startlesson.ToString(format)
                  + " - " + Timetables.TimetableID(Convert.ToInt32(pays[i].TimetableID)).Endlesson.ToString(format2);

                gridpay.Rows[i].Cells[4].Value = pays[i].Payment;

                gridpay.Rows[i].Cells[5].Value = pays[i].BranchID + ". " + Branches.BranchID(pays[i].BranchID).Name;

                gridpay.Rows[i].Cells[6].Value = pays[i].Type;

                gridpay.Rows[i].Cells[7].Value = pays[i].Purpose;
            }


            // Заполняем оплаченные и неоплаченные занятия

            double salary; // Переменная для хранения значения оплаты
            gridpaid.Rows.Clear();
            gridunpaid.Rows.Clear();
            int nextpaid = 0;
            int nextunpaid = 0;

            List<Timetable> t = new List<Timetable>();
            t = Timetables.FindAll(deldate, branch, cabinet, teacher, course, student, date, sort, asсdesс, page, count, ref countrecord);
            for (int i = 0; i < t.Count; i++)
            {
            //    foreach (Timetable t in Timetables.FindAll(deldate, branch, cabinet, teacher, course, student, date, sort, asсdesс, page, count, ref countrecord))
            //{;

                if((salary=teacher.Salary(t[i])) == 0) // Оплаченные занятия 
                {
                    DataGridViewRow row = new DataGridViewRow();

                    gridpaid.Rows.Add(row);

                    gridpaid.Rows[nextpaid].Cells[0].Value = /*(page - 1) * count +*/ i + 1 + "✎";   // Отображение счетчика записей и значок редактирования

                    gridpaid.Rows[nextpaid].Cells[1].Value = t[i].ID;

                    gridpaid.Rows[nextpaid].Cells[2].Value = /*t[i].ID + ". " + */t[i].Startlesson.ToString(format) + " - " + t[i].Endlesson.ToString(format2);

                    gridpaid.Rows[nextpaid].Cells[3].Value = t[i].CourseID + ". " + Courses.CourseID(t[i].CourseID).nameGroup;

                    gridpaid.Rows[nextpaid].Cells[4].Value = Cabinets.CabinetID(t[i].CabinetID).BranchID + ". " + Branches.BranchID(Cabinets.CabinetID(t[i].CabinetID).BranchID).Name;
                    nextpaid++;
                }
                else
                {
                    DataGridViewRow row = new DataGridViewRow();

                    gridunpaid.Rows.Add(row);

                    gridunpaid.Rows[nextunpaid].Cells[0].Value = /*(page - 1) * count +*/ i + 1 + "✎";   // Отображение счетчика записей и значок редактирования

                    gridunpaid.Rows[nextunpaid].Cells[1].Value = t[i].ID;

                    gridunpaid.Rows[nextunpaid].Cells[2].Value = /*t[i].ID + ". " + */t[i].Startlesson.ToString(format) + " - " + t[i].Endlesson.ToString(format2);

                    gridunpaid.Rows[nextunpaid].Cells[3].Value = t[i].CourseID + ". " + Courses.CourseID(t[i].CourseID).nameGroup;


                    gridunpaid.Rows[nextunpaid].Cells[4].Value = Cabinets.CabinetID(t[i].CabinetID).BranchID + ". " + Branches.BranchID(Cabinets.CabinetID(t[i].CabinetID).BranchID).Name;

                    gridunpaid.Rows[nextunpaid].Cells[5].Value = salary;

                    gridunpaid.Rows[nextunpaid].Cells[6].Value = "Оплатить";
                    nextunpaid++;
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Worker_view_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void gridunpaid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Добавление оплаты
            if (e.ColumnIndex == 6)
            {
                if (e.RowIndex > -1)
                {
                    if (gridunpaid.RowCount - 1 >= e.RowIndex)
                    {
                        int l = e.RowIndex;
                        int k = Convert.ToInt32(gridunpaid.Rows[l].Cells[1].Value);
                        Timetable timetable = Timetables.TimetableID(k); 

                        Pay_edit f = new Pay_edit(worker, timetable, Convert.ToDouble(gridunpaid.Rows[l].Cells[5].Value)); // передаем преподавателя, занятие и долг - чтобы сделать это значение максимальным
                        DialogResult result = f.ShowDialog();
                        FillForm();
                        FillGrid();                   
                    }
                }
            }
            
        }

        private void gridpay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Редактирование
            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex > -1)
                {
                    if (gridpay.RowCount - 1 >= e.RowIndex)
                    {
                        int l = e.RowIndex;
                        int k = Convert.ToInt32(gridpay.Rows[l].Cells[1].Value);
                        Pay_edit f = new Pay_edit(Pays.PayID(k));
                        DialogResult result = f.ShowDialog();
                        FillGrid();
                    }
                }
            }
        }

        private void bcon_Click(object sender, EventArgs e)
        {
            Contract_find f = new Contract_find(worker); // Передем choose - это означает, что нужно добавить кнопку выбора родителя
            DialogResult result = f.ShowDialog();
            //chooseContract = f.chooseCon; // Передаем ссылку форме родителей на переменную в этой форме
            FillGrid();
        }

        private void timetable_Click(object sender, EventArgs e)
        {
            Timetable_find f = new Timetable_find(worker);
            DialogResult result = f.ShowDialog();
        }

        private void brancht_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Открытие формы для просмотра данных
            Branch_view f = new Branch_view(Branches.BranchID(Convert.ToInt32(worker.BranchID)));
            DialogResult result = f.ShowDialog();
            FillGrid();
        }
    }
}
