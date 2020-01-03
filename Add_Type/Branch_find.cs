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
    public partial class Branch_find : Form
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

        bool editBan; // Перменная для хранения доступа к редактированию
        bool delBan; // Перменная для хранения доступа к удалению

        //public static Student chooseStudent; // Эта переменная для приема значения из вызываемой(дочерней) формы
        //public static Type chooseType; // Эта переменная для приема значения из вызываемой(дочерней) формы
        //public Course chooseCour; // Эта переменная для пересылке своего значения в вызывающую форму
        public Branch_find()
        {
            this.KeyPreview = true;
            InitializeComponent();
            LoadAll();
        }
        public Branch_find(String answer)
        {
            this.KeyPreview = true;
            InitializeComponent();
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
            delBan = Prohibition.Banned("add_del_branch");
            add.Enabled = delBan; 
            editBan = Prohibition.Banned("edit_branch");

            //            add.Enabled = (what_i_can("add_cabinet"));
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
            sortf.Items.Add("№ филиала");
            DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn();
            name.HeaderText = "Наименование";
            sortf.Items.Add("Наименование");
            DataGridViewTextBoxColumn address = new DataGridViewTextBoxColumn();
            address.HeaderText = "Адрес";
            sortf.Items.Add("Адрес");
            DataGridViewTextBoxColumn dir = new DataGridViewTextBoxColumn();
            dir.HeaderText = "Директор";
            sortf.Items.Add("Директор");


            D.Columns.Add(id);
            D.Columns.Add(name);
            D.Columns.Add(address);
            D.Columns.Add(dir);

            D.Columns[0].Width = 65;
            D.Columns[1].Width = 65;
            D.Columns[2].Width = 360;
            D.Columns[3].Width = 330;
            D.Columns[4].Width = 180;

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
                //if (delBan == false)
                //{ 
                D.Columns[5].Visible = delBan;
                //}
            }

            D.ReadOnly = true;

            // Установление начальных значений на элементах формы
            this.countf.SelectedItem = "10";
            pagef.Items.Add(1);
            this.pagef.SelectedIndex = 0;
            pageindex = pagef.SelectedIndex;
            deldatef.Checked = true;

            // Построение комбобоксов: наименование, адрес, директор
            Branch branch = new Branch();
            Worker director = new Worker();
            int countrecord = 0;

            List<Branch> branches = new List<Branch>();
            branches = Branches.FindAll(deldate, branch, director, sort, asсdesс, page, count, ref countrecord);

            namef.Items.Add("Не выбрано");
            addressf.Items.Add("Не выбрано");
            directorf.Items.Add("Не выбрано");
            foreach (var s in branches)
            {
                // добавляем один элемент
                namef.Items.Add(s.Name);
                addressf.Items.Add(s.Address);
                directorf.Items.Add(s.DirectorBranch + ". " + Workers.WorkerID(s.DirectorBranch).FIO);
            }
            this.namef.SelectedIndex = 0;
            this.addressf.SelectedIndex = 0;
            this.directorf.SelectedIndex = 0;
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
                if (this.sortf.SelectedItem.ToString() == "№ филиала")
                {
                    sort = "ID";
                }
                if (this.sortf.SelectedItem.ToString() == "Наименование")
                {
                    sort = "Name";
                }
                if (this.sortf.SelectedItem.ToString() == "Адрес")
                {
                    sort = "Address";
                }
                if (this.sortf.SelectedItem.ToString() == "Директор")
                {
                    sort = "DirectorBranch";
                }
            }

            // Смысловые переменные, отражающие основные параметры поиска
            Branch branch = new Branch();
            if (namef.SelectedItem != null)
            {
                if (namef.SelectedIndex == 0)
                {
                    branch.Name = null;
                }
                else
                {
                    //string[] branchID = (Convert.ToString(branchf.SelectedItem)).Split('.');
                    //branch.ID = Branches.BranchID(Convert.ToInt32(branchID[0])).ID;
                    branch.Name = namef.SelectedItem.ToString();
                }
            }

            if (addressf.SelectedItem != null)
            {
                if (addressf.SelectedIndex == 0)
                {
                    branch.Address = null;
                }
                else
                {
                    branch.Address = addressf.SelectedItem.ToString();
                }
            }

            Worker director = new Worker();

            if (directorf.SelectedItem != null)
            {
                if (directorf.SelectedIndex == 0)
                {
                    director.FIO = null;
                }
                else
                {
                    string[] directorID = (Convert.ToString(directorf.SelectedItem)).Split('.');
                    director.ID = Workers.WorkerID(Convert.ToInt32(directorID[0])).ID;
                }
            }

            List<Branch> branches = new List<Branch>();
            branches = Branches.FindAll(deldate, branch, director, sort, asсdesс, page, count, ref countrecord);
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
            for (int i = 0; i < branches.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                D.Rows.Add(row);

                D.Rows[i].Cells[0].Value = (page - 1) * count + i + 1 + "✎";   // Отображение счетчика записей и значок редактирования

                D.Rows[i].Cells[1].Value = branches[i].ID;

                D.Rows[i].Cells[2].Value = branches[i].Name;

                D.Rows[i].Cells[3].Value = branches[i].Address;

                D.Rows[i].Cells[4].Value = branches[i].DirectorBranch + ". " + Workers.WorkerID(branches[i].DirectorBranch).FIO;

                if (purpose == "choose")
                {
                    D.Rows[i].Cells[5].Value = "Выбрать";
                }
                else
                {
                    D.Rows[i].Cells[5].Value = "Удалить";
                    //if (delBan == false)
                    //{ D.Rows[i].Cells[5].ToolTipText = "У вас нет полномочий на выполнение этого действия"; }
                }
            }
        }

        private void find_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            // Сброс всех выбранных значений в значения по умолчанию

            this.namef.SelectedIndex = 0;
            this.addressf.SelectedIndex = 0;
            this.directorf.SelectedIndex = 0;
            sortf.SelectedIndex = 0;
            ascflag = true;
            this.countf.SelectedItem = "10";
            pagef.Items.Add(1);
            this.pagef.SelectedItem = 1;
            pageindex = pagef.SelectedIndex;
            deldatef.Checked = true;
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

        private void add_Click(object sender, EventArgs e)
        {
            // Добавление
            Branch_edit f = new Branch_edit(true);  // Передаем true, так как это означает, что нам нужно отображать только неудаленные объекты
            DialogResult result = f.ShowDialog();
            FillGrid();
        }

        private void Branch_find_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void D_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //// Обрабатывается событие нажатия на кнопку "Выбрать"
            //if (purpose == "choose")
            //{
            //    if (e.ColumnIndex == 7)
            //    {
            //        if (e.RowIndex > -1)
            //        {
            //            if (D.RowCount - 1 >= e.RowIndex)
            //            {
            //                int l = e.RowIndex;
            //                int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
            //                chooseCon = Contracts.ContractID(k);

            //                this.Close();
            //            }
            //        }
            //    }
            //}
            // Обрабатывается событие нажатия на кнопку "Удалить"
            //else
            //{
            if (e.ColumnIndex == 5)
            {
                if (delBan == true) // Запрета нет
                {
                    if (e.RowIndex > -1)
                    {
                        if (D.RowCount - 1 >= e.RowIndex)
                        {
                            int l = e.RowIndex;
                            const string message = "Вы уверены, что хотите удалить филиал?";
                            const string caption = "Удаление";
                            var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                            if (result == DialogResult.OK)
                            {
                                // Форма не закрывается
                                int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
                                D.Rows.Remove(D.Rows[l]);
                                Branch o = Branches.BranchID(k);
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
                            Branch_edit f = new Branch_edit(Branches.BranchID(k), false);
                            DialogResult result = f.ShowDialog();
                            FillGrid();
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
                Branch_view f = new Branch_view(Branches.BranchID(k));
                DialogResult result = f.ShowDialog();
                FillGrid();
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
