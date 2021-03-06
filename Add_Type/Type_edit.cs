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
    public partial class Type_edit : Form
    {
        bool indicator; // Переменная отвечающая за распределение - или добавляется новый объект, или изменяется существующий
        int idforEdit; // ID для редактируемого объекта

        Type newtype = new Type(); // Глобальная перменная этой формы
        public Type_edit()
        {
            InitializeComponent();
        }
        public Type_edit(bool deldate) // Конструктор для добавление нового объекта
        {
            InitializeComponent();
            this.KeyPreview = true;
            namet.Select(); // Установка курсора
            indicator = true;
        }
        public Type_edit(Type type, bool deldate) // Конструктор для редактирования объекта
        {
            InitializeComponent();
            this.KeyPreview = true;
            namet.Select(); // Установка курсора
            indicator = false;
            idforEdit = type.ID;

            newtype = type;
            this.Text = this.Text + newtype.ID;

            FillForm();
        }
        private void FillForm()
        {
            namet.Text = newtype.Name;
            montht.Text = newtype.Month.ToString();
            lessont.Text = newtype.Lessons.ToString();
            costt.Text = newtype.Cost.ToString();
            notet.Text = newtype.Note;
        }

        private void save_Click(object sender, EventArgs e)
        {
            string Answer = "";
            bool flag = Check(); // Вызовов функции проверки
            if (flag)
            {
                newtype.Name = namet.Text;
                newtype.Cost = Convert.ToDouble(costt.Text);
                newtype.Month = Convert.ToInt32(montht.Text);
                newtype.Lessons = Convert.ToInt32(lessont.Text);
                newtype.Note = notet.Text;

                if (indicator == true) // Значит, что происходит добавление нового
                {
                    Answer = newtype.Add();
                }

                if (indicator == false) // Значит, что происходит редактирование
                {
                    Answer = newtype.Edit();
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
                errorProvider1.SetError(namet, "Введите название типа курса. Это поле не может быть пустым.");
                return false;
            }
            if (costt.Text == "")
            {
                errorProvider1.SetError(costt, "Введите стоимость обучения по этому типу курса. Это поле не может быть пустым.");
                return false;
            }
            if (lessont.Value <= 0)
            {
                errorProvider1.SetError(lessont, "Введите количество занятий по этому типу курса. Это поле не может быть пустым.");
                return false;
            }
            if (montht.Value <= 0)
            {
                errorProvider1.SetError(montht, "Введите количество месяцев обучения по этому типу курса. Это поле не может быть пустым.");
                return false;
            }
            return true;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Type_edit_KeyDown(object sender, KeyEventArgs e)
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

        private void costt_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void lessont_ValueChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void montht_ValueChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
