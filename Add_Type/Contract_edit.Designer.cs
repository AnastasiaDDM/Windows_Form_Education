namespace Add_Type
{
    partial class Contract_edit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.datef = new System.Windows.Forms.DateTimePicker();
            this.branchf = new System.Windows.Forms.ComboBox();
            this.bstud = new System.Windows.Forms.Button();
            this.bcour = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.studentt = new System.Windows.Forms.Label();
            this.courset = new System.Windows.Forms.Label();
            this.costt = new System.Windows.Forms.MaskedTextBox();
            this.payt = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата заключения\r\nдоговра";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Клиент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Филиал ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "Наименование \r\nкурса";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 34);
            this.label6.TabIndex = 5;
            this.label6.Text = "Стоимость\r\n обучения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ежемесячная плата";
            // 
            // datef
            // 
            this.datef.Location = new System.Drawing.Point(144, 21);
            this.datef.Name = "datef";
            this.datef.Size = new System.Drawing.Size(172, 22);
            this.datef.TabIndex = 7;
            // 
            // branchf
            // 
            this.branchf.FormattingEnabled = true;
            this.branchf.Location = new System.Drawing.Point(421, 18);
            this.branchf.Name = "branchf";
            this.branchf.Size = new System.Drawing.Size(239, 24);
            this.branchf.TabIndex = 13;
            // 
            // bstud
            // 
            this.bstud.Location = new System.Drawing.Point(421, 80);
            this.bstud.Name = "bstud";
            this.bstud.Size = new System.Drawing.Size(167, 27);
            this.bstud.TabIndex = 14;
            this.bstud.Text = "Найти ученика";
            this.bstud.UseVisualStyleBackColor = true;
            this.bstud.Click += new System.EventHandler(this.bstud_Click);
            // 
            // bcour
            // 
            this.bcour.Location = new System.Drawing.Point(421, 155);
            this.bcour.Name = "bcour";
            this.bcour.Size = new System.Drawing.Size(167, 27);
            this.bcour.TabIndex = 15;
            this.bcour.Text = "Найти курс";
            this.bcour.UseVisualStyleBackColor = true;
            this.bcour.Click += new System.EventHandler(this.bcour_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(525, 334);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(142, 41);
            this.save.TabIndex = 16;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(17, 334);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(142, 41);
            this.cancel.TabIndex = 17;
            this.cancel.Text = "Отменить";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // studentt
            // 
            this.studentt.Location = new System.Drawing.Point(141, 85);
            this.studentt.Name = "studentt";
            this.studentt.Size = new System.Drawing.Size(175, 22);
            this.studentt.TabIndex = 0;
            this.studentt.Text = "Клиент не выбран";
            // 
            // courset
            // 
            this.courset.Location = new System.Drawing.Point(141, 160);
            this.courset.Name = "courset";
            this.courset.Size = new System.Drawing.Size(156, 19);
            this.courset.TabIndex = 20;
            this.courset.Text = "Курс не выбран";
            // 
            // costt
            // 
            this.costt.Location = new System.Drawing.Point(144, 222);
            this.costt.Mask = "00000";
            this.costt.Name = "costt";
            this.costt.Size = new System.Drawing.Size(64, 22);
            this.costt.TabIndex = 22;
            this.costt.ValidatingType = typeof(int);
            // 
            // payt
            // 
            this.payt.Location = new System.Drawing.Point(506, 222);
            this.payt.Mask = "00000";
            this.payt.Name = "payt";
            this.payt.Size = new System.Drawing.Size(56, 22);
            this.payt.TabIndex = 23;
            this.payt.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "руб.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(580, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "руб.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 44;
            // 
            // Contract_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 400);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.payt);
            this.Controls.Add(this.costt);
            this.Controls.Add(this.courset);
            this.Controls.Add(this.studentt);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.bcour);
            this.Controls.Add(this.bstud);
            this.Controls.Add(this.branchf);
            this.Controls.Add(this.datef);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Contract_edit";
            this.Text = "Редактирование договора №";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Contract_edit_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datef;
        private System.Windows.Forms.ComboBox branchf;
        private System.Windows.Forms.Button bstud;
        private System.Windows.Forms.Button bcour;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label studentt;
        private System.Windows.Forms.Label courset;
        private System.Windows.Forms.MaskedTextBox costt;
        private System.Windows.Forms.MaskedTextBox payt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}