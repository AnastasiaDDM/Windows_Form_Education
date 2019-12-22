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
        public Theme_view(Theme theme)
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
    }
}
