namespace Add_Type
{
    partial class Type_find
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
            this.reset = new System.Windows.Forms.Button();
            this.sortf = new System.Windows.Forms.ComboBox();
            this.find = new System.Windows.Forms.Button();
            this.lessonto = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lessonfrom = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deldatef = new System.Windows.Forms.CheckBox();
            this.namet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.form = new System.Windows.Forms.GroupBox();
            this.monthto = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.ascf = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.costto = new System.Windows.Forms.MaskedTextBox();
            this.monthfrom = new System.Windows.Forms.NumericUpDown();
            this.costfrom = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.countf = new System.Windows.Forms.ComboBox();
            this.prev = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.pagef = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonfrom)).BeginInit();
            this.form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthfrom)).BeginInit();
            this.SuspendLayout();
            // 
            // D
            // 
            this.D.AllowUserToAddRows = false;
            this.D.AllowUserToDeleteRows = false;
            this.D.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.D.Location = new System.Drawing.Point(11, 80);
            this.D.Name = "D";
            this.D.RowTemplate.Height = 24;
            this.D.Size = new System.Drawing.Size(926, 563);
            this.D.TabIndex = 2;
            this.D.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.D_CellContentClick);
            this.D.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.D_CellDoubleClick);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(687, 45);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(89, 24);
            this.reset.TabIndex = 23;
            this.reset.Text = "Сбросить";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // sortf
            // 
            this.sortf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortf.FormattingEnabled = true;
            this.sortf.Location = new System.Drawing.Point(434, 48);
            this.sortf.Name = "sortf";
            this.sortf.Size = new System.Drawing.Size(180, 24);
            this.sortf.TabIndex = 24;
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(800, 31);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(134, 39);
            this.find.TabIndex = 20;
            this.find.Text = "Поиск";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // lessonto
            // 
            this.lessonto.Location = new System.Drawing.Point(465, 17);
            this.lessonto.Name = "lessonto";
            this.lessonto.Size = new System.Drawing.Size(55, 22);
            this.lessonto.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Сортировать по";
            // 
            // lessonfrom
            // 
            this.lessonfrom.Location = new System.Drawing.Point(384, 16);
            this.lessonfrom.Name = "lessonfrom";
            this.lessonfrom.Size = new System.Drawing.Size(56, 22);
            this.lessonfrom.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(442, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "до";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Кол-во занятий от";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Месяцев от:";
            // 
            // deldatef
            // 
            this.deldatef.AutoSize = true;
            this.deldatef.Location = new System.Drawing.Point(764, 4);
            this.deldatef.Name = "deldatef";
            this.deldatef.Size = new System.Drawing.Size(170, 21);
            this.deldatef.TabIndex = 19;
            this.deldatef.Text = "Только неудаленные";
            this.deldatef.UseVisualStyleBackColor = true;
            // 
            // namet
            // 
            this.namet.Location = new System.Drawing.Point(80, 14);
            this.namet.Multiline = true;
            this.namet.Name = "namet";
            this.namet.Size = new System.Drawing.Size(164, 24);
            this.namet.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Название";
            // 
            // form
            // 
            this.form.Controls.Add(this.monthto);
            this.form.Controls.Add(this.label12);
            this.form.Controls.Add(this.ascf);
            this.form.Controls.Add(this.label8);
            this.form.Controls.Add(this.costto);
            this.form.Controls.Add(this.monthfrom);
            this.form.Controls.Add(this.costfrom);
            this.form.Controls.Add(this.label11);
            this.form.Controls.Add(this.label10);
            this.form.Controls.Add(this.reset);
            this.form.Controls.Add(this.label3);
            this.form.Controls.Add(this.sortf);
            this.form.Controls.Add(this.namet);
            this.form.Controls.Add(this.find);
            this.form.Controls.Add(this.deldatef);
            this.form.Controls.Add(this.lessonto);
            this.form.Controls.Add(this.label4);
            this.form.Controls.Add(this.label7);
            this.form.Controls.Add(this.label5);
            this.form.Controls.Add(this.lessonfrom);
            this.form.Controls.Add(this.label6);
            this.form.Location = new System.Drawing.Point(0, -2);
            this.form.Name = "form";
            this.form.Size = new System.Drawing.Size(952, 76);
            this.form.TabIndex = 30;
            this.form.TabStop = false;
            this.form.Text = "Поиск";
            // 
            // monthto
            // 
            this.monthto.Location = new System.Drawing.Point(687, 14);
            this.monthto.Name = "monthto";
            this.monthto.Size = new System.Drawing.Size(55, 22);
            this.monthto.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(666, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 17);
            this.label12.TabIndex = 42;
            this.label12.Text = "до";
            // 
            // ascf
            // 
            this.ascf.Location = new System.Drawing.Point(617, 50);
            this.ascf.Name = "ascf";
            this.ascf.Size = new System.Drawing.Size(51, 23);
            this.ascf.TabIndex = 40;
            this.ascf.Text = "А-Я";
            this.ascf.UseVisualStyleBackColor = true;
            this.ascf.Click += new System.EventHandler(this.ascf_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "руб.";
            // 
            // costto
            // 
            this.costto.Location = new System.Drawing.Point(188, 46);
            this.costto.Mask = "00000";
            this.costto.Name = "costto";
            this.costto.Size = new System.Drawing.Size(71, 22);
            this.costto.TabIndex = 38;
            this.costto.ValidatingType = typeof(int);
            // 
            // monthfrom
            // 
            this.monthfrom.Location = new System.Drawing.Point(619, 15);
            this.monthfrom.Name = "monthfrom";
            this.monthfrom.Size = new System.Drawing.Size(47, 22);
            this.monthfrom.TabIndex = 38;
            // 
            // costfrom
            // 
            this.costfrom.Location = new System.Drawing.Point(73, 46);
            this.costfrom.Mask = "00000";
            this.costfrom.Name = "costfrom";
            this.costfrom.Size = new System.Drawing.Size(71, 22);
            this.costfrom.TabIndex = 37;
            this.costfrom.ValidatingType = typeof(int);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(150, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = " до:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "Цена от:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(820, 695);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "записей";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 695);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 35;
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
            this.countf.Location = new System.Drawing.Point(708, 692);
            this.countf.Name = "countf";
            this.countf.Size = new System.Drawing.Size(106, 24);
            this.countf.TabIndex = 34;
            this.countf.SelectionChangeCommitted += new System.EventHandler(this.countf_SelectionChangeCommitted);
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(284, 688);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(106, 32);
            this.prev.TabIndex = 33;
            this.prev.Text = "◀ Назад";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(479, 688);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(106, 32);
            this.next.TabIndex = 32;
            this.next.Text = "Вперед ▶";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // pagef
            // 
            this.pagef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pagef.FormattingEnabled = true;
            this.pagef.Location = new System.Drawing.Point(396, 693);
            this.pagef.Name = "pagef";
            this.pagef.Size = new System.Drawing.Size(77, 24);
            this.pagef.TabIndex = 31;
            this.pagef.SelectionChangeCommitted += new System.EventHandler(this.pagef_SelectionChangeCommitted);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(11, 649);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(156, 27);
            this.add.TabIndex = 52;
            this.add.Text = "Добавить тип курса";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Type_find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 727);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countf);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.next);
            this.Controls.Add(this.pagef);
            this.Controls.Add(this.form);
            this.Controls.Add(this.D);
            this.Name = "Type_find";
            this.Text = "Список типов курсов";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Type_find_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonfrom)).EndInit();
            this.form.ResumeLayout(false);
            this.form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthfrom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView D;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.ComboBox sortf;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.NumericUpDown lessonto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown lessonfrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox deldatef;
        private System.Windows.Forms.TextBox namet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox form;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown monthfrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox costto;
        private System.Windows.Forms.MaskedTextBox costfrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox countf;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.ComboBox pagef;
        private System.Windows.Forms.Button ascf;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.NumericUpDown monthto;
        private System.Windows.Forms.Label label12;
    }
}