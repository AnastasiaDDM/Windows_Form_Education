namespace Add_Type
{
    partial class Theme_find
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
            this.dateto = new System.Windows.Forms.DateTimePicker();
            this.namet = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datefrom = new System.Windows.Forms.DateTimePicker();
            this.coursef = new System.Windows.Forms.TextBox();
            this.bcour = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ascf = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.sortf = new System.Windows.Forms.ComboBox();
            this.find = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.deldatef = new System.Windows.Forms.CheckBox();
            this.D = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.countf = new System.Windows.Forms.ComboBox();
            this.prev = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.pagef = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.teacherf = new System.Windows.Forms.TextBox();
            this.bteach = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.D)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.teacherf);
            this.groupBox1.Controls.Add(this.bteach);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateto);
            this.groupBox1.Controls.Add(this.namet);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.datefrom);
            this.groupBox1.Controls.Add(this.coursef);
            this.groupBox1.Controls.Add(this.bcour);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.ascf);
            this.groupBox1.Controls.Add(this.reset);
            this.groupBox1.Controls.Add(this.sortf);
            this.groupBox1.Controls.Add(this.find);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.deldatef);
            this.groupBox1.Location = new System.Drawing.Point(2, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 70);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // dateto
            // 
            this.dateto.Location = new System.Drawing.Point(275, 16);
            this.dateto.Name = "dateto";
            this.dateto.Size = new System.Drawing.Size(165, 22);
            this.dateto.TabIndex = 47;
            // 
            // namet
            // 
            this.namet.Location = new System.Drawing.Point(45, 46);
            this.namet.Multiline = true;
            this.namet.Name = "namet";
            this.namet.Size = new System.Drawing.Size(174, 19);
            this.namet.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(245, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 17);
            this.label13.TabIndex = 45;
            this.label13.Text = "до:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Тема";
            // 
            // datefrom
            // 
            this.datefrom.Location = new System.Drawing.Point(67, 17);
            this.datefrom.Name = "datefrom";
            this.datefrom.Size = new System.Drawing.Size(172, 22);
            this.datefrom.TabIndex = 46;
            // 
            // coursef
            // 
            this.coursef.Location = new System.Drawing.Point(491, 15);
            this.coursef.Multiline = true;
            this.coursef.Name = "coursef";
            this.coursef.ReadOnly = true;
            this.coursef.Size = new System.Drawing.Size(161, 20);
            this.coursef.TabIndex = 42;
            // 
            // bcour
            // 
            this.bcour.Location = new System.Drawing.Point(653, 14);
            this.bcour.Name = "bcour";
            this.bcour.Size = new System.Drawing.Size(23, 23);
            this.bcour.TabIndex = 43;
            this.bcour.Text = "🔍";
            this.bcour.UseVisualStyleBackColor = true;
            this.bcour.Click += new System.EventHandler(this.bcour_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 17);
            this.label12.TabIndex = 44;
            this.label12.Text = "Дата от:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(446, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 41;
            this.label9.Text = "Курс";
            // 
            // ascf
            // 
            this.ascf.Location = new System.Drawing.Point(664, 42);
            this.ascf.Name = "ascf";
            this.ascf.Size = new System.Drawing.Size(42, 23);
            this.ascf.TabIndex = 40;
            this.ascf.Text = "А-Я";
            this.ascf.UseVisualStyleBackColor = true;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(713, 42);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(86, 24);
            this.reset.TabIndex = 12;
            this.reset.Text = "Сбросить";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // sortf
            // 
            this.sortf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortf.FormattingEnabled = true;
            this.sortf.Location = new System.Drawing.Point(515, 40);
            this.sortf.Name = "sortf";
            this.sortf.Size = new System.Drawing.Size(147, 24);
            this.sortf.TabIndex = 12;
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(805, 30);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(127, 36);
            this.find.TabIndex = 11;
            this.find.Text = "Поиск";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Сорт.";
            // 
            // deldatef
            // 
            this.deldatef.AutoSize = true;
            this.deldatef.Location = new System.Drawing.Point(687, 5);
            this.deldatef.Name = "deldatef";
            this.deldatef.Size = new System.Drawing.Size(251, 21);
            this.deldatef.TabIndex = 10;
            this.deldatef.Text = "Показывать только неудаленные";
            this.deldatef.UseVisualStyleBackColor = true;
            // 
            // D
            // 
            this.D.AllowUserToAddRows = false;
            this.D.AllowUserToDeleteRows = false;
            this.D.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.D.Location = new System.Drawing.Point(11, 73);
            this.D.Name = "D";
            this.D.RowTemplate.Height = 24;
            this.D.Size = new System.Drawing.Size(921, 446);
            this.D.TabIndex = 12;
            this.D.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.D_CellContentClick);
            this.D.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.D_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(834, 609);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "записей";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(629, 609);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 49;
            this.label5.Text = "Показывать";
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
            this.countf.Location = new System.Drawing.Point(722, 606);
            this.countf.Name = "countf";
            this.countf.Size = new System.Drawing.Size(106, 24);
            this.countf.TabIndex = 48;
            this.countf.SelectionChangeCommitted += new System.EventHandler(this.countf_SelectionChangeCommitted);
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(298, 602);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(106, 32);
            this.prev.TabIndex = 47;
            this.prev.Text = "◀ Назад";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(493, 602);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(106, 32);
            this.next.TabIndex = 46;
            this.next.Text = "Вперед ▶";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // pagef
            // 
            this.pagef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pagef.FormattingEnabled = true;
            this.pagef.Location = new System.Drawing.Point(410, 607);
            this.pagef.Name = "pagef";
            this.pagef.Size = new System.Drawing.Size(77, 24);
            this.pagef.TabIndex = 45;
            this.pagef.SelectionChangeCommitted += new System.EventHandler(this.pagef_SelectionChangeCommitted);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 525);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(147, 27);
            this.add.TabIndex = 51;
            this.add.Text = "Добавить тему";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // teacherf
            // 
            this.teacherf.Location = new System.Drawing.Point(285, 46);
            this.teacherf.Multiline = true;
            this.teacherf.Name = "teacherf";
            this.teacherf.ReadOnly = true;
            this.teacherf.Size = new System.Drawing.Size(155, 20);
            this.teacherf.TabIndex = 49;
            // 
            // bteach
            // 
            this.bteach.Location = new System.Drawing.Point(441, 45);
            this.bteach.Name = "bteach";
            this.bteach.Size = new System.Drawing.Size(22, 23);
            this.bteach.TabIndex = 50;
            this.bteach.Text = "🔍";
            this.bteach.UseVisualStyleBackColor = true;
            this.bteach.Click += new System.EventHandler(this.bteach_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Препод.";
            // 
            // Theme_find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 643);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.countf);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.next);
            this.Controls.Add(this.pagef);
            this.Controls.Add(this.D);
            this.Controls.Add(this.groupBox1);
            this.Name = "Theme_find";
            this.Text = "Список тем";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.D)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ascf;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.ComboBox sortf;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox deldatef;
        private System.Windows.Forms.TextBox namet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bcour;
        private System.Windows.Forms.TextBox coursef;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker datefrom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView D;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox countf;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.ComboBox pagef;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox teacherf;
        private System.Windows.Forms.Button bteach;
        private System.Windows.Forms.Label label1;
    }
}