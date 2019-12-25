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
    public partial class Parent_find : Form
    {
        Boolean deldate; // true - неудален false - все!!!
        int count;
        int page;
        String sort;
        String asсdesс = "asc";
        bool ascflag = true;
        int pageindex;
        int pages;
        string purpose;
        public Parent choosePar;
        public static Student chooseStudent; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public Parent_find()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        public Parent_find(String answer, string button)
        {
            InitializeComponent();
            this.KeyPreview = true;
            purpose = answer;
            if (button == "bstud") // Блокировка поиска по ученикам
            {
                bstud.Enabled = false;
            }
            LoadAll();
        }

        private void Parent_find_Load(object sender, EventArgs e)
        {
            LoadAll();
        }
        private void LoadAll()
        {
            //clients = new Clients();
            //workers = new Persons();
            //types = new Types();
            //cars = new Cars();
            //orders = new Orders(workers, cars, clients, types);
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
            sortf.Items.Add("№ отв. лица");
            DataGridViewTextBoxColumn st = new DataGridViewTextBoxColumn();
            st.HeaderText = "ФИО";
            sortf.Items.Add("ФИО");
            DataGridViewTextBoxColumn ph = new DataGridViewTextBoxColumn();
            ph.HeaderText = "Телефон";
            sortf.Items.Add("Телефон");

            D.Columns.Add(edit);
            D.Columns.Add(id);
            D.Columns.Add(st);
            D.Columns.Add(ph);

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
            }
           
            D.ReadOnly = true;

            // Установление начальных значений на элементах формы
            this.countf.SelectedItem = "10";
            pagef.Items.Add(1);
            this.pagef.SelectedItem = 1;
            pageindex = pagef.SelectedIndex;
            deldatef.Checked = true;
        }

        private void FillGrid() // Заполняем гриды
        {
            D.Rows.Clear();

            // Служебные переменные, связанные с выбором страниц, количества, сортировки
            deldate = this.deldatef.Checked;
            asсdesс = ascflag == true ? "asc" : "desc";
            count = this.countf.SelectedItem == null ? 10 : Convert.ToInt32(this.countf.SelectedItem);
            page = this.pagef.SelectedItem == null ? 1 : Convert.ToInt32(this.pagef.SelectedItem);
            sort = this.sortf.SelectedItem == null ? "ID" : Convert.ToString(this.sortf.SelectedItem);
            if (this.sortf.SelectedItem != null)
            {
                if (this.sortf.SelectedItem.ToString() == "№ отв. лица")
                {
                    sort = "ID";
                }
                if (this.sortf.SelectedItem.ToString() == "ФИО")
                {
                    sort = "FIO";
                }
                if (this.sortf.SelectedItem.ToString() == "Телефон")
                {
                    sort = "Phone";
                }
            }

            // Смысловые переменные, отражающие основные параметры поиска
            Parent parent = new Parent();
            parent.FIO = this.fiof.Text == "" ? null : this.fiof.Text;
            parent.Phone = this.phonef.Text == "+7(   )    -" ? null : this.phonef.Text;

            Student student = new Student();
            if (chooseStudent != null)
            {
                studentf.Text = chooseStudent.ID + ". " + chooseStudent.FIO;
                student = Students.StudentID(chooseStudent.ID);
            }

            student.FIO = this.stfiof.Text == "" ? null : this.stfiof.Text;
            student.Phone = this.stphonef.Text == "+7(   )    -" ? null : this.stphonef.Text;

            int countrecord = 0;

            List<Parent> c = new List<Parent>();
            c = Parents.FindAll(deldate, parent, student, sort, asсdesс, page, count, ref countrecord);

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
            for (int i = 0; i < c.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                D.Rows.Add(row);

                D.Rows[i].Cells[0].Value = (page - 1) * count + i + 1 + "✎";   // Отображение счетчика записей и значок редактирования

                D.Rows[i].Cells[1].Value = c[i].ID;

                D.Rows[i].Cells[2].Value = c[i].FIO;

                D.Rows[i].Cells[3].Value = c[i].Phone;

                if(purpose == "choose")
                {
                    D.Rows[i].Cells[4].Value = "Выбрать";
                }
                else
                {
                    D.Rows[i].Cells[4].Value = "Удалить";
                }
            }
        }

        private void find_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void Parent_find_Activated(object sender, EventArgs e)
        {
            //FillGrid();
        }

        private void D_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Обрабатывается событие нажатия на кнопку "Выбрать"
            if (purpose == "choose")
            {
                if (e.ColumnIndex == 4)
                {
                    if (e.RowIndex > -1)
                    {
                        if (D.RowCount - 1 >= e.RowIndex)
                        {
                            int l = e.RowIndex;
                            int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
                            // D.Rows.Remove(D.Rows[l]);
                            //Student_find.chooseParent = Parents.ParentID(k);
                            choosePar = Parents.ParentID(k);

                            this.Close();
                        }
                    }
                }
            }
            // Обрабатывается событие нажатия на кнопку "Удалить"
            else
            {
                if (e.ColumnIndex == 4)
                {
                    if (e.RowIndex > -1)
                    {
                        if (D.RowCount - 1 >= e.RowIndex)
                        {
                            int l = e.RowIndex;
                            const string message = "Вы уверены, что хотите удалить отв. лицо?";
                            const string caption = "Удаление";
                            var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                            if (result == DialogResult.OK)
                            {
                                // Форма не закрывается
                                int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
                                D.Rows.Remove(D.Rows[l]);
                                Student o = Students.StudentID(k);
                                String ans = o.Del();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Эту строку нельзя удалить, в ней нет данных!");
                        }
                    }
                }
                // Редактирование
                if (e.ColumnIndex == 0)
                {
                    if (e.RowIndex > -1)
                    {
                        if (D.RowCount - 1 >= e.RowIndex)
                        {
                            int l = e.RowIndex;
                            int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
                            Parent_edit f = new Parent_edit(Parents.ParentID(k), false);
                            DialogResult result = f.ShowDialog();
                            FillGrid();
                        }
                    }
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            // Добавление
            Parent_edit f = new Parent_edit(true);  // Передаем true, так как это означает, что нам нужно отображать только неудаленные объекты
            DialogResult result = f.ShowDialog();
            FillGrid();
        }

        private void D_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Открытие формы для просмотра данных
            if (e.RowIndex > -1)
            {
                int l = e.RowIndex;
                int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
                Parent_view f = new Parent_view(Parents.ParentID(k));
                f.Show();
            }
        }

        private void prev_Click(object sender, EventArgs e)
        {
            // Переключение страниц на предыдущую по средствам кнопки
            if (pageindex + 1 > 1)
            {
                //              pagef.SelectedIndex = pagef.FindStringExact(Convert.ToString(pageindex - 1));
                pagef.SelectedIndex = (pageindex - 1);
                pageindex = pagef.SelectedIndex;
                //           this.pagef.SelectedItem =
                FillGrid();
            }
        }
        private void next_Click(object sender, EventArgs e)
        {
            // Переключение страниц на следующую по средствам кнопки
            if (pageindex + 1 < pages)
            {
                //               pagef.SelectedIndex = pagef.FindStringExact(Convert.ToString(pageindex + 1));
                //this.pagef.SelectedItem = pagef.SelectedItem+1;
                pagef.SelectedIndex = (pageindex + 1);
                pageindex = pagef.SelectedIndex;
                //page = this.pagef.SelectedItem == null ? 1 : Convert.ToInt32(this.pagef.SelectedItem);
                FillGrid();
            }
        }

        private void reset_Click(object sender, EventArgs e) // Сбрасываются все установленные значения поиска
        {
            // Сброс всех выбранных значений в значения по умолчанию
            fiof.Clear();
            phonef.Clear();
            sortf.SelectedIndex = 0;
            ascflag = true;
            this.countf.SelectedItem = "10";
            pagef.Items.Add(1);
            this.pagef.SelectedItem = 1;
            pageindex = pagef.SelectedIndex;
            deldatef.Checked = true;
            studentf.Clear();
            chooseStudent = null;
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

        private void pagef_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Переключение страниц по средствам комбобокса
            pageindex = pagef.SelectedIndex;
            pagef.SelectedIndex = pagef.FindStringExact(pagef.Text);
            page = Convert.ToInt32(pagef.SelectedItem);
            FillGrid();
        }

        private void bstud_Click(object sender, EventArgs e)
        {
            Student_find f = new Student_find("choose", "bpar"); // Передем choose - это означает, что нужно добавить кнопку выбора родителя
            DialogResult result = f.ShowDialog();
            chooseStudent = f.chooseSt; // Передаем ссылку форме родителей на переменную в этой форме
            FillGrid();
        }

        private void D_KeyDown(object sender, KeyEventArgs e)
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
    }
}
