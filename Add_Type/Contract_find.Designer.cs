namespace Add_Type
{
    partial class Contract_find
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
            this.prev = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.pagef = new System.Windows.Forms.ComboBox();
            this.D = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.countf = new System.Windows.Forms.ComboBox();
            this.reset = new System.Windows.Forms.Button();
            this.sortf = new System.Windows.Forms.ComboBox();
            this.find = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deldatef = new System.Windows.Forms.CheckBox();
            this.studentf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.costto = new System.Windows.Forms.MaskedTextBox();
            this.costfrom = new System.Windows.Forms.MaskedTextBox();
            this.branchf = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ascf = new System.Windows.Forms.Button();
            this.dateto = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.datefrom = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.bcour = new System.Windows.Forms.Button();
            this.coursef = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bman = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.managerf = new System.Windows.Forms.TextBox();
            this.bstud = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.D)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(289, 680);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(106, 32);
            this.prev.TabIndex = 9;
            this.prev.Text = "◀ Назад";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(503, 680);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(106, 32);
            this.next.TabIndex = 8;
            this.next.Text = "Вперед ▶";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // pagef
            // 
            this.pagef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pagef.FormattingEnabled = true;
            this.pagef.Location = new System.Drawing.Point(410, 679);
            this.pagef.Name = "pagef";
            this.pagef.Size = new System.Drawing.Size(77, 24);
            this.pagef.TabIndex = 7;
            this.pagef.SelectionChangeCommitted += new System.EventHandler(this.pagef_SelectionChangeCommitted);
            // 
            // D
            // 
            this.D.AllowUserToAddRows = false;
            this.D.AllowUserToDeleteRows = false;
            this.D.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.D.Location = new System.Drawing.Point(6, 107);
            this.D.Name = "D";
            this.D.RowTemplate.Height = 24;
            this.D.Size = new System.Drawing.Size(1005, 529);
            this.D.TabIndex = 6;
            this.D.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.D_CellContentClick);
            this.D.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.D_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(843, 685);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "записей";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(638, 685);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 11;
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
            this.countf.Location = new System.Drawing.Point(731, 682);
            this.countf.Name = "countf";
            this.countf.Size = new System.Drawing.Size(106, 24);
            this.countf.TabIndex = 10;
            this.countf.SelectionChangeCommitted += new System.EventHandler(this.countf_SelectionChangeCommitted);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(754, 60);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(86, 24);
            this.reset.TabIndex = 23;
            this.reset.Text = "Сбросить";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // sortf
            // 
            this.sortf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortf.FormattingEnabled = true;
            this.sortf.Location = new System.Drawing.Point(487, 69);
            this.sortf.Name = "sortf";
            this.sortf.Size = new System.Drawing.Size(180, 24);
            this.sortf.TabIndex = 24;
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(876, 49);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(138, 50);
            this.find.TabIndex = 20;
            this.find.Text = "Поиск";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Сортировать по";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Менеджер";
            // 
            // deldatef
            // 
            this.deldatef.AutoSize = true;
            this.deldatef.Location = new System.Drawing.Point(697, 0);
            this.deldatef.Name = "deldatef";
            this.deldatef.Size = new System.Drawing.Size(251, 21);
            this.deldatef.TabIndex = 19;
            this.deldatef.Text = "Показывать только неудаленные";
            this.deldatef.UseVisualStyleBackColor = true;
            // 
            // studentf
            // 
            this.studentf.Location = new System.Drawing.Point(65, 16);
            this.studentf.Multiline = true;
            this.studentf.Name = "studentf";
            this.studentf.ReadOnly = true;
            this.studentf.Size = new System.Drawing.Size(161, 20);
            this.studentf.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ученик";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.costto);
            this.groupBox1.Controls.Add(this.costfrom);
            this.groupBox1.Controls.Add(this.branchf);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.ascf);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateto);
            this.groupBox1.Controls.Add(this.reset);
            this.groupBox1.Controls.Add(this.sortf);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.find);
            this.groupBox1.Controls.Add(this.datefrom);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.bcour);
            this.groupBox1.Controls.Add(this.coursef);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.bman);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.managerf);
            this.groupBox1.Controls.Add(this.bstud);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.studentf);
            this.groupBox1.Controls.Add(this.deldatef);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(-3, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1025, 102);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // costto
            // 
            this.costto.Location = new System.Drawing.Point(192, 73);
            this.costto.Mask = "000000";
            this.costto.Name = "costto";
            this.costto.Size = new System.Drawing.Size(74, 22);
            this.costto.TabIndex = 48;
            // 
            // costfrom
            // 
            this.costfrom.Location = new System.Drawing.Point(81, 73);
            this.costfrom.Mask = "000000";
            this.costfrom.Name = "costfrom";
            this.costfrom.Size = new System.Drawing.Size(74, 22);
            this.costfrom.TabIndex = 47;
            // 
            // branchf
            // 
            this.branchf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchf.FormattingEnabled = true;
            this.branchf.Location = new System.Drawing.Point(65, 43);
            this.branchf.Name = "branchf";
            this.branchf.Size = new System.Drawing.Size(185, 24);
            this.branchf.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "руб.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(154, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 40;
            this.label11.Text = " до:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 39;
            this.label10.Text = "Цена от:";
            // 
            // ascf
            // 
            this.ascf.Location = new System.Drawing.Point(670, 69);
            this.ascf.Name = "ascf";
            this.ascf.Size = new System.Drawing.Size(45, 23);
            this.ascf.TabIndex = 38;
            this.ascf.Text = "А-Я";
            this.ascf.UseVisualStyleBackColor = true;
            // 
            // dateto
            // 
            this.dateto.Location = new System.Drawing.Point(851, 21);
            this.dateto.Name = "dateto";
            this.dateto.Size = new System.Drawing.Size(165, 22);
            this.dateto.TabIndex = 37;
            this.dateto.Value = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(786, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = "Дата до:";
            // 
            // datefrom
            // 
            this.datefrom.Location = new System.Drawing.Point(603, 21);
            this.datefrom.Name = "datefrom";
            this.datefrom.Size = new System.Drawing.Size(172, 22);
            this.datefrom.TabIndex = 36;
            this.datefrom.TabStop = false;
            this.datefrom.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(538, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "Дата от:";
            // 
            // bcour
            // 
            this.bcour.Location = new System.Drawing.Point(505, 43);
            this.bcour.Name = "bcour";
            this.bcour.Size = new System.Drawing.Size(23, 23);
            this.bcour.TabIndex = 35;
            this.bcour.Text = "🔍";
            this.bcour.UseVisualStyleBackColor = true;
            this.bcour.Click += new System.EventHandler(this.bcour_Click);
            // 
            // coursef
            // 
            this.coursef.Location = new System.Drawing.Point(343, 44);
            this.coursef.Multiline = true;
            this.coursef.Name = "coursef";
            this.coursef.ReadOnly = true;
            this.coursef.Size = new System.Drawing.Size(161, 20);
            this.coursef.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(269, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Курс";
            // 
            // bman
            // 
            this.bman.Location = new System.Drawing.Point(505, 17);
            this.bman.Name = "bman";
            this.bman.Size = new System.Drawing.Size(23, 23);
            this.bman.TabIndex = 32;
            this.bman.Text = "🔍";
            this.bman.UseVisualStyleBackColor = true;
            this.bman.Click += new System.EventHandler(this.bman_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Филиал";
            // 
            // managerf
            // 
            this.managerf.Location = new System.Drawing.Point(343, 18);
            this.managerf.Multiline = true;
            this.managerf.Name = "managerf";
            this.managerf.ReadOnly = true;
            this.managerf.Size = new System.Drawing.Size(161, 20);
            this.managerf.TabIndex = 31;
            // 
            // bstud
            // 
            this.bstud.Location = new System.Drawing.Point(227, 15);
            this.bstud.Name = "bstud";
            this.bstud.Size = new System.Drawing.Size(23, 23);
            this.bstud.TabIndex = 31;
            this.bstud.Text = "🔍";
            this.bstud.UseVisualStyleBackColor = true;
            this.bstud.Click += new System.EventHandler(this.bstud_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(6, 642);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(147, 27);
            this.add.TabIndex = 52;
            this.add.Text = "Добавить договор";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Contract_find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 715);
            this.Controls.Add(this.add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countf);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.next);
            this.Controls.Add(this.pagef);
            this.Controls.Add(this.D);
            this.Name = "Contract_find";
            this.Text = "Список договоров";
            this.Load += new System.EventHandler(this.Contract_find_Load);
            ((System.ComponentModel.ISupportInitialize)(this.D)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.ComboBox pagef;
        private System.Windows.Forms.DataGridView D;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox countf;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.ComboBox sortf;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox deldatef;
        private System.Windows.Forms.TextBox studentf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker datefrom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bcour;
        private System.Windows.Forms.TextBox coursef;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bman;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox managerf;
        private System.Windows.Forms.Button bstud;
        private System.Windows.Forms.Button ascf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ComboBox branchf;
        private System.Windows.Forms.MaskedTextBox costfrom;
        private System.Windows.Forms.MaskedTextBox costto;
    }
}