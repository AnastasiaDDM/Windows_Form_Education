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
    public partial class Type_find : Form
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
        public Type chooseTyp; // Эта переменная для пересылке своего значения в вызывающую форму

        bool editBan; // Перменная для хранения доступа к редактированию
        bool delBan; // Перменная для хранения доступа к удалению
        public Type_find()
        {
            InitializeComponent();
            this.KeyPreview = true;
            LoadAll();
        }
        public Type_find(String answer)
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
            delBan = Prohibition.Banned("add_del_type");
            add.Enabled = delBan;
            editBan = Prohibition.Banned("edit_type");
        }
        private void buildDG() //Построение грида 
        {
            D.Columns.Clear();
            D.Rows.Clear();
            D.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

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
            sortf.Items.Add("№ типа курса");
            DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn();
            name.HeaderText = "Название";
            sortf.Items.Add("Название");
            DataGridViewTextBoxColumn cost = new DataGridViewTextBoxColumn();
            cost.HeaderText = "Стоимость";
            sortf.Items.Add("Стоимость");
            DataGridViewTextBoxColumn lessons = new DataGridViewTextBoxColumn();
            lessons.HeaderText = "Занятий";
            sortf.Items.Add("Количество занятий");
            DataGridViewTextBoxColumn month = new DataGridViewTextBoxColumn();
            month.HeaderText = "Месяцев";
            sortf.Items.Add("Количество месяцев");
            DataGridViewTextBoxColumn note = new DataGridViewTextBoxColumn();
            note.HeaderText = "Описание";

            D.Columns.Add(id);
            D.Columns.Add(name);
            D.Columns.Add(cost);
            D.Columns.Add(lessons);
            D.Columns.Add(month);
            D.Columns.Add(note);

            D.Columns[0].Width = 60;
            D.Columns[1].Width = 60;
            D.Columns[2].Width = 200;
            D.Columns[3].Width = 78;
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
                D.Columns[7].Visible = delBan;
            }

            D.ReadOnly = true;

            // Установление начальных значений на элементах формы
            this.countf.SelectedItem = "10";
            pagef.Items.Add(1);
            this.pagef.SelectedIndex = 0;
            pageindex = pagef.SelectedIndex;
            deldatef.Checked = true;        
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
                if (this.sortf.SelectedItem.ToString() == "№ типа курса")
                {
                    sort = "ID";
                }
                if (this.sortf.SelectedItem.ToString() == "Название")
                {
                    sort = "Name";
                }
                if (this.sortf.SelectedItem.ToString() == "Стоимость")
                {
                    sort = "Cost";
                }
                if (this.sortf.SelectedItem.ToString() == "Количество занятий")
                {
                    sort = "Lessons";
                }
                if (this.sortf.SelectedItem.ToString() == "Количество месяцев")
                {
                    sort = "Month";
                }
            }

            // Смысловые переменные, отражающие основные параметры поиска
            Type type = new Type();
            type.Name = this.namet.Text == "" ? null : this.namet.Text;

            int minLes = this.lessonfrom.Text == "" ? 0 : Convert.ToInt32(this.lessonfrom.Text);
            int maxLes = this.lessonto.Text == "" ? 0 : Convert.ToInt32(this.lessonto.Text);

            double minCost = this.costfrom.Text == "" ? 0 : Convert.ToInt32(this.costfrom.Text);
            double maxCost = this.costto.Text == "" ? 0 : Convert.ToInt32(this.costto.Text);

            int minMonth = this.monthfrom.Text == "" ? 0 : Convert.ToInt32(this.monthfrom.Text);
            int maxMonth = this.monthto.Text == "" ? 0 : Convert.ToInt32(this.monthto.Text);

            List<Type> types = new List<Type>();
            types = Types.FindAll(deldate, type, minLes, maxLes, minCost, maxCost, minMonth, maxMonth, sort, asсdesс, page, count, ref countrecord);
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
            for (int i = 0; i < types.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                D.Rows.Add(row);

                D.Rows[i].Cells[0].Value = (page - 1) * count + i + 1 + "✎";   // Отображение счетчика записей и значок редактирования

                D.Rows[i].Cells[1].Value = types[i].ID;

                D.Rows[i].Cells[2].Value = types[i].Name;

                D.Rows[i].Cells[3].Value = types[i].Cost;

                D.Rows[i].Cells[4].Value = types[i].Lessons;

                D.Rows[i].Cells[5].Value = types[i].Month;

                D.Rows[i].Cells[6].Value = types[i].Note;

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
                            chooseTyp = Types.TypeID(k);

                            this.Close();
                        }
                    }
                }
            }
            // Обрабатывается событие нажатия на кнопку "Удалить"
            else
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
                                const string message = "Вы уверены, что хотите удалить тип курса?";
                                const string caption = "Удаление";
                                var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                                if (result == DialogResult.OK)
                                {
                                    // Форма не закрывается
                                    int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
                                    D.Rows.Remove(D.Rows[l]);
                                    Type o = Types.TypeID(k);
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
                                Type_edit f = new Type_edit(Types.TypeID(k), false);
                                DialogResult result = f.ShowDialog();
                                FillGrid();
                            }
                        }
                    }
                }
            }
        }

        private void find_Click(object sender, EventArgs e)
        {
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

        private void reset_Click(object sender, EventArgs e)
        {
            // Сброс всех выбранных значений в значения по умолчанию
            costfrom.Clear();
            costto.Clear();
            monthfrom.Value = 0;
            monthto.Value = 0;
            lessonfrom.Value = 0;
            lessonto.Value = 0;
            namet.Clear();
            sortf.SelectedIndex = 0;
            ascflag = true;
            this.countf.SelectedItem = "10";
            pagef.Items.Add(1);
            this.pagef.SelectedItem = 1;
            pageindex = pagef.SelectedIndex;
            deldatef.Checked = true;
            FillGrid();
        }

        private void prev_Click(object sender, EventArgs e)
        {
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
            Type_edit f = new Type_edit(true);  // Передаем true, так как это означает, что нам нужно отображать только неудаленные объекты
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
                Type_view f = new Type_view(Types.TypeID(k));
                DialogResult result = f.ShowDialog();
            }
        }

        private void Type_find_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
