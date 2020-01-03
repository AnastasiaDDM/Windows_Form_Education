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
    public partial class Worker_find : Form
    {
        Boolean deldate; // true - неудален false - все!!!
        int page = 1;
        int count = 100;
        String sort = "ID";
        String asсdesс = "asc";
        bool ascflag = true;
        int pageindex;
        int pages;
        //       string format = "yyyy-MM-dd HH:mm:ss";
        string formattotext = "dd.MM.yyyy"; // Формат для отображения даты в текстовые поля
        string purpose; // Строка предназначения, например, choose - добавить кнопку "Выбрать" т.е. происходит выбор для другой(родительской) формы
        public Worker chooseWor; // Эта переменная для пересылке своего значения в вызывающую форму
        int typeworker = 0; // Тип должности, для отображения только необходимого типа работников

        List<Worker> freeteachers = new List<Worker>(); // Это поле для манипуляции со свободными преподавателями (вызов из формы Timetable_view)

        bool editBan; // Перменная для хранения доступа к редактированию
        bool delBan; // Перменная для хранения доступа к удалению
        public Worker_find()
        {
            InitializeComponent();
            this.KeyPreview = true;
            LoadAll();
        }
        public Worker_find(String answer)
        {
            InitializeComponent();
            this.KeyPreview = true;
            purpose = answer;

            LoadAll();
        }

        public Worker_find(String answer, int type) // type -  тип должности, для отображения только необходимого типа работников
        {
            InitializeComponent();
            this.KeyPreview = true;
            purpose = answer;
            typeworker = type;

            LoadAll();
        }

        public Worker_find(String answer, List<Worker> free) // type -  тип должности, для отображения только необходимого типа работников
        {
            InitializeComponent();
            this.KeyPreview = true;
            purpose = answer;
            freeteachers = free;

            buildDG();
            FillGridfreeteachers(freeteachers);
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
            delBan = Prohibition.Banned("add_del_worker");
            add.Enabled = delBan;
            editBan = Prohibition.Banned("edit_worker");
        }
        private void buildDG() //Построение грида 
        {
            // Преподаватели
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
            sortf.Items.Add("№ работника");
            DataGridViewTextBoxColumn fio = new DataGridViewTextBoxColumn();
            fio.HeaderText = "ФИО";
            sortf.Items.Add("ФИО");
            DataGridViewTextBoxColumn ph = new DataGridViewTextBoxColumn();
            ph.HeaderText = "Телефон";
            sortf.Items.Add("Телефон");
            DataGridViewTextBoxColumn pos = new DataGridViewTextBoxColumn();
            pos.HeaderText = "Должность";
            sortf.Items.Add("Должность");
            DataGridViewTextBoxColumn rate = new DataGridViewTextBoxColumn();
            rate.HeaderText = "Ставка";
            sortf.Items.Add("Ставка");
            DataGridViewTextBoxColumn br = new DataGridViewTextBoxColumn();
            br.HeaderText = "Филиал";
            sortf.Items.Add("Филиал");

            D.Columns.Add(id);
            D.Columns.Add(fio);
            D.Columns.Add(ph);
            D.Columns.Add(pos);
            D.Columns.Add(rate);
            D.Columns.Add(br);

            D.Columns[0].Width = 60;
            D.Columns[1].Width = 60;
            D.Columns[2].Width = 200;
            D.Columns[3].Width = 120;
            D.Columns[4].Width = 200;

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
                D.Columns[7].Visible = delBan;
            }
            D.ReadOnly = true;

            // Установление начальных значений на элементах формы
            this.countf.SelectedItem = "10";
            pagef.Items.Add(1);
            this.pagef.SelectedIndex = 0;
            pageindex = pagef.SelectedIndex;
            deldatef.Checked = true;
            this.sortf.SelectedIndex = 0;
            //if(typeworker != 0)
            //{

            //}
            //typef.SelectedIndex = 2;
            //this.typef.SelectedIndex = 0;
            //this.typef.SelectedIndex = typeworker;

            // Построение комбобокса филиалов
            Branch branch = new Branch();
            Worker worker = new Worker();
            int countrecord = 0;

            List<Branch> branches = new List<Branch>();
            branches = Branches.FindAll(deldate, branch, worker, sort, asсdesс, page, count, ref countrecord);

            branchf.Items.Add("Не выбрано");
            foreach (var s in branches)
            {
                // добавляем один элемент
                branchf.Items.Add(s.ID + ". " + s.Name);
            }
            this.branchf.SelectedIndex = 0;

            // Построение комбобокса сотрудников
            List<Worker> workers = new List<Worker>();
            workers = Workers.FindAll(deldate, worker, branch, sort, asсdesс, page, count, ref countrecord);

            positionf.Items.Add("Не выбрано");
            foreach (var s in workers)
            {
                if(positionf.Items.Contains(s.Position) == false)
                {
                    // добавляем один элемент, если его еще нет в коллекции
                    positionf.Items.Add(s.Position);
                }
            }
            this.positionf.SelectedIndex = 0;

            // Построение комбобокса ролей, типов
            List<Role> roles = Roles.GetRoles();

            typef.Items.Add("Не выбрано");
            foreach (var s in roles)
            {
                // добавляем один элемент
                typef.Items.Add(s.Name);
            }
            this.typef.SelectedIndex = 0;
            if (typeworker != 0)
            {
                this.typef.SelectedIndex = typeworker;
            }
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
                if (this.sortf.SelectedItem.ToString() == "№ работника")
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
                if (this.sortf.SelectedItem.ToString() == "Должность")
                {
                    sort = "Position";
                }
                if (this.sortf.SelectedItem.ToString() == "Ставка")
                {
                    sort = "Rate";
                }
                if (this.sortf.SelectedItem.ToString() == "Филиал")
                {
                    sort = "BranchID";
                }
            }

            // Смысловые переменные, отражающие основные параметры поиска
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

            Worker wor = new Worker();
            wor.FIO = this.fiot.Text == "" ? null : this.fiot.Text;

            // Должность
            if (positionf.SelectedItem != null)
            {
                if (positionf.SelectedIndex == 0)
                {
                    wor.Position = null;
                }
                else
                {
                    wor.Position = positionf.SelectedItem.ToString();
                }
            }

            // Тип
            if (typef.SelectedItem != null)
            {
                if (typef.SelectedIndex == 0)
                {
                    wor.RoleID = 0;
                }
                else
                {
                    wor.RoleID = Roles.RoleName(typef.SelectedItem.ToString()).ID;
                    //if(typef.SelectedItem.ToString() == "Директор")
                    //{
                    //    wor.RoleID = 1;
                    //}
                    //if (typef.SelectedItem.ToString() == "Менеджер")
                    //{
                    //    wor.RoleID = 2;
                    //}
                    //if (typef.SelectedItem.ToString() == "Преподаватель")
                    //{
                    //    wor.RoleID = 3;
                    //}
                }
            }

            List<Worker> workers = new List<Worker>();
            workers = Workers.FindAll(deldate, wor, branch, sort, asсdesс, page, count, ref countrecord);
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
            for (int i = 0; i < workers.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                D.Rows.Add(row);

                D.Rows[i].Cells[0].Value = (page - 1) * count + i + 1 + "✎";   // Отображение счетчика записей и значок редактирования

                D.Rows[i].Cells[1].Value = workers[i].ID;

                D.Rows[i].Cells[2].Value = workers[i].FIO;

                D.Rows[i].Cells[3].Value = workers[i].Phone;

                D.Rows[i].Cells[4].Value = workers[i].Position;

                D.Rows[i].Cells[5].Value = workers[i].Rate;

                if(workers[i].BranchID == 0 || workers[i].BranchID == null)
                {
                    D.Rows[i].Cells[6].Value = "Филиал не выбран";
                }
                else
                {
                    D.Rows[i].Cells[6].Value = workers[i].BranchID + ". " + Branches.BranchID(Convert.ToInt32(workers[i].BranchID)).Name;
                }

                if (purpose == "choose")
                {
                    D.Rows[i].Cells[7].Value = "Выбрать";
                }
                else
                {
                    D.Rows[i].Cells[7].Value = "Удалить";
                }
            }
        }

        private void FillGridfreeteachers(List<Worker> free) // Заполняем гриды
        {
            D.Rows.Clear();
            // Заполнение грида данными
            for (int i = 0; i < free.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                D.Rows.Add(row);

                D.Rows[i].Cells[0].Value = (page - 1) * count + i + 1 + "✎";   // Отображение счетчика записей и значок редактирования

                D.Rows[i].Cells[1].Value = free[i].ID;

                D.Rows[i].Cells[2].Value = free[i].FIO;

                D.Rows[i].Cells[3].Value = free[i].Phone;

                D.Rows[i].Cells[4].Value = free[i].Position;

                D.Rows[i].Cells[5].Value = free[i].Rate;

                if (free[i].BranchID == 0)
                {
                    D.Rows[i].Cells[6].Value = "Филиал не выбран";
                }
                else
                {
                    D.Rows[i].Cells[6].Value = free[i].BranchID + ". " + Branches.BranchID(Convert.ToInt32(free[i].BranchID)).Name;
                }

                if (purpose == "choose")
                {
                    D.Rows[i].Cells[7].Value = "Выбрать";
                }
                else
                {
                    D.Rows[i].Cells[7].Value = "Удалить";
                }
            }
        }


        private void find_Click(object sender, EventArgs e)
        {
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

        private void reset_Click(object sender, EventArgs e)
        {
            fiot.Clear();
            this.typef.SelectedIndex = 0;
            this.positionf.SelectedIndex = 0;
            this.branchf.SelectedIndex = 0;
            sortf.SelectedIndex = 0;
            ascflag = true;
            this.countf.SelectedItem = "10";
            pagef.Items.Add(1);
            this.pagef.SelectedItem = 1;
            pageindex = pagef.SelectedIndex;
            deldatef.Checked = true;
            FillGrid();
        }

        private void add_Click(object sender, EventArgs e)
        {
            // Добавление
            Worker_edit f = new Worker_edit(true);  // Передаем true, так как это означает, что нам нужно отображать только неудаленные объекты
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
                Worker_view f = new Worker_view(Workers.WorkerID(k));
                DialogResult result = f.ShowDialog();
                FillGrid();
            }
        }

        private void D_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Обрабатывается событие нажатия на кнопку "Выбрать"
            if (purpose == "choose")
            {
                if (e.ColumnIndex == 7)
                {
                    if (e.RowIndex > -1)
                    {
                        if (D.RowCount - 1 >= e.RowIndex)
                        {
                            int l = e.RowIndex;
                            int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
                            chooseWor = Workers.WorkerID(k);

                            this.Close();
                        }
                    }
                }
            }

                // Обрабатывается событие нажатия на кнопку "Удалить"
                if (purpose != "choose")
                {
                if (e.ColumnIndex == 7)
                {
                    if (delBan == true) // Запрета нет
                    {
                        if (e.RowIndex > -1)
                        {
                            if (D.RowCount - 1 >= e.RowIndex)
                            {
                                int l = e.RowIndex;
                                const string message = "Вы уверены, что хотите удалить работника?";
                                const string caption = "Удаление";
                                var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                                if (result == DialogResult.OK)
                                {
                                    // Форма не закрывается
                                    int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
                                    D.Rows.Remove(D.Rows[l]);
                                    Worker o = Workers.WorkerID(k);
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
                                Worker_edit f = new Worker_edit(Workers.WorkerID(k), false);
                                DialogResult result = f.ShowDialog();
                                FillGrid();
                            }
                        }
                    }
                }
            }
        }

        private void Worker_find_KeyDown(object sender, KeyEventArgs e)
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
