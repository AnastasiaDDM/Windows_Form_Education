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
        public static Worker chooseTeacher; // Эта переменная для приема значения из вызываемой(дочерней) формы
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
            this.Text = this.Text + newtheme.ID;
            namet.Text = newtheme.Tema;
            homeworkt.Text = newtheme.Homework;
            if(newtheme.Deadline != null)
            {
                deadlinet.Value = Convert.ToDateTime(newtheme.Deadline);
            }
            else
            {
                datenull.Text = "Срок сдачи домашней работы не установлен";
            }
            teacherf.Text = newtheme.TeacherID + ". " + Workers.WorkerID(newtheme.TeacherID).FIO;
        }

        private void save_Click(object sender, EventArgs e)
        {
            string Answer = "";

            if (indicator == true) // Значит, что происходит добавление нового
            {
                newtheme.Tema = namet.Text;
                newtheme.Homework = homeworkt.Text;
                newtheme.Deadline = deadlinet.Value;
                string[] teachID = (Convert.ToString(teacherf.Text)).Split('.');
                newtheme.TeacherID = Workers.WorkerID(Convert.ToInt32(teachID[0])).ID;

                Answer = newtheme.Add();
            }

            if (indicator == false) // Значит, что происходит редактирование
            {
                newtheme.Tema = namet.Text;
                newtheme.Homework = homeworkt.Text;
                newtheme.Deadline = deadlinet.Value;
                string[] teachID = (Convert.ToString(teacherf.Text)).Split('.');
                newtheme.TeacherID = Workers.WorkerID(Convert.ToInt32(teachID[0])).ID;

                Answer = newtheme.Edit();
            }

            if (Answer == "Данные корректны!")
            {
                this.Close();
            }
        }

        private void bteach_Click(object sender, EventArgs e)
        {
            Worker_find f = new Worker_find("choose", 3); // Передем choose - это означает, что нужно добавить кнопку выбора родителя
            DialogResult result = f.ShowDialog();
            chooseTeacher = f.chooseWor; // Передаем ссылку форме родителей на переменную в этой форме
            if (chooseTeacher != null)
            {
                newtheme.TeacherID = chooseTeacher.ID;
            }
            FillForm();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Theme_edit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
