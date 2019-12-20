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
    public partial class Theme_edit : Form
    {
        bool indicator; // Переменная отвечающая за распределение - или добавляется новый объект, или изменяется существующий
        int idforEdit; // ID для редактируемого объекта
        Boolean deldate = true; // true - неудален false - все!!!
        String sort = "ID";
        String asсdesс = "asc";
        //        bool ascflag = true;
        int page = 1;
        int count = 100;
        Theme newtheme = new Theme(); // Глобальная перменная этой формы
        public static Course chooseCourse; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public Theme_edit()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public Theme_edit(bool deldate) // Конструктор для добавление нового объекта
        {
            InitializeComponent();
            this.KeyPreview = true;
            indicator = true;
        }
        public Theme_edit(Theme theme, bool deldate) // Конструктор для редактирования объекта
        {
            InitializeComponent();
            this.KeyPreview = true;
            indicator = false;
            idforEdit = theme.ID;

            newtheme = theme;

            FillForm();
        }
        private void FillForm()
        {
            //this.Text = this.Text + newtheme.ID;
            //datef.Value = newtheme.Date;
            //studentt.Text = newcontract.StudentID + ". " + Students.StudentID(newcontract.StudentID).FIO;
            //coursef.Text = newtheme.CourseID + ". " + Courses.CourseID(newtheme.CourseID).nameGroup;
            //costt.Text = newcontract.Cost.ToString();
            //payt.Text = newcontract.PayofMonth.ToString();
            //branchf.SelectedItem = newcontract.BranchID + ". " + Branches.BranchID(newcontract.BranchID).Name;
        }
    }
}
