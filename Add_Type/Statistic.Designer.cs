namespace Add_Type
{
    partial class Statistic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartProfit = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCount = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.to = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.build = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProfit)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1195, 644);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chartRevenue);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1187, 615);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Выручка филиалов";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chartRevenue
            // 
            chartArea5.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend5);
            this.chartRevenue.Location = new System.Drawing.Point(6, 6);
            this.chartRevenue.Name = "chartRevenue";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Выручка";
            this.chartRevenue.Series.Add(series5);
            this.chartRevenue.Size = new System.Drawing.Size(1175, 591);
            this.chartRevenue.TabIndex = 48;
            this.chartRevenue.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartProfit);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1187, 615);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Прибыль филиалов";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartProfit
            // 
            chartArea6.Name = "ChartArea1";
            this.chartProfit.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartProfit.Legends.Add(legend6);
            this.chartProfit.Location = new System.Drawing.Point(6, 7);
            this.chartProfit.Name = "chartProfit";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Прибыль";
            this.chartProfit.Series.Add(series6);
            this.chartProfit.Size = new System.Drawing.Size(1175, 602);
            this.chartProfit.TabIndex = 54;
            this.chartProfit.Text = "chart2";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chart1);
            this.tabPage3.Controls.Add(this.chartCount);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1187, 615);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Количество договоров";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(807, 300);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(377, 312);
            this.chart1.TabIndex = 55;
            this.chart1.Text = "chart1";
            // 
            // chartCount
            // 
            chartArea8.Name = "ChartArea1";
            this.chartCount.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartCount.Legends.Add(legend8);
            this.chartCount.Location = new System.Drawing.Point(3, 3);
            this.chartCount.Name = "chartCount";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Количество договоров";
            this.chartCount.Series.Add(series8);
            this.chartCount.Size = new System.Drawing.Size(1008, 609);
            this.chartCount.TabIndex = 54;
            this.chartCount.Text = "chart3";
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(607, 681);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(165, 22);
            this.to.TabIndex = 58;
            this.to.ValueChanged += new System.EventHandler(this.to_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(531, 683);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 17);
            this.label13.TabIndex = 56;
            this.label13.Text = "Дата до:";
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(308, 680);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(172, 22);
            this.from.TabIndex = 57;
            this.from.ValueChanged += new System.EventHandler(this.from_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(233, 683);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 17);
            this.label12.TabIndex = 55;
            this.label12.Text = "Дата от:";
            // 
            // build
            // 
            this.build.Location = new System.Drawing.Point(981, 673);
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(106, 40);
            this.build.TabIndex = 54;
            this.build.Text = "Построить";
            this.build.UseVisualStyleBackColor = true;
            this.build.Click += new System.EventHandler(this.build_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 724);
            this.Controls.Add(this.to);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.from);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.build);
            this.Controls.Add(this.tabControl1);
            this.Name = "Statistic";
            this.Text = "Статистические данные";
            this.Load += new System.EventHandler(this.Statistic_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Statistic_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartProfit)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProfit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCount;
        private System.Windows.Forms.DateTimePicker to;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker from;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button build;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}