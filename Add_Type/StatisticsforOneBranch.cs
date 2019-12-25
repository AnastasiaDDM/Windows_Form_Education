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
    public partial class StatisticsforOneBranch : Form
    {
        public StatisticsforOneBranch(Branch branch)
        {
            InitializeComponent();
            this.Text = this.Text + branch.ID + ". " + branch.Name;
            double profit;
            double revenue;
            // Вызов функции, которая считает все три показателя
            int countContracts = branch.Statistic(DateTime.MinValue, DateTime.MaxValue, out profit, out revenue);
            revenuet.Text = "Выручка " + revenue;
            profitt.Text = "Прибыль " + profit;
            countt.Text = "Количество договоров " + countContracts;
            Access(); 
        }
        private void Access() // Реализация разделения ролей
        {
            // Заперт на добавление и удаление одиннаковый
            statistic.Enabled = Prohibition.Banned("see_all_statistic");
        }

        private void statistic_Click(object sender, EventArgs e)
        {
            Statistic f = new Statistic("revenue");
            DialogResult result = f.ShowDialog();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void close_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
