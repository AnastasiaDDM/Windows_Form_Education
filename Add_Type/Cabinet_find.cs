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
    public partial class Cabinet_find : Form
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
        public Cabinet_find()
        {
            this.KeyPreview = true;
            InitializeComponent();
            LoadAll();
        }
        public Cabinet_find(String answer)
        {
            this.KeyPreview = true;
            InitializeComponent();
            purpose = answer;
            LoadAll();
        }
        private void LoadAll()
        {
            buildDG();
            FillGrid();
        }
        private void buildDG() //Построение грида 
        {
            D.Columns.Clear();
            D.Rows.Clear();

            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.HeaderText = "№ ";
            sortf.Items.Add("№ кабинета");
            DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn();
            name.HeaderText = "Название кабинета";
            sortf.Items.Add("Наименование кабинета");
            DataGridViewTextBoxColumn capacity = new DataGridViewTextBoxColumn();
            capacity.HeaderText = "Вместимость";
            sortf.Items.Add("Вместимость");
            DataGridViewTextBoxColumn bran = new DataGridViewTextBoxColumn();
            bran.HeaderText = "Филиал";
            sortf.Items.Add("Филиал");


            D.Columns.Add(edit);
            D.Columns.Add(id);
            D.Columns.Add(name);
            D.Columns.Add(capacity);
            D.Columns.Add(bran);

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
            this.pagef.SelectedIndex = 0;
            pageindex = pagef.SelectedIndex;
            deldatef.Checked = true;
            this.sortf.SelectedIndex = 0;

            // Построение комбобоксов: наименование, адрес, директор
            // Построение комбобокса филиалов
            Branch branch = new Branch();
            Worker director = new Worker();
            int countrecord = 0;

            List<Branch> branches = new List<Branch>();
            branches = Branches.FindAll(deldate, branch, director, sort, asсdesс, page, count, ref countrecord);

            branchf.Items.Clear();
            branchf.Items.Add("Не выбрано");
            foreach (var s in branches)
            {
                // добавляем один элемент
                branchf.Items.Add(s.ID + ". " + s.Name);
            }
            this.branchf.SelectedIndex = 0;
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
                if (this.sortf.SelectedItem.ToString() == "№ кабинета")
                {
                    sort = "ID";
                }
                if (this.sortf.SelectedItem.ToString() == "Название кабинета")
                {
                    sort = "Number";
                }
                if (this.sortf.SelectedItem.ToString() == "Вместимость")
                {
                    sort = "Capacity";
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

            int min = this.min.Text == "" ? 0 : Convert.ToInt32(this.min.Text);
            int max = this.max.Text == "" ? 0 : Convert.ToInt32(this.max.Text);

            Cabinet cab = new Cabinet();
            cab.Number = this.numbert.Text == "" ? null : this.numbert.Text;


            List<Cabinet> cabinets = new List<Cabinet>();
            cabinets = Cabinets.FindAll(deldate, cab, branch, min, max, sort, asсdesс, page, count, ref countrecord);
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
            for (int i = 0; i < cabinets.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                D.Rows.Add(row);

                D.Rows[i].Cells[0].Value = (page - 1) * count + i + 1 + "✎";   // Отображение счетчика записей и значок редактирования

                D.Rows[i].Cells[1].Value = cabinets[i].ID;

                D.Rows[i].Cells[2].Value = cabinets[i].Number;

                D.Rows[i].Cells[3].Value = cabinets[i].Capacity;

                D.Rows[i].Cells[4].Value = cabinets[i].BranchID + ". " + Branches.BranchID(cabinets[i].BranchID).Name;

                if (purpose == "choose")
                {
                    D.Rows[i].Cells[5].Value = "Выбрать";
                }
                else
                {
                    D.Rows[i].Cells[5].Value = "Удалить";
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
            Cabinet_edit f = new Cabinet_edit(true);  // Передаем true, так как это означает, что нам нужно отображать только неудаленные объекты
            DialogResult result = f.ShowDialog();
            FillGrid();
        }

        private void D_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Обрабатывается событие нажатия на кнопку "Удалить"
            if (e.ColumnIndex == 5)
            {
                if (e.RowIndex > -1)
                {
                    if (D.RowCount - 1 >= e.RowIndex)
                    {
                        int l = e.RowIndex;
                        const string message = "Вы уверены, что хотите удалить кабинет?";
                        const string caption = "Удаление";
                        var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (result == DialogResult.OK)
                        {
                            // Форма не закрывается
                            int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
                            D.Rows.Remove(D.Rows[l]);
                            Cabinet o = Cabinets.CabinetID(k);
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
                        Cabinet_edit f = new Cabinet_edit(Cabinets.CabinetID(k), false);
                        DialogResult result = f.ShowDialog();
                        FillGrid();
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
                Cabinet_view f = new Cabinet_view(Cabinets.CabinetID(k));
                DialogResult result = f.ShowDialog();
                FillGrid();
            }
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

        private void free_Click(object sender, EventArgs e)
        {
            D.Rows.Clear();
            int countrecord = 0;
            List<Cabinet> cabinets = new List<Cabinet>();
            cabinets = Cabinets.getFree(ref countrecord);

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
            for (int i = 0; i < cabinets.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                D.Rows.Add(row);

                D.Rows[i].Cells[0].Value = (page - 1) * count + i + 1 + "✎";   // Отображение счетчика записей и значок редактирования

                D.Rows[i].Cells[1].Value = cabinets[i].ID;

                D.Rows[i].Cells[2].Value = cabinets[i].Number;

                D.Rows[i].Cells[3].Value = cabinets[i].Capacity;

                D.Rows[i].Cells[4].Value = cabinets[i].BranchID + ". " + Branches.BranchID(cabinets[i].BranchID).Name;

                if (purpose == "choose")
                {
                    D.Rows[i].Cells[5].Value = "Выбрать";
                }
                else
                {
                    D.Rows[i].Cells[5].Value = "Удалить";
                }
            }

        }

        private void reset_Click(object sender, EventArgs e)
        {
            // Сброс всех выбранных значений в значения по умолчанию
            numbert.Clear();
            min.Value = 0;
            max.Value = 0;
            branchf.SelectedIndex = 0;
            sortf.SelectedIndex = 0;
            ascflag = true;
            this.countf.SelectedItem = "10";
            pagef.Items.Add(1);
            this.pagef.SelectedItem = 1;
            pageindex = pagef.SelectedIndex;
            deldatef.Checked = true;
            FillGrid();
        }
    }
}
