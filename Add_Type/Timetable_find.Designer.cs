namespace Add_Type
{
    partial class Timetable_find
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.prev = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.DataGridView();
            this.monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satyrday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mondayt = new System.Windows.Forms.Label();
            this.sundayt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cabinetf = new System.Windows.Forms.ComboBox();
            this.branchf = new System.Windows.Forms.ComboBox();
            this.find = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.bcour = new System.Windows.Forms.Button();
            this.coursef = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bwor = new System.Windows.Forms.Button();
            this.studentf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bstud = new System.Windows.Forms.Button();
            this.teacherf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.datef = new System.Windows.Forms.DateTimePicker();
            this.countimetables = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.D)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(373, 101);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(160, 31);
            this.prev.TabIndex = 0;
            this.prev.Text = "Предыдущая неделя";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(595, 101);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(160, 31);
            this.next.TabIndex = 1;
            this.next.Text = "Следующая неделя";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // D
            // 
            this.D.AllowUserToAddRows = false;
            this.D.AllowUserToDeleteRows = false;
            this.D.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.D.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.monday,
            this.tuesday,
            this.wednesday,
            this.thursday,
            this.friday,
            this.satyrday,
            this.sunday});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.D.DefaultCellStyle = dataGridViewCellStyle1;
            this.D.Location = new System.Drawing.Point(11, 179);
            this.D.Name = "D";
            this.D.ReadOnly = true;
            this.D.RowTemplate.Height = 24;
            this.D.Size = new System.Drawing.Size(1009, 516);
            this.D.TabIndex = 4;
            // 
            // monday
            // 
            this.monday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.monday.HeaderText = "Понедельник";
            this.monday.Name = "monday";
            this.monday.ReadOnly = true;
            this.monday.Width = 125;
            // 
            // tuesday
            // 
            this.tuesday.HeaderText = "Вторник";
            this.tuesday.Name = "tuesday";
            this.tuesday.ReadOnly = true;
            this.tuesday.Width = 92;
            // 
            // wednesday
            // 
            this.wednesday.HeaderText = "Среда";
            this.wednesday.Name = "wednesday";
            this.wednesday.ReadOnly = true;
            this.wednesday.Width = 78;
            // 
            // thursday
            // 
            this.thursday.HeaderText = "Четверг";
            this.thursday.Name = "thursday";
            this.thursday.ReadOnly = true;
            this.thursday.Width = 90;
            // 
            // friday
            // 
            this.friday.HeaderText = "Пятница";
            this.friday.Name = "friday";
            this.friday.ReadOnly = true;
            this.friday.Width = 94;
            // 
            // satyrday
            // 
            this.satyrday.HeaderText = "Суббота";
            this.satyrday.Name = "satyrday";
            this.satyrday.ReadOnly = true;
            this.satyrday.Width = 92;
            // 
            // sunday
            // 
            this.sunday.HeaderText = "Воскресенье";
            this.sunday.Name = "sunday";
            this.sunday.ReadOnly = true;
            this.sunday.Width = 122;
            // 
            // mondayt
            // 
            this.mondayt.AutoSize = true;
            this.mondayt.Location = new System.Drawing.Point(386, 152);
            this.mondayt.Name = "mondayt";
            this.mondayt.Size = new System.Drawing.Size(140, 17);
            this.mondayt.TabIndex = 5;
            this.mondayt.Text = "Дата понедельника";
            // 
            // sundayt
            // 
            this.sundayt.AutoSize = true;
            this.sundayt.Location = new System.Drawing.Point(556, 152);
            this.sundayt.Name = "sundayt";
            this.sundayt.Size = new System.Drawing.Size(129, 17);
            this.sundayt.TabIndex = 6;
            this.sundayt.Text = "Дата воскресенья";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(534, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "_";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cabinetf);
            this.groupBox1.Controls.Add(this.branchf);
            this.groupBox1.Controls.Add(this.find);
            this.groupBox1.Controls.Add(this.reset);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.bcour);
            this.groupBox1.Controls.Add(this.coursef);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.bwor);
            this.groupBox1.Controls.Add(this.studentf);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.bstud);
            this.groupBox1.Controls.Add(this.teacherf);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(4, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1029, 73);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // cabinetf
            // 
            this.cabinetf.FormattingEnabled = true;
            this.cabinetf.Location = new System.Drawing.Point(64, 37);
            this.cabinetf.Name = "cabinetf";
            this.cabinetf.Size = new System.Drawing.Size(161, 24);
            this.cabinetf.TabIndex = 13;
            // 
            // branchf
            // 
            this.branchf.FormattingEnabled = true;
            this.branchf.Location = new System.Drawing.Point(64, 10);
            this.branchf.Name = "branchf";
            this.branchf.Size = new System.Drawing.Size(161, 24);
            this.branchf.TabIndex = 14;
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(891, 22);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(122, 37);
            this.find.TabIndex = 52;
            this.find.Text = "Поиск";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(771, 43);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(89, 27);
            this.reset.TabIndex = 51;
            this.reset.Text = "Сбросить";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "Кабинет";
            // 
            // bcour
            // 
            this.bcour.Location = new System.Drawing.Point(523, 41);
            this.bcour.Name = "bcour";
            this.bcour.Size = new System.Drawing.Size(23, 23);
            this.bcour.TabIndex = 46;
            this.bcour.Text = "🔍";
            this.bcour.UseVisualStyleBackColor = true;
            this.bcour.Click += new System.EventHandler(this.bcour_Click);
            // 
            // coursef
            // 
            this.coursef.Location = new System.Drawing.Point(361, 43);
            this.coursef.Multiline = true;
            this.coursef.Name = "coursef";
            this.coursef.Size = new System.Drawing.Size(161, 20);
            this.coursef.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Курс";
            // 
            // bwor
            // 
            this.bwor.Location = new System.Drawing.Point(522, 15);
            this.bwor.Name = "bwor";
            this.bwor.Size = new System.Drawing.Size(23, 23);
            this.bwor.TabIndex = 41;
            this.bwor.Text = "🔍";
            this.bwor.UseVisualStyleBackColor = true;
            this.bwor.Click += new System.EventHandler(this.bwor_Click);
            // 
            // studentf
            // 
            this.studentf.Location = new System.Drawing.Point(627, 14);
            this.studentf.Multiline = true;
            this.studentf.Name = "studentf";
            this.studentf.Size = new System.Drawing.Size(161, 20);
            this.studentf.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(568, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ученик";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "Филиал";
            // 
            // bstud
            // 
            this.bstud.Location = new System.Drawing.Point(789, 13);
            this.bstud.Name = "bstud";
            this.bstud.Size = new System.Drawing.Size(23, 23);
            this.bstud.TabIndex = 40;
            this.bstud.Text = "🔍";
            this.bstud.UseVisualStyleBackColor = true;
            this.bstud.Click += new System.EventHandler(this.bstud_Click);
            // 
            // teacherf
            // 
            this.teacherf.Location = new System.Drawing.Point(361, 16);
            this.teacherf.Multiline = true;
            this.teacherf.Name = "teacherf";
            this.teacherf.Size = new System.Drawing.Size(161, 20);
            this.teacherf.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Преподаватель";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(870, 78);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(147, 54);
            this.add.TabIndex = 9;
            this.add.Text = "Добавить элемент\r\nрасписания";
            this.add.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Посмотреть конкретную дату";
            // 
            // datef
            // 
            this.datef.Location = new System.Drawing.Point(12, 110);
            this.datef.Name = "datef";
            this.datef.Size = new System.Drawing.Size(200, 22);
            this.datef.TabIndex = 11;
            // 
            // countimetables
            // 
            this.countimetables.AutoSize = true;
            this.countimetables.Location = new System.Drawing.Point(12, 698);
            this.countimetables.Name = "countimetables";
            this.countimetables.Size = new System.Drawing.Size(217, 17);
            this.countimetables.TabIndex = 12;
            this.countimetables.Text = "Количестов занятий в неделю: ";
            // 
            // Timetable_find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 724);
            this.Controls.Add(this.countimetables);
            this.Controls.Add(this.datef);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sundayt);
            this.Controls.Add(this.mondayt);
            this.Controls.Add(this.D);
            this.Controls.Add(this.next);
            this.Controls.Add(this.prev);
            this.Name = "Timetable_find";
            this.Text = "Расписание занятий ";
            this.Load += new System.EventHandler(this.Timetable_find_Load);
            ((System.ComponentModel.ISupportInitialize)(this.D)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.DataGridView D;
        private System.Windows.Forms.Label mondayt;
        private System.Windows.Forms.Label sundayt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bcour;
        private System.Windows.Forms.TextBox coursef;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bwor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox teacherf;
        private System.Windows.Forms.Button bstud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datef;
        private System.Windows.Forms.Label countimetables;
        private System.Windows.Forms.ComboBox cabinetf;
        private System.Windows.Forms.ComboBox branchf;
        private System.Windows.Forms.DataGridViewTextBoxColumn monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn satyrday;
        private System.Windows.Forms.DataGridViewTextBoxColumn sunday;
    }
}