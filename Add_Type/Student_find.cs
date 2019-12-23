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
    public partial class Student_find : Form
    {
        Boolean deldate ; // true - неудален false - все!!!
        int page = 1;
        int count = 100;
        String sort = "ID";
        String asсdesс = "asc";
        bool ascflag = true;
        int pageindex;
        int pages;
 //       string format = "yyyy-MM-dd HH:mm:ss";
        string formattotext = "dd.MM.yyyy"; // Формат для отображения даты в текстовые поля
        public static Parent chooseParent; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public static Contract chooseContract; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public static Course chooseCourse; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public Student chooseSt; // Эта переменная для пересылке своего значения в вызывающую форму
        public Contract chooseCon; // Эта переменная для пересылке своего значения в вызывающую форму
        string purpose; // Строка предназначения, например, choose - добавить кнопку "Выбрать" т.е. происходит выбор для другой(родительской) формы


        public Student_find()
        {
            InitializeComponent();
            this.KeyPreview = true;
            LoadAll();
        }
        public Student_find(String answer, string button)
        {
            InitializeComponent();
            this.KeyPreview = true;
            purpose = answer;
            if(button == "bcon")
            {
                bcon.Enabled = false;
            }
            if (button == "bpar")
            {
                bpar.Enabled = false;
            }
            LoadAll(); 
        }

        public Student_find(String answer)
        {
            InitializeComponent();
            this.KeyPreview = true;
            purpose = answer;
            LoadAll();
        }

        private void Student_find_Load(object sender, EventArgs e)
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
            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            //see.HeaderText = "Изменить";
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.HeaderText = "№";
            sortf.Items.Add("№ ученика");
            DataGridViewTextBoxColumn st = new DataGridViewTextBoxColumn();
            st.HeaderText = "ФИО ученика";
            sortf.Items.Add("ФИО ученика");
            DataGridViewTextBoxColumn ph = new DataGridViewTextBoxColumn();
            ph.HeaderText = "Телефон";
            sortf.Items.Add("Телефон");

            //D.Columns.Add(nom);
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
            this.sortf.SelectedIndex = 0;
        }

        private void FillGrid() // Заполняем гриды
        {
            D.Rows.Clear();

            // Служебные переменные, связанные с выбором страниц, количества, сортировки

            int countrecord = 0;
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
             if(this.sortf.SelectedItem != null)
            {
                if(this.sortf.SelectedItem.ToString() == "№ ученика")
                {
                    sort = "ID";
                }
                if(this.sortf.SelectedItem.ToString() == "ФИО ученика")
                {
                    sort = "FIO";
                }
                if (this.sortf.SelectedItem.ToString() == "Телефон") 
                {
                    sort = "Phone";
                }
            }

            // Смысловые переменные, отражающие основные параметры поиска
            Student student = new Student();
            student.FIO = this.fiof.Text == "" ? null : this.fiof.Text;
            student.Phone = this.phonef.Text == "+7(   )    -" ? null : this.phonef.Text;


            Parent parent = new Parent();
            if(chooseParent != null)
            {
                parentf.Text = chooseParent.ID + ". " + chooseParent.FIO;
                parent = Parents.ParentID(chooseParent.ID);
            }
            //       parent.ID = 0 /*this.parentf.Text*/;

            Contract contract = new Contract();
            if (chooseContract != null)
            {
                contractf.Text = chooseContract.ID + ". " + chooseContract.Date.ToString(formattotext);
                contract = Contracts.ContractID(chooseContract.ID);
            }

            Course course = new Course();
            if (chooseCourse != null)
            {
                coursef.Text = chooseCourse.ID + ". " + chooseCourse.nameGroup;
                course = Courses.CourseID(chooseCourse.ID);
            }

            List<Student> c = new List<Student>();
            c = Students.FindAll(deldate, parent, student, contract, course, sort, asсdesс, page, count, ref countrecord);

            // Формирование количества страниц
            pagef.Items.Clear();
            pages = Convert.ToInt32(Math.Ceiling((double)countrecord / count));
            for(int p=1; p<=pages; p++)
            {
                // добавляем один элемент
                pagef.Items.Add(p);
            }
            this.pagef.SelectedItem = page; // Выбираем текущую страницу поиска
                                            //           this.pagef.SelectedItem = 1; // Выбираем текущую страницу поиска


            // Заполнение грида данными
            for (int i = 0; i < c.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                D.Rows.Add(row);

                D.Rows[i].Cells[0].Value = (page - 1) * count +i+1 + "✎";   // Отображение счетчика записей и значок редактирования

                D.Rows[i].Cells[1].Value = c[i].ID;

                D.Rows[i].Cells[2].Value = c[i].FIO;

                D.Rows[i].Cells[3].Value = c[i].Phone;

                if (purpose == "choose")
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

        private void ascf_Click(object sender, EventArgs e)
        {
            if(ascflag == true)
            {
                ascflag = false;
                ascf.Text = "▼";
                //         ascf.BackColor = Color.FromArgb(220, 220, 220);
            }
            else
            {
                ascflag = true;
                //ascf.Text = "ᐱ";
                ascf.Text = "▲";
                //          ascf.BackColor = Color.FromArgb(192, 192, 192);
            }
        }

        private void prev_Click(object sender, EventArgs e)
        {
            // Переключение страниц на предыдущую по средствам кнопки
            if (pageindex +1 > 1)
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

        private void pagef_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pagef.SelectedIndex = pageindex;
            //pageindex = pagef.FindStringExact(pagef.Text);
            //pagef.SelectedIndex = pageindex ;
            //pageindex = pagef.SelectedIndex;

            //FillGrid();
        }

        private void pagef_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Переключение страниц по средствам комбобокса
            pageindex = pagef.SelectedIndex;
            pagef.SelectedIndex = pagef.FindStringExact(pagef.Text);
            page = Convert.ToInt32(pagef.SelectedItem);


      //      pagef.SelectedItem = pagef.Text;
            //pageindex = pagef.FindStringExact(pagef.Text);
            ////      pagef.SelectedIndex = pagef.FindStringExact(Convert.ToString(e));
     //       pagef.SelectedIndex = pageindex;
            ////pageindex = pagef.SelectedIndex;
            FillGrid() ;
        }

        private void pagef_TextChanged(object sender, EventArgs e)
        {
            //pageindex = this.Sel
            ////pageindex = pagef.FindStringExact(pagef.Text);
            //pagef.SelectedIndex = pageindex;
            //pageindex = pagef.FindStringExact(pagef.Text);
            //pageindex = pagef.SelectedIndex;
            ////           pagef.SelectedText = e.ToString();
 //           FillGrid();
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
                            chooseSt = Students.StudentID(k);

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
                            const string message = "Вы уверены, что хотите удалить ученика?";
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
                // Редактирование
                if (e.ColumnIndex == 0)  
                {
                    if (e.RowIndex > -1)
                    {
                        if (D.RowCount - 1 >= e.RowIndex)
                        {
                            int l = e.RowIndex;
                            int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
                            Student_edit f = new Student_edit(Students.StudentID(k), false);
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
            Student_edit f = new Student_edit(true);  // Передаем true, так как это означает, что нам нужно отображать только неудаленные объекты
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
                Student_view f = new Student_view(Students.StudentID(k));
                DialogResult result = f.ShowDialog();
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
            parentf.Clear();
            chooseParent = null;
            contractf.Clear();
            chooseContract = null;
            coursef.Clear();
            chooseCourse = null;
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

        private void bpar_Click(object sender, EventArgs e)
        {
            Parent_find f = new Parent_find("choose", "bstud"); // Передем choose - это означает, что нужно добавить кнопку выбора родителя
            DialogResult result = f.ShowDialog();
            chooseParent = f.choosePar; // Передаем ссылку форме родителей на переменную в этой форме
            FillGrid();


            //Parent_find f = new Parent_find("choose");  // Передем choose - это означает, что нужно добавить кнопку выбора родителя 
            ////f.choosePar = this.chooseParent; // Передаем ссылку форме родителей на переменную в этой форме
            //f.Show();
            ////Parent_find f = new Parent_find("choose"); // Передем choose - это означает, что нужно добавить кнопку выбора родителя
            ////DialogResult result = f.ShowDialog();
            ////this.chooseParent = f.choosePar; // Передаем ссылку форме родителей на переменную в этой форме
        }
        private void bcon_Click(object sender, EventArgs e)
        {
            Contract_find f = new Contract_find("choose", "bstud"); // Передем choose - это означает, что нужно добавить кнопку выбора родителя
            DialogResult result = f.ShowDialog();
            chooseContract = f.chooseCon; // Передаем ссылку форме родителей на переменную в этой форме
            FillGrid();
        }

        private void bcour_Click(object sender, EventArgs e)
        {
            Course_find f = new Course_find("choose"); // Передем choose - это означает, что нужно добавить кнопку выбора 
            DialogResult result = f.ShowDialog();
            chooseCourse = f.chooseCour; // Передаем ссылку форме родителей на переменную в этой форме
            FillGrid();
        }

        private void Student_find_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
