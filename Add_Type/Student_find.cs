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
        int count;
        int page;
        String sort;
        String asсdesс;
        bool ascflag = true;



    public Student_find()
        {
            InitializeComponent();
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

        private void add_Click(object sender, EventArgs e)
        {
            Student_edit f = new Student_edit(true);  // Передем true, так как это означает, что нам нужно отображать только неудаленные объекты
            f.Show();
        }

        private void buildDG() //Построение грида 
        {
            D.Columns.Clear();
            D.Rows.Clear();
            DataGridViewTextBoxColumn nom = new DataGridViewTextBoxColumn();
            nom.HeaderText = "№ ученика";
            DataGridViewTextBoxColumn st = new DataGridViewTextBoxColumn();
            st.HeaderText = "ФИО ученика";
            DataGridViewTextBoxColumn ph = new DataGridViewTextBoxColumn();
            ph.HeaderText = "Телефон";
            DataGridViewButtonColumn remove = new DataGridViewButtonColumn();
            remove.HeaderText = "Удалить?";
            D.Columns.Add(nom);
            D.Columns.Add(st);
            D.Columns.Add(ph);
            D.Columns.Add(remove);
            D.ReadOnly = true;
        }

        private void FillGrid() // Заполняем гриды
        {
            D.Rows.Clear();
            //            this.pagef.SelectedText = "1";
            this.pagef.SelectedItem = "1";
            this.countf.SelectedItem = "10";
            this.sortf.SelectedItem = "ID";
            asсdesс = "asc";
            //sort = "ID";
            //count = 10;
            //page = 1;
            deldate = this.deldatef.Checked; 
            // true - неудален false - все!!!
                                              //count = Convert.ToInt32(this.countf.SelectedItem);
                                              //page = Convert.ToInt32(this.pagef.SelectedItem);
                                              //sort = Convert.ToString(this.sortf.SelectedItem);
                                              //asсdesс = ascflag == true ? "asc" : "desc";


            count = this.countf.SelectedItem == null ? 10 : Convert.ToInt32(this.countf.SelectedItem);
            page = this.pagef.SelectedItem == null ? 1 : Convert.ToInt32(this.pagef.SelectedItem);
            sort = this.sortf.SelectedItem == null ? "ID" : Convert.ToString(this.sortf.SelectedItem);


            Student student = new Student();
            //student.FIO = this.fiof.Text;
            //student.Phone = this.phonef.Text;

            Parent parent = new Parent();
            parent.ID = 0 /*this.parentf.Text*/;


            Contract contract = new Contract();
            Course course = new Course();
            //                             course.ID = 1;
            int countrecord = 0;

            List<Student> c = new List<Student>();
            c = Students.FindAll(deldate, parent, student, contract, course, sort, asсdesс, page, count, ref countrecord);

            int pages = Convert.ToInt32(Math.Ceiling((double)countrecord / count));



            //foreach (var s in stud)
            //{
            //    Console.WriteLine("ID: {0} \t FIO: {1} \t Phone: {2} \t Deldate: {3} \t Editdate: {4}", s.ID, s.FIO, s.Phone, s.Deldate, s.Editdate);
            //}
            //Console.WriteLine(countrecord);

            {

                for (int i = 0; i < c.Count; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();

                    D.Rows.Add(row);

                    D.Rows[i].Cells[0].Value = c[i].ID;

                    D.Rows[i].Cells[1].Value = c[i].FIO;

                    D.Rows[i].Cells[2].Value = c[i].Phone;


                    //string workcar = "";
                    //for (int q = 0; q < c[i].driver.Count - 1; q++)
                    //{
                    //    workcar = workcar + Convert.ToString(c[i].driver[q].FIO + ", ");
                    //}
                    //workcar = workcar + Convert.ToString(c[i].driver[c[i].driver.Count - 1].FIO);

                    ////        foreach (Person c in workers.C)
                    //D.Rows[i].Cells[2].Value = workcar;

                    //string w = "";
                    //if (c[i].porter.Count > 0)
                    //{
                    //    for (int q = 0; q < c[i].porter.Count - 1; q++)
                    //    {
                    //        w = w + Convert.ToString(c[i].porter[q].FIO + ", ");
                    //    }
                    //    w = w + Convert.ToString(c[i].porter[c[i].porter.Count - 1].FIO);
                    //}

                    //D.Rows[i].Cells[3].Value = w;

                    //D.Rows[i].Cells[4].Value = c[i].type.typ;

                    //D.Rows[i].Cells[5].Value = c[i].date;

                    //D.Rows[i].Cells[6].Value = c[i].ot + " - " + c[i].doo;

                    //D.Rows[i].Cells[7].Value = c[i].note;

                    //string wa = "";
                    //for (int q = 0; q < c[i].dostav.Count - 1; q++)
                    //{
                    //    wa = wa + Convert.ToString(c[i].dostav[q] + ", ");
                    //}
                    //wa = wa + Convert.ToString(c[i].dostav[c[i].dostav.Count - 1]);

                    //D.Rows[i].Cells[8].Value = wa;
                    //string car = "";
                    //for (int q = 0; q < c[i].car.Count - 1; q++)
                    //{
                    //    car = car + Convert.ToString(c[i].car[q].ID + ". " + c[i].car[q].model + " - " + c[i].car[q].nomer + ", ");
                    //}
                    //car = car + Convert.ToString(c[i].car[c[i].car.Count - 1].ID + ". " + c[i].car[c[i].car.Count - 1].model + " - " + c[i].car[c[i].car.Count - 1].nomer);

                    //D.Rows[i].Cells[9].Value = car;
                    D.Rows[i].Cells[3].Value = "Удалить";
                }
            }
        }

        private void Student_find_Load(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void find_Click(object sender, EventArgs e)
        {
            D.Rows.Clear();
            //            this.pagef.SelectedText = "1";
            //this.pagef.SelectedItem = "1";
            //this.countf.SelectedItem = "10";
            //this.sortf.SelectedItem = "ID";
            //asсdesс = "asc";
            //sort = "ID";
            //count = 10;
            //page = 1;
            deldate = this.deldatef.Checked;  // true - неудален false - все!!!
            //count = Convert.ToInt32(this.countf.SelectedItem);
            //page = Convert.ToInt32(this.pagef.SelectedItem);
            //sort = Convert.ToString(this.sortf.SelectedItem);
            asсdesс = ascflag == true ? "asc" : "desc";


            count = this.countf.SelectedItem == null ? 10 : Convert.ToInt32(this.countf.SelectedItem);
            page = this.pagef.SelectedItem == null ? 10 : Convert.ToInt32(this.pagef.SelectedItem);
            sort = this.sortf.SelectedItem == null ? "ID" : Convert.ToString(this.sortf.SelectedItem);
            //count = this.countf.SelectedItem == null ? 10 : Convert.ToInt32(this.countf.SelectedItem);


            Student student = new Student();
            //student.FIO = this.fiof.Text;
            //student.Phone = this.phonef.Text;

            Parent parent = new Parent();
            parent.ID = 0 /*this.parentf.Text*/;


            Contract contract = new Contract();
            Course course = new Course();
            //                             course.ID = 1;
            int countrecord = 0;

            List<Student> c = new List<Student>();
            c = Students.FindAll(deldate, parent, student, contract, course, sort, asсdesс, page, count, ref countrecord);

            int pages = Convert.ToInt32(Math.Ceiling((double)countrecord / count));



            //foreach (var s in stud)
            //{
            //    Console.WriteLine("ID: {0} \t FIO: {1} \t Phone: {2} \t Deldate: {3} \t Editdate: {4}", s.ID, s.FIO, s.Phone, s.Deldate, s.Editdate);
            //}
            //Console.WriteLine(countrecord);

            {

                for (int i = 0; i < c.Count; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();

                    D.Rows.Add(row);

                    D.Rows[i].Cells[0].Value = c[i].ID;

                    D.Rows[i].Cells[1].Value = c[i].FIO;

                    D.Rows[i].Cells[2].Value = c[i].Phone;


                    //string workcar = "";
                    //for (int q = 0; q < c[i].driver.Count - 1; q++)
                    //{
                    //    workcar = workcar + Convert.ToString(c[i].driver[q].FIO + ", ");
                    //}
                    //workcar = workcar + Convert.ToString(c[i].driver[c[i].driver.Count - 1].FIO);

                    ////        foreach (Person c in workers.C)
                    //D.Rows[i].Cells[2].Value = workcar;

                    //string w = "";
                    //if (c[i].porter.Count > 0)
                    //{
                    //    for (int q = 0; q < c[i].porter.Count - 1; q++)
                    //    {
                    //        w = w + Convert.ToString(c[i].porter[q].FIO + ", ");
                    //    }
                    //    w = w + Convert.ToString(c[i].porter[c[i].porter.Count - 1].FIO);
                    //}

                    //D.Rows[i].Cells[3].Value = w;

                    //D.Rows[i].Cells[4].Value = c[i].type.typ;

                    //D.Rows[i].Cells[5].Value = c[i].date;

                    //D.Rows[i].Cells[6].Value = c[i].ot + " - " + c[i].doo;

                    //D.Rows[i].Cells[7].Value = c[i].note;

                    //string wa = "";
                    //for (int q = 0; q < c[i].dostav.Count - 1; q++)
                    //{
                    //    wa = wa + Convert.ToString(c[i].dostav[q] + ", ");
                    //}
                    //wa = wa + Convert.ToString(c[i].dostav[c[i].dostav.Count - 1]);

                    //D.Rows[i].Cells[8].Value = wa;
                    //string car = "";
                    //for (int q = 0; q < c[i].car.Count - 1; q++)
                    //{
                    //    car = car + Convert.ToString(c[i].car[q].ID + ". " + c[i].car[q].model + " - " + c[i].car[q].nomer + ", ");
                    //}
                    //car = car + Convert.ToString(c[i].car[c[i].car.Count - 1].ID + ". " + c[i].car[c[i].car.Count - 1].model + " - " + c[i].car[c[i].car.Count - 1].nomer);

                    //D.Rows[i].Cells[9].Value = car;
                    D.Rows[i].Cells[3].Value = "Удалить";
                }
            }
        }

        private void ascf_Click(object sender, EventArgs e)
        {
            if(ascflag == true)
            {
                ascflag = false;
            }
            else
            {
                ascflag = true;
            }

        }

        private void bpar_Click(object sender, EventArgs e)
        {
            Parent_find f = new Parent_find();  // Передем true, так как это означает, что нам нужно отображать только неудаленные объекты
            f.Show();
        }
    }
}
