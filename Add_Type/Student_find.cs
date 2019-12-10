﻿using System;
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
        int count;
        int page;
        String sort;
        String asсdesс = "asc";
        bool ascflag = true;
        int pageindex;
        int pages;
        public static Parent chooseParent;


        public Student_find()
        {
            InitializeComponent();
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
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.HeaderText = "№ ученика";
            sortf.Items.Add("№ ученика");
            DataGridViewTextBoxColumn st = new DataGridViewTextBoxColumn();
            st.HeaderText = "ФИО ученика";
            sortf.Items.Add("ФИО ученика");
            DataGridViewTextBoxColumn ph = new DataGridViewTextBoxColumn();
            ph.HeaderText = "Телефон";
            sortf.Items.Add("Телефон");
            DataGridViewButtonColumn remove = new DataGridViewButtonColumn();
            remove.HeaderText = "Удалить?";
            //D.Columns.Add(nom);
            D.Columns.Add(id);
            D.Columns.Add(st);
            D.Columns.Add(ph);
            D.Columns.Add(remove);
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
             if(this.sortf.SelectedItem != null)
            {
                if(this.sortf.SelectedText == "№ ученика")
                {
                    sort = "ID";
                }
                if(this.sortf.SelectedText == "ФИО ученика")
                {
                    sort = "FIO";
                }
                else
                {
                    sort = "Phone";
                }
            }


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
            Course course = new Course();
       //                                  course.ID = 1;
            int countrecord = 0;

            List<Student> c = new List<Student>();
            c = Students.FindAll(deldate, parent, student, contract, course, sort, asсdesс, page, count, ref countrecord);
            pagef.Items.Clear();
            pages = Convert.ToInt32(Math.Ceiling((double)countrecord / count));
            for(int p=1; p<=pages; p++)
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

                    D.Rows[i].Cells[3].Value = "Удалить";
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
                ascf.BackColor = Color.FromArgb(220, 220, 220);
            }
            else
            {
                ascflag = true;
                ascf.BackColor = Color.FromArgb(192, 192, 192);
            }
        }

        public void setParent(Parent o)
        {
            chooseParent = o;
        }


        private void bpar_Click(object sender, EventArgs e)
        {

            Parent_find f = new Parent_find("choose");  // Передем choose - это означает, что нужно добавить кнопку выбора родителя 
            //f.choosePar = this.chooseParent; // Передаем ссылку форме родителей на переменную в этой форме
            f.Show();
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
            if(pageindex +1 > 1)
            {
  //              pagef.SelectedIndex = pagef.FindStringExact(Convert.ToString(pageindex - 1));
                pagef.SelectedIndex = (pageindex - 1);
                pageindex = pagef.SelectedIndex;
                //           this.pagef.SelectedItem =
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
            //pageindex =pagef.SelectedIndex;
            //pagef.SelectedIndex = pagef.FindStringExact(pagef.Text);


      //      pagef.SelectedItem = pagef.Text;
            //pageindex = pagef.FindStringExact(pagef.Text);
            ////      pagef.SelectedIndex = pagef.FindStringExact(Convert.ToString(e));
     //       pagef.SelectedIndex = pageindex;
            ////pageindex = pagef.SelectedIndex;
//            FillGrid() ;
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

        private void D_CellClick(object sender, DataGridViewCellEventArgs e)  // Удаление
        {
            if (e.ColumnIndex == 3)
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
        }

        private void add_Click(object sender, EventArgs e)  // Добавление
        {
            Student_edit f = new Student_edit(true);  // Передаем true, так как это означает, что нам нужно отображать только неудаленные объекты
            f.Show();
        }

        private void D_CellDoubleClick(object sender, DataGridViewCellEventArgs e) // Редактирование
        {
            //if (e.RowIndex < orders.getOrd().Count)
            {
                int l = e.RowIndex;
                int k = Convert.ToInt32(D.Rows[l].Cells[0].Value);
                Student_edit f = new Student_edit(Students.StudentID(k), false);
                f.Show();
            }
        }

        private void Student_find_Activated(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void reset_Click(object sender, EventArgs e)
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
