using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
        public Timetable_edit(bool indic) // Конструктор для добавления
        {
            InitializeComponent();
            this.KeyPreview = true;
            startt.Select(); // Установка курсора
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
            startt.Select(); // Установка курсора

            timetable = st;
            this.Text = this.Text + timetable.ID;

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

            DataGridViewTextBoxColumn edit = new DataGridViewTextBoxColumn();
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

        private void buildDGfreecabinets(List<Cabinet> freecabinets) //Построение грида свободных кабинетов
        {
            // Построение комбобокса кабинетов
            cabinetf.Items.Clear();
            cabinetf.Items.Add("Не выбрано");
            foreach (var s in freecabinets)
            {
                // добавляем один элемент
                cabinetf.Items.Add(s.ID + ". " + s.Number);
            }
            //// Проверка условия, если ранее выбранный кабинет свободен, то он остается выбранным, в противном случае выбранный кабинет сбрасывается
            //if( freecabinets.FindLast((x => x.ID + ". " + x.Number == cabinetf.SelectedItem.ToString())) != null)
            //{
                this.cabinetf.SelectedIndex = 0;
            //}
        }
        private void buildDGfreecabinets(Branch branch) //Построение грида свободных кабинетов
        {
            // Построение комбобокса кабинетов исходя из выбранного филиала
            int countrecord = 0;
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
        }
        private void FillForm()
        {
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

                D.Rows[i].Cells[0].Value = i + 1;   // Отображение счетчика записей и значок редактирования

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

                D.Rows[i].Cells[0].Value = i + 1;   // Отображение счетчика записей и значок редактирования

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
            bool flag = Check(); // Вызовов функции проверки
            if (flag)
            {

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

                    if (timetable.GetTeachers() != null)
                    {
                        Answer = timetable.Edit();
                        if (Answer == "Данные корректны!")
                        {
                            foreach (var del in timetable.GetTeachers())
                            {
                                String ans = timetable.delTeacher(del);
                            }
                            foreach (var teacher in listteachers)
                            {
                                String ans = timetable.addTeacher(teacher);
                            }
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(groupBoxteachers, "Выберите преподавателей на это занятие, без этого нельзя добавить занятие в базу.");
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

                    if /*(timetable.GetTeachers() != null)*/(listteachers.Count != 0)
                    {
                        if (repeatf.Checked == true) // Вызов метода добавления с повторениями
                        {
                            //Answer = timetable.Add(Endrepeat, period, timetable/*, ref timetablelist*/);
                            listtimetables = timetable.Add(Endrepeat, period, timetable, ref Answer);
                        }
                        else // Вызов метода без добавления повторений
                        {
                            newtimetable = timetable.Add(ref Answer);
                        }
                        if (Answer == "Данные корректны!")
                        {
                            if (listtimetables != null)
                            {
                                foreach (var teacher in listteachers)
                                {
                                    foreach (var time in listtimetables)
                                    {
                                        String ans = time.addTeacher(teacher);
                                    }

                                }
                            }
                            if (newtimetable.ID != 0)
                            {
                                foreach (var teacher in listteachers)
                                {
                                    String ans = newtimetable.addTeacher(teacher);
                                }
                            }
                        }                           
                    }
                    else
                    {
                        errorProvider1.SetError(groupBoxteachers, "Выберите преподавателей на это занятие, без этого нельзя добавить занятие в базу.");
                    }
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
            if (startt.Text == "  :")
            {
                errorProvider1.SetError(startt, "Ввведите время начала занятия. Это поле не может быть пустым.");
                return false;
            }
            if (endt.Text == "  :")
            {
                errorProvider1.SetError(endt, "Ввведите время окончания занятия. Это поле не может быть пустым.");
                return false;
            }

            ////////////////// Логическая проверка времени
            string[] masot = startt.Text.Split(new string[] { ":" }, StringSplitOptions.None);
            string[] masdo = endt.Text.Split(new string[] { ":" }, StringSplitOptions.None);
            int minot = Convert.ToInt32(masot[0]) * 60 + Convert.ToInt32(masot[1]);
            int mindo = Convert.ToInt32(masdo[0]) * 60 + Convert.ToInt32(masdo[1]);            
            if (mindo > 420)
            {
                if (minot > mindo)
                {
                    errorProvider1.SetError(startt, "Введены неккоректные данные!Время начала занятия должно быть раньше, чем время окончания занятия!");
                    return false;
                }
            }
            if (0 <= Convert.ToInt32(masot[0]) == false | Convert.ToInt32(masot[0]) < 25 == false)
            {
                errorProvider1.SetError(startt, "Недопустимое время, возможно введено больше, чем 23 часа");
                return false;
            }
            if (0 <= Convert.ToInt32(masot[1]) == false | Convert.ToInt32(masot[1]) < 60 == false)
            {
                errorProvider1.SetError(startt, "Недопустимое время, возможно введено больше, чем 59 минут");
                return false;
            }
            if (0 <= Convert.ToInt32(masdo[0]) == false | Convert.ToInt32(masdo[0]) < 25 == false)
            {
                errorProvider1.SetError(endt, "Недопустимое время, возможно введено больше, чем 23 часа");
                return false;
            }
            if (0 <= Convert.ToInt32(masdo[1]) == false | Convert.ToInt32(masdo[1]) < 60 == false)
            {
                errorProvider1.SetError(endt, "Недопустимое время, возможно введено больше, чем 59 минут");
                return false;
            }
            ////////////////

            if (cabinetf.SelectedIndex == 0)
            {
                errorProvider1.SetError(cabinetf, "Выберите кабинет. Это поле не может быть не определено.");
                return false;
            }
            if (coursef.Text == "")
            {
                errorProvider1.SetError(label9, "Выберите курс. Это поле не может быть пустым.");
                return false;
            }

            // Проверка для повтора
            if (repeatf.Checked == true) // Вызов метода добавления с повторениями
            {
                if (periodf.SelectedItem == null)
                {
                    errorProvider1.SetError(periodf, "Выберите  период повторений. Это поле не может быть не определено.");
                    return false;
                }
            }
                return true;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchteachers_Click(object sender, EventArgs e)
        {
            if(startt.Text != "  :" & endt.Text != "  :")
            {
                if (repeatf.Checked == true & periodf.SelectedItem != null) // Требуется повторение
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
                                errorProvider1.Clear();
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
                if (e.ColumnIndex == 3)
                {
                    if (e.RowIndex > -1)
                    {
                        if (D.RowCount - 1 >= e.RowIndex)
                        {
                            int l = e.RowIndex;
                            const string message = "Вы уверены, что хотите удалить этого преподавателя с этого занятия?";
                            const string caption = "Удаление";
                            var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                            if (result == DialogResult.OK)
                            {
                                // Форма не закрывается
                                int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
                                Worker o = Workers.WorkerID(k);
                                // Удаляем преподавателя из имеющегося листа
                                if (listteachers.Find(x => x.ID == o.ID) != null)
                                {
                                    listteachers.RemoveAll(x => x.ID == o.ID);
                                    D.Rows.Remove(D.Rows[l]);
                                }
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
            errorProvider1.Clear();
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

        private void startt_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            // Проверка свободных кабинетов на это время и перегрузка комбобокса кабинетов
            Regex r = new Regex(@"\b\d{2}:\d{2}\b");

            if (r.IsMatch(startt.Text) == true && r.IsMatch(endt.Text) == true) // Проверка времени 
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
                List<Cabinet> freecabinets = timetable.GetFreecabinets(Endrepeat, period);
                buildDGfreecabinets(freecabinets);
            }
        }

        private void endt_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            // Проверка свободных кабинетов на это время и перегрузка комбобокса кабинетов
            Regex r = new Regex(@"\b\d{2}:\d{2}\b");

            if (r.IsMatch(startt.Text) == true && r.IsMatch(endt.Text) == true) // Проверка времени 
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
                List<Cabinet> freecabinets = timetable.GetFreecabinets(Endrepeat, period);
                buildDGfreecabinets(freecabinets);
            }
        }

        private void branchf_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string[] branchID = (Convert.ToString(branchf.SelectedItem)).Split('.');
            if(branchID[0] != "Не выбрано")
            {
                Branch branch = Branches.BranchID(Convert.ToInt32(branchID[0]));
                buildDGfreecabinets(branch);
            }
            else
            {
                Branch branch = new Branch();
                buildDGfreecabinets(branch);
            }       
        }

        private void branchf_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(branchf);
        }

        private void branchf_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("!Выбор филиала необязателен, но это поможет вам облегчить поиск кабинета", branchf);
        }

        private void fixtimef_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Regex r = new Regex(@"\b\d{2}:\d{2}\b");

            if (fixtimef.SelectedItem != null & r.IsMatch(startt.Text) == true)
            {
                String date = datet.Value.ToString(formattotext);
                string[] da = date.Split('.');

                string starttime = startt.Text;
                string[] st = (Convert.ToString(startt.Text)).Split(':');

                // Сбор времени вместе
                DateTime start = new DateTime(Convert.ToInt32(da[2]), Convert.ToInt32(da[1]), Convert.ToInt32(da[0]), Convert.ToInt32(st[0]), Convert.ToInt32(st[1]), 00);


                DateTime end;
                if (fixtimef.SelectedItem.ToString() == "40 минут")
                {
                    end = start.AddMinutes(40);
                    if (end.Minute < 10)
                    {
                        endt.Text = end.Hour + ":0" + end.Minute;
                    }
                    else
                    {
                        endt.Text = end.Hour + ":" + end.Minute;
                    }
                }
                if (fixtimef.SelectedItem.ToString() == "1 час")
                {
                    end = start.AddHours(1);
                    if (end.Minute < 10)
                    {
                        endt.Text = end.Hour + ":0" + end.Minute;
                    }
                    else
                    {
                        endt.Text = end.Hour + ":" + end.Minute;
                    }
                }
                if (fixtimef.SelectedItem.ToString() == "1 час 30 минут")
                {
                    end = start.AddHours(1);
                    end = end.AddMinutes(30);
                    if (end.Minute < 10)
                    {
                        endt.Text = end.Hour + ":0" + end.Minute;
                    }
                    else
                    {
                        endt.Text = end.Hour + ":" + end.Minute;
                    }
                }
                if (fixtimef.SelectedItem.ToString() == "2 часа")
                {
                    end = start.AddHours(2);
                    if(end.Minute < 10)
                    {
                        endt.Text = end.Hour + ":0" + end.Minute;
                    }
                    else
                    {
                        endt.Text = end.Hour + ":" + end.Minute;
                    }
                }
            }
        }

        private void coursef_TextChanged(object sender, EventArgs e)
        {
            if( coursef.Text != null )
            {
                if (branchf.SelectedIndex == 0)
                {
                    string[] st = (Convert.ToString(coursef.Text)).Split('.');
                    branchf.SelectedItem = st[0] + ". " + Branches.BranchID(Convert.ToInt32(st[0])).Name;
                }
            }
        }

        private void cabinetf_SelectionChangeCommitted(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void periodf_SelectionChangeCommitted(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
