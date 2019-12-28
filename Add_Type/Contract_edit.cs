using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Itenso.TimePeriod;

namespace Add_Type
{
    public partial class Contract_edit : Form
    {
        bool indicator; // Переменная отвечающая за распределение - или добавляется новый объект, или изменяется существующий
        int idforEdit; // ID для редактируемого объекта
        Boolean deldate = true; // true - неудален false - все!!!
        String sort = "ID";
        String asсdesс = "asc";
//        bool ascflag = true;
        int page = 1;
        int count = 100;
        Contract newcontract = new Contract(); // Глобальная перменная этой формы
        public static Student chooseStudent; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public static Course chooseCourse; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public Contract_edit()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public Contract_edit(bool deldate) // Конструктор для добавление нового объекта
        {
            InitializeComponent();
            this.KeyPreview = true;
            indicator = true;

            buildDG();
        }
        public Contract_edit(Contract contract, bool deldate) // Конструктор для редактирования объекта
        {
            InitializeComponent();
            this.KeyPreview = true;
            indicator = false;
            idforEdit = contract.ID;

            newcontract = contract;
            buildDG();
            //FillForm(contract);
            FillForm();
        }
        public Contract_edit(Course course, bool deldate) // Конструктор для добавления договора уже на заданный курс объекта
        {
            InitializeComponent();
            this.KeyPreview = true;
            indicator = true;

            bcour.Enabled = false;
            buildDG();
            courset.Text = course.ID + ". " + Courses.CourseID(course.ID).nameGroup;
            costt.Text = Types.TypeID(course.TypeID).Cost.ToString(); // Подстановка стоимости из типа курса
        }
        public Contract_edit(Student student, bool deldate) // Конструктор для добавления договора уже для заданного ученика
        {
            InitializeComponent();
            this.KeyPreview = true;
            indicator = true;

            bstud.Enabled = false;
            buildDG();
            studentt.Text = student.ID + ". " + Students.StudentID(student.ID).FIO;
        }
        private void LoadAll()
        {

 //           buildDG();
 ////           FillForm(contract);
        }
        private void buildDG() //Построение комбобоксов, гридов 
        {
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
            if (Convert.ToInt32(Singleton.getPerson().BranchID) != 0 | Singleton.getPerson().BranchID != null) // выбор филиала. если у авторизированного менеджера есть филиал
            {
              if(  Branches.BranchID(Convert.ToInt32(Singleton.getPerson().BranchID)) != null ) // Вот с этой строкой работает . но почему не работает предыдущее условие 
                {
                    this.branchf.SelectedItem = Singleton.getPerson().BranchID + ". " + Branches.BranchID(Convert.ToInt32(Singleton.getPerson().BranchID)).Name;
                }
                
            }
        }
        private void FillForm()
        {
            this.Text = this.Text + newcontract.ID;
            datef.Value = newcontract.Date;
            studentt.Text = newcontract.StudentID + ". " + Students.StudentID(newcontract.StudentID).FIO;
            courset.Text = newcontract.CourseID + ". " + Courses.CourseID(newcontract.CourseID).nameGroup;
            costt.Text = newcontract.Cost.ToString();
            payt.Text = newcontract.PayofMonth.ToString();
            branchf.SelectedItem = newcontract.BranchID + ". " + Branches.BranchID(newcontract.BranchID).Name;
        }

        private void save_Click(object sender, EventArgs e)
        {
            string Answer = "";

            bool flag = Check(); // Вызовов функции проверки
            if (flag)
            {
                newcontract.Date = datef.Value;
                string[] branchID = (Convert.ToString(branchf.SelectedItem)).Split('.');
                newcontract.BranchID = Branches.BranchID(Convert.ToInt32(branchID[0])).ID;

                string[] studentID = (Convert.ToString(studentt.Text)).Split('.');
                newcontract.StudentID = Students.StudentID(Convert.ToInt32(studentID[0])).ID;

                string[] courseID = (Convert.ToString(courset.Text)).Split('.');
                newcontract.CourseID = Courses.CourseID(Convert.ToInt32(courseID[0])).ID;
                newcontract.Cost = Convert.ToDouble(costt.Text);
                newcontract.PayofMonth = Convert.ToDouble(payt.Text);
                newcontract.ManagerID = Singleton.getPerson().ID;

                if (indicator == true) // Значит, что происходит добавление нового
                {
                    Answer = newcontract.Add();
                }

                if (indicator == false) // Значит, что происходит редактирование
                {
                    Answer = newcontract.Edit();
                }
            }
            if (Answer == "Данные корректны!")
            {
                this.Close();
            }
            else
            {
                errorProvider1.SetError(save, Answer);
            }
        }

        public bool Check() // Проверка всех введеннных данных 
        {
            errorProvider1.Clear();
            if (studentt.Text == "Клиент не выбран")
            {
                errorProvider1.SetError(studentt, "Выберите ученика. Это поле не может быть пустым.");
                return false;
            }
            if (courset.Text == "Курс не выбран")
            {
                errorProvider1.SetError(courset, "Выберите курс. Это поле не может быть пустым.");
                return false;
            }
            if (costt.Text == "")
            {
                errorProvider1.SetError(costt, "Введите стоимость обучения на курсе. Это поле не может быть пустым.");
                return false;
            }
            if (payt.Text == "")
            {
                errorProvider1.SetError(payt, "Введите оплату на месяц обучения. Это поле не может быть пустым.");
                return false;
            }
            if (branchf.SelectedIndex == 0)
            {
                errorProvider1.SetError(branchf, "Выберите филиал. Это поле не может быть не определено.");
                return false;
            }
            return true;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bstud_Click(object sender, EventArgs e)
        {
            Student_find f = new Student_find("choose", "bcon"); // Передем choose - это означает, что нужно добавить кнопку выбора родителя
            DialogResult result = f.ShowDialog();
            if(f.chooseSt != null) // Для того чтобы заполнить текстовое поле на форме, нужно убедиться, что ученик выбран, если не выюран, то изменений на форме не происходит
            {
                chooseStudent = f.chooseSt; // Передаем ссылку форме родителей на переменную в этой форме
                studentt.Text = chooseStudent.ID + ". " + Students.StudentID(chooseStudent.ID).FIO;
            }
            //FillForm();
        }

        private void bcour_Click(object sender, EventArgs e)
        {
            Course_find f = new Course_find("choose"); // Передем choose - это означает, что нужно добавить кнопку выбора 
            DialogResult result = f.ShowDialog();
            if (f.chooseCour != null) // Для того чтобы заполнить текстовое поле на форме, нужно убедиться, что ученик выбран, если не выюран, то изменений на форме не происходит
            {
                chooseCourse = f.chooseCour; // Передаем ссылку форме родителей на переменную в этой форме
                courset.Text = chooseCourse.ID + ". " + Courses.CourseID(chooseCourse.ID).nameGroup;
                //if(costt.Text == "") // Подстановка стоимости из типа курса, если это поле пустое
                {
                    //                 costt.Text = Types.TypeID(chooseCourse.TypeID).Cost.ToString();

                    costt.Text = chooseCourse.Cost.ToString();
                }
                //if (payt.Text == "") // Подстановка оплаты за месяц из типа курса, если это поле пустое
                {
                  //  int i = (Convert.ToDateTime(chooseCourse.End) - Convert.ToDateTime(chooseCourse.Start)).
                    int i = Math.Abs((Convert.ToDateTime(chooseCourse.End).Month - Convert.ToDateTime(chooseCourse.Start).Month) + 12 * (Convert.ToDateTime(chooseCourse.End).Year - Convert.ToDateTime(chooseCourse.Start).Year));
                    TimeRange Range = new TimeRange(Convert.ToDateTime(chooseCourse.Start), Convert.ToDateTime(chooseCourse.End));
                    payt.Text = Convert.ToString(Convert.ToInt32(costt.Text)/i);
                }
             //            (datetime2 - datetime1).TotalMonth;
            }
            //FillGrid();
        }

        private void Contract_edit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void opentemlate_Click(object sender, EventArgs e)
        {
            if( chooseCourse != null)
            {
                string answer = Types.TypeID(chooseCourse.TypeID).openTemplate();
                if (answer != "Успешно")
                {
                    MessageBox.Show(answer);
                }
            }
            else
            {
                if (courset.Text == "Курс не выбран")
                {
                    MessageBox.Show("Для начала вам нужно выбрать курс. Выберите курс и попробуйте заново.");
                }
                else
                {
                    MessageBox.Show("Шаблон для этого курса не выбран. Его можно выбрать на форме просмотра типа курса.");
                }
            }  
        }
    }
}
