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
    public partial class Theme_view : Form
    {
        bool indicator; // Переменная отвечающая за распределение - или добавляется новый объект, или изменяется существующий
        int idforEdit; // ID для редактируемого объекта
        Theme newtheme = new Theme(); // Глобальная перменная этой формы
        public static Timetable chooseTimetable; // Эта переменная для приема значения из вызываемой(дочерней) формы
        public Theme_view(Theme theme)
        {
            InitializeComponent();
            this.KeyPreview = true;
            indicator = false;
            idforEdit = theme.ID;

            newtheme = theme;
            this.Text = this.Text + newtheme.ID;

            FillForm();
        }

        public Theme_view(Theme theme, Timetable timetable)
        {
            InitializeComponent();
            this.KeyPreview = true;
            indicator = false;
            idforEdit = theme.ID;

            newtheme = theme;
            this.Text = this.Text + newtheme.ID;

            if (newtheme.Deadline != null)
            {
                deadlinedatet.Text = "Предположительная дата \r сдачи дз: " + timetable.Startlesson.AddDays(Convert.ToInt32(newtheme.Deadline)).ToLongDateString().ToString();
            }

            FillForm();
        }

        private void FillForm()
        {
            namet.Text = newtheme.Tema;
            homeworkt.Text = newtheme.Homework;
            if (newtheme.Deadline != null)
            {
                deadlinet.Text = newtheme.Deadline.ToString();
            }
            else
            {
                deadlinet.Text = "Срок сдачи домашней работы не установлен";
            }
            teachert.Text = newtheme.TeacherID + ". " + Workers.WorkerID(newtheme.TeacherID).FIO;
        }

        private void teachert_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Открытие формы для просмотра данных
            Worker_view f = new Worker_view(Workers.WorkerID(newtheme.TeacherID));
            DialogResult result = f.ShowDialog();
            FillForm();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Theme_view_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void addtimetable_Click(object sender, EventArgs e)
        {
            Timetable_find f = new Timetable_find("choose"); // Передем choose - это означает, что нужно добавить кнопку выбора 
            DialogResult result = f.ShowDialog();
            chooseTimetable = f.chooseTime; // Передаем ссылку форме родителей на переменную в этой форме
            if (chooseTimetable != null)
            {
                String ans = chooseTimetable.addTheme(newtheme);
                MessageBox.Show("Тема успешно добавлена на занятие, посмотреть темы занятия можно через просмотр занятия.");
            }
            FillForm();
        }
    }
}
