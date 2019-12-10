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
        int idforEdit;
        public Parent newparent = new Parent();
        public Parent_edit(bool deldate) // Конструктор для добавление нового объекта
        {
            InitializeComponent();
            indicator = true;
        }
        public Parent_edit(Parent parent, bool deldate) // Конструктор для редактирования объекта
        {
            InitializeComponent();
            indicator = false;

            FillForm(parent);
        }
        public Parent_edit()
        {
            InitializeComponent();
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
                newparent.FIO = fiof.Text;
                newparent.Phone = phonef.Text;
                Answer = newparent.Add();
            }

            if (indicator == false) // Значит, что происходит редактирование
            {
                newparent = Parents.ParentID(idforEdit);

                newparent.FIO = fiof.Text;
                newparent.Phone = phonef.Text;
                Answer = newparent.Edit();
            }

            label1.Text = Answer;
            if (Answer == "Данные корректны!")
            {
                this.Close();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
