namespace Add_Type
{
    partial class Timetable_edit
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
            this.bcour = new System.Windows.Forms.Button();
            this.coursef = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notet = new System.Windows.Forms.TextBox();
            this.datet = new System.Windows.Forms.DateTimePicker();
            this.finaldatet = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.startt = new System.Windows.Forms.MaskedTextBox();
            this.endt = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.repeatf = new System.Windows.Forms.CheckBox();
            this.periodf = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.fixtimef = new System.Windows.Forms.ComboBox();
            this.cabinetf = new System.Windows.Forms.ComboBox();
            this.branchf = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.DataGridView();
            this.groupBoxteachers = new System.Windows.Forms.GroupBox();
            this.searchteachers = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.existteachers = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.D)).BeginInit();
            this.groupBoxteachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bcour
            // 
            this.bcour.Location = new System.Drawing.Point(602, 113);
            this.bcour.Name = "bcour";
            this.bcour.Size = new System.Drawing.Size(23, 23);
            this.bcour.TabIndex = 56;
            this.bcour.Text = "🔍";
            this.bcour.UseVisualStyleBackColor = true;
            this.bcour.Click += new System.EventHandler(this.bcour_Click);
            // 
            // coursef
            // 
            this.coursef.Location = new System.Drawing.Point(350, 113);
            this.coursef.Multiline = true;
            this.coursef.Name = "coursef";
            this.coursef.ReadOnly = true;
            this.coursef.Size = new System.Drawing.Size(251, 23);
            this.coursef.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(305, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 54;
            this.label9.Text = "Курс";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "Комментарий";
            // 
            // notet
            // 
            this.notet.Location = new System.Drawing.Point(12, 86);
            this.notet.Multiline = true;
            this.notet.Name = "notet";
            this.notet.Size = new System.Drawing.Size(583, 77);
            this.notet.TabIndex = 58;
            // 
            // datet
            // 
            this.datet.Location = new System.Drawing.Point(128, 31);
            this.datet.Name = "datet";
            this.datet.Size = new System.Drawing.Size(169, 22);
            this.datet.TabIndex = 62;
            // 
            // finaldatet
            // 
            this.finaldatet.Location = new System.Drawing.Point(393, 31);
            this.finaldatet.Name = "finaldatet";
            this.finaldatet.Size = new System.Drawing.Size(202, 22);
            this.finaldatet.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 64;
            this.label3.Text = "начало";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 66;
            this.label5.Text = "Дата занятия";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 67;
            this.label7.Text = "конец";
            // 
            // startt
            // 
            this.startt.Location = new System.Drawing.Point(335, 31);
            this.startt.Mask = "00:00";
            this.startt.Name = "startt";
            this.startt.Size = new System.Drawing.Size(41, 22);
            this.startt.TabIndex = 68;
            this.startt.ValidatingType = typeof(System.DateTime);
            this.startt.TextChanged += new System.EventHandler(this.startt_TextChanged);
            // 
            // endt
            // 
            this.endt.Location = new System.Drawing.Point(413, 31);
            this.endt.Mask = "00:00";
            this.endt.Name = "endt";
            this.endt.Size = new System.Drawing.Size(41, 22);
            this.endt.TabIndex = 69;
            this.endt.ValidatingType = typeof(System.DateTime);
            this.endt.TextChanged += new System.EventHandler(this.endt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 70;
            this.label8.Text = "—";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.repeatf);
            this.groupBox1.Controls.Add(this.periodf);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.notet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.finaldatet);
            this.groupBox1.Location = new System.Drawing.Point(18, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 172);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дополнительные функции";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 17);
            this.label6.TabIndex = 65;
            this.label6.Text = "до";
            // 
            // repeatf
            // 
            this.repeatf.AutoSize = true;
            this.repeatf.Location = new System.Drawing.Point(87, 33);
            this.repeatf.Name = "repeatf";
            this.repeatf.Size = new System.Drawing.Size(18, 17);
            this.repeatf.TabIndex = 64;
            this.repeatf.UseVisualStyleBackColor = true;
            this.repeatf.CheckedChanged += new System.EventHandler(this.repeatf_CheckedChanged);
            // 
            // periodf
            // 
            this.periodf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodf.FormattingEnabled = true;
            this.periodf.Items.AddRange(new object[] {
            "Ежедневно",
            "Еженедельно",
            "Ежемесячно",
            "Каждый год",
            "Каждый будний день(пн - пт)"});
            this.periodf.Location = new System.Drawing.Point(111, 28);
            this.periodf.Name = "periodf";
            this.periodf.Size = new System.Drawing.Size(239, 24);
            this.periodf.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Повторить";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(514, 584);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(116, 37);
            this.save.TabIndex = 72;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(17, 584);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(116, 37);
            this.cancel.TabIndex = 73;
            this.cancel.Text = "Отменить";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // fixtimef
            // 
            this.fixtimef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fixtimef.FormattingEnabled = true;
            this.fixtimef.Location = new System.Drawing.Point(335, 59);
            this.fixtimef.Name = "fixtimef";
            this.fixtimef.Size = new System.Drawing.Size(119, 24);
            this.fixtimef.TabIndex = 74;
            // 
            // cabinetf
            // 
            this.cabinetf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cabinetf.FormattingEnabled = true;
            this.cabinetf.Location = new System.Drawing.Point(75, 140);
            this.cabinetf.Name = "cabinetf";
            this.cabinetf.Size = new System.Drawing.Size(222, 24);
            this.cabinetf.TabIndex = 75;
            // 
            // branchf
            // 
            this.branchf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchf.FormattingEnabled = true;
            this.branchf.Location = new System.Drawing.Point(75, 109);
            this.branchf.Name = "branchf";
            this.branchf.Size = new System.Drawing.Size(222, 24);
            this.branchf.TabIndex = 76;
            this.branchf.SelectionChangeCommitted += new System.EventHandler(this.branchf_SelectionChangeCommitted);
            this.branchf.MouseEnter += new System.EventHandler(this.branchf_MouseEnter);
            this.branchf.MouseLeave += new System.EventHandler(this.branchf_MouseLeave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 78;
            this.label10.Text = "Кабинет";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 77;
            this.label11.Text = "Филиал";
            // 
            // D
            // 
            this.D.AllowUserToAddRows = false;
            this.D.AllowUserToDeleteRows = false;
            this.D.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.D.Location = new System.Drawing.Point(6, 21);
            this.D.Name = "D";
            this.D.RowTemplate.Height = 24;
            this.D.Size = new System.Drawing.Size(601, 167);
            this.D.TabIndex = 79;
            this.D.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.D_CellContentClick);
            // 
            // groupBoxteachers
            // 
            this.groupBoxteachers.Controls.Add(this.D);
            this.groupBoxteachers.Location = new System.Drawing.Point(17, 170);
            this.groupBoxteachers.Name = "groupBoxteachers";
            this.groupBoxteachers.Size = new System.Drawing.Size(613, 200);
            this.groupBoxteachers.TabIndex = 79;
            this.groupBoxteachers.TabStop = false;
            this.groupBoxteachers.Text = "Свободные преподаватели";
            // 
            // searchteachers
            // 
            this.searchteachers.Location = new System.Drawing.Point(556, 153);
            this.searchteachers.Name = "searchteachers";
            this.searchteachers.Size = new System.Drawing.Size(75, 23);
            this.searchteachers.TabIndex = 80;
            this.searchteachers.Text = "Найти";
            this.searchteachers.UseVisualStyleBackColor = true;
            this.searchteachers.Click += new System.EventHandler(this.searchteachers_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // existteachers
            // 
            this.existteachers.Location = new System.Drawing.Point(435, 153);
            this.existteachers.Name = "existteachers";
            this.existteachers.Size = new System.Drawing.Size(104, 23);
            this.existteachers.TabIndex = 81;
            this.existteachers.Text = "Имеющиеся";
            this.existteachers.UseVisualStyleBackColor = true;
            this.existteachers.Click += new System.EventHandler(this.existteachers_Click);
            // 
            // Timetable_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 644);
            this.Controls.Add(this.existteachers);
            this.Controls.Add(this.searchteachers);
            this.Controls.Add(this.groupBoxteachers);
            this.Controls.Add(this.cabinetf);
            this.Controls.Add(this.branchf);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.fixtimef);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.endt);
            this.Controls.Add(this.startt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datet);
            this.Controls.Add(this.bcour);
            this.Controls.Add(this.coursef);
            this.Controls.Add(this.label9);
            this.Name = "Timetable_edit";
            this.Text = "Редактирование элемента расписания №";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Timetable_edit_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.D)).EndInit();
            this.groupBoxteachers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bcour;
        private System.Windows.Forms.TextBox coursef;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox notet;
        private System.Windows.Forms.DateTimePicker datet;
        private System.Windows.Forms.DateTimePicker finaldatet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox startt;
        private System.Windows.Forms.MaskedTextBox endt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox periodf;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ComboBox fixtimef;
        private System.Windows.Forms.ComboBox cabinetf;
        private System.Windows.Forms.ComboBox branchf;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox repeatf;
        private System.Windows.Forms.DataGridView D;
        private System.Windows.Forms.GroupBox groupBoxteachers;
        private System.Windows.Forms.Button searchteachers;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button existteachers;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}