namespace Add_Type
{
    partial class Cabinet_find
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
            this.D = new System.Windows.Forms.DataGridView();
            this.pagef = new System.Windows.Forms.ComboBox();
            this.next = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.countf = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numbert = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ascf = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.sortf = new System.Windows.Forms.ComboBox();
            this.find = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.branchf = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deldatef = new System.Windows.Forms.CheckBox();
            this.add = new System.Windows.Forms.Button();
            this.free = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.D)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            this.SuspendLayout();
            // 
            // D
            // 
            this.D.AllowUserToAddRows = false;
            this.D.AllowUserToDeleteRows = false;
            this.D.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.D.Location = new System.Drawing.Point(6, 80);
            this.D.Name = "D";
            this.D.RowTemplate.Height = 24;
            this.D.Size = new System.Drawing.Size(932, 545);
            this.D.TabIndex = 1;
            this.D.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.D_CellContentClick);
            this.D.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.D_CellDoubleClick);
            // 
            // pagef
            // 
            this.pagef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pagef.FormattingEnabled = true;
            this.pagef.Location = new System.Drawing.Point(424, 694);
            this.pagef.Name = "pagef";
            this.pagef.Size = new System.Drawing.Size(77, 24);
            this.pagef.TabIndex = 2;
            this.pagef.SelectionChangeCommitted += new System.EventHandler(this.pagef_SelectionChangeCommitted);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(507, 689);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(106, 32);
            this.next.TabIndex = 3;
            this.next.Text = "Вперед ▶";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(312, 689);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(106, 32);
            this.prev.TabIndex = 4;
            this.prev.Text = "◀ Назад";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
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
            this.countf.Location = new System.Drawing.Point(736, 693);
            this.countf.Name = "countf";
            this.countf.Size = new System.Drawing.Size(106, 24);
            this.countf.TabIndex = 5;
            this.countf.SelectionChangeCommitted += new System.EventHandler(this.countf_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(643, 696);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Показывать";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(848, 696);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "записей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Номер кабинета";
            // 
            // numbert
            // 
            this.numbert.Location = new System.Drawing.Point(130, 18);
            this.numbert.Multiline = true;
            this.numbert.Name = "numbert";
            this.numbert.Size = new System.Drawing.Size(164, 20);
            this.numbert.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ascf);
            this.groupBox1.Controls.Add(this.reset);
            this.groupBox1.Controls.Add(this.sortf);
            this.groupBox1.Controls.Add(this.find);
            this.groupBox1.Controls.Add(this.max);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.min);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.branchf);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.deldatef);
            this.groupBox1.Controls.Add(this.numbert);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 74);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // ascf
            // 
            this.ascf.Location = new System.Drawing.Point(611, 46);
            this.ascf.Name = "ascf";
            this.ascf.Size = new System.Drawing.Size(42, 23);
            this.ascf.TabIndex = 40;
            this.ascf.Text = "А-Я";
            this.ascf.UseVisualStyleBackColor = true;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(702, 44);
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
            this.sortf.Location = new System.Drawing.Point(431, 45);
            this.sortf.Name = "sortf";
            this.sortf.Size = new System.Drawing.Size(180, 24);
            this.sortf.TabIndex = 12;
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(803, 18);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(127, 46);
            this.find.TabIndex = 11;
            this.find.Text = "Поиск";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(239, 45);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(55, 22);
            this.max.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Сортировать по ";
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(130, 45);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(62, 22);
            this.min.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Макс.";
            // 
            // branchf
            // 
            this.branchf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchf.FormattingEnabled = true;
            this.branchf.Location = new System.Drawing.Point(381, 17);
            this.branchf.Name = "branchf";
            this.branchf.Size = new System.Drawing.Size(230, 24);
            this.branchf.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Мин. вместимость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Филиал";
            // 
            // deldatef
            // 
            this.deldatef.AutoSize = true;
            this.deldatef.Location = new System.Drawing.Point(627, 7);
            this.deldatef.Name = "deldatef";
            this.deldatef.Size = new System.Drawing.Size(170, 21);
            this.deldatef.TabIndex = 10;
            this.deldatef.Text = "Только неудаленные";
            this.deldatef.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(6, 631);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(147, 27);
            this.add.TabIndex = 52;
            this.add.Text = "Добавить кабинет";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // free
            // 
            this.free.Location = new System.Drawing.Point(791, 631);
            this.free.Name = "free";
            this.free.Size = new System.Drawing.Size(147, 27);
            this.free.TabIndex = 53;
            this.free.Text = "Свободные сейчас";
            this.free.UseVisualStyleBackColor = true;
            this.free.Click += new System.EventHandler(this.free_Click);
            // 
            // Cabinet_find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 727);
            this.Controls.Add(this.free);
            this.Controls.Add(this.add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countf);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.next);
            this.Controls.Add(this.pagef);
            this.Controls.Add(this.D);
            this.Name = "Cabinet_find";
            this.Text = "Список кабинетов";
            ((System.ComponentModel.ISupportInitialize)(this.D)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView D;
        private System.Windows.Forms.ComboBox pagef;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.ComboBox countf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numbert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown max;
        private System.Windows.Forms.NumericUpDown min;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox branchf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox deldatef;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.ComboBox sortf;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ascf;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button free;
    }
}