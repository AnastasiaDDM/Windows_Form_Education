namespace Add_Type
{
    partial class Course_find
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.costto = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateto = new System.Windows.Forms.DateTimePicker();
            this.branchf = new System.Windows.Forms.ComboBox();
            this.sortf = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.typef = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.costfrom = new System.Windows.Forms.MaskedTextBox();
            this.btype = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ascf = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.find = new System.Windows.Forms.Button();
            this.datefrom = new System.Windows.Forms.DateTimePicker();
            this.bteach = new System.Windows.Forms.Button();
            this.teacherf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.namet = new System.Windows.Forms.TextBox();
            this.deldatef = new System.Windows.Forms.CheckBox();
            this.D = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.countf = new System.Windows.Forms.ComboBox();
            this.prev = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.pagef = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.D)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.costto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateto);
            this.groupBox1.Controls.Add(this.branchf);
            this.groupBox1.Controls.Add(this.sortf);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.typef);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.costfrom);
            this.groupBox1.Controls.Add(this.btype);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.ascf);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.reset);
            this.groupBox1.Controls.Add(this.find);
            this.groupBox1.Controls.Add(this.datefrom);
            this.groupBox1.Controls.Add(this.bteach);
            this.groupBox1.Controls.Add(this.teacherf);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.namet);
            this.groupBox1.Controls.Add(this.deldatef);
            this.groupBox1.Location = new System.Drawing.Point(4, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1157, 97);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // costto
            // 
            this.costto.Location = new System.Drawing.Point(743, 39);
            this.costto.Mask = "00000";
            this.costto.Name = "costto";
            this.costto.Size = new System.Drawing.Size(71, 22);
            this.costto.TabIndex = 46;
            this.costto.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Окончание";
            // 
            // dateto
            // 
            this.dateto.Location = new System.Drawing.Point(394, 69);
            this.dateto.Name = "dateto";
            this.dateto.Size = new System.Drawing.Size(172, 22);
            this.dateto.TabIndex = 45;
            this.dateto.Value = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            // 
            // branchf
            // 
            this.branchf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchf.FormattingEnabled = true;
            this.branchf.Location = new System.Drawing.Point(367, 38);
            this.branchf.Name = "branchf";
            this.branchf.Size = new System.Drawing.Size(199, 24);
            this.branchf.TabIndex = 36;
            // 
            // sortf
            // 
            this.sortf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortf.FormattingEnabled = true;
            this.sortf.Location = new System.Drawing.Point(732, 67);
            this.sortf.Name = "sortf";
            this.sortf.Size = new System.Drawing.Size(180, 24);
            this.sortf.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(820, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "руб.";
            // 
            // typef
            // 
            this.typef.Location = new System.Drawing.Point(634, 9);
            this.typef.Multiline = true;
            this.typef.Name = "typef";
            this.typef.ReadOnly = true;
            this.typef.Size = new System.Drawing.Size(161, 20);
            this.typef.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "Начало курса";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Тип";
            // 
            // costfrom
            // 
            this.costfrom.Location = new System.Drawing.Point(638, 38);
            this.costfrom.Mask = "00000";
            this.costfrom.Name = "costfrom";
            this.costfrom.Size = new System.Drawing.Size(71, 22);
            this.costfrom.TabIndex = 42;
            this.costfrom.ValidatingType = typeof(int);
            // 
            // btype
            // 
            this.btype.Location = new System.Drawing.Point(795, 8);
            this.btype.Name = "btype";
            this.btype.Size = new System.Drawing.Size(23, 23);
            this.btype.TabIndex = 32;
            this.btype.Text = "🔍";
            this.btype.UseVisualStyleBackColor = true;
            this.btype.Click += new System.EventHandler(this.btype_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(709, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 40;
            this.label11.Text = " до:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(306, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Филиал";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(572, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 39;
            this.label10.Text = "Цена от:";
            // 
            // ascf
            // 
            this.ascf.Location = new System.Drawing.Point(917, 67);
            this.ascf.Name = "ascf";
            this.ascf.Size = new System.Drawing.Size(42, 23);
            this.ascf.TabIndex = 38;
            this.ascf.Text = "А-Я";
            this.ascf.UseVisualStyleBackColor = true;
            this.ascf.Click += new System.EventHandler(this.ascf_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(613, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Сортировать по";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(919, 37);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(86, 26);
            this.reset.TabIndex = 23;
            this.reset.Text = "Сбросить";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(1011, 36);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(138, 50);
            this.find.TabIndex = 20;
            this.find.Text = "Поиск";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // datefrom
            // 
            this.datefrom.Location = new System.Drawing.Point(108, 69);
            this.datefrom.Name = "datefrom";
            this.datefrom.Size = new System.Drawing.Size(172, 22);
            this.datefrom.TabIndex = 36;
            this.datefrom.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // bteach
            // 
            this.bteach.Location = new System.Drawing.Point(275, 36);
            this.bteach.Name = "bteach";
            this.bteach.Size = new System.Drawing.Size(23, 23);
            this.bteach.TabIndex = 35;
            this.bteach.Text = "🔍";
            this.bteach.UseVisualStyleBackColor = true;
            this.bteach.Click += new System.EventHandler(this.bteach_Click);
            // 
            // teacherf
            // 
            this.teacherf.Location = new System.Drawing.Point(113, 38);
            this.teacherf.Multiline = true;
            this.teacherf.Name = "teacherf";
            this.teacherf.ReadOnly = true;
            this.teacherf.Size = new System.Drawing.Size(161, 20);
            this.teacherf.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Преподаватель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Название";
            // 
            // namet
            // 
            this.namet.Location = new System.Drawing.Point(113, 12);
            this.namet.Multiline = true;
            this.namet.Name = "namet";
            this.namet.Size = new System.Drawing.Size(410, 21);
            this.namet.TabIndex = 18;
            // 
            // deldatef
            // 
            this.deldatef.AutoSize = true;
            this.deldatef.Location = new System.Drawing.Point(885, 9);
            this.deldatef.Name = "deldatef";
            this.deldatef.Size = new System.Drawing.Size(251, 21);
            this.deldatef.TabIndex = 19;
            this.deldatef.Text = "Показывать только неудаленные";
            this.deldatef.UseVisualStyleBackColor = true;
            // 
            // D
            // 
            this.D.AllowUserToAddRows = false;
            this.D.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.D.Location = new System.Drawing.Point(4, 101);
            this.D.Name = "D";
            this.D.RowTemplate.Height = 24;
            this.D.Size = new System.Drawing.Size(1157, 517);
            this.D.TabIndex = 32;
            this.D.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.D_CellContentClick);
            this.D.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.D_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(938, 688);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "записей";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(733, 688);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Показывать";
            // 
            // countf
            // 
            this.countf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countf.FormattingEnabled = true;
            this.countf.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "30"});
            this.countf.Location = new System.Drawing.Point(826, 685);
            this.countf.Name = "countf";
            this.countf.Size = new System.Drawing.Size(106, 24);
            this.countf.TabIndex = 36;
            this.countf.SelectionChangeCommitted += new System.EventHandler(this.countf_SelectionChangeCommitted);
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(402, 681);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(106, 32);
            this.prev.TabIndex = 35;
            this.prev.Text = "◀ Назад";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(597, 681);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(106, 32);
            this.next.TabIndex = 34;
            this.next.Text = "Вперед ▶";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // pagef
            // 
            this.pagef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pagef.FormattingEnabled = true;
            this.pagef.Location = new System.Drawing.Point(514, 686);
            this.pagef.Name = "pagef";
            this.pagef.Size = new System.Drawing.Size(77, 24);
            this.pagef.TabIndex = 33;
            this.pagef.SelectionChangeCommitted += new System.EventHandler(this.pagef_SelectionChangeCommitted);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(4, 624);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(147, 27);
            this.add.TabIndex = 52;
            this.add.Text = "Добавить курс";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Course_find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 716);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countf);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.next);
            this.Controls.Add(this.pagef);
            this.Controls.Add(this.D);
            this.Controls.Add(this.groupBox1);
            this.Name = "Course_find";
            this.Text = "Список курсов";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Course_find_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.D)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox branchf;
        private System.Windows.Forms.ComboBox sortf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox typef;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox costfrom;
        private System.Windows.Forms.Button btype;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ascf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.DateTimePicker datefrom;
        private System.Windows.Forms.Button bteach;
        private System.Windows.Forms.TextBox teacherf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox namet;
        private System.Windows.Forms.CheckBox deldatef;
        private System.Windows.Forms.DataGridView D;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox countf;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.ComboBox pagef;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateto;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.MaskedTextBox costto;
    }
}