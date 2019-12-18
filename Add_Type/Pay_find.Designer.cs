namespace Add_Type
{
    partial class Pay_find
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.countf = new System.Windows.Forms.ComboBox();
            this.prev = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.pagef = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.costto = new System.Windows.Forms.MaskedTextBox();
            this.btime = new System.Windows.Forms.Button();
            this.timef = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.indicatorf = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bwor = new System.Windows.Forms.Button();
            this.branchf = new System.Windows.Forms.ComboBox();
            this.typef = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.teacherf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.costfrom = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateto = new System.Windows.Forms.DateTimePicker();
            this.bcon = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.ascf = new System.Windows.Forms.Button();
            this.datefrom = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.contractf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.sortf = new System.Windows.Forms.ComboBox();
            this.find = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.deldatef = new System.Windows.Forms.CheckBox();
            this.D = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.D)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(982, 668);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "записей";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(777, 668);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 23;
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
            this.countf.Location = new System.Drawing.Point(870, 665);
            this.countf.Name = "countf";
            this.countf.Size = new System.Drawing.Size(106, 24);
            this.countf.TabIndex = 22;
            this.countf.SelectionChangeCommitted += new System.EventHandler(this.countf_SelectionChangeCommitted);
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(321, 660);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(106, 32);
            this.prev.TabIndex = 21;
            this.prev.Text = "◀ Назад";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(535, 660);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(106, 32);
            this.next.TabIndex = 20;
            this.next.Text = "Вперед ▶";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // pagef
            // 
            this.pagef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pagef.FormattingEnabled = true;
            this.pagef.Location = new System.Drawing.Point(443, 665);
            this.pagef.Name = "pagef";
            this.pagef.Size = new System.Drawing.Size(77, 24);
            this.pagef.TabIndex = 19;
            this.pagef.SelectionChangeCommitted += new System.EventHandler(this.pagef_SelectionChangeCommitted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.costto);
            this.groupBox1.Controls.Add(this.btime);
            this.groupBox1.Controls.Add(this.timef);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.indicatorf);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bwor);
            this.groupBox1.Controls.Add(this.branchf);
            this.groupBox1.Controls.Add(this.typef);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.teacherf);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.costfrom);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dateto);
            this.groupBox1.Controls.Add(this.bcon);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.ascf);
            this.groupBox1.Controls.Add(this.datefrom);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.contractf);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.reset);
            this.groupBox1.Controls.Add(this.sortf);
            this.groupBox1.Controls.Add(this.find);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.deldatef);
            this.groupBox1.Location = new System.Drawing.Point(2, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1100, 97);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // costto
            // 
            this.costto.Location = new System.Drawing.Point(464, 14);
            this.costto.Mask = "00000";
            this.costto.Name = "costto";
            this.costto.Size = new System.Drawing.Size(71, 22);
            this.costto.TabIndex = 62;
            this.costto.ValidatingType = typeof(int);
            // 
            // btime
            // 
            this.btime.Location = new System.Drawing.Point(514, 40);
            this.btime.Name = "btime";
            this.btime.Size = new System.Drawing.Size(23, 23);
            this.btime.TabIndex = 61;
            this.btime.Text = "🔍";
            this.btime.UseVisualStyleBackColor = true;
            // 
            // timef
            // 
            this.timef.Location = new System.Drawing.Point(353, 41);
            this.timef.Multiline = true;
            this.timef.Name = "timef";
            this.timef.Size = new System.Drawing.Size(161, 20);
            this.timef.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(274, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 59;
            this.label11.Text = "Занятие";
            // 
            // indicatorf
            // 
            this.indicatorf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.indicatorf.FormattingEnabled = true;
            this.indicatorf.Items.AddRange(new object[] {
            "Не выбрано",
            "Оплата по договору",
            "Зарплата сотрудникам"});
            this.indicatorf.Location = new System.Drawing.Point(353, 65);
            this.indicatorf.Name = "indicatorf";
            this.indicatorf.Size = new System.Drawing.Size(184, 24);
            this.indicatorf.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(274, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 57;
            this.label9.Text = "Индикатор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "до";
            // 
            // bwor
            // 
            this.bwor.Location = new System.Drawing.Point(237, 38);
            this.bwor.Name = "bwor";
            this.bwor.Size = new System.Drawing.Size(23, 23);
            this.bwor.TabIndex = 55;
            this.bwor.Text = "🔍";
            this.bwor.UseVisualStyleBackColor = true;
            this.bwor.Click += new System.EventHandler(this.bwor_Click);
            // 
            // branchf
            // 
            this.branchf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchf.FormattingEnabled = true;
            this.branchf.Location = new System.Drawing.Point(619, 39);
            this.branchf.Name = "branchf";
            this.branchf.Size = new System.Drawing.Size(178, 24);
            this.branchf.TabIndex = 50;
            // 
            // typef
            // 
            this.typef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typef.FormattingEnabled = true;
            this.typef.Items.AddRange(new object[] {
            "Не выбрано",
            "Наличный расчет",
            "Безналичный расчет"});
            this.typef.Location = new System.Drawing.Point(74, 68);
            this.typef.Name = "typef";
            this.typef.Size = new System.Drawing.Size(184, 24);
            this.typef.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 34);
            this.label4.TabIndex = 47;
            this.label4.Text = "Способ\r\n оплаты";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(549, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Филиал";
            // 
            // teacherf
            // 
            this.teacherf.Location = new System.Drawing.Point(75, 39);
            this.teacherf.Multiline = true;
            this.teacherf.Name = "teacherf";
            this.teacherf.Size = new System.Drawing.Size(161, 20);
            this.teacherf.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 53;
            this.label8.Text = "Препод.";
            // 
            // costfrom
            // 
            this.costfrom.Location = new System.Drawing.Point(354, 13);
            this.costfrom.Mask = "00000";
            this.costfrom.Name = "costfrom";
            this.costfrom.Size = new System.Drawing.Size(71, 22);
            this.costfrom.TabIndex = 46;
            this.costfrom.ValidatingType = typeof(int);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(274, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 43;
            this.label10.Text = "Оплата от:";
            // 
            // dateto
            // 
            this.dateto.Location = new System.Drawing.Point(747, 13);
            this.dateto.Name = "dateto";
            this.dateto.Size = new System.Drawing.Size(147, 22);
            this.dateto.TabIndex = 41;
            // 
            // bcon
            // 
            this.bcon.Location = new System.Drawing.Point(236, 11);
            this.bcon.Name = "bcon";
            this.bcon.Size = new System.Drawing.Size(23, 23);
            this.bcon.TabIndex = 35;
            this.bcon.Text = "🔍";
            this.bcon.UseVisualStyleBackColor = true;
            this.bcon.Click += new System.EventHandler(this.bcon_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(722, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 17);
            this.label13.TabIndex = 39;
            this.label13.Text = "до:";
            // 
            // ascf
            // 
            this.ascf.Location = new System.Drawing.Point(800, 68);
            this.ascf.Name = "ascf";
            this.ascf.Size = new System.Drawing.Size(42, 23);
            this.ascf.TabIndex = 39;
            this.ascf.Text = "А-Я";
            this.ascf.UseVisualStyleBackColor = true;
            this.ascf.Click += new System.EventHandler(this.ascf_Click);
            // 
            // datefrom
            // 
            this.datefrom.Location = new System.Drawing.Point(576, 13);
            this.datefrom.Name = "datefrom";
            this.datefrom.Size = new System.Drawing.Size(145, 22);
            this.datefrom.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(549, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 17);
            this.label12.TabIndex = 38;
            this.label12.Text = "От:";
            // 
            // contractf
            // 
            this.contractf.Location = new System.Drawing.Point(74, 14);
            this.contractf.Multiline = true;
            this.contractf.Name = "contractf";
            this.contractf.Size = new System.Drawing.Size(161, 20);
            this.contractf.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Договор";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(859, 66);
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
            this.sortf.Location = new System.Drawing.Point(640, 68);
            this.sortf.Name = "sortf";
            this.sortf.Size = new System.Drawing.Size(157, 24);
            this.sortf.TabIndex = 12;
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(953, 43);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(142, 45);
            this.find.TabIndex = 11;
            this.find.Text = "Поиск";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(544, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Сортировать";
            // 
            // deldatef
            // 
            this.deldatef.AutoSize = true;
            this.deldatef.Location = new System.Drawing.Point(922, 10);
            this.deldatef.Name = "deldatef";
            this.deldatef.Size = new System.Drawing.Size(170, 21);
            this.deldatef.TabIndex = 10;
            this.deldatef.Text = "Только неудаленные";
            this.deldatef.UseVisualStyleBackColor = true;
            // 
            // D
            // 
            this.D.AllowUserToAddRows = false;
            this.D.AllowUserToDeleteRows = false;
            this.D.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.D.Location = new System.Drawing.Point(11, 99);
            this.D.Name = "D";
            this.D.RowTemplate.Height = 24;
            this.D.Size = new System.Drawing.Size(1083, 500);
            this.D.TabIndex = 26;
            this.D.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.D_CellContentClick);
            this.D.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.D_CellDoubleClick);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(11, 605);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(147, 27);
            this.add.TabIndex = 52;
            this.add.Text = "Добавить оплату";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Pay_find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 698);
            this.Controls.Add(this.add);
            this.Controls.Add(this.D);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countf);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.next);
            this.Controls.Add(this.pagef);
            this.Name = "Pay_find";
            this.Text = "Список оплат";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pay_find_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.D)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox countf;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.ComboBox pagef;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ascf;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.ComboBox sortf;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox deldatef;
        private System.Windows.Forms.Button bcon;
        private System.Windows.Forms.TextBox contractf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker datefrom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox costfrom;
        private System.Windows.Forms.ComboBox typef;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox branchf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView D;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button btime;
        private System.Windows.Forms.TextBox timef;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox indicatorf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bwor;
        private System.Windows.Forms.TextBox teacherf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox costto;
    }
}