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
    public partial class Course_view : Form
    {
        public Course course;   // Глобальная переменная объявляет объект данной формы
        public Course_view()
        {
            InitializeComponent();
        }
        public Course_view(Course st) // Конструктор для просмотра объекта
        {
            InitializeComponent();

            course = st;

            FillForm();
            buildDG();
            FillGrid();
        }
    }
}
