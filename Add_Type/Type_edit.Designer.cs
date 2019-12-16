namespace Add_Type
{
    partial class Type_edit
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.namet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.notet = new System.Windows.Forms.TextBox();
            this.lessont = new System.Windows.Forms.NumericUpDown();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.costt = new System.Windows.Forms.MaskedTextBox();
            this.montht = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lessont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.montht)).BeginInit();
            this.SuspendLayout();
            // 
            // namet
            // 
            this.namet.Location = new System.Drawing.Point(96, 26);
            this.namet.Multiline = true;
            this.namet.Name = "namet";
            this.namet.Size = new System.Drawing.Size(487, 54);
            this.namet.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название \r\nтипа курса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Стоимость курса";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Количество занятий";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Количество месяцев";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Описание";
            // 
            // notet
            // 
            this.notet.Location = new System.Drawing.Point(96, 213);
            this.notet.Multiline = true;
            this.notet.Name = "notet";
            this.notet.Size = new System.Drawing.Size(487, 87);
            this.notet.TabIndex = 9;
            // 
            // lessont
            // 
            this.lessont.Location = new System.Drawing.Point(166, 160);
            this.lessont.Name = "lessont";
            this.lessont.Size = new System.Drawing.Size(107, 22);
            this.lessont.TabIndex = 11;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(451, 366);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(131, 40);
            this.save.TabIndex = 12;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(11, 366);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(131, 40);
            this.cancel.TabIndex = 13;
            this.cancel.Text = "Отменить";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // costt
            // 
            this.costt.Location = new System.Drawing.Point(166, 109);
            this.costt.Mask = "00000";
            this.costt.Name = "costt";
            this.costt.Size = new System.Drawing.Size(70, 22);
            this.costt.TabIndex = 14;
            this.costt.ValidatingType = typeof(int);
            // 
            // montht
            // 
            this.montht.Location = new System.Drawing.Point(476, 160);
            this.montht.Name = "montht";
            this.montht.Size = new System.Drawing.Size(107, 22);
            this.montht.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "руб.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 20;
            // 
            // Type_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 425);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.montht);
            this.Controls.Add(this.costt);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.lessont);
            this.Controls.Add(this.notet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.namet);
            this.Name = "Type_edit";
            this.Text = "Тип курса №";
            ((System.ComponentModel.ISupportInitialize)(this.lessont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.montht)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox notet;
        private System.Windows.Forms.NumericUpDown lessont;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.MaskedTextBox costt;
        private System.Windows.Forms.NumericUpDown montht;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}

