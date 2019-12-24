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
    public partial class Parent_edit : Form
    {
        bool indicator; // Переменная отвечающая за распределение - или добавляется новый объект, или изменяется существующий
        int idforEdit; // ID для редактируемого объекта
        public Parent newparent = new Parent();
        public Parent_edit(bool deldate) // Конструктор для добавление нового объекта
        {
            InitializeComponent();
            this.KeyPreview = true;
            indicator = true;
        }
        public Parent_edit(Parent parent, bool deldate) // Конструктор для редактирования объекта
        {
            InitializeComponent();
            this.KeyPreview = true;
            indicator = false;

            FillForm(parent);
        }
        public Parent_edit()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void FillForm(Parent s)
        {
            this.Text = this.Text + s.ID;
            idforEdit = s.ID;
            fiof.Text = s.FIO;
            phonef.Text = s.Phone;
        }

        private void save_Click(object sender, EventArgs e)
        {
            string Answer = "";

            if (indicator == true) // Значит, что происходит добавление нового
            {
                bool flag = Check(); // Вызовов функции проверки
                if (flag)
                {
                    newparent.FIO = fiof.Text;
                    newparent.Phone = phonef.Text;
                    Answer = newparent.Add();
                }
            }

            if (indicator == false) // Значит, что происходит редактирование
            { bool flag = Check(); // Вызовов функции проверки
                if (flag)
                {
                    newparent = Parents.ParentID(idforEdit);
                    newparent.FIO = fiof.Text;
                    newparent.Phone = phonef.Text;
                    Answer = newparent.Edit();
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
            if (fiof.Text == "")
            {
                errorProvider1.SetError(fiof, "Введите ФИО. Это поле не может быть пустым.");
                return false;
            }
            if (phonef.Text == "+7(   )    -")
            {
                errorProvider1.SetError(phonef, "Введите номер телефона. Это поле не может быть пустым.");
                return false;
            }
            return true;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Parent_edit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
