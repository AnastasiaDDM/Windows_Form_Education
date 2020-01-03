namespace Add_Type
{
    partial class Pay_edit
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datef = new System.Windows.Forms.DateTimePicker();
            this.typef = new System.Windows.Forms.ComboBox();
            this.purposef = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.contractt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.indicatorf = new System.Windows.Forms.ComboBox();
            this.btime = new System.Windows.Forms.Button();
            this.timetablef = new System.Windows.Forms.TextBox();
            this.bcon = new System.Windows.Forms.Button();
            this.contractf = new System.Windows.Forms.TextBox();
            this.bteach = new System.Windows.Forms.Button();
            this.teacherf = new System.Windows.Forms.TextBox();
            this.branchf = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.paymentt = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.erpay = new System.Windows.Forms.ErrorProvider(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.incomef = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erpay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Договор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Размер оплаты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Способ оплаты";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Назначение";
            // 
            // datef
            // 
            this.datef.Location = new System.Drawing.Point(402, 4);
            this.datef.Name = "datef";
            this.datef.Size = new System.Drawing.Size(166, 22);
            this.datef.TabIndex = 7;
            // 
            // typef
            // 
            this.typef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typef.FormattingEnabled = true;
            this.typef.Items.AddRange(new object[] {
            "Не выбрано",
            "Наличный расчет",
            "Безналичный расчет"});
            this.typef.Location = new System.Drawing.Point(383, 188);
            this.typef.Name = "typef";
            this.typef.Size = new System.Drawing.Size(185, 24);
            this.typef.TabIndex = 8;
            this.typef.SelectionChangeCommitted += new System.EventHandler(this.typef_SelectionChangeCommitted);
            // 
            // purposef
            // 
            this.purposef.Location = new System.Drawing.Point(128, 285);
            this.purposef.Multiline = true;
            this.purposef.Name = "purposef";
            this.purposef.Size = new System.Drawing.Size(440, 95);
            this.purposef.TabIndex = 9;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(448, 395);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(124, 45);
            this.save.TabIndex = 10;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(11, 395);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(124, 45);
            this.cancel.TabIndex = 11;
            this.cancel.Text = "Отменить";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // contractt
            // 
            this.contractt.AutoSize = true;
            this.contractt.Location = new System.Drawing.Point(135, 56);
            this.contractt.Name = "contractt";
            this.contractt.Size = new System.Drawing.Size(0, 17);
            this.contractt.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "/ Преподаватель";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 34);
            this.label9.TabIndex = 52;
            this.label9.Text = "Индикатор \r\nоплаты";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(196, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 34);
            this.label10.TabIndex = 54;
            this.label10.Text = "Занятие \r\nдля оплаты";
            // 
            // indicatorf
            // 
            this.indicatorf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.indicatorf.FormattingEnabled = true;
            this.indicatorf.Items.AddRange(new object[] {
            "Не выбрано",
            "Оплата по договору",
            "Зарплата сотрудникам"});
            this.indicatorf.Location = new System.Drawing.Point(138, 6);
            this.indicatorf.Name = "indicatorf";
            this.indicatorf.Size = new System.Drawing.Size(196, 24);
            this.indicatorf.TabIndex = 53;
            this.indicatorf.SelectionChangeCommitted += new System.EventHandler(this.indicatorf_SelectionChangeCommitted);
            // 
            // btime
            // 
            this.btime.Location = new System.Drawing.Point(520, 101);
            this.btime.Name = "btime";
            this.btime.Size = new System.Drawing.Size(23, 23);
            this.btime.TabIndex = 60;
            this.btime.Text = "🔍";
            this.btime.UseVisualStyleBackColor = true;
            this.btime.Click += new System.EventHandler(this.btime_Click);
            // 
            // timetablef
            // 
            this.timetablef.Location = new System.Drawing.Point(287, 103);
            this.timetablef.Multiline = true;
            this.timetablef.Name = "timetablef";
            this.timetablef.ReadOnly = true;
            this.timetablef.Size = new System.Drawing.Size(232, 20);
            this.timetablef.TabIndex = 59;
            // 
            // bcon
            // 
            this.bcon.Location = new System.Drawing.Point(246, 75);
            this.bcon.Name = "bcon";
            this.bcon.Size = new System.Drawing.Size(23, 23);
            this.bcon.TabIndex = 62;
            this.bcon.Text = "🔍";
            this.bcon.UseVisualStyleBackColor = true;
            this.bcon.Click += new System.EventHandler(this.bcon_Click);
            // 
            // contractf
            // 
            this.contractf.Location = new System.Drawing.Point(85, 76);
            this.contractf.Multiline = true;
            this.contractf.Name = "contractf";
            this.contractf.ReadOnly = true;
            this.contractf.Size = new System.Drawing.Size(161, 20);
            this.contractf.TabIndex = 61;
            // 
            // bteach
            // 
            this.bteach.Location = new System.Drawing.Point(520, 73);
            this.bteach.Name = "bteach";
            this.bteach.Size = new System.Drawing.Size(23, 23);
            this.bteach.TabIndex = 64;
            this.bteach.Text = "🔍";
            this.bteach.UseVisualStyleBackColor = true;
            this.bteach.Click += new System.EventHandler(this.bteach_Click);
            // 
            // teacherf
            // 
            this.teacherf.Location = new System.Drawing.Point(287, 75);
            this.teacherf.Multiline = true;
            this.teacherf.Name = "teacherf";
            this.teacherf.ReadOnly = true;
            this.teacherf.Size = new System.Drawing.Size(232, 20);
            this.teacherf.TabIndex = 63;
            this.teacherf.TextChanged += new System.EventHandler(this.teacherf_TextChanged);
            // 
            // branchf
            // 
            this.branchf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchf.FormattingEnabled = true;
            this.branchf.Location = new System.Drawing.Point(85, 144);
            this.branchf.Name = "branchf";
            this.branchf.Size = new System.Drawing.Size(196, 24);
            this.branchf.TabIndex = 66;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 65;
            this.label11.Text = "Филиал";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 69;
            this.label8.Text = "руб.";
            // 
            // paymentt
            // 
            this.paymentt.Location = new System.Drawing.Point(128, 186);
            this.paymentt.Mask = "00000";
            this.paymentt.Name = "paymentt";
            this.paymentt.Size = new System.Drawing.Size(74, 22);
            this.paymentt.TabIndex = 70;
            this.paymentt.ValidatingType = typeof(int);
            this.paymentt.TextChanged += new System.EventHandler(this.paymentt_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 17);
            this.label12.TabIndex = 71;
            // 
            // erpay
            // 
            this.erpay.ContainerControl = this;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(374, 17);
            this.label13.TabIndex = 72;
            this.label13.Text = "Выберите этот параметр, если это оплата по договору";
            // 
            // incomef
            // 
            this.incomef.AutoSize = true;
            this.incomef.Location = new System.Drawing.Point(402, 242);
            this.incomef.Name = "incomef";
            this.incomef.Size = new System.Drawing.Size(78, 21);
            this.incomef.TabIndex = 73;
            this.incomef.Text = "Приход";
            this.incomef.UseVisualStyleBackColor = true;
            this.incomef.CheckedChanged += new System.EventHandler(this.incomef_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Pay_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 452);
            this.Controls.Add(this.incomef);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.paymentt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.branchf);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bteach);
            this.Controls.Add(this.teacherf);
            this.Controls.Add(this.bcon);
            this.Controls.Add(this.contractf);
            this.Controls.Add(this.btime);
            this.Controls.Add(this.timetablef);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.indicatorf);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.contractt);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.purposef);
            this.Controls.Add(this.typef);
            this.Controls.Add(this.datef);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pay_edit";
            this.Text = "Редактирование оплаты №";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pay_edit_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.erpay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datef;
        private System.Windows.Forms.ComboBox typef;
        private System.Windows.Forms.TextBox purposef;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label contractt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox indicatorf;
        private System.Windows.Forms.Button btime;
        private System.Windows.Forms.TextBox timetablef;
        private System.Windows.Forms.Button bcon;
        private System.Windows.Forms.TextBox contractf;
        private System.Windows.Forms.Button bteach;
        private System.Windows.Forms.TextBox teacherf;
        private System.Windows.Forms.ComboBox branchf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox paymentt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider erpay;
        private System.Windows.Forms.CheckBox incomef;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}