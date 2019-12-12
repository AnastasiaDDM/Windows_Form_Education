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
    public partial class Contract_find : Form
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
        public Contract  chooseCon;
        public Contract_find()
        {
            InitializeComponent();
        }
        public Contract_find(String answer)
        {
            InitializeComponent();
            purpose = answer;
            LoadAll();
        }
        private void Contract_find_Load(object sender, EventArgs e)
        {
   //         LoadAll();
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
            sortf.Items.Add("№ договора");
            DataGridViewTextBoxColumn date = new DataGridViewTextBoxColumn();
            date.HeaderText = "Дата";
            sortf.Items.Add("Дата");
            DataGridViewTextBoxColumn st = new DataGridViewTextBoxColumn();
            st.HeaderText = "№ ученика";
            sortf.Items.Add("№ ученика");
            DataGridViewTextBoxColumn course = new DataGridViewTextBoxColumn();
            course.HeaderText = "Курс";
            sortf.Items.Add("Курс");
            DataGridViewTextBoxColumn cost2 = new DataGridViewTextBoxColumn();
            cost2.HeaderText = "Стоимость";
            sortf.Items.Add("Стоимость");
            DataGridViewTextBoxColumn payment = new DataGridViewTextBoxColumn();
            payment.HeaderText = "Оплата за месяц";
            sortf.Items.Add("Оплата за месяц");
            DataGridViewTextBoxColumn manager = new DataGridViewTextBoxColumn();
            manager.HeaderText = "Менеджер";
            sortf.Items.Add("Менеджер");
            DataGridViewTextBoxColumn bran = new DataGridViewTextBoxColumn();
            bran.HeaderText = "Филиал";
            sortf.Items.Add("Филиал");

            D.Columns.Add(edit);
            D.Columns.Add(id);
            D.Columns.Add(date);
            D.Columns.Add(st);
            D.Columns.Add(course);
            D.Columns.Add(cost2);
            D.Columns.Add(payment);

            if (purpose == "choose")
            {
                DataGridViewButtonColumn choose = new DataGridViewButtonColumn();
                choose.HeaderText = "Выбрать";
                D.Columns.Add(choose);
            }
            else
            {
                D.Columns.Add(manager);
                D.Columns.Add(bran);
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
                if (this.sortf.SelectedText == "№ договора")
                {
                    sort = "ID";
                }
                if (this.sortf.SelectedText == "Дата")
                {
                    sort = "Date";
                }
                if (this.sortf.SelectedText == "№ ученика")
                {
                    sort = "StudentID";
                }
                if (this.sortf.SelectedText == "Курс")
                {
                    sort = "CourseID";
                }
                if (this.sortf.SelectedText == "Стоимость")
                {
                    sort = "Cost";
                }
                if (this.sortf.SelectedText == "Оплата за месяц")
                {
                    sort = "PayofMonth";
                }
                if (this.sortf.SelectedText == "Менеджер")
                {
                    sort = "ManagerID";
                }
                else
                {
                    sort = "BranchID";
                }
            }

            // Смысловые переменные, отражающие основные параметры поиска
            Contract contract = new Contract();
            DateTime mindate = datefrom.Value;
            DateTime maxdate = dateto.Value;

            Branch branch = new Branch();
            if(branchf.SelectedItem != null)
            {
                if(branchf.SelectedIndex == 0)
                {
                    branch.ID = 0;
                }
                else
                {
                    string[] branchID = (Convert.ToString(branchf.SelectedItem)).Split('.');
                    branch.ID = Branches.BranchID(Convert.ToInt32(branchID[0])).ID;
                }
            }

            Worker manager = new Worker();
            Student student = new Student();
            Course course = new Course();

            int min = this.costfrom.Text == "" ? 0 : Convert.ToInt32(this.costfrom.Text);
            int max = this.costto.Text == "" ? 0 : Convert.ToInt32(this.costto.Text);

            List<Contract> contracts = new List<Contract>();
            contracts = Contracts.FindAll(deldate, student, manager, branch, course, mindate, maxdate, min, max, sort, asсdesс, page, count, ref countrecord);
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
            for (int i = 0; i < contracts.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                D.Rows.Add(row);

                D.Rows[i].Cells[0].Value = (page - 1) * count + i + 1 + "✎";   // Отображение счетчика записей и значок редактирования

                D.Rows[i].Cells[1].Value = contracts[i].ID;

                D.Rows[i].Cells[2].Value = contracts[i].Date;

                D.Rows[i].Cells[3].Value = contracts[i].StudentID + ". " + Students.StudentID(contracts[i].StudentID).FIO;

                D.Rows[i].Cells[4].Value = contracts[i].CourseID + ". " + Courses.CourseID(contracts[i].CourseID).nameGroup;

                D.Rows[i].Cells[5].Value = contracts[i].Cost;

                D.Rows[i].Cells[6].Value = contracts[i].PayofMonth;

                if (purpose == "choose")
                {
                    D.Rows[i].Cells[7].Value = "Выбрать";
                }
                else
                {
                    D.Rows[i].Cells[7].Value = contracts[i].ManagerID + ". " + Workers.WorkerID(contracts[i].ManagerID).FIO;

                    D.Rows[i].Cells[8].Value = contracts[i].BranchID + ". " + Branches.BranchID(contracts[i].BranchID).Name;

                    D.Rows[i].Cells[9].Value = "Удалить";
                }
            }
        }

        private void find_Click(object sender, EventArgs e)
        {
            FillGrid();
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
                            chooseCon = Contracts.ContractID(k);

                            this.Close();
                        }
                    }
                }
            }
            // Обрабатывается событие нажатия на кнопку "Удалить"
            else
            {
                if (e.ColumnIndex == 9)
                {
                    if (e.RowIndex > -1)
                    {
                        if (D.RowCount - 1 >= e.RowIndex)
                        {
                            int l = e.RowIndex;
                            const string message = "Вы уверены, что хотите удалить договор?";
                            const string caption = "Удаление";
                            var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                            if (result == DialogResult.OK)
                            {
                                // Форма не закрывается
                                int k = Convert.ToInt32(D.Rows[l].Cells[0].Value);
                                D.Rows.Remove(D.Rows[l]);
                                Contract o = Contracts.ContractID(k);
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
        }

        private void reset_Click(object sender, EventArgs e)
        {
            // Сброс всех выбранных знаений в значения по умолчанию
            studentf.Clear();
            managerf.Clear();
            coursef.Clear();
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

        private void pagef_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Переключение страниц по средствам комбобокса
            pageindex = pagef.SelectedIndex;
            pagef.SelectedIndex = pagef.FindStringExact(pagef.Text);
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
    }
}
