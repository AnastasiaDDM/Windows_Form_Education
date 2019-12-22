namespace Add_Type
{
    partial class Visit_find
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
            this.deldatef = new System.Windows.Forms.CheckBox();
            this.visitf = new System.Windows.Forms.ComboBox();
            this.sortf = new System.Windows.Forms.ComboBox();
            this.find = new System.Windows.Forms.Button();
            this.ascf = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.dateto = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.datefrom = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.bthem = new System.Windows.Forms.Button();
            this.themef = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bcour = new System.Windows.Forms.Button();
            this.coursef = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bstud = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.studentf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.countf = new System.Windows.Forms.ComboBox();
            this.prev = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.pagef = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.D)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deldatef);
            this.groupBox1.Controls.Add(this.visitf);
            this.groupBox1.Controls.Add(this.sortf);
            this.groupBox1.Controls.Add(this.find);
            this.groupBox1.Controls.Add(this.ascf);
            this.groupBox1.Controls.Add(this.reset);
            this.groupBox1.Controls.Add(this.dateto);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.datefrom);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.bthem);
            this.groupBox1.Controls.Add(this.themef);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.bcour);
            this.groupBox1.Controls.Add(this.coursef);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.bstud);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.studentf);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(4, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1079, 72);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // deldatef
            // 
            this.deldatef.AutoSize = true;
            this.deldatef.Location = new System.Drawing.Point(913, 4);
            this.deldatef.Name = "deldatef";
            this.deldatef.Size = new System.Drawing.Size(170, 21);
            this.deldatef.TabIndex = 20;
            this.deldatef.Text = "Только неудаленные";
            this.deldatef.UseVisualStyleBackColor = true;
            // 
            // visitf
            // 
            this.visitf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.visitf.FormattingEnabled = true;
            this.visitf.Items.AddRange(new object[] {
            "Не выбрано",
            "Присутствует",
            "Отсутствует"});
            this.visitf.Location = new System.Drawing.Point(102, 7);
            this.visitf.Name = "visitf";
            this.visitf.Size = new System.Drawing.Size(121, 24);
            this.visitf.TabIndex = 58;
            // 
            // sortf
            // 
            this.sortf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortf.FormattingEnabled = true;
            this.sortf.Location = new System.Drawing.Point(593, 43);
            this.sortf.Name = "sortf";
            this.sortf.Size = new System.Drawing.Size(180, 24);
            this.sortf.TabIndex = 56;
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(944, 29);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(122, 37);
            this.find.TabIndex = 52;
            this.find.Text = "Поиск";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // ascf
            // 
            this.ascf.Location = new System.Drawing.Point(776, 45);
            this.ascf.Name = "ascf";
            this.ascf.Size = new System.Drawing.Size(42, 23);
            this.ascf.TabIndex = 57;
            this.ascf.Text = "А-Я";
            this.ascf.UseVisualStyleBackColor = true;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(844, 41);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(94, 27);
            this.reset.TabIndex = 51;
            this.reset.Text = "Отменить";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // dateto
            // 
            this.dateto.Location = new System.Drawing.Point(742, 15);
            this.dateto.Name = "dateto";
            this.dateto.Size = new System.Drawing.Size(165, 22);
            this.dateto.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(715, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 17);
            this.label13.TabIndex = 40;
            this.label13.Text = "до:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(484, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 55;
            this.label7.Text = "Сортировать по";
            // 
            // datefrom
            // 
            this.datefrom.Location = new System.Drawing.Point(542, 15);
            this.datefrom.Name = "datefrom";
            this.datefrom.Size = new System.Drawing.Size(172, 22);
            this.datefrom.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(481, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 17);
            this.label12.TabIndex = 39;
            this.label12.Text = "Дата от:";
            // 
            // bthem
            // 
            this.bthem.Location = new System.Drawing.Point(210, 39);
            this.bthem.Name = "bthem";
            this.bthem.Size = new System.Drawing.Size(23, 23);
            this.bthem.TabIndex = 54;
            this.bthem.Text = "🔍";
            this.bthem.UseVisualStyleBackColor = true;
            this.bthem.Click += new System.EventHandler(this.bthem_Click);
            // 
            // themef
            // 
            this.themef.Location = new System.Drawing.Point(48, 39);
            this.themef.Multiline = true;
            this.themef.Name = "themef";
            this.themef.ReadOnly = true;
            this.themef.Size = new System.Drawing.Size(161, 20);
            this.themef.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "Тема";
            // 
            // bcour
            // 
            this.bcour.Location = new System.Drawing.Point(454, 36);
            this.bcour.Name = "bcour";
            this.bcour.Size = new System.Drawing.Size(23, 23);
            this.bcour.TabIndex = 46;
            this.bcour.Text = "🔍";
            this.bcour.UseVisualStyleBackColor = true;
            this.bcour.Click += new System.EventHandler(this.bcour_Click);
            // 
            // coursef
            // 
            this.coursef.Location = new System.Drawing.Point(290, 39);
            this.coursef.Multiline = true;
            this.coursef.Name = "coursef";
            this.coursef.ReadOnly = true;
            this.coursef.Size = new System.Drawing.Size(161, 20);
            this.coursef.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(235, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Курс";
            // 
            // bstud
            // 
            this.bstud.Location = new System.Drawing.Point(453, 10);
            this.bstud.Name = "bstud";
            this.bstud.Size = new System.Drawing.Size(23, 23);
            this.bstud.TabIndex = 41;
            this.bstud.Text = "🔍";
            this.bstud.UseVisualStyleBackColor = true;
            this.bstud.Click += new System.EventHandler(this.bstud_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "Присутствие";
            // 
            // studentf
            // 
            this.studentf.Location = new System.Drawing.Point(290, 12);
            this.studentf.Multiline = true;
            this.studentf.Name = "studentf";
            this.studentf.ReadOnly = true;
            this.studentf.Size = new System.Drawing.Size(161, 20);
            this.studentf.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Ученик";
            // 
            // D
            // 
            this.D.AllowUserToAddRows = false;
            this.D.AllowUserToDeleteRows = false;
            this.D.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.D.Location = new System.Drawing.Point(11, 76);
            this.D.Name = "D";
            this.D.RowTemplate.Height = 24;
            this.D.Size = new System.Drawing.Size(1072, 486);
            this.D.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(875, 636);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "записей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(670, 636);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Показывать";
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
            this.countf.Location = new System.Drawing.Point(763, 633);
            this.countf.Name = "countf";
            this.countf.Size = new System.Drawing.Size(106, 24);
            this.countf.TabIndex = 16;
            this.countf.SelectionChangeCommitted += new System.EventHandler(this.countf_SelectionChangeCommitted);
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(321, 631);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(106, 32);
            this.prev.TabIndex = 15;
            this.prev.Text = "◀ Назад";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(535, 631);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(106, 32);
            this.next.TabIndex = 14;
            this.next.Text = "Вперед ▶";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // pagef
            // 
            this.pagef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pagef.FormattingEnabled = true;
            this.pagef.Location = new System.Drawing.Point(442, 630);
            this.pagef.Name = "pagef";
            this.pagef.Size = new System.Drawing.Size(77, 24);
            this.pagef.TabIndex = 13;
            this.pagef.SelectionChangeCommitted += new System.EventHandler(this.pagef_SelectionChangeCommitted);
            // 
            // Visit_find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 666);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countf);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.next);
            this.Controls.Add(this.pagef);
            this.Controls.Add(this.D);
            this.Controls.Add(this.groupBox1);
            this.Name = "Visit_find";
            this.Text = "Список посещаемости";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.D)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox deldatef;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.ComboBox sortf;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button ascf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bthem;
        private System.Windows.Forms.TextBox themef;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bcour;
        private System.Windows.Forms.TextBox coursef;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bstud;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox studentf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker datefrom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox visitf;
        private System.Windows.Forms.DataGridView D;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox countf;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.ComboBox pagef;
    }
}