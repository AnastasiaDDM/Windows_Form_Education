namespace Add_Type
{
    partial class Worker_edit
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lrate = new System.Windows.Forms.Label();
            this.phonet = new System.Windows.Forms.MaskedTextBox();
            this.fiot = new System.Windows.Forms.TextBox();
            this.positiont = new System.Windows.Forms.TextBox();
            this.typef = new System.Windows.Forms.ComboBox();
            this.branchf = new System.Windows.Forms.ComboBox();
            this.passwordt = new System.Windows.Forms.TextBox();
            this.ratet = new System.Windows.Forms.MaskedTextBox();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.lrate2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер телефона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Должность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Тип должности";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Филиал";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Пароль";
            // 
            // lrate
            // 
            this.lrate.AutoSize = true;
            this.lrate.Location = new System.Drawing.Point(366, 180);
            this.lrate.Name = "lrate";
            this.lrate.Size = new System.Drawing.Size(54, 17);
            this.lrate.TabIndex = 6;
            this.lrate.Text = "Ставка";
            // 
            // phonet
            // 
            this.phonet.Location = new System.Drawing.Point(141, 224);
            this.phonet.Mask = "+7(999) 000-0000";
            this.phonet.Name = "phonet";
            this.phonet.Size = new System.Drawing.Size(125, 22);
            this.phonet.TabIndex = 7;
            // 
            // fiot
            // 
            this.fiot.Location = new System.Drawing.Point(141, 23);
            this.fiot.Multiline = true;
            this.fiot.Name = "fiot";
            this.fiot.Size = new System.Drawing.Size(415, 42);
            this.fiot.TabIndex = 8;
            // 
            // positiont
            // 
            this.positiont.Location = new System.Drawing.Point(141, 88);
            this.positiont.Multiline = true;
            this.positiont.Name = "positiont";
            this.positiont.Size = new System.Drawing.Size(415, 50);
            this.positiont.TabIndex = 9;
            this.positiont.TextChanged += new System.EventHandler(this.positiont_TextChanged);
            // 
            // typef
            // 
            this.typef.FormattingEnabled = true;
            this.typef.Items.AddRange(new object[] {
            "Директор",
            "Менеджер",
            "Преподаватель"});
            this.typef.Location = new System.Drawing.Point(141, 175);
            this.typef.Name = "typef";
            this.typef.Size = new System.Drawing.Size(205, 24);
            this.typef.TabIndex = 10;
            // 
            // branchf
            // 
            this.branchf.FormattingEnabled = true;
            this.branchf.Location = new System.Drawing.Point(141, 261);
            this.branchf.Name = "branchf";
            this.branchf.Size = new System.Drawing.Size(415, 24);
            this.branchf.TabIndex = 11;
            // 
            // passwordt
            // 
            this.passwordt.Location = new System.Drawing.Point(141, 305);
            this.passwordt.Name = "passwordt";
            this.passwordt.Size = new System.Drawing.Size(415, 22);
            this.passwordt.TabIndex = 12;
            // 
            // ratet
            // 
            this.ratet.Location = new System.Drawing.Point(426, 175);
            this.ratet.Mask = "00000";
            this.ratet.Name = "ratet";
            this.ratet.Size = new System.Drawing.Size(57, 22);
            this.ratet.TabIndex = 13;
            this.ratet.ValidatingType = typeof(int);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(426, 400);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(130, 42);
            this.save.TabIndex = 14;
            this.save.Text = "Сохранить ";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(20, 400);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(130, 42);
            this.cancel.TabIndex = 15;
            this.cancel.Text = "Отменить";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // lrate2
            // 
            this.lrate2.AutoSize = true;
            this.lrate2.Location = new System.Drawing.Point(489, 180);
            this.lrate2.Name = "lrate2";
            this.lrate2.Size = new System.Drawing.Size(35, 17);
            this.lrate2.TabIndex = 16;
            this.lrate2.Text = "руб.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 17;
            // 
            // Worker_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 454);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lrate2);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.ratet);
            this.Controls.Add(this.passwordt);
            this.Controls.Add(this.branchf);
            this.Controls.Add(this.typef);
            this.Controls.Add(this.positiont);
            this.Controls.Add(this.fiot);
            this.Controls.Add(this.phonet);
            this.Controls.Add(this.lrate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Worker_edit";
            this.Text = "Работник №";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lrate;
        private System.Windows.Forms.MaskedTextBox phonet;
        private System.Windows.Forms.TextBox fiot;
        private System.Windows.Forms.TextBox positiont;
        private System.Windows.Forms.ComboBox typef;
        private System.Windows.Forms.ComboBox branchf;
        private System.Windows.Forms.TextBox passwordt;
        private System.Windows.Forms.MaskedTextBox ratet;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label lrate2;
        private System.Windows.Forms.Label label9;
    }
}