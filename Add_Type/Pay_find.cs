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
    public partial class Pay_find : Form
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
        string format2 = "HH:mm"; // Формат для отображения даты 

        string format = "dd.MM.yy HH:mm"; // Формат для отображения даты 
        public static Timetable chooseTimetable; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public static Worker chooseTeacher; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public static Contract chooseContract; // Эта переменная для приема значения из вызываемой(дочерней) формы

        bool editBan; // Перменная для хранения доступа к редактированию
        bool delBan; // Перменная для хранения доступа к удалению
        public Pay_find()
        {
            InitializeComponent();
            this.KeyPreview = true;
            LoadAll();
        }
        public Pay_find(String answer, string button)
        {
            InitializeComponent();
            this.KeyPreview = true;
            purpose = answer;
            if (button == "bstud") // Блокировка поиска по ученикам
            {
 //               bstud.Enabled = false;
            }
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
            delBan = Prohibition.Banned("add_del_pay");
            add.Enabled = delBan;
            editBan = Prohibition.Banned("edit_pay");
        }
        private void buildDG() //Построение грида 
        {
            D.Columns.Clear();
            D.Rows.Clear();

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
            sortf.Items.Add("№ оплаты");
            DataGridViewTextBoxColumn st = new DataGridViewTextBoxColumn();
            st.HeaderText = "Дата оплаты";
            sortf.Items.Add("Дата оплаты");
            DataGridViewTextBoxColumn cont = new DataGridViewTextBoxColumn();
            cont.HeaderText = "Договор";
            sortf.Items.Add("Договор");
            DataGridViewTextBoxColumn wor = new DataGridViewTextBoxColumn();
            wor.HeaderText = "Преподаватель";
            sortf.Items.Add("Преподаватель");
            DataGridViewTextBoxColumn time = new DataGridViewTextBoxColumn();
            time.HeaderText = "Занятие";
            sortf.Items.Add("Занятие");
            DataGridViewTextBoxColumn ph = new DataGridViewTextBoxColumn();
            ph.HeaderText = "Оплата";
            sortf.Items.Add("Оплата");
            DataGridViewTextBoxColumn br = new DataGridViewTextBoxColumn();
            br.HeaderText = "Филиал";
            sortf.Items.Add("Филиал");
            DataGridViewTextBoxColumn type = new DataGridViewTextBoxColumn();
            type.HeaderText = "Способ оплаты";
            sortf.Items.Add("Способ оплаты");

            D.Columns.Add(id);
            D.Columns.Add(st);
            D.Columns.Add(cont);
            D.Columns.Add(wor);
            D.Columns.Add(time);
            D.Columns.Add(ph);
            D.Columns.Add(br);
            D.Columns.Add(type);

            D.Columns[0].Width = 60;
            D.Columns[1].Width = 60;
            D.Columns[2].Width = 120;
            D.Columns[3].Width = 110;
            D.Columns[4].Width = 110;
            D.Columns[5].Width = 110;
            D.Columns[6].Width = 75;

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
                D.Columns[9].Visible = delBan;
            }

            D.ReadOnly = true;

            // Установление начальных значений на элементах формы
            this.countf.SelectedItem = "10";
            pagef.Items.Add(1);
            this.pagef.SelectedIndex = 0;
            pageindex = pagef.SelectedIndex;
            deldatef.Checked = true;
            this.sortf.SelectedIndex = 0;
            this.typef.SelectedIndex = 0;
            this.indicatorf.SelectedIndex = 0;


            datefrom.Value = new DateTime(DateTime.Now.Year, 01, 01, 0, 0, 0);
            dateto.Value = new DateTime(DateTime.Now.Year, 12, 31, 0, 0, 0);

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
                if (this.sortf.SelectedItem.ToString() == "№ оплаты")
                {
                    sort = "ID";
                }
                if (this.sortf.SelectedItem.ToString() == "Дата оплаты")
                {
                    sort = "Date";
                }
                if (this.sortf.SelectedItem.ToString() == "Договор")
                {
                    sort = "ContractID";
                }
                if (this.sortf.SelectedItem.ToString() == "Преподаватель")
                {
                    sort = "WorkerID";
                }
                if (this.sortf.SelectedItem.ToString() == "Занятие")
                {
                    sort = "TimetableID";
                }
                if (this.sortf.SelectedItem.ToString() == "Оплата")
                {
                    sort = "Payment";
                }
                if (this.sortf.SelectedItem.ToString() == "Филиал")
                {
                    sort = "BranchID";
                }
                if (this.sortf.SelectedItem.ToString() == "Способ оплаты")
                {
                    sort = "Type";
                }
            }

            // Смысловые переменные, отражающие основные параметры поиска
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

            Pay pay = new Pay();

            if(this.typef.SelectedIndex !=0)
            {
                pay.Type = this.typef.SelectedItem.ToString();
            }

            if (this.indicatorf.SelectedIndex == 1)
            {
                pay.Indicator = 1;
            }
            if (this.indicatorf.SelectedIndex == 1)
            {
                pay.Indicator = 2;
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

            Worker teacher = new Worker();
            if (chooseTeacher != null)
            {
                teacher = chooseTeacher;
                teacherf.Text = teacher.ID + ". " + teacher.FIO;
            }

            Contract contract = new Contract();
            if (chooseContract != null)
            {
                contract = chooseContract;
                contractf.Text = chooseContract.ID + ". " + chooseContract.Date;
            }

            Timetable timetable = new Timetable();

            int min = this.costfrom.Text == "" ? 0 : Convert.ToInt32(this.costfrom.Text);
            int max = this.costto.Text == "" ? 0 : Convert.ToInt32(this.costto.Text);

            List<Pay> pays = new List<Pay>();
            pays = Pays.FindAll(deldate, pay, contract, teacher, timetable, branch, mindate, maxdate, min, max, sort, asсdesс, page, count, ref countrecord);
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
            for (int i = 0; i < pays.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                D.Rows.Add(row);

                D.Rows[i].Cells[0].Value = (page - 1) * count + i + 1 + "✎";   // Отображение счетчика записей и значок редактирования

                D.Rows[i].Cells[1].Value = pays[i].ID;

                D.Rows[i].Cells[2].Value = pays[i].Date;

                if(pays[i].ContractID != null)
                {
                    D.Rows[i].Cells[3].Value = pays[i].ContractID + ". " + Contracts.ContractID(Convert.ToInt32(pays[i].ContractID)).Date;
                }
                else
                {
                    D.Rows[i].Cells[3].Value = "";
                }
                
                if(pays[i].WorkerID != null)
                {
                    D.Rows[i].Cells[4].Value = pays[i].WorkerID + ". " + Workers.WorkerID(Convert.ToInt32(pays[i].WorkerID)).FIO;

                    D.Rows[i].Cells[5].Value = pays[i].TimetableID + ". " + Timetables.TimetableID(Convert.ToInt32(pays[i].TimetableID)).Startlesson.ToString(format)
                      + " - " + Timetables.TimetableID(Convert.ToInt32(pays[i].TimetableID)).Endlesson.ToString(format2);
                }
                else
                {
                    D.Rows[i].Cells[4].Value = "";
                    D.Rows[i].Cells[5].Value = "";
                }

                D.Rows[i].Cells[6].Value = pays[i].Payment;

                D.Rows[i].Cells[7].Value = pays[i].BranchID + ". " + Branches.BranchID(pays[i].BranchID).Name;

                D.Rows[i].Cells[8].Value = pays[i].Type;

                if (purpose == "choose")
                {
                    D.Rows[i].Cells[9].Value = "Выбрать";
                }
                else
                {
                    D.Rows[i].Cells[9].Value = "Удалить";
                }
            }
        }


        private void bwor_Click(object sender, EventArgs e)
        {
            Worker_find f = new Worker_find("choose", 3); // Передем choose - это означает, что нужно добавить кнопку выбора родителя
            DialogResult result = f.ShowDialog();
            chooseTeacher = f.chooseWor; // Передаем ссылку форме родителей на переменную в этой форме
            FillGrid();
        }

        private void bcon_Click(object sender, EventArgs e)
        {
            Contract_find f = new Contract_find("choose", "b"); // Передем choose - это означает, что нужно добавить кнопку выбора родителя
            DialogResult result = f.ShowDialog();
            chooseContract = f.chooseCon; // Передаем ссылку форме родителей на переменную в этой форме
            FillGrid();
        }

        private void D_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Обрабатывается событие нажатия на кнопку "Выбрать"
            if (purpose == "choose")
            {
                //if (e.ColumnIndex == 7)
                //{
                //    if (e.RowIndex > -1)
                //    {
                //        if (D.RowCount - 1 >= e.RowIndex)
                //        {
                //            int l = e.RowIndex;
                //            int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
                //            chooseCon = Contracts.ContractID(k);

                //            this.Close();
                //        }
                //    }
                //}
            }
            // Обрабатывается событие нажатия на кнопку "Удалить"
            else
            {
                if (e.ColumnIndex == 9)
                {
                    if (delBan == true) // Запрета нет
                    {
                        if (e.RowIndex > -1)
                        {
                            if (D.RowCount - 1 >= e.RowIndex)
                            {
                                int l = e.RowIndex;
                                const string message = "Вы уверены, что хотите удалить оплату?";
                                const string caption = "Удаление";
                                var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                                if (result == DialogResult.OK)
                                {
                                    // Форма не закрывается
                                    int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
                                    D.Rows.Remove(D.Rows[l]);
                                    Pay o = Pays.PayID(k);
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
                                Pay_edit f = new Pay_edit(Pays.PayID(k));
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
                if (e.ColumnIndex > -1)
                {
                    int l = e.RowIndex;
                    int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
                    Pay_view f = new Pay_view(Pays.PayID(k)); 
                    DialogResult result = f.ShowDialog();
                    FillGrid();
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            Pay_edit f = new Pay_edit();
            DialogResult result = f.ShowDialog();
            FillGrid();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            // Сброс всех выбранных значений в значения по умолчанию
            costfrom.Clear();
            costto.Clear();
            sortf.SelectedIndex = 0;
            ascflag = true;
            this.countf.SelectedItem = "10";
            pagef.Items.Add(1);
            this.pagef.SelectedItem = 1;
            pageindex = pagef.SelectedIndex;
            deldatef.Checked = true;
            indicatorf.SelectedIndex = 0;
            typef.SelectedIndex = 0;
            branchf.SelectedIndex = 0;
            datef.Checked = false;
            datefrom.Value = new DateTime(DateTime.Now.Year, 01, 01, 0, 0, 0);
            dateto.Value = new DateTime(DateTime.Now.Year, 12, 31, 0, 0, 0);
            teacherf.Clear();
            chooseTeacher = null;
            contractf.Clear();
            chooseContract = null;
            timef.Clear();
            chooseTimetable = null;
            FillGrid();
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

        private void Pay_find_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void datef_CheckedChanged(object sender, EventArgs e)
        {
            if (datef.Checked == true)
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
