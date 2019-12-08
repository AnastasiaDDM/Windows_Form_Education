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
    public partial class Student_edit : Form
    {
        bool ind; // Переменная отвечающая за распределение - или добавляется новый объект, или изменяется существующий
        public Student_edit(bool deldate) // Конструктор для добавление нового объекта
        {
            InitializeComponent();
            ind = true;
            //see = q;
            //LoadAll(see);
            //addik();
        }
        public Student_edit()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string Answer = "";
            Student st = new Student();
            st.FIO = fio.Text;
            st.Phone = phone.Text;
            if (ind == true)
            {
                Answer = st.Add();
            }

            label3.Text = Answer;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
