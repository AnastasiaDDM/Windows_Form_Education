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
            this.Text = this.Text + type.ID;

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

        private void Type_view_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void createtemplate_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    string filename = openFileDialog.FileName;
            //    //label11.Text = filename;
            //    ////Сохранение файла в указанную директорию
            //    //using (FileStream fileStream = new FileStream(@"Ссылка на папку", FileMode.Create, FileAccess.Write))
            //    //{
            //    //    byte[] bytes = File.ReadAllBytes(filename);
            //    //    fileStream.Write(bytes, 0, bytes.Length);
            //    //}
            //}





            string a = type.createTemplate();
            MessageBox.Show(a);
            //////string newLocation = " ";
            //////string folderLocation = "..\\..\\..\\Templates";
            //////var OFD = new System.Windows.Forms.OpenFileDialog();
            //////if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //////{
            //////    string fileToCopy = OFD.FileName;
            //////    if (System.IO.File.Exists(fileToCopy))
            //////    {
            //////        var onlyFileName = System.IO.Path.GetFileName(OFD.FileName);
            //////        newLocation = folderLocation + "\\" + onlyFileName;
            //////        System.IO.File.Copy(fileToCopy, newLocation, true);

            //////        // Добавление этого адреса шаблона в  тип курса
            //////        type.pathTemplate = newLocation;
            //////        type.Edit();
            //////        MessageBox.Show("Файл успешно скопирован");
            //////    }
            //////    else
            //////    {
            //////        MessageBox.Show("Файл не найден");
            //////    }
            //////}
            //////else
            //////{
            //////    MessageBox.Show("Путь к папке сохранения не найден");
            //////}
        }

        private void opentemlate_Click(object sender, EventArgs e)
        {
            string answer = type.openTemplate();
            if(answer != "Успешно")
            {
                MessageBox.Show(answer);
            }
        }
    }
}
