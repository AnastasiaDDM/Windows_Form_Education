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
            namet.Select(); // Установка курсора
            indicator = true;
        }
        public Theme_edit(Theme theme, bool deldate) // Конструктор для редактирования объекта
        {
            InitializeComponent();
            this.KeyPreview = true;
            namet.Select(); // Установка курсора
            indicator = false;
            idforEdit = theme.ID;

            newtheme = theme;
            this.Text = this.Text + newtheme.ID;

            FillForm();
        }
        private void FillForm()
        {
            namet.Text = newtheme.Tema;
            homeworkt.Text = newtheme.Homework;
            if(newtheme.Deadline != null)
            {
                deadlinecountt.Value = Convert.ToInt32(newtheme.Deadline);
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
                bool flag = Check(); // Вызовов функции проверки
                if (flag)
                {
                    newtheme.Tema = namet.Text;
                    newtheme.Homework = homeworkt.Text;
                    newtheme.Deadline = Convert.ToInt32(deadlinecountt.Value);
                    string[] teachID = (Convert.ToString(teacherf.Text)).Split('.');
                    newtheme.TeacherID = Workers.WorkerID(Convert.ToInt32(teachID[0])).ID;

                    Answer = newtheme.Add();
                }
            }

            if (indicator == false) // Значит, что происходит редактирование
            {
                bool flag = Check(); // Вызовов функции проверки
                if (flag)
                {
                    newtheme.Tema = namet.Text;
                    newtheme.Homework = homeworkt.Text;
                    newtheme.Deadline = Convert.ToInt32(deadlinecountt.Value);
                    string[] teachID = (Convert.ToString(teacherf.Text)).Split('.');
                    newtheme.TeacherID = Workers.WorkerID(Convert.ToInt32(teachID[0])).ID;

                    Answer = newtheme.Edit();
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
            if (namet.Text == "")
            {
                errorProvider1.SetError(namet, "Введите название темы. Это поле не может быть пустым.");
                return false;
            }
            if (teacherf.Text == "")
            {
                errorProvider1.SetError(label2, "Выберите преподавателя-составителя. Это поле не может быть пустым.");
                return false;
            }

            return true;
        }

        private void bteach_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Worker_find f = new Worker_find("choose", 3); // Передем choose - это означает, что нужно добавить кнопку выбора родителя
            DialogResult result = f.ShowDialog();
            chooseTeacher = f.chooseWor; // Передаем ссылку форме родителей на переменную в этой форме
            if (chooseTeacher != null)
            {
                newtheme.TeacherID = chooseTeacher.ID;
                teacherf.Text = newtheme.TeacherID + ". " + Workers.WorkerID(newtheme.TeacherID).FIO;
            }
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

        private void namet_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
