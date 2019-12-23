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
    public partial class Timetable_edit : Form
    {
        bool indicator; // Переменная отвечающая за распределение - или добавляется новый объект, или изменяется существующий
        public Timetable timetable = new Timetable();   // Глобальная переменная объявляет занятие данной формы
        Boolean deldate = true; // true - неудален false - все!!!
        int count = 20;
        int page = 1;
        String sort = "ID";
        String asсdesс = "asc";
        string formathour = "HH:mm"; // Время для ячеек
        string formattotext = "dd.MM.yyyy"; // Формат для отображения даты в текстовые поля
        public static Course chooseCourse; // Эта переменная для приема значения из вызываемой(дочерней) формы
        string purpose; // Обозначает что нужно делать с преподавателями - удалять или выбирать 
        List<Worker> listteachers = new List<Worker>(); // Лист для хранения преподавателей, которые есть на этом занятии

        List<Timetable> timetablelist = new List<Timetable>();


        // Начальные значения переменных для манипуляций с повторениями
        DateTime Endrepeat = new DateTime();
        string period = "Не повторять";
        public Timetable_edit(bool indic)
        {
            InitializeComponent();
            this.KeyPreview = true;
            indicator = indic;
            buildDG();
            periodf.Enabled = false;
            finaldatet.Enabled = false;
            listteachers = timetable.GetTeachers();
        }
        public Timetable_edit(Timetable st, bool indic) // Конструктор для редактирования объекта
        {
            InitializeComponent();
            this.KeyPreview = true;

            timetable = st;
            indicator = indic;
            groupBox1.Visible = false; // Нет возможности воспользоваться доп. возможностями ( они только при добавлении )
            listteachers = timetable.GetTeachers();

            buildDG();
            FillForm();
            FillGrid();
        }

        private void buildDG() //Построение грида 
        {
            // Построение комбобокса филиалов
            Branch branch = new Branch();
            Worker director = new Worker();
            int countrecord = 0;

            List<Branch> branches = new List<Branch>();
            branches = Branches.FindAll(true, branch, director, "ID", "asc", page, count, ref countrecord);

            branchf.Items.Clear();
            branchf.Items.Add("Не выбрано");
            foreach (var s in branches)
            {
                // добавляем один элемент
                branchf.Items.Add(s.ID + ". " + s.Name);
            }
            this.branchf.SelectedIndex = 0;

            // Построение комбобокса кабинетов
            Cabinet cab = new Cabinet();

            List<Cabinet> cabinets = new List<Cabinet>();
            cabinets = Cabinets.FindAll(true, cab, branch, 0, 0, "ID", "asc", page, count, ref countrecord);

            cabinetf.Items.Clear();
            cabinetf.Items.Add("Не выбрано");
            foreach (var s in cabinets)
            {
                // добавляем один элемент
                cabinetf.Items.Add(s.ID + ". " + s.Number);
            }
            this.cabinetf.SelectedIndex = 0;

            // Построение грида преподавателей
            D.Columns.Clear();
            D.Rows.Clear();

            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            DataGridViewTextBoxColumn idt = new DataGridViewTextBoxColumn();
            idt.HeaderText = "№";
            DataGridViewTextBoxColumn fiot = new DataGridViewTextBoxColumn();
            fiot.HeaderText = "ФИО";

            D.Columns.Add(edit);
            D.Columns.Add(idt);
            D.Columns.Add(fiot);

            DataGridViewButtonColumn remove = new DataGridViewButtonColumn();
            remove.HeaderText = "Удалить?";
            D.Columns.Add(remove);
            D.ReadOnly = true;
        }
        private void FillForm()
        {
            this.Text = this.Text + timetable.ID;
            cabinetf.SelectedItem = timetable.CabinetID + ". " + Cabinets.CabinetID(timetable.CabinetID).Number;
            branchf.SelectedItem = Cabinets.CabinetID(timetable.CabinetID).BranchID + ". " + Branches.BranchID(Cabinets.CabinetID(timetable.CabinetID).BranchID).Name;
            coursef.Text = timetable.CourseID + ". " + Courses.CourseID(timetable.CourseID).nameGroup;
            datet.Value = timetable.Startlesson;
            startt.Text = timetable.Startlesson.ToString(formathour);
            endt.Text = timetable.Endlesson.ToString(formathour);
        }

        private void FillGrid()
        {
            purpose = "delete";
            // Заполняем гриды, комбобоксы
            D.Rows.Clear();
            //List<Worker> teachers = new List<Worker>();
            //teachers = timetable.GetTeachers();
            //for (int i = 0; i < teachers.Count; i++)
            //{
            //    DataGridViewRow row = new DataGridViewRow();

            //    D.Rows.Add(row);

            //    D.Rows[i].Cells[0].Value = i + 1 + "✎";   // Отображение счетчика записей и значок редактирования

            //    D.Rows[i].Cells[1].Value = teachers[i].ID;

            //    D.Rows[i].Cells[2].Value = teachers[i].FIO;

            //    D.Rows[i].Cells[3].Value = "Удалить";
            //}


            
            for (int i = 0; i < listteachers.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                D.Rows.Add(row);

                D.Rows[i].Cells[0].Value = i + 1 + "✎";   // Отображение счетчика записей и значок редактирования

                D.Rows[i].Cells[1].Value = listteachers[i].ID;

                D.Rows[i].Cells[2].Value = listteachers[i].FIO;

                D.Rows[i].Cells[3].Value = "Удалить";
            }
        }

        private void FillGrid(List<Worker> free)
        {
            purpose = "choose";
            // Заполняем гриды, комбобоксы
            D.Rows.Clear();
            for (int i = 0; i < free.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                D.Rows.Add(row);

                D.Rows[i].Cells[0].Value = i + 1 + "✎";   // Отображение счетчика записей и значок редактирования

                D.Rows[i].Cells[1].Value = free[i].ID;

                D.Rows[i].Cells[2].Value = free[i].FIO;

                D.Rows[i].Cells[3].Value = "Выбрать";
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            List<Timetable> listtimetables = new List<Timetable>();
            Timetable newtimetable = new Timetable();
            // Установление начального значения переменнной 
            DateTime Endrepeat = timetable.Endlesson;
            string Answer = "";

            if (indicator == false) // Значит, что происходит редактирование
            {
                String date = datet.Value.ToString(formattotext);
                string[] da = date.Split('.');

                string starttime = startt.Text;
                string[] st = (Convert.ToString(starttime)).Split(':');

                string endtime = endt.Text;
                string[] en = (Convert.ToString(endtime)).Split(':');
                // Сбор времени вместе
                timetable.Startlesson = new DateTime(Convert.ToInt32(da[2]), Convert.ToInt32(da[1]), Convert.ToInt32(da[0]), Convert.ToInt32(st[0]), Convert.ToInt32(st[1]), 00);

                timetable.Endlesson = new DateTime(Convert.ToInt32(da[2]), Convert.ToInt32(da[1]), Convert.ToInt32(da[0]), Convert.ToInt32(en[0]), Convert.ToInt32(en[1]), 00);


                //string[] branchID = (Convert.ToString(branchf.SelectedItem)).Split('.');
                //newcourse.BranchID = Branches.BranchID(Convert.ToInt32(branchID[0])).ID;

                string[] cabID = (Convert.ToString(branchf.SelectedItem)).Split('.');
                timetable.CabinetID = Branches.BranchID(Convert.ToInt32(cabID[0])).ID;

                string[] courID = (Convert.ToString(coursef.Text)).Split('.');
                timetable.CourseID = Convert.ToInt32(courID[0]);

                timetable.Note = notet.Text;

                if(timetable.GetTeachers() != null)
                {
                    Answer = timetable.Edit();
                }
                else
                {
                    errorProvider1.SetError(D, "Выберите преподавателей на это занятие, без этого нельзя добавить занятие в базу.");
                }
            }

            if (indicator == true) // Значит, что происходит добавление
            {
                String date = datet.Value.ToString(formattotext);
                string[] da = date.Split('.');

                string starttime = startt.Text;
                string[] st = (Convert.ToString(starttime)).Split(':');

                string endtime = endt.Text;
                string[] en = (Convert.ToString(endtime)).Split(':');
                // Сбор времени вместе
                timetable.Startlesson = new DateTime(Convert.ToInt32(da[2]), Convert.ToInt32(da[1]), Convert.ToInt32(da[0]), Convert.ToInt32(st[0]), Convert.ToInt32(st[1]), 00);

                timetable.Endlesson = new DateTime(Convert.ToInt32(da[2]), Convert.ToInt32(da[1]), Convert.ToInt32(da[0]), Convert.ToInt32(en[0]), Convert.ToInt32(en[1]), 00);


                //string[] branchID = (Convert.ToString(branchf.SelectedItem)).Split('.');
                //newcourse.BranchID = Branches.BranchID(Convert.ToInt32(branchID[0])).ID;

                string[] cabID = (Convert.ToString(cabinetf.SelectedItem)).Split('.');
                timetable.CabinetID = Convert.ToInt32(cabID[0]);

                string[] courID = (Convert.ToString(coursef.Text)).Split('.');
                timetable.CourseID = Convert.ToInt32(courID[0]);

                timetable.Note = notet.Text;

                // Условие для проверки с повтором нужно добавлять или без него
                if (repeatf.Checked == true) // Требуется повторение
                {
                    period = periodf.SelectedItem.ToString();
                    string final = finaldatet.Value.ToString(formattotext);
                    string[] f = final.Split('.');
                    Endrepeat = new DateTime(Convert.ToInt32(f[2]), Convert.ToInt32(f[1]), Convert.ToInt32(f[0]), 23, 59, 59);
                }

                if /*(timetable.GetTeachers() != null)*/(listteachers != null)
                {
                    if(repeatf.Checked == true) // Вызов метода добавления с повторениями
                    {
                        //Answer = timetable.Add(Endrepeat, period, timetable/*, ref timetablelist*/);
                        listtimetables = timetable.Add(Endrepeat, period, timetable, ref Answer);
                    }
                    else // Вызов метода без добавления повторений
                    {
                        newtimetable = timetable.Add(ref Answer);
                    }

                    if(listtimetables != null)
                    {
                        foreach (var teacher in listteachers)
                        {
                            foreach (var time in listtimetables)
                            {
                                String ans = time.addTeacher(teacher);
                            }

                        }
                    }
                    if (newtimetable != null)
                    {
                        foreach (var teacher in listteachers)
                        {   
                                String ans = newtimetable.addTeacher(teacher);
                        } 
                    }                
                }
                else
                {
                    errorProvider1.SetError(D, "Выберите преподавателей на это занятие, без этого нельзя добавить занятие в базу.");
                }
            }

            //label8.Text = Answer;
            if (Answer == "Данные корректны!")
            {
                this.Close();
            }
            else
            {
                errorProvider1.SetError(D, Answer);
            }
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchteachers_Click(object sender, EventArgs e)
        {
            if(startt.Text != "  :" & endt.Text != "  :")
            {
                if (repeatf.Checked == true) // Требуется повторение
                {
                    period = periodf.SelectedItem.ToString();
                    string final = finaldatet.Value.ToString(formattotext);
                    string[] f = final.Split('.');
                    Endrepeat = new DateTime(Convert.ToInt32(f[2]), Convert.ToInt32(f[1]), Convert.ToInt32(f[0]), 23, 59, 59);
                }
                else
                {
                    String date = datet.Value.ToString(formattotext);
                    string[] da = date.Split('.');

                    string starttime = startt.Text;
                    string[] st = (Convert.ToString(starttime)).Split(':');

                    string endtime = endt.Text;
                    string[] en = (Convert.ToString(endtime)).Split(':');
                    // Сбор времени вместе
                    timetable.Startlesson = new DateTime(Convert.ToInt32(da[2]), Convert.ToInt32(da[1]), Convert.ToInt32(da[0]), Convert.ToInt32(st[0]), Convert.ToInt32(st[1]), 00);

                    timetable.Endlesson = new DateTime(Convert.ToInt32(da[2]), Convert.ToInt32(da[1]), Convert.ToInt32(da[0]), Convert.ToInt32(en[0]), Convert.ToInt32(en[1]), 00);
                    Endrepeat = timetable.Endlesson;
                }
                List<Worker> freeteachers = timetable.GetFreeteachers(Endrepeat, period);
                FillGrid(freeteachers);
            }
           
        }

        private void repeatf_CheckedChanged(object sender, EventArgs e)
        {
            if(repeatf.Checked == true)
            {
                // Активация элементов формы
                periodf.Enabled = true;
                finaldatet.Enabled = true;
            }
            else
            {
                // Дезактивация элементов формы
                periodf.Enabled = false;
                finaldatet.Enabled = false;
            }
        }

        private void D_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Обрабатывается событие нажатия на кнопку "Выбрать"
            if (purpose == "choose")
            {
                if (e.ColumnIndex == 3)
                {
                    if (e.RowIndex > -1)
                    {
                        if (D.RowCount - 1 >= e.RowIndex)
                        {
                            int l = e.RowIndex;
                    //        chooseCour = Courses.CourseID(k);
                            var result = MessageBox.Show("Вы уверены, что хотите выбрать этого преподавателя на занятие?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                            if (result == DialogResult.OK)
                            {
                                // Форма не закрывается
                                int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);

                                Worker o = Workers.WorkerID(k);

                                // Добавляем преподавателя в имеющийся лист
                                if( listteachers.Find(x => x.ID == o.ID) == null )
                                {
                                    listteachers.Add(o);
                                    //       String ans = timetable.addTeacher(o);
                                }
                            }
                        }
                    }
                }
            }
            // Обрабатывается событие нажатия на кнопку "Удалить"
            else
            {
                if (e.ColumnIndex == 8)
                {
                    if (e.RowIndex > -1)
                    {
                        if (D.RowCount - 1 >= e.RowIndex)
                        {
                            int l = e.RowIndex;
                            const string message = "Вы уверены, что хотите удалить курс?";
                            const string caption = "Удаление";
                            var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                            if (result == DialogResult.OK)
                            {
                                // Форма не закрывается
                                int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
                                D.Rows.Remove(D.Rows[l]);
                                Course o = Courses.CourseID(k);
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

        private void existteachers_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void bcour_Click(object sender, EventArgs e)
        {
            Course_find f = new Course_find("choose"); // Передем choose - это означает, что нужно добавить кнопку выбора 
            DialogResult result = f.ShowDialog();
            if (f.chooseCour != null) // Для того чтобы заполнить текстовое поле на форме, нужно убедиться, что ученик выбран, если не выюран, то изменений на форме не происходит
            {
                chooseCourse = f.chooseCour; // Передаем ссылку форме родителей на переменную в этой форме
                coursef.Text = chooseCourse.ID + ". " + Courses.CourseID(chooseCourse.ID).nameGroup;
            }
        }

        private void Timetable_edit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
