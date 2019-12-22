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
    public partial class Timetable_view : Form
    {
        public Timetable timetable;   // Глобальная переменная объявляет занятие данной формы
        string formattotext = "dd.MM.yyyy"; // Формат для отображения даты в текстовые поля
        string formathour = "HH:mm"; // Время без даты
        public Timetable_view()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public Timetable_view(Timetable st) // Конструктор для просмотра объекта
        {
            InitializeComponent();
            this.KeyPreview = true;

            timetable = st;

            FillForm();
            buildDG();
            FillGrid();
        }
        private void FillForm()
        {
            this.Text = this.Text + timetable.ID;
            cabinett.Text = timetable.CabinetID + ". " + Cabinets.CabinetID(timetable.CabinetID).Number;
            brancht.Text = Cabinets.CabinetID(timetable.CabinetID).BranchID + ". " + Branches.BranchID(Cabinets.CabinetID(timetable.CabinetID).BranchID).Name;
            courset.Text = timetable.CourseID + ". " + Courses.CourseID(timetable.CourseID).nameGroup;
            datet.Text = timetable.Startlesson.ToString(formattotext);
            timet.Text = timetable.Startlesson.ToString(formathour) + " - " + timetable.Endlesson.ToString(formathour);
        }

        private void buildDG() //Построение грида 
        {
            // Построение грида преподавателей
            D.Columns.Clear();
            D.Rows.Clear();

            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
            DataGridViewTextBoxColumn idt = new DataGridViewTextBoxColumn();
            idt.HeaderText = "№";
            DataGridViewTextBoxColumn fiot = new DataGridViewTextBoxColumn();
            fiot.HeaderText = "ФИО";
           
            D.Columns.Add(edit);
            D.Columns.Add(idt);
            D.Columns.Add(fiot);
            
            DataGridViewButtonColumn remove = new DataGridViewButtonColumn();
            remove.HeaderText = "Удалить?";
            D.Columns.Add(remove);
            D.ReadOnly = true;
        }

        private void FillGrid()
        {
            // Заполняем гриды, комбобоксы
            D.Rows.Clear();
            List<Worker> teachers = new List<Worker>();
            teachers = timetable.GetTeachers();
            for (int i = 0; i < teachers.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                D.Rows.Add(row);

                D.Rows[i].Cells[0].Value = i + 1 + "✎";   // Отображение счетчика записей и значок редактирования

                D.Rows[i].Cells[1].Value = teachers[i].ID;

                D.Rows[i].Cells[2].Value = teachers[i].FIO;

                D.Rows[i].Cells[3].Value = "Удалить";
            }
        }
        private void edit_Click(object sender, EventArgs e)
        {
            // Редактирование
            Timetable_edit f = new Timetable_edit(timetable, false);
            DialogResult result = f.ShowDialog();
            FillForm();
        }

        private void brancht_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Branch_view f = new Branch_view(Branches.BranchID(Cabinets.CabinetID(timetable.CabinetID).BranchID));
            DialogResult result = f.ShowDialog();
        }

        private void courset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Открытие формы для просмотра данных
            Course_view f = new Course_view(Courses.CourseID(timetable.CourseID));
            DialogResult result = f.ShowDialog();
            FillGrid();
        }

        private void cabinett_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Открытие формы для просмотра данных
            Cabinet_view f = new Cabinet_view(Cabinets.CabinetID(timetable.CabinetID));
            DialogResult result = f.ShowDialog();
            FillGrid();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
