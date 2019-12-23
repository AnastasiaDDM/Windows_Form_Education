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
    public partial class Student_view : Form
    {
        public Student student;   // Глобальная переменная объявляет ученика данной формы
        public Parent chooseParent; //  Родитель для того, чтобы передать в эту переменную значение из дочерней формы выбора

        public Student_view()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public Student_view(Student st) // Конструктор для просмотра объекта
        {
            InitializeComponent();
            this.KeyPreview = true;

            student = st;

            FillForm();
            buildDG();
            FillGrid();
        }
        private void buildDG() //Построение грида 
        {
            gridparent.Columns.Clear();
            gridparent.Rows.Clear();
            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.HeaderText = "№";
            DataGridViewTextBoxColumn st = new DataGridViewTextBoxColumn();
            st.HeaderText = "ФИО";
            DataGridViewTextBoxColumn ph = new DataGridViewTextBoxColumn();
            ph.HeaderText = "Телефон";

            gridparent.Columns.Add(edit);
            gridparent.Columns.Add(id);
            gridparent.Columns.Add(st);
            gridparent.Columns.Add(ph);


            DataGridViewButtonColumn remove1 = new DataGridViewButtonColumn();
            remove1.HeaderText = "Удалить?";
            gridparent.Columns.Add(remove1);
            gridparent.ReadOnly = true;


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
            DataGridViewTextBoxColumn branch = new DataGridViewTextBoxColumn();
            branch.HeaderText = "Филиал";
            DataGridViewTextBoxColumn start = new DataGridViewTextBoxColumn();
            start.HeaderText = "Начало курса";
            DataGridViewTextBoxColumn end = new DataGridViewTextBoxColumn();
            end.HeaderText = "Окончание курса";

            gridcourse.Columns.Add(edit1);
            gridcourse.Columns.Add(idc);
            gridcourse.Columns.Add(group);
            gridcourse.Columns.Add(type);
            gridcourse.Columns.Add(cost);
            gridcourse.Columns.Add(branch);
            gridcourse.Columns.Add(start);
            gridcourse.Columns.Add(end);

            //DataGridViewButtonColumn remove2 = new DataGridViewButtonColumn();
            //remove2.HeaderText = "Завершить?";
            //gridcourse.Columns.Add(remove2);
            gridcourse.ReadOnly = true;


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
            //DataGridViewTextBoxColumn manager = new DataGridViewTextBoxColumn();
            //manager.HeaderText = "Менеджер";
            DataGridViewTextBoxColumn debt = new DataGridViewTextBoxColumn();
            debt.HeaderText = "Долг";

            gridcontract.Columns.Add(edit2);
            gridcontract.Columns.Add(idcon);
            gridcontract.Columns.Add(date);
            gridcontract.Columns.Add(course);
            gridcontract.Columns.Add(cost2);
            gridcontract.Columns.Add(payment);
            //gridcontract.Columns.Add(manager);
            gridcontract.Columns.Add(debt);


            DataGridViewButtonColumn pay  = new DataGridViewButtonColumn();
            pay.HeaderText = "Оплатить?";
            gridcontract.Columns.Add(pay);
            gridcontract.ReadOnly = true;
        }

        private void FillForm()
        {
            this.Text = this.Text + student.ID;
            fiot.Text = student.FIO;
            debtt.Text = student.getDebt().ToString();
            phonet.Text = student.Phone;
        }

        private void FillGrid() // Заполняем гриды
        {
            gridparent.Rows.Clear();
            List<Parent> parents = new List<Parent>();
            parents = student.GetParents();
            for (int i = 0; i < parents.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                gridparent.Rows.Add(row);

                gridparent.Rows[i].Cells[0].Value = i + 1 + "✎";   // Отображение счетчика записей и значок редактирования

                gridparent.Rows[i].Cells[1].Value = parents[i].ID;

                gridparent.Rows[i].Cells[2].Value = parents[i].FIO;

                gridparent.Rows[i].Cells[3].Value = parents[i].Phone;

                gridparent.Rows[i].Cells[4].Value = "Удалить";
            }


            gridcontract.Rows.Clear();
            List<Contract> contracts = new List<Contract>();
            contracts = student.GetContracts();
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

                //gridcontract.Rows[i].Cells[5].Value = contracts[i].ManagerID + ". " + Workers.WorkerID(contracts[i].ManagerID).FIO;
                gridcontract.Rows[i].Cells[6].Value = student.getDebt(contracts[i]);

                gridcontract.Rows[i].Cells[7].Value = "Оплатить";
            }


            gridcourse.Rows.Clear();
            List<Course> courses = new List<Course>();
            courses = student.GetCourses();
            for (int i = 0; i < courses.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                gridcourse.Rows.Add(row);

                gridcourse.Rows[i].Cells[0].Value = i + 1 + "✎";   // Отображение счетчика записей и значок редактирования

                gridcourse.Rows[i].Cells[1].Value = courses[i].ID;

                gridcourse.Rows[i].Cells[2].Value = courses[i].nameGroup;

                gridcourse.Rows[i].Cells[3].Value = Types.TypeID(courses[i].TypeID).Name;

                gridcourse.Rows[i].Cells[4].Value = courses[i].Cost;

                gridcourse.Rows[i].Cells[5].Value = Branches.BranchID(courses[i].BranchID).ID + ". " + Branches.BranchID(courses[i].BranchID).Name;

                gridcourse.Rows[i].Cells[6].Value = courses[i].Start;
            
                gridcourse.Rows[i].Cells[7].Value = courses[i].End;

                //gridcourse.Rows[i].Cells[8].Value = "Удалить";
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridcontract_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Добавление оплаты
            if (e.ColumnIndex == 7)
            {
                if (e.RowIndex > -1)
                {
                    if (gridcontract.RowCount - 1 >= e.RowIndex)
                    {
                        int l = e.RowIndex;
                        int k = Convert.ToInt32(gridcontract.Rows[l].Cells[1].Value);
                        Contract contract = Contracts.ContractID(k);

                        Pay_edit f = new Pay_edit(contract);
                        DialogResult result = f.ShowDialog();
                    }
                }
            }
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
            //if (e.ColumnIndex == 8)
            //{
            //    if (e.RowIndex > -1)
            //    {
            //        if (gridcourse.RowCount - 1 >= e.RowIndex)
            //        {
            //            int l = e.RowIndex;
            //            const string message = "Вы уверены, что хотите удалить ученика с этого курса?";
            //            const string caption = "Удаление";
            //            var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            //            if (result == DialogResult.OK)
            //            {
            //                // Форма не закрывается
            //                int k = Convert.ToInt32(gridcourse.Rows[l].Cells[1].Value);
            //                gridcourse.Rows.Remove(gridcourse.Rows[l]);
            //                Course o = Courses.CourseID(k);
            //                String ans = o.delStudent(student);
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Эту строку нельзя удалить, в ней нет данных!");
            //        }
            //    }
            //}
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

        private void gridparent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (e.RowIndex > -1)
                {
                    if (gridparent.RowCount - 1 >= e.RowIndex)
                    {
                        int l = e.RowIndex;
                        const string message = "Вы уверены, что хотите удалить это отв. лицо из данных об этом ученике?";
                        const string caption = "Удаление";
                        var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (result == DialogResult.OK)
                        {
                            // Форма не закрывается
                            int k = Convert.ToInt32(gridparent.Rows[l].Cells[1].Value);
                            gridparent.Rows.Remove(gridparent.Rows[l]);
                            Parent o = Parents.ParentID(k);
                            String ans = o.delStudent(student);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Эту строку нельзя удалить, в ней нет данных!");
                    }
                }
            }
        }

        private void addparent_Click(object sender, EventArgs e)
        {
            Parent_edit f = new Parent_edit(true); // Передем true - значит показывать только неудаленные объекты
            DialogResult result = f.ShowDialog();
            chooseParent = f.newparent; // Передаем ссылку форме родителей на переменную в этой форме
            string answer;
            List<Parent> possibleparents = student.addParent(chooseParent, out answer);
            FillGrid();
        }

        private void chooseparent_Click(object sender, EventArgs e)
        {
            Parent_find f = new Parent_find("choose", "bstud"); // Передем choose - это означает, что нужно добавить кнопку выбора родителя
            DialogResult result = f.ShowDialog();
            chooseParent = f.choosePar; // Передаем ссылку форме родителей на переменную в этой форме

            string answer;
            List<Parent> possibleparents = student.addParent(chooseParent, out answer);
            FillGrid();
        }

        private void timetable_Click(object sender, EventArgs e)
        {
            Timetable_find f = new Timetable_find(student);
            DialogResult result = f.ShowDialog();
        }

        private void addcontract_Click(object sender, EventArgs e)
        {
            // Добавление
            Contract_edit f = new Contract_edit(student, true);  // Передаем true, так как это означает, что нам нужно отображать только неудаленные объекты
            DialogResult result = f.ShowDialog();
            FillGrid();
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
        private void gridparent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int l = e.RowIndex;
                int k = Convert.ToInt32(gridparent.Rows[l].Cells[1].Value);
                Parent_view f = new Parent_view(Parents.ParentID(k));
                DialogResult result = f.ShowDialog();
            }
        }

        private void payAll_Click(object sender, EventArgs e)
        {
 //           DialogResult result = f.ShowDialog();
        }

        private void Student_view_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
