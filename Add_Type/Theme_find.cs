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
    public partial class Theme_find : Form
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
        public static Course chooseCourse; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public static Worker chooseTeacher; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public Theme chooseThem; // Эта переменная для пересылке своего значения в вызывающую форму

        bool editBan; // Перменная для хранения доступа к редактированию
        bool delBan; // Перменная для хранения доступа к удалению
        public Theme_find()
        {
            InitializeComponent();
            this.KeyPreview = true;
            LoadAll();
        }
        public Theme_find(String answer/*, string button*/)
        {
            InitializeComponent();
            this.KeyPreview = true;
            purpose = answer;
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
            delBan = Prohibition.Banned("add_del_theme");
            add.Enabled = delBan;
            editBan = Prohibition.Banned("edit_theme");
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
            sortf.Items.Add("№ темы");
            DataGridViewTextBoxColumn st = new DataGridViewTextBoxColumn();
            st.HeaderText = "Тема";
            sortf.Items.Add("Тема");
            DataGridViewTextBoxColumn hw = new DataGridViewTextBoxColumn();
            hw.HeaderText = "Домашняя работа";
            DataGridViewTextBoxColumn deadline = new DataGridViewTextBoxColumn();
            deadline.HeaderText = "Кол-во дней на дз";
            sortf.Items.Add("Кол-во дней на дз");
            DataGridViewTextBoxColumn teach = new DataGridViewTextBoxColumn();
            teach.HeaderText = "Составитель";

            D.Columns.Add(id);
            D.Columns.Add(st);
            D.Columns.Add(hw);
            D.Columns.Add(deadline);
            D.Columns.Add(teach);

            D.Columns[0].Width = 60;
            D.Columns[1].Width = 60;
            D.Columns[2].Width = 200;
            D.Columns[3].Width = 140;
            D.Columns[4].Width = 70;

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
                D.Columns[6].Visible = delBan;
            }

            D.ReadOnly = true;

            // Установление начальных значений на элементах формы
            this.countf.SelectedItem = "10";
            pagef.Items.Add(1);
            this.pagef.SelectedIndex = 0;
            pageindex = pagef.SelectedIndex;
            deldatef.Checked = true;
            this.sortf.SelectedIndex = 0;

            datefrom.Value = new DateTime(DateTime.Now.Year, 01, 01, 0, 0, 0);
            dateto.Value = new DateTime(DateTime.Now.Year, 12, 31, 0, 0, 0);
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
                if (this.sortf.SelectedItem.ToString() == "№ темы")
                {
                    sort = "ID";
                }
                if (this.sortf.SelectedItem.ToString() == "Тема")
                {
                    sort = "Tema";
                }
                if (this.sortf.SelectedItem.ToString() == "Кол-во дней на дз")
                {
                    sort = "Deadline";
                }
            }

            // Смысловые переменные, отражающие основные параметры поиска
            Theme theme = new Theme();
            theme.Tema = this.namet.Text == "" ? null : this.namet.Text;

            DateTime mindate;
            DateTime maxdate;
            if (datef.Checked == true)
            {
                mindate = datefrom.Value;
                maxdate = dateto.Value;
            }
            else
            {
                mindate = DateTime.MinValue;
                maxdate = DateTime.MaxValue;
                datefrom.Enabled = false;
                dateto.Enabled = false;
            }


            Course course = new Course();
            if (chooseCourse != null)
            {
                coursef.Text = chooseCourse.ID + ". " + chooseCourse.nameGroup;
                course = Courses.CourseID(chooseCourse.ID);
            }

            Worker teach = new Worker();
            if (chooseTeacher != null)
            {
                teacherf.Text = chooseTeacher.ID + ". " + chooseTeacher.FIO;
                teach = chooseTeacher;
            }

            List<Theme> themes = new List<Theme>();
            themes = Themes.FindAll(deldate, theme, teach, course, mindate, maxdate, sort, asсdesс, page, count, ref countrecord);
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

            // Заполнение грида данными
            for (int i = 0; i < themes.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                D.Rows.Add(row);

                D.Rows[i].Cells[0].Value = (page - 1) * count + i + 1 + "✎";   // Отображение счетчика записей и значок редактирования

                D.Rows[i].Cells[1].Value = themes[i].ID;

                D.Rows[i].Cells[2].Value = themes[i].Tema;

                D.Rows[i].Cells[3].Value = themes[i].Homework;

                D.Rows[i].Cells[4].Value = themes[i].Deadline;

                D.Rows[i].Cells[5].Value = themes[i].TeacherID + ". " + Workers.WorkerID(Convert.ToInt32(themes[i].TeacherID)).FIO;

                if (purpose == "choose")
                {
                    D.Rows[i].Cells[6].Value = "Выбрать";
                }
                else
                {
                    D.Rows[i].Cells[6].Value = "Удалить";
                }
            }
        }

        private void find_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void bcour_Click(object sender, EventArgs e)
        {
            Course_find f = new Course_find("choose"); // Передем choose - это означает, что нужно добавить кнопку выбора 
            DialogResult result = f.ShowDialog();
            chooseCourse = f.chooseCour; // Передаем ссылку форме родителей на переменную в этой форме
            FillGrid();
        }

        private void bteach_Click(object sender, EventArgs e)
        {
            Worker_find f = new Worker_find("choose", 3); // Передем choose - это означает, что нужно добавить кнопку выбора родителя
            DialogResult result = f.ShowDialog();
            chooseTeacher = f.chooseWor; // Передаем ссылку форме родителей на переменную в этой форме
            FillGrid();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            // Сброс всех выбранных значений в значения по умолчанию
            namet.Clear();
            sortf.SelectedIndex = 0;
            ascflag = true;
            this.countf.SelectedItem = "10";
            pagef.Items.Add(1);
            this.pagef.SelectedItem = 1;
            pageindex = pagef.SelectedIndex;
            deldatef.Checked = true;
            datef.Checked = false;
            datefrom.Value = new DateTime(DateTime.Now.Year, 01, 01, 0, 0, 0);
            dateto.Value = new DateTime(DateTime.Now.Year, 12, 31, 0, 0, 0);
            coursef.Clear();
            chooseCourse = null;
            teacherf.Clear();
            chooseTeacher = null;

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

        private void add_Click(object sender, EventArgs e)
        {
            // Добавление
            Theme_edit f = new Theme_edit(true);  // Передаем true, так как это означает, что нам нужно отображать только неудаленные объекты
            DialogResult result = f.ShowDialog();
            FillGrid();
        }

        private void D_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Обрабатывается событие нажатия на кнопку "Выбрать"
            if (purpose == "choose")
            {
                if (e.ColumnIndex == 6)
                {
                    if (e.RowIndex > -1)
                    {
                        if (D.RowCount - 1 >= e.RowIndex)
                        {
                            int l = e.RowIndex;
                            int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
                            chooseThem = Themes.ThemeID(k);

                            this.Close();
                        }
                    }
                }
            }
            // Обрабатывается событие нажатия на кнопку "Удалить"
            else
            {
                if (e.ColumnIndex == 6)
                {
                    if (delBan == true) // Запрета нет
                    {

                        if (e.RowIndex > -1)
                        {
                            if (D.RowCount - 1 >= e.RowIndex)
                            {
                                int l = e.RowIndex;
                                const string message = "Вы уверены, что хотите удалить тему?";
                                const string caption = "Удаление";
                                var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                                if (result == DialogResult.OK)
                                {
                                    // Форма не закрывается
                                    int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
                                    D.Rows.Remove(D.Rows[l]);
                                    Theme o = Themes.ThemeID(k);
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
                                Theme_edit f = new Theme_edit(Themes.ThemeID(k), false);
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
                Theme_view f = new Theme_view(Themes.ThemeID(k));
                DialogResult result = f.ShowDialog();
                FillGrid();
            }
        }

        private void Theme_find_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
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

        private void datef_CheckedChanged(object sender, EventArgs e)
        {
            if(datef.Checked == true)
            {
                datefrom.Enabled = true;
                dateto.Enabled = true;
            }
            else
            {
                datefrom.Enabled = false;
                dateto.Enabled = false;
            }
        }
    }
}
