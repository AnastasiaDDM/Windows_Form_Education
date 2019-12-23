namespace Add_Type
{
    partial class Worker_find
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
            this.branchf = new System.Windows.Forms.ComboBox();
            this.typef = new System.Windows.Forms.ComboBox();
            this.positionf = new System.Windows.Forms.ComboBox();
            this.sortf = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ascf = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.find = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fiot = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.branchf);
            this.groupBox1.Controls.Add(this.typef);
            this.groupBox1.Controls.Add(this.positionf);
            this.groupBox1.Controls.Add(this.sortf);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ascf);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.reset);
            this.groupBox1.Controls.Add(this.find);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fiot);
            this.groupBox1.Controls.Add(this.deldatef);
            this.groupBox1.Location = new System.Drawing.Point(3, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1158, 71);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // branchf
            // 
            this.branchf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchf.FormattingEnabled = true;
            this.branchf.Location = new System.Drawing.Point(72, 41);
            this.branchf.Name = "branchf";
            this.branchf.Size = new System.Drawing.Size(285, 24);
            this.branchf.TabIndex = 45;
            // 
            // typef
            // 
            this.typef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typef.FormattingEnabled = true;
            this.typef.Items.AddRange(new object[] {
            "Не выбрано ",
            "Директор",
            "Менеджер",
            "Преподаватель"});
            this.typef.Location = new System.Drawing.Point(454, 38);
            this.typef.Name = "typef";
            this.typef.Size = new System.Drawing.Size(169, 24);
            this.typef.TabIndex = 44;
            // 
            // positionf
            // 
            this.positionf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionf.FormattingEnabled = true;
            this.positionf.Location = new System.Drawing.Point(454, 12);
            this.positionf.Name = "positionf";
            this.positionf.Size = new System.Drawing.Size(272, 24);
            this.positionf.TabIndex = 36;
            // 
            // sortf
            // 
            this.sortf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortf.FormattingEnabled = true;
            this.sortf.Location = new System.Drawing.Point(680, 41);
            this.sortf.Name = "sortf";
            this.sortf.Size = new System.Drawing.Size(184, 24);
            this.sortf.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(367, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Должность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Тип";
            // 
            // ascf
            // 
            this.ascf.Location = new System.Drawing.Point(869, 42);
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
            this.label7.Location = new System.Drawing.Point(631, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Сорт.";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(921, 41);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(86, 24);
            this.reset.TabIndex = 23;
            this.reset.Text = "Сбросить";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(1014, 15);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(138, 50);
            this.find.TabIndex = 20;
            this.find.Text = "Поиск";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Филиал";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "ФИО";
            // 
            // fiot
            // 
            this.fiot.Location = new System.Drawing.Point(72, 12);
            this.fiot.Multiline = true;
            this.fiot.Name = "fiot";
            this.fiot.Size = new System.Drawing.Size(285, 22);
            this.fiot.TabIndex = 18;
            // 
            // deldatef
            // 
            this.deldatef.AutoSize = true;
            this.deldatef.Location = new System.Drawing.Point(732, 10);
            this.deldatef.Name = "deldatef";
            this.deldatef.Size = new System.Drawing.Size(251, 21);
            this.deldatef.TabIndex = 19;
            this.deldatef.Text = "Показывать только неудаленные";
            this.deldatef.UseVisualStyleBackColor = true;
            // 
            // D
            // 
            this.D.AllowUserToAddRows = false;
            this.D.AllowUserToDeleteRows = false;
            this.D.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.D.Location = new System.Drawing.Point(3, 75);
            this.D.Name = "D";
            this.D.RowTemplate.Height = 24;
            this.D.Size = new System.Drawing.Size(1158, 528);
            this.D.TabIndex = 33;
            this.D.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.D_CellContentClick);
            this.D.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.D_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(916, 676);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "записей";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(711, 676);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 41;
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
            this.countf.Location = new System.Drawing.Point(804, 673);
            this.countf.Name = "countf";
            this.countf.Size = new System.Drawing.Size(106, 24);
            this.countf.TabIndex = 40;
            this.countf.SelectionChangeCommitted += new System.EventHandler(this.countf_SelectionChangeCommitted);
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(380, 669);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(106, 32);
            this.prev.TabIndex = 39;
            this.prev.Text = "◀ Назад";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(575, 669);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(106, 32);
            this.next.TabIndex = 38;
            this.next.Text = "Вперед ▶";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // pagef
            // 
            this.pagef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pagef.FormattingEnabled = true;
            this.pagef.Location = new System.Drawing.Point(492, 674);
            this.pagef.Name = "pagef";
            this.pagef.Size = new System.Drawing.Size(77, 24);
            this.pagef.TabIndex = 37;
            this.pagef.SelectionChangeCommitted += new System.EventHandler(this.pagef_SelectionChangeCommitted);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(3, 609);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(163, 27);
            this.add.TabIndex = 52;
            this.add.Text = "Добавить работника";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Worker_find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 720);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countf);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.next);
            this.Controls.Add(this.pagef);
            this.Controls.Add(this.D);
            this.Controls.Add(this.groupBox1);
            this.Name = "Worker_find";
            this.Text = "Список работников";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Worker_find_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.D)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox typef;
        private System.Windows.Forms.ComboBox positionf;
        private System.Windows.Forms.ComboBox sortf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ascf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fiot;
        private System.Windows.Forms.CheckBox deldatef;
        private System.Windows.Forms.ComboBox branchf;
        private System.Windows.Forms.DataGridView D;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox countf;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.ComboBox pagef;
        private System.Windows.Forms.Button add;
    }
}