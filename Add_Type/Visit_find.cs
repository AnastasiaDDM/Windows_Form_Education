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
    public partial class Visit_find : Form
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
        public static Student chooseStudent; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public static Course chooseCourse; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public static Theme chooseTheme; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public Contract chooseCon; // Эта переменная для пересылке своего значения в вызывающую форму


        bool editBan; // Перменная для хранения доступа к редактированию
        bool delBan; // Перменная для хранения доступа к удалению
        public Visit_find()
        {
            InitializeComponent();
            this.KeyPreview = true;
            LoadAll();
        }
        public Visit_find(String answer/*, string button*/)
        {
            InitializeComponent();
            this.KeyPreview = true;
            purpose = answer;
            //if (button == "bstud") // Блокировка поиска по ученикам
            //{
            //    bstud.Enabled = false;
            //}
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
            delBan = Prohibition.Banned("add_del_visit");
            editBan = Prohibition.Banned("edit_visit");
        }
        private void buildDG() //Построение грида 
        {
            D.Columns.Clear();
            D.Rows.Clear();

            DataGridViewTextBoxColumn edit = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.HeaderText = "№ ";
            sortf.Items.Add("№ присутствия");
            DataGridViewTextBoxColumn date = new DataGridViewTextBoxColumn();
            date.HeaderText = "Дата";
            sortf.Items.Add("Дата");
            DataGridViewTextBoxColumn st = new DataGridViewTextBoxColumn();
            st.HeaderText = "№ ученика";
            sortf.Items.Add("№ ученика");
            DataGridViewTextBoxColumn time = new DataGridViewTextBoxColumn();
            time.HeaderText = "Занятие";
            sortf.Items.Add("Занятие");
            DataGridViewTextBoxColumn vis = new DataGridViewTextBoxColumn();
            vis.HeaderText = "Присутствие";
            sortf.Items.Add("Присутствие");

            D.Columns.Add(edit);
            D.Columns.Add(id);
            D.Columns.Add(date);
            D.Columns.Add(st);
            D.Columns.Add(time);
            D.Columns.Add(vis);

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

            this.visitf.SelectedIndex = 0;

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
                if (this.sortf.SelectedItem.ToString() == "№ присутствия")
                {
                    sort = "ID";
                }
                if (this.sortf.SelectedItem.ToString() == "№ ученика")
                {
                    sort = "StudentID";
                }
                if (this.sortf.SelectedItem.ToString() == "Занятие")
                {
                    sort = "TimetableID";
                }
                if (this.sortf.SelectedItem.ToString() == "Присутствие")
                {
                    sort = "Vis";
                }
            }

            // Смысловые переменные, отражающие основные параметры поиска
            DateTime mindate = datefrom.Value;
            DateTime maxdate = dateto.Value;

            Visit vis = new Visit();
            if (visitf.SelectedItem != null)
            {
                if (visitf.SelectedIndex == 0)
                {
                    vis.Vis = 0;
                }
                if (visitf.SelectedIndex == 1)
                {
                    vis.Vis = 2; // Присутствие
                }
                if (visitf.SelectedIndex == 2)
                {
                    vis.Vis = 1; // Отсутствие
                }
            }

            Theme theme = new Theme();
            if (chooseTheme != null)
            {
                themef.Text = chooseTheme.ID + ". " + chooseTheme.Tema;
                theme = chooseTheme;
            }

            Student student = new Student();
            if (chooseStudent != null)
            {
                studentf.Text = chooseStudent.ID + ". " + chooseStudent.FIO;
                student = Students.StudentID(chooseStudent.ID);
            }
            Course course = new Course();
            if (chooseCourse != null)
            {
                coursef.Text = chooseCourse.ID + ". " + chooseCourse.nameGroup;
                course = Courses.CourseID(chooseCourse.ID);
            }

            List<Visit> visits = new List<Visit>();
            visits = Visits.FindAll(deldate, vis, theme, course, student, mindate, maxdate, sort, asсdesс, page, count, ref countrecord);
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
            for (int i = 0; i < visits.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                D.Rows.Add(row);

                D.Rows[i].Cells[0].Value = (page - 1) * count + i + 1;   // Отображение счетчика записей и значок редактирования

                D.Rows[i].Cells[1].Value = visits[i].ID;

                D.Rows[i].Cells[2].Value = Timetables.TimetableID(visits[i].TimetableID).Startlesson;

                D.Rows[i].Cells[3].Value = visits[i].StudentID + ". " + Students.StudentID(visits[i].StudentID).FIO;

                D.Rows[i].Cells[4].Value = visits[i].TimetableID + ". " + Timetables.TimetableID(visits[i].TimetableID).Startlesson;

                if(visits[i].Vis == 1)
                {
                    D.Rows[i].Cells[5].Value = "Отсутствует";
                }
                if (visits[i].Vis == 2)
                {
                    D.Rows[i].Cells[5].Value = "Присутствует";
                }

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

        private void bstud_Click(object sender, EventArgs e)
        {
            Student_find f = new Student_find("choose", "bcon"); // Передем choose - это означает, что нужно добавить кнопку выбора родителя
            DialogResult result = f.ShowDialog();
            chooseStudent = f.chooseSt; // Передаем ссылку форме родителей на переменную в этой форме
            FillGrid();
        }

        private void bcour_Click(object sender, EventArgs e)
        {
            Course_find f = new Course_find("choose"); // Передем choose - это означает, что нужно добавить кнопку выбора 
            DialogResult result = f.ShowDialog();
            chooseCourse = f.chooseCour; // Передаем ссылку форме родителей на переменную в этой форме
            FillGrid();
        }

        private void bthem_Click(object sender, EventArgs e)
        {
            Theme_find f = new Theme_find("choose"); // Передем choose - это означает, что нужно добавить кнопку выбора 
            DialogResult result = f.ShowDialog();
            chooseTheme = f.chooseThem; // Передаем ссылку форме родителей на переменную в этой форме
            FillGrid();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            // Сброс всех выбранных значений в значения по умолчанию
            ascflag = true;
            sortf.SelectedIndex = 0;
            this.countf.SelectedItem = "10";
            pagef.Items.Add(1);
            this.pagef.SelectedItem = 1;
            pageindex = pagef.SelectedIndex;
            deldatef.Checked = true;
            datefrom.Value = new DateTime(DateTime.Now.Year, 01, 01, 0, 0, 0);
            dateto.Value = new DateTime(DateTime.Now.Year, 12, 31, 0, 0, 0);
            visitf.SelectedIndex = 0;
            studentf.Clear();
            chooseStudent = null;
            coursef.Clear();
            chooseCourse = null;
            themef.Clear();
            chooseTheme = null;
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

        private void Visit_find_KeyDown(object sender, KeyEventArgs e)
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

        private void D_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Обрабатывается событие нажатия на кнопку "Выбрать"
            if (purpose == "choose")
            {
                //if (e.ColumnIndex == 6)
                //{
                //    if (e.RowIndex > -1)
                //    {
                //        if (D.RowCount - 1 >= e.RowIndex)
                //        {
                //            int l = e.RowIndex;
                //            int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
                //            chooseTyp = Types.TypeID(k);

                //            this.Close();
                //        }
                //    }
                //}
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
                                const string message = "Вы уверены, что хотите удалить это присутствие?";
                                const string caption = "Удаление";
                                var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                                if (result == DialogResult.OK)
                                {
                                    // Форма не закрывается
                                    int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
                                    D.Rows.Remove(D.Rows[l]);
                                    Visit o = Visits.VisitID(k);
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
                //// Редактирование
                //if (e.ColumnIndex == 0)
                //{
                //    if (editBan == true) // Запрета нет
                //    {
                //        if (e.RowIndex > -1)
                //        {
                //            if (D.RowCount - 1 >= e.RowIndex)
                //            {
                //                int l = e.RowIndex;
                //                int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
                //                Visit_edit f = new Type_edit(Types.TypeID(k), false);
                //                DialogResult result = f.ShowDialog();
                //                FillGrid();
                //            }
                //        }
                //    }
                //}
            }
        }

        private void D_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Открытие формы для просмотра данных
            if (e.RowIndex > -1)
            {
                int l = e.RowIndex;
                int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);

                string[] timeID = (Convert.ToString(D.Rows[l].Cells[4].Value)).Split('.');
                
                Visit_view f = new Visit_view( Timetables.TimetableID(Convert.ToInt32(timeID[0])), Courses.CourseID(Timetables.TimetableID(Convert.ToInt32(timeID[0])).CourseID) );
                f.Show();
            }
        }
    }
}
