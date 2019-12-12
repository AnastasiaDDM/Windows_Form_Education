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

        public Parent_find()
        {
            InitializeComponent();
        }

        public Parent_find(String answer)
        {
            InitializeComponent();
            purpose = answer;
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
            //nom = D.Columns.Add("ID", typeof(Int32));
            //DataGridViewTextBoxColumn nom = new DataGridViewTextBoxColumn();
            //DataGridViewColumn nom = D.Columns.Add("ID", typeof(Int32));
            //nom.HeaderText = "№";
            //nom.Aut
            //nom.AutoIncrementSeed = 1;
            //nom.AutoIncrementStep = 1;
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.HeaderText = "№ ответственного лица";
            sortf.Items.Add("№ отв. лица");
            DataGridViewTextBoxColumn st = new DataGridViewTextBoxColumn();
            st.HeaderText = "ФИО";
            sortf.Items.Add("ФИО");
            DataGridViewTextBoxColumn ph = new DataGridViewTextBoxColumn();
            ph.HeaderText = "Телефон";
            sortf.Items.Add("Телефон");

            //D.Columns.Add(nom);
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

            this.countf.SelectedItem = "10";
            pagef.Items.Add(1);
            this.pagef.SelectedItem = 1;
            pageindex = pagef.SelectedIndex;
            deldatef.Checked = true;
        }

        private void FillGrid() // Заполняем гриды
        {
            D.Rows.Clear();
            //            this.pagef.SelectedText = "1";

            //this.countf.SelectedItem = "10";
            //this.sortf.SelectedItem = "ID";
            //asсdesс = "asc";
            //sort = "ID";
            //count = 10;
            //page = 1;
            deldate = this.deldatef.Checked;
            // true - неудален false - все!!!
            //count = Convert.ToInt32(this.countf.SelectedItem);
            //page = Convert.ToInt32(this.pagef.SelectedItem);
            //sort = Convert.ToString(this.sortf.SelectedItem);
            asсdesс = ascflag == true ? "asc" : "desc";


            count = this.countf.SelectedItem == null ? 10 : Convert.ToInt32(this.countf.SelectedItem);
            page = this.pagef.SelectedItem == null ? 1 : Convert.ToInt32(this.pagef.SelectedItem);
            sort = this.sortf.SelectedItem == null ? "ID" : Convert.ToString(this.sortf.SelectedItem);
            if (this.sortf.SelectedItem != null)
            {
                if (this.sortf.SelectedText == "№ отв. лица")
                {
                    sort = "ID";
                }
                if (this.sortf.SelectedText == "ФИО")
                {
                    sort = "FIO";
                }
                else
                {
                    sort = "Phone";
                }
            }


            Parent parent = new Parent();
            parent.FIO = this.fiof.Text == "" ? null : this.fiof.Text;
            parent.Phone = this.phonef.Text == "+7(   )    -" ? null : this.phonef.Text;

            Student student = new Student();
            student.FIO = this.stfiof.Text == "" ? null : this.stfiof.Text;
            parent.Phone = this.stphonef.Text == "+7(   )    -" ? null : this.stphonef.Text;

            int countrecord = 0;

            List<Parent> c = new List<Parent>();
            c = Parents.FindAll(deldate, parent, student, sort, asсdesс, page, count, ref countrecord);
            pagef.Items.Clear();
            pages = Convert.ToInt32(Math.Ceiling((double)countrecord / count));
            for (int p = 1; p <= pages; p++) // Формирование количества страниц
            {
                // добавляем один элемент
                pagef.Items.Add(p);
            }

            for (int i = 0; i < c.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                D.Rows.Add(row);

                D.Rows[i].Cells[0].Value = c[i].ID;

                D.Rows[i].Cells[1].Value = c[i].FIO;

                D.Rows[i].Cells[2].Value = c[i].Phone;

                if(purpose == "choose")
                {
                    D.Rows[i].Cells[3].Value = "Выбрать";
                }
                else
                {
                    D.Rows[i].Cells[3].Value = "Удалить";
                }
            }
        }

        private void find_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void Parent_find_Activated(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void D_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(purpose == "choose")
            {
                if (e.ColumnIndex == 3)
                {
                    if (e.RowIndex > -1)
                    {
                        if (D.RowCount - 1 >= e.RowIndex)
                        {

                            int l = e.RowIndex;
                            //const string message = "Вы уверены, что хотите удалить отв. лицо?";
                            //const string caption = "Удаление";
                            //var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                            //if (result == DialogResult.OK)
                            //{
                            //    // Форма не закрывается



                            //int k = Convert.ToInt32(D.Rows[l].Cells[0].Value);
                            ////    D.Rows.Remove(D.Rows[l]);
                            //Student_find.chooseParent = Parents.ParentID(k);

                            ////                     Program.ParentStudent_find.setParent(choosePar);
                            ////    String ans = o.Del();
                            ////}



                            int k = Convert.ToInt32(D.Rows[l].Cells[0].Value);
                            // D.Rows.Remove(D.Rows[l]);
                            //Student_find.chooseParent = Parents.ParentID(k);
                            choosePar = Parents.ParentID(k);


                            this.Close();
                        }
                    }
                }
            }
            else
            {
                if (e.ColumnIndex == 3)
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
                                int k = Convert.ToInt32(D.Rows[l].Cells[0].Value);
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
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            Parent_edit f = new Parent_edit(true);  // Передаем true, так как это означает, что нам нужно отображать только неудаленные объекты
            f.Show();
        }

        private void D_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int l = e.RowIndex;
                int k = Convert.ToInt32(D.Rows[l].Cells[0].Value);
                Parent_edit f = new Parent_edit(Parents.ParentID(k), false);
                f.Show();
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
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

        private void prev_Click(object sender, EventArgs e)
        {
            if (pageindex + 1 > 1)
            {
                //              pagef.SelectedIndex = pagef.FindStringExact(Convert.ToString(pageindex - 1));
                pagef.SelectedIndex = (pageindex - 1);
                pageindex = pagef.SelectedIndex;
                //           this.pagef.SelectedItem =
                FillGrid();
            }
        }

        private void reset_Click(object sender, EventArgs e) // Сбрасываются все установленные значения поиска
        {
            fiof.Clear();
            phonef.Clear();
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
            FillGrid();
        }
    }
}
