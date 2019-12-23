namespace Add_Type
{
    partial class Course_view
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
            this.gridteacher = new System.Windows.Forms.DataGridView();
            this.addteacher = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.addstudent = new System.Windows.Forms.Button();
            this.gridstudent = new System.Windows.Forms.DataGridView();
            this.close = new System.Windows.Forms.Button();
            this.dateto = new System.Windows.Forms.DateTimePicker();
            this.datefrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.namet = new System.Windows.Forms.Label();
            this.costt = new System.Windows.Forms.Label();
            this.typet = new System.Windows.Forms.LinkLabel();
            this.brancht = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridteacher)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridstudent)).BeginInit();
            this.SuspendLayout();
            // 
            // timetable
            // 
            this.timetable.Location = new System.Drawing.Point(488, 222);
            this.timetable.Name = "timetable";
            this.timetable.Size = new System.Drawing.Size(167, 56);
            this.timetable.TabIndex = 34;
            this.timetable.Text = "Посмотреть\r\n Расписание курса";
            this.timetable.UseVisualStyleBackColor = true;
            this.timetable.Click += new System.EventHandler(this.timetable_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 274);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(659, 346);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridteacher);
            this.tabPage1.Controls.Add(this.addteacher);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(651, 317);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Преподаватели ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridteacher
            // 
            this.gridteacher.AllowUserToAddRows = false;
            this.gridteacher.AllowUserToDeleteRows = false;
            this.gridteacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridteacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridteacher.Location = new System.Drawing.Point(6, 44);
            this.gridteacher.Name = "gridteacher";
            this.gridteacher.RowTemplate.Height = 24;
            this.gridteacher.Size = new System.Drawing.Size(639, 267);
            this.gridteacher.TabIndex = 15;
            // 
            // addteacher
            // 
            this.addteacher.Location = new System.Drawing.Point(6, 6);
            this.addteacher.Name = "addteacher";
            this.addteacher.Size = new System.Drawing.Size(188, 32);
            this.addteacher.TabIndex = 17;
            this.addteacher.Text = "Добавить преподавателя";
            this.addteacher.UseVisualStyleBackColor = true;
            this.addteacher.Click += new System.EventHandler(this.addteacher_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.addstudent);
            this.tabPage2.Controls.Add(this.gridstudent);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(651, 317);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ученики курса";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // addstudent
            // 
            this.addstudent.Location = new System.Drawing.Point(11, 6);
            this.addstudent.Name = "addstudent";
            this.addstudent.Size = new System.Drawing.Size(144, 27);
            this.addstudent.TabIndex = 1;
            this.addstudent.Text = "Добавить ученика";
            this.addstudent.UseVisualStyleBackColor = true;
            this.addstudent.Click += new System.EventHandler(this.addstudent_Click);
            // 
            // gridstudent
            // 
            this.gridstudent.AllowUserToAddRows = false;
            this.gridstudent.AllowUserToDeleteRows = false;
            this.gridstudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridstudent.Location = new System.Drawing.Point(10, 39);
            this.gridstudent.Name = "gridstudent";
            this.gridstudent.RowTemplate.Height = 24;
            this.gridstudent.Size = new System.Drawing.Size(635, 272);
            this.gridstudent.TabIndex = 0;
            this.gridstudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridstudent_CellContentClick);
            this.gridstudent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridstudent_CellDoubleClick);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(268, 656);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(126, 38);
            this.close.TabIndex = 32;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // dateto
            // 
            this.dateto.Location = new System.Drawing.Point(444, 182);
            this.dateto.Name = "dateto";
            this.dateto.Size = new System.Drawing.Size(174, 22);
            this.dateto.TabIndex = 30;
            // 
            // datefrom
            // 
            this.datefrom.Location = new System.Drawing.Point(163, 182);
            this.datefrom.Name = "datefrom";
            this.datefrom.Size = new System.Drawing.Size(168, 22);
            this.datefrom.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Дата конца ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Дата начала занятий";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Филиал";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Стоимость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Тип курса";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Наименование курса";
            // 
            // namet
            // 
            this.namet.AutoSize = true;
            this.namet.Location = new System.Drawing.Point(165, 9);
            this.namet.Name = "namet";
            this.namet.Size = new System.Drawing.Size(46, 17);
            this.namet.TabIndex = 35;
            this.namet.Text = "label7";
            // 
            // costt
            // 
            this.costt.AutoSize = true;
            this.costt.Location = new System.Drawing.Point(165, 127);
            this.costt.Name = "costt";
            this.costt.Size = new System.Drawing.Size(46, 17);
            this.costt.TabIndex = 37;
            this.costt.Text = "label9";
            // 
            // typet
            // 
            this.typet.AutoSize = true;
            this.typet.Location = new System.Drawing.Point(165, 72);
            this.typet.Name = "typet";
            this.typet.Size = new System.Drawing.Size(72, 17);
            this.typet.TabIndex = 47;
            this.typet.TabStop = true;
            this.typet.Text = "linkLabel1";
            this.typet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.typet_LinkClicked);
            // 
            // brancht
            // 
            this.brancht.AutoSize = true;
            this.brancht.Location = new System.Drawing.Point(367, 130);
            this.brancht.Name = "brancht";
            this.brancht.Size = new System.Drawing.Size(72, 17);
            this.brancht.TabIndex = 48;
            this.brancht.TabStop = true;
            this.brancht.Text = "linkLabel2";
            this.brancht.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.brancht_LinkClicked);
            // 
            // Course_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 706);
            this.Controls.Add(this.brancht);
            this.Controls.Add(this.typet);
            this.Controls.Add(this.costt);
            this.Controls.Add(this.namet);
            this.Controls.Add(this.timetable);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.dateto);
            this.Controls.Add(this.datefrom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Course_view";
            this.Text = "Курс №";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Course_view_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridteacher)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridstudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button timetable;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView gridteacher;
        private System.Windows.Forms.Button addteacher;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button addstudent;
        private System.Windows.Forms.DataGridView gridstudent;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.DateTimePicker dateto;
        private System.Windows.Forms.DateTimePicker datefrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label namet;
        private System.Windows.Forms.Label costt;
        private System.Windows.Forms.LinkLabel typet;
        private System.Windows.Forms.LinkLabel brancht;
    }
}