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
    public partial class Type_edit : Form
    {
        bool indicator; // Переменная отвечающая за распределение - или добавляется новый объект, или изменяется существующий
        int idforEdit; // ID для редактируемого объекта
        Boolean deldate = true; // true - неудален false - все!!!
        String sort = "ID";
        String asсdesс = "asc";
        //        bool ascflag = true;
        int page = 1;
        int count = 100;
        Type newtype = new Type(); // Глобальная перменная этой формы
        public Type_edit()
        {
            InitializeComponent();
        }
        public Type_edit(bool deldate) // Конструктор для добавление нового объекта
        {
            InitializeComponent();
            this.KeyPreview = true;
            indicator = true;

            buildDG();
        }
        public Type_edit(Type type, bool deldate) // Конструктор для редактирования объекта
        {
            InitializeComponent();
            this.KeyPreview = true;
            indicator = false;
            idforEdit = type.ID;

            newtype = type;
            buildDG();
            //FillForm(contract);
            FillForm();
        }
        private void buildDG() //Построение комбобоксов, гридов 
        {
            //// Построение комбобокса филиалов
            //Branch branch = new Branch();
            //Worker director = new Worker();
            //int countrecord = 0;

            //List<Branch> branches = new List<Branch>();
            //branches = Branches.FindAll(deldate, branch, director, sort, asсdesс, page, count, ref countrecord);

            //branchf.Items.Add("Не выбрано");
            //foreach (var s in branches)
            //{
            //    // добавляем один элемент
            //    branchf.Items.Add(s.ID + ". " + s.Name);
            //}
            //this.branchf.SelectedIndex = 0;
        }
        private void FillForm()
        {
            this.Text = this.Text + newtype.ID;
            namet.Text = newtype.Name;
            montht.Text = newtype.Month.ToString();
            lessont.Text = newtype.Lessons.ToString();
            costt.Text = newtype.Cost.ToString();
            notet.Text = newtype.Note;
        }

        private void save_Click(object sender, EventArgs e)
        {
            string Answer = "";

            if (indicator == true) // Значит, что происходит добавление нового
            {
                newtype.Name = namet.Text;
                newtype.Cost = Convert.ToDouble(costt.Text);
                newtype.Month = Convert.ToInt32(montht.Text);
                newtype.Lessons = Convert.ToInt32(lessont.Text);
                newtype.Note = notet.Text;

                Answer = newtype.Add();
            }

            if (indicator == false) // Значит, что происходит редактирование
            {
                newtype.Name = namet.Text;
                newtype.Cost = Convert.ToDouble(costt.Text);
                newtype.Month = Convert.ToInt32(montht.Text);
                newtype.Lessons = Convert.ToInt32(lessont.Text);
                newtype.Note = notet.Text;

                Answer = newtype.Edit();
            }

            label7.Text = Answer;
            if (Answer == "Данные корректны!")
            {
                this.Close();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
