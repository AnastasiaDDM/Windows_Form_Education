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
    public partial class Course_find : Form
    {
        Boolean deldate; // true - неудален false - все!!!
        String sort = "ID";
        String asсdesс = "asc";
        bool ascflag = true;
        int page = 1;
        int count = 100;
        int pageindex;
        int pages;
        string purpose;
        string formattotext = "dd.MM.yyyy"; // Формат для отображения даты в текстовые поля
        public static Student chooseStudent; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public static Type chooseType; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public static Worker chooseTeacher; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public Course chooseCour; // Эта переменная для пересылке своего значения в вызывающую форму

        bool editBan; // Перменная для хранения доступа к редактированию
        bool delBan; // Перменная для хранения доступа к удалению
        public Course_find()
        {
            InitializeComponent();
            this.KeyPreview = true;
            LoadAll();
        }
        public Course_find(String answer)
        {
            InitializeComponent();
            this.KeyPreview = true;
            purpose = answer;
            LoadAll();
        }
        public Course_find(Type st) // Конструктор для просмотра объекта
        {
            InitializeComponent();
            this.KeyPreview = true;

            chooseType = st;

            LoadAll();
        }
        private void LoadAll()
        {
            Access();
            buildDG();
            FillGrid();
        }

        private void Access() // Реализация разделения ролей
        {
            // Заперт на добавление и удаление одиннаковый
            delBan = Prohibition.Banned("add_del_course");
            add.Enabled = delBan;
            editBan = Prohibition.Banned("edit_course");
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
            id.HeaderText = "№ ";
            sortf.Items.Add("№ курса");
            DataGridViewTextBoxColumn group = new DataGridViewTextBoxColumn();
            group.HeaderText = "Группа";
            sortf.Items.Add("Группа");
            DataGridViewTextBoxColumn typec = new DataGridViewTextBoxColumn();
            typec.HeaderText = "Тип курса";
            sortf.Items.Add("Тип курса");
            DataGridViewTextBoxColumn cost = new DataGridViewTextBoxColumn();
            cost.HeaderText = "Стоимость";
            sortf.Items.Add("Стоимость");
            DataGridViewTextBoxColumn br = new DataGridViewTextBoxColumn();
            br.HeaderText = "Филиал";
            sortf.Items.Add("Филиал");
            DataGridViewTextBoxColumn start = new DataGridViewTextBoxColumn();
            start.HeaderText = "Начало занятий";
            sortf.Items.Add("Начало занятий");
            DataGridViewTextBoxColumn end = new DataGridViewTextBoxColumn();
            end.HeaderText = "Окончание";
            sortf.Items.Add("Окончание занятий");

            D.Columns.Add(id);
            D.Columns.Add(group);
            D.Columns.Add(typec);
            D.Columns.Add(cost);
            D.Columns.Add(br);
            D.Columns.Add(start);
            D.Columns.Add(end);

            D.Columns[0].Width = 60;
            D.Columns[1].Width = 60;
            D.Columns[2].Width = 200;
            D.Columns[3].Width = 140;
            D.Columns[4].Width = 80;

            if (purpose == "choose")
            {
                DataGridViewButtonColumn choose = new DataGridViewButtonColumn();
                choose.HeaderText = "Выбрать";
                D.Columns.Add(choose);
            }
            else
            {
                DataGridViewButtonColumn remove = new DataGridViewButtonColumn();
                remove.HeaderText = "Удалить?";
                D.Columns.Add(remove);
                D.Columns[8].Visible = delBan;
            }

            D.ReadOnly = true;

            // Установление начальных значений на элементах формы
            this.countf.SelectedItem = "10";
            pagef.Items.Add(1);
            this.pagef.SelectedIndex = 0;
            pageindex = pagef.SelectedIndex;
            deldatef.Checked = true;

            datefrom.Value = this.datefrom.MinDate;
            dateto.Value = this.datefrom.MaxDate;

            // Построение комбобокса филиалов
            Branch branch = new Branch();
            Worker director = new Worker();
            int countrecord = 0;

            List<Branch> branches = new List<Branch>();
            branches = Branches.FindAll(deldate, branch, director, sort, asсdesс, page, count, ref countrecord);

            branchf.Items.Add("Не выбрано");
            foreach (var s in branches)
            {
                // добавляем один элемент
                branchf.Items.Add(s.ID + ". " + s.Name);
            }
            this.branchf.SelectedIndex = 0;
            this.sortf.SelectedIndex = 0;
        }
        private void FillGrid() // Заполняем гриды
        {
            D.Rows.Clear();
            // Служебные переменные, связанные с выбором страниц, количества, сортировки
            int countrecord = 0;
            deldate = this.deldatef.Checked;
            asсdesс = ascflag == true ? "asc" : "desc";
            count = this.countf.SelectedItem == null ? 10 : Convert.ToInt32(this.countf.SelectedItem);
            page = this.pagef.SelectedItem == null ? 1 : Convert.ToInt32(this.pagef.SelectedItem);

            if (this.sortf.SelectedItem != null)
            {
                if (this.sortf.SelectedItem.ToString() == "№ курса")
                {
                    sort = "ID";
                }
                if (this.sortf.SelectedItem.ToString() == "Группа")
                {
                    sort = "nameGroup";
                }
                if (this.sortf.SelectedItem.ToString() == "Тип курса")
                {
                    sort = "TypeID";
                }
                if (this.sortf.SelectedItem.ToString() == "Стоимость")
                {
                    sort = "Cost";
                }
                if (this.sortf.SelectedItem.ToString() == "Филиал")
                {
                    sort = "BranchID";
                }
                if (this.sortf.SelectedItem.ToString() == "Начало занятий")
                {
                    sort = "Start";
                }
                if (this.sortf.SelectedItem.ToString() == "Окончание занятий")
                {
                    sort = "End";
                }
            }

            // Смысловые переменные, отражающие основные параметры поиска
            Worker teacher = new Worker();
            if (chooseTeacher != null)
            {
                teacher = chooseTeacher;
                teacherf.Text = teacher.ID + ". " + teacher.FIO;
            }

            Course course = new Course();
            course.nameGroup = this.namet.Text == "" ? null : this.namet.Text;

            DateTime mindate = datefrom.Value;
            DateTime maxdate = dateto.Value;

            Type type = new Type();
            if (chooseType != null)
            {
                typef.Text = chooseType.ID + ". " + chooseType.Name;
                type = Types.TypeID(chooseType.ID);
            }

            Branch branch = new Branch();
            if (branchf.SelectedItem != null)
            {
                if (branchf.SelectedIndex == 0)
                {
                    branch.ID = 0;
                }
                else
                {
                    string[] branchID = (Convert.ToString(branchf.SelectedItem)).Split('.');
                    branch.ID = Branches.BranchID(Convert.ToInt32(branchID[0])).ID;
                }
            }

            int min = this.costfrom.Text == "" ? 0 : Convert.ToInt32(this.costfrom.Text);
            int max = this.costto.Text == "" ? 0 : Convert.ToInt32(this.costto.Text);

            List<Course> courses = new List<Course>();
            courses = Courses.FindAll(deldate, course, type, teacher, branch, mindate, maxdate, min, max, sort, asсdesс, page, count, ref countrecord);
            pages = Convert.ToInt32(Math.Ceiling((double)countrecord / count));

            // Формирование количества страниц
            pagef.Items.Clear();
            pages = Convert.ToInt32(Math.Ceiling((double)countrecord / count));
            for (int p = 1; p <= pages; p++)
            {
                // добавляем один элемент
                pagef.Items.Add(p);
            }
            this.pagef.SelectedItem = page; // Выбираем текущую страницу поиска


            // Установление минимального и максимального времени курсов для удобства вместо MinValue и MaxValue
            DateTime newmindate = Convert.ToDateTime(courses.First<Course>().Start);
            DateTime newmaxdate = Convert.ToDateTime(courses.First<Course>().End);
            foreach (var c in courses)
            {
                if(newmindate > c.Start)
                {
                    newmindate = Convert.ToDateTime(c.Start);
                }
                if(newmaxdate < c.End)
                {
                    newmaxdate = Convert.ToDateTime(c.End);
                }
            }
            datefrom.Value = newmindate;
            dateto.Value = newmaxdate;

            // Заполнение грида данными
            for (int i = 0; i < courses.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                D.Rows.Add(row);

                D.Rows[i].Cells[0].Value = (page - 1) * count + i + 1 + "✎";   // Отображение счетчика записей и значок редактирования

                D.Rows[i].Cells[1].Value = courses[i].ID;

                D.Rows[i].Cells[2].Value = courses[i].nameGroup;

                D.Rows[i].Cells[3].Value = courses[i].TypeID + ". " + Types.TypeID(courses[i].TypeID).Name;

                D.Rows[i].Cells[4].Value = courses[i].Cost;

                D.Rows[i].Cells[5].Value = courses[i].BranchID + ". " + Branches.BranchID(courses[i].BranchID).Name;

                D.Rows[i].Cells[6].Value = courses[i].Start.ToString(formattotext);

                D.Rows[i].Cells[7].Value = courses[i].End.ToString(formattotext);

                if (purpose == "choose")
                {
                    D.Rows[i].Cells[8].Value = "Выбрать";
                }
                else
                {
                    D.Rows[i].Cells[8].Value = "Удалить";
                }
            }
        }

        private void find_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void add_Click(object sender, EventArgs e)
        {
           // Добавление  
           Course_edit f = new Course_edit(true);  // Передаем true, так как это означает, что нам нужно отображать только неудаленные объекты
            DialogResult result = f.ShowDialog();
            FillGrid();
        }

        private void D_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Обрабатывается событие нажатия на кнопку "Выбрать"
            if (purpose == "choose")
            {
                if (e.ColumnIndex == 8)
                {
                    if (e.RowIndex > -1)
                    {
                        if (D.RowCount - 1 >= e.RowIndex)
                        {
                            int l = e.RowIndex;
                            int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
                            chooseCour = Courses.CourseID(k);

                            this.Close();
                        }
                    }
                }
            }
            // Обрабатывается событие нажатия на кнопку "Удалить"
            else
            {
                if (e.ColumnIndex == 8)
                {
                    if (delBan == true) // Запрета нет
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
                // Редактирование
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
                                Course_edit f = new Course_edit(Courses.CourseID(k), false);
                                DialogResult result = f.ShowDialog();
                                FillGrid();
                            }
                        }
                    }
                }
            }
        }
        private void D_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Открытие формы для просмотра данных
            if (e.RowIndex > -1)
            {
                int l = e.RowIndex;
                int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
                Course_view f = new Course_view(Courses.CourseID(k));          
                DialogResult result = f.ShowDialog();
                FillGrid();
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            // Сброс всех выбранных значений в значения по умолчанию
            typef.Clear();
            chooseType = null;
            teacherf.Clear();
            namet.Clear();
            costfrom.Clear();
            costto.Clear();
            this.branchf.SelectedIndex = 0;
            sortf.SelectedIndex = 0;
            ascflag = true;
            this.countf.SelectedItem = "10";
            pagef.Items.Add(1);
            this.pagef.SelectedItem = 1;
            pageindex = pagef.SelectedIndex;
            deldatef.Checked = true;
            datefrom.Value = new DateTime(DateTime.Now.Year, 01, 01, 0, 0, 0);
            dateto.Value = new DateTime(DateTime.Now.Year, 12, 31, 0, 0, 0);
            FillGrid();
        }

        private void prev_Click(object sender, EventArgs e)
        {
            // Переключение страниц на предыдущую по средствам кнопки
            if (pageindex + 1 > 1)
            {
                pagef.SelectedIndex = (pageindex - 1);
                pageindex = pagef.SelectedIndex;
                FillGrid();
            }
        }
        private void next_Click(object sender, EventArgs e)
        {
            // Переключение страниц на следующую по средствам кнопки
            if (pageindex + 1 < pages)
            {
                pagef.SelectedIndex = (pageindex + 1);
                pageindex = pagef.SelectedIndex;
                FillGrid();
            }
        }

        private void pagef_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Переключение страниц по средствам комбобокса
            pageindex = pagef.SelectedIndex;
            pagef.SelectedIndex = pagef.FindStringExact(pagef.Text);
            page = Convert.ToInt32(pagef.SelectedItem);
            FillGrid();
        }

        private void countf_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Переключение количества записей на странице по средствам комбобокса
            this.pagef.SelectedItem = 1;
            pageindex = pagef.SelectedIndex;
            page = Convert.ToInt32(pagef.SelectedItem);
            FillGrid();
        }

        private void btype_Click(object sender, EventArgs e)
        {
            Type_find f = new Type_find("choose"); // Передаем choose - это означает, что нужно добавить кнопку выбора 
            DialogResult result = f.ShowDialog();
            chooseType = f.chooseTyp; // Передаем ссылку форме родителей на переменную в этой форме
            FillGrid();
        }

        private void ascf_Click(object sender, EventArgs e)
        {
            if (ascflag == true)
            {
                ascflag = false;
                ascf.Text = "▼";
            }
            else
            {
                ascflag = true;
                ascf.Text = "▲";
            }
        }

        private void bteach_Click(object sender, EventArgs e)
        {
                        Worker_find f = new Worker_find("choose", 3); // Передем choose - это означает, что нужно добавить кнопку выбора родителя
            DialogResult result = f.ShowDialog();
            chooseTeacher = f.chooseWor; // Передаем ссылку форме родителей на переменную в этой форме
            FillGrid();
        }

        private void Course_find_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
