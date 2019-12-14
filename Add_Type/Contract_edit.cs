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
        Contract newcontract = new Contract();
        public static Student chooseStudent; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public static Course chooseCourse; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public Contract_edit()
        {
            InitializeComponent();
        }
        public Contract_edit(bool deldate) // Конструктор для добавление нового объекта
        {
            InitializeComponent();
            indicator = true;

            buildDG();
        }
        public Contract_edit(Contract contract, bool deldate) // Конструктор для редактирования объекта
        {
            InitializeComponent();
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
            indicator = true;

            bcour.Enabled = false;
            buildDG();
            courset.Text = course.ID + ". " + Courses.CourseID(course.ID).nameGroup;
        }
        public Contract_edit(Student student, bool deldate) // Конструктор для добавления договора уже для заданного ученика
        {
            InitializeComponent();
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

            if (indicator == true) // Значит, что происходит добавление нового
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
                // еЩЕ нужно добавить менеджера!!!!!!!!!!!!!!!!!!!!1 от из формы авторизации!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                Answer = newcontract.Add();
            }

            if (indicator == false) // Значит, что происходит редактирование
            {
 //               newcontract = Contracts.ContractID(idforEdit);

                newcontract.Date = datef.Value;
                string[] branchID = (Convert.ToString(branchf.SelectedItem)).Split('.');
                newcontract.BranchID = Branches.BranchID(Convert.ToInt32(branchID[0])).ID;

                string[] studentID = (Convert.ToString(studentt.Text)).Split('.');
                newcontract.StudentID = Students.StudentID(Convert.ToInt32(studentID[0])).ID;

                string[] courseID = (Convert.ToString(courset.Text)).Split('.');
                newcontract.CourseID = Courses.CourseID(Convert.ToInt32(courseID[0])).ID;
                newcontract.Cost = Convert.ToDouble(costt.Text);
                newcontract.PayofMonth = Convert.ToDouble(payt.Text);
                // еЩЕ нужно добавить менеджера!!!!!!!!!!!!!!!!!!!! от из формы авторизации!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                Answer = newcontract.Edit();
            }

            label9.Text = Answer;
            if (Answer == "Данные корректны!")
            {
                this.Close();
            }
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
            }
            //FillGrid();
        }
    }
}
