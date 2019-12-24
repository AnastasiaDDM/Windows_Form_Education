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

            DataGridViewTextBoxColumn edit = new DataGridViewTextBoxColumn();
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


            // Построение грида тем
            gridtheme.Columns.Clear();
            gridtheme.Rows.Clear();

            DataGridViewTextBoxColumn edit1 = new DataGridViewTextBoxColumn();

            //DataGridViewTextBoxColumn date = new DataGridViewTextBoxColumn();
            //date.HeaderText = "Дата";
            DataGridViewTextBoxColumn st = new DataGridViewTextBoxColumn();
            st.HeaderText = "Тема";
            DataGridViewTextBoxColumn hw = new DataGridViewTextBoxColumn();
            hw.HeaderText = "Домашняя работа";
            //DataGridViewTextBoxColumn deadline = new DataGridViewTextBoxColumn();
            //deadline.HeaderText = "Срок сдачи дз";
            DataGridViewTextBoxColumn teach = new DataGridViewTextBoxColumn();
            teach.HeaderText = "Составитель";

            gridtheme.Columns.Add(edit1);
            //D.Columns.Add(date);
            gridtheme.Columns.Add(st);
            gridtheme.Columns.Add(hw);
            //gridtheme.Columns.Add(deadline);
            gridtheme.Columns.Add(teach);

            //if (purpose == "choose")
            //{
            //    DataGridViewButtonColumn choose = new DataGridViewButtonColumn();
            //    choose.HeaderText = "Выбрать";
            //    gridtheme.Columns.Add(choose);
            //}
            //else
            {
                DataGridViewButtonColumn remove1 = new DataGridViewButtonColumn();
                remove.HeaderText = "Удалить?";
                gridtheme.Columns.Add(remove1);
            }

            gridtheme.ReadOnly = true;
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

                D.Rows[i].Cells[0].Value = i + 1;   // Отображение счетчика записей и значок редактирования

                D.Rows[i].Cells[1].Value = teachers[i].ID;

                D.Rows[i].Cells[2].Value = teachers[i].FIO;

                D.Rows[i].Cells[3].Value = "Удалить";
            }

            gridtheme.Rows.Clear();
            List<int> themes = timetable.GetThemes();
            for (int i = 0; i < themes.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                gridtheme.Rows.Add(row);

                gridtheme.Rows[i].Cells[0].Value = i + 1;   // Отображение счетчика записей и значок редактирования

                gridtheme.Rows[i].Cells[1].Value = themes[i] + ". " + Themes.ThemeID(themes[i]).Tema; 

                gridtheme.Rows[i].Cells[2].Value = Themes.ThemeID(themes[i]).Homework;

                gridtheme.Rows[i].Cells[3].Value = Workers.WorkerID(Themes.ThemeID(themes[i]).TeacherID).FIO;

                gridtheme.Rows[i].Cells[4].Value = "Удалить";
            }
        }
        private void edit_Click(object sender, EventArgs e)
        {
            // Редактирование
            Timetable_edit f = new Timetable_edit(timetable, false);
            DialogResult result = f.ShowDialog();
            FillForm();
            FillGrid();
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

        private void Timetable_view_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btomark_Click(object sender, EventArgs e)
        {
            MarkandThemes f = new MarkandThemes(null, Courses.CourseID(timetable.CourseID), null, (Branches.BranchID(Cabinets.CabinetID(timetable.CabinetID).BranchID)).ID ); // Передаем 
            DialogResult result = f.ShowDialog();
            //          chooseStudent = f.chooseSt; // Передаем ссылку форме родителей на переменную в этой форме
            FillGrid();
        }

        private void D_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (e.RowIndex > -1)
                {
                    if (D.RowCount >1)
                    {
                        int l = e.RowIndex;
                        const string message = "Вы уверены, что хотите удалить этого преподавателя с этого занятия?";
                        const string caption = "Удаление";
                        var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (result == DialogResult.OK)
                        {
                            // Форма не закрывается
                            int k = Convert.ToInt32(D.Rows[l].Cells[1].Value);
                            D.Rows.Remove(D.Rows[l]);
                            Worker o = Workers.WorkerID(k);
                            String ans = timetable.delTeacher(o);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Эту строку нельзя удалить, так как на занятии должен быть хотя бы один преподаватель. Советуем выбрать другого преподаватлея, а потом уже удалить этого!");
                    }
                }
            }
        }
    }
}
