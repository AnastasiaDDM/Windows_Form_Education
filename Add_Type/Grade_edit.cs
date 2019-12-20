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
    public partial class Grade_edit : Form
    {
        bool indicator; // Переменная отвечающая за распределение - или добавляется новый объект, или изменяется существующий
        int idforEdit; // ID для редактируемого объекта
        Grade newgrade = new Grade(); // Глобальная перменная этой формы
        public Grade_edit()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public Grade_edit(bool deldate) // Конструктор для добавление нового объекта
        {
            InitializeComponent();
            this.KeyPreview = true;
            indicator = true;

            //buildDG();
        }
        public Grade_edit(Grade grade, bool deldate) // Конструктор для редактирования объекта
        {
            InitializeComponent();
            this.KeyPreview = true;
            indicator = false;
            idforEdit = grade.ID;

            newgrade = grade;
            //buildDG();
            //FillForm();
        }
    }
}
