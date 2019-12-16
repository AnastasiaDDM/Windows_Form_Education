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
    public partial class Type_view : Form
    {
        public Type type;   // Глобальная переменная объявляет объект данной формы
        public Type_view()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public Type_view(Type typ) // Конструктор для просмотра объекта
        {
            InitializeComponent();
            this.KeyPreview = true;

            type = typ;

            FillForm();
            //buildDG();
            //FillGrid();
        }
        private void buildDG() //Построение грида 
        {
            //D.Columns.Clear();
            //D.Rows.Clear();

            //DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            //DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            //id.HeaderText = "№";
            //DataGridViewTextBoxColumn st = new DataGridViewTextBoxColumn();
            //st.HeaderText = "Дата оплаты";
            //DataGridViewTextBoxColumn ph = new DataGridViewTextBoxColumn();
            //ph.HeaderText = "Оплата";
            //DataGridViewTextBoxColumn br = new DataGridViewTextBoxColumn();
            //br.HeaderText = "Филиал";
            //DataGridViewTextBoxColumn type = new DataGridViewTextBoxColumn();
            //type.HeaderText = "Способ оплаты";
            //DataGridViewTextBoxColumn pur = new DataGridViewTextBoxColumn();
            //pur.HeaderText = "Назначение";

            //D.Columns.Add(edit);
            //D.Columns.Add(id);
            //D.Columns.Add(st);
            //D.Columns.Add(ph);
            //D.Columns.Add(br);
            //D.Columns.Add(type);
            //D.Columns.Add(pur);


            //DataGridViewButtonColumn remove = new DataGridViewButtonColumn();
            //remove.HeaderText = "Удалить?";
            //D.Columns.Add(remove);
            //D.ReadOnly = true;
        }

        private void FillForm()
        {   // Заполнение формы известными данными о договоре
            this.Text = this.Text + type.ID;

            namet.Text = type.Name;
            montht.Text = type.Month.ToString();
            lessont.Text = type.Lessons.ToString();
            costt.Text = type.Cost.ToString();
            notet.Text = type.Note;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bcour_Click(object sender, EventArgs e)
        {
            Course_find f = new Course_find(type); // Передем тип курса
            DialogResult result = f.ShowDialog();
        }
    }
}
