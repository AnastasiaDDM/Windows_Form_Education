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
    public partial class Statistic : Form
    {
        int[] yCount;
        double[] yRevenue;
        double[] yProfit;
        String[] x;
        
        public Statistic()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        public Statistic(string type)
        {
            InitializeComponent();
            this.KeyPreview = true;
            if (type == "count")
            {
                tabControl1.SelectedIndex = 2;
            }
            if (type == "revenue")
            {
                tabControl1.SelectedIndex = 0;
            }
            if (type == "profit")
            {
                tabControl1.SelectedIndex = 1;
            }
        }

        private void Statistic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void build_Click(object sender, EventArgs e)
        {
            // Очищение старых данных
            chartRevenue.Series[0].Points.Clear();
            chartProfit.Series[0].Points.Clear();
            chartCount.Series[0].Points.Clear();
            chart1.Series[0].Points.Clear();


            DateTime min = from.Value.Date.AddDays(1);
            DateTime max = to.Value.Date.AddDays(1);
            int count = (max - min).Days + 1;

            if (Check())
            {
                // Подписи осей
                chartRevenue.ChartAreas[0].AxisX.Title = "Филиалы";
                chartRevenue.ChartAreas[0].AxisY.Title = "Выручка в рублях";
                ////'' повернуть значения подписи оси X на 90 гр
                //chartRevenue.ChartAreas[0].AxisX.LabelStyle.Angle = -10;


                chartProfit.ChartAreas[0].AxisX.Title = "Филиалы";
                chartProfit.ChartAreas[0].AxisY.Title = "Прибыль в рублях";

                chartCount.ChartAreas[0].AxisX.Title = "Филиалы";
                chartCount.ChartAreas[0].AxisY.Title = "Кол-во договоров";

                
                chartRevenue.ChartAreas[0].AxisY.Interval = 0.0; // Установление шага
                chartProfit.ChartAreas[0].AxisY.Interval = 0.0; // Установление шага
                chartCount.ChartAreas[0].AxisY.Interval = 1; // Установление шага

                Сonstruction(count, min, max);
            }
        }
        private void Сonstruction(int count, DateTime min, DateTime max)
        {
          
            // Получения списка филиалов
            Branch branch = new Branch();
            Worker director = new Worker();
            int countrecord = 0;

            List<Branch> branches = new List<Branch>();
            branches = Branches.FindAll(true, branch, director, "ID", "asc", 1, 100, ref countrecord);

            // Указание длины массивов
            x = new string[countrecord];
            yCount = new int[countrecord];
            yRevenue = new double[countrecord];
            yProfit = new double[countrecord];

            for (int i = 0; i < branches.Count; i++)
            {
                // Вычисляем значение X
                x[i] = branches[i].Name; // Для всех трех графиков
                //chart1.Series[0].Label = x[i].ToString(); //подпись значений Y сверху точек диаграммы
                // Вычисляем значение функций в точке X
                double profit;
                double revenue;
                // Вызов функции, которая считает все три показателя
                int countContracts = branches[i].Statistic(min, max, out profit, out revenue);
                yCount[i] = countContracts; // Для графика количества договоров
                yRevenue[i] = revenue;
                yProfit[i] = profit;

                // Добавление точек на график и подпись значений каждой точки
                chartRevenue.Series[0].Points.AddXY(x[i], yRevenue[i]);           //установка точек диаграммы
                chartRevenue.Series[0].Points[i].Label = yRevenue[i].ToString(); //подпись значений Y сверху точек диаграммы


                chartProfit.Series[0].Points.AddXY(x[i], yProfit[i]);           //установка точек диаграммы
                chartProfit.Series[0].Points[i].Label = yProfit[i].ToString(); //подпись значений Y сверху точек диаграммы

                chartCount.Series[0].Points.AddXY(x[i], yCount[i]);           //установка точек диаграммы
                chartCount.Series[0].Points[i].Label= yCount[i].ToString(); //подпись значений Y сверху точек диаграммы

                chart1.Series[0].Points.AddXY(x[i], yCount[i]);           //установка точек диаграммы
                chart1.Series[0].Points[i].Label = yCount[i].ToString();/*+ " " + x[i]*/; //подпись значений Y сверху точек диаграммы
            }
        } 
        private bool Check()
        {
            errorProvider1.Clear();
            TimeSpan interval = to.Value - from.Value;
            if (interval.Days < 0)
            {
                errorProvider1.SetError(from, "Введены неккоректные данные! Конечная дата  не может быть раньше начальной даты ");
                return false;
            }
            return true;
        }

        private void Statistic_Load(object sender, EventArgs e)
        {

        }
    }
}