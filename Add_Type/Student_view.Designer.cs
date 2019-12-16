namespace Add_Type
{
    partial class Student_view
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
            this.timetable = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addcontract = new System.Windows.Forms.Button();
            this.gridcontract = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gridcourse = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chooseparent = new System.Windows.Forms.Button();
            this.gridparent = new System.Windows.Forms.DataGridView();
            this.addparent = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fiot = new System.Windows.Forms.Label();
            this.phonet = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.debtt = new System.Windows.Forms.Label();
            this.payAll = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontract)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcourse)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridparent)).BeginInit();
            this.SuspendLayout();
            // 
            // timetable
            // 
            this.timetable.Location = new System.Drawing.Point(608, 66);
            this.timetable.Name = "timetable";
            this.timetable.Size = new System.Drawing.Size(197, 51);
            this.timetable.TabIndex = 21;
            this.timetable.Text = "Посмотреть расписание";
            this.timetable.UseVisualStyleBackColor = true;
            this.timetable.Click += new System.EventHandler(this.timetable_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(17, 107);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 380);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addcontract);
            this.tabPage1.Controls.Add(this.gridcontract);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(784, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Договоры";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // addcontract
            // 
            this.addcontract.Location = new System.Drawing.Point(6, 6);
            this.addcontract.Name = "addcontract";
            this.addcontract.Size = new System.Drawing.Size(146, 44);
            this.addcontract.TabIndex = 14;
            this.addcontract.Text = "Создать договор";
            this.addcontract.UseVisualStyleBackColor = true;
            this.addcontract.Click += new System.EventHandler(this.addcontract_Click);
            // 
            // gridcontract
            // 
            this.gridcontract.AllowUserToAddRows = false;
            this.gridcontract.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridcontract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridcontract.Location = new System.Drawing.Point(6, 56);
            this.gridcontract.Name = "gridcontract";
            this.gridcontract.RowTemplate.Height = 24;
            this.gridcontract.Size = new System.Drawing.Size(772, 289);
            this.gridcontract.TabIndex = 0;
            this.gridcontract.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridcontract_CellContentClick);
            this.gridcontract.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridcontract_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.gridcourse);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(784, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Курсы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(123, 21);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Завершенные";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // gridcourse
            // 
            this.gridcourse.AllowUserToAddRows = false;
            this.gridcourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridcourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridcourse.Location = new System.Drawing.Point(6, 39);
            this.gridcourse.Name = "gridcourse";
            this.gridcourse.RowTemplate.Height = 24;
            this.gridcourse.Size = new System.Drawing.Size(772, 306);
            this.gridcourse.TabIndex = 0;
            this.gridcourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridcourse_CellContentClick);
            this.gridcourse.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridcourse_CellDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chooseparent);
            this.tabPage3.Controls.Add(this.gridparent);
            this.tabPage3.Controls.Add(this.addparent);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(784, 351);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ответственные лица";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chooseparent
            // 
            this.chooseparent.Location = new System.Drawing.Point(223, 3);
            this.chooseparent.Name = "chooseparent";
            this.chooseparent.Size = new System.Drawing.Size(195, 26);
            this.chooseparent.TabIndex = 24;
            this.chooseparent.Text = "Выбрать ответственного";
            this.chooseparent.UseVisualStyleBackColor = true;
            this.chooseparent.Click += new System.EventHandler(this.chooseparent_Click);
            // 
            // gridparent
            // 
            this.gridparent.AllowUserToAddRows = false;
            this.gridparent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridparent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridparent.Location = new System.Drawing.Point(4, 35);
            this.gridparent.Name = "gridparent";
            this.gridparent.RowTemplate.Height = 24;
            this.gridparent.Size = new System.Drawing.Size(776, 313);
            this.gridparent.TabIndex = 1;
            this.gridparent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridparent_CellContentClick);
            this.gridparent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridparent_CellDoubleClick);
            // 
            // addparent
            // 
            this.addparent.Location = new System.Drawing.Point(4, 3);
            this.addparent.Name = "addparent";
            this.addparent.Size = new System.Drawing.Size(195, 26);
            this.addparent.TabIndex = 12;
            this.addparent.Text = "Добавить ответственного";
            this.addparent.UseVisualStyleBackColor = true;
            this.addparent.Click += new System.EventHandler(this.addparent_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(340, 520);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(126, 42);
            this.close.TabIndex = 19;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Номер телефона";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "ФИО ученика";
            // 
            // fiot
            // 
            this.fiot.AutoSize = true;
            this.fiot.Location = new System.Drawing.Point(145, 24);
            this.fiot.Name = "fiot";
            this.fiot.Size = new System.Drawing.Size(46, 17);
            this.fiot.TabIndex = 22;
            this.fiot.Text = "label3";
            // 
            // phonet
            // 
            this.phonet.AutoSize = true;
            this.phonet.Location = new System.Drawing.Point(639, 24);
            this.phonet.Name = "phonet";
            this.phonet.Size = new System.Drawing.Size(46, 17);
            this.phonet.TabIndex = 23;
            this.phonet.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Задолженность";
            // 
            // debtt
            // 
            this.debtt.AutoSize = true;
            this.debtt.Location = new System.Drawing.Point(148, 65);
            this.debtt.Name = "debtt";
            this.debtt.Size = new System.Drawing.Size(46, 17);
            this.debtt.TabIndex = 25;
            this.debtt.Text = "label6";
            // 
            // payAll
            // 
            this.payAll.Location = new System.Drawing.Point(278, 60);
            this.payAll.Name = "payAll";
            this.payAll.Size = new System.Drawing.Size(114, 29);
            this.payAll.TabIndex = 26;
            this.payAll.Text = "Оплатить все";
            this.payAll.UseVisualStyleBackColor = true;
            this.payAll.Click += new System.EventHandler(this.payAll_Click);
            // 
            // Student_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 573);
            this.Controls.Add(this.payAll);
            this.Controls.Add(this.debtt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phonet);
            this.Controls.Add(this.fiot);
            this.Controls.Add(this.timetable);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Student_view";
            this.Text = "Ученик №";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridcontract)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcourse)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridparent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button timetable;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button addcontract;
        private System.Windows.Forms.DataGridView gridcontract;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView gridcourse;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView gridparent;
        private System.Windows.Forms.Button addparent;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fiot;
        private System.Windows.Forms.Label phonet;
        private System.Windows.Forms.Button chooseparent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label debtt;
        private System.Windows.Forms.Button payAll;
    }
}