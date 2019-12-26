namespace Add_Type
{
    partial class payAll
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
            this.lableperson = new System.Windows.Forms.Label();
            this.person = new System.Windows.Forms.Label();
            this.datet = new System.Windows.Forms.Label();
            this.labelpay = new System.Windows.Forms.Label();
            this.paymentt = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.bpay = new System.Windows.Forms.Button();
            this.typef = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.branchf = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lableperson
            // 
            this.lableperson.AutoSize = true;
            this.lableperson.Location = new System.Drawing.Point(12, 59);
            this.lableperson.Name = "lableperson";
            this.lableperson.Size = new System.Drawing.Size(0, 17);
            this.lableperson.TabIndex = 0;
            // 
            // person
            // 
            this.person.AutoSize = true;
            this.person.Location = new System.Drawing.Point(85, 59);
            this.person.Name = "person";
            this.person.Size = new System.Drawing.Size(46, 17);
            this.person.TabIndex = 1;
            this.person.Text = "label2";
            // 
            // datet
            // 
            this.datet.AutoSize = true;
            this.datet.Location = new System.Drawing.Point(216, 9);
            this.datet.Name = "datet";
            this.datet.Size = new System.Drawing.Size(46, 17);
            this.datet.TabIndex = 2;
            this.datet.Text = "label3";
            // 
            // labelpay
            // 
            this.labelpay.AutoSize = true;
            this.labelpay.Location = new System.Drawing.Point(15, 114);
            this.labelpay.Name = "labelpay";
            this.labelpay.Size = new System.Drawing.Size(58, 17);
            this.labelpay.TabIndex = 3;
            this.labelpay.Text = "Оплата";
            // 
            // paymentt
            // 
            this.paymentt.AutoSize = true;
            this.paymentt.Location = new System.Drawing.Point(85, 114);
            this.paymentt.Name = "paymentt";
            this.paymentt.Size = new System.Drawing.Size(46, 17);
            this.paymentt.TabIndex = 4;
            this.paymentt.Text = "label5";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(15, 300);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(112, 45);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Отменить";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // bpay
            // 
            this.bpay.Location = new System.Drawing.Point(241, 300);
            this.bpay.Name = "bpay";
            this.bpay.Size = new System.Drawing.Size(112, 45);
            this.bpay.TabIndex = 6;
            this.bpay.Text = "Оплатить";
            this.bpay.UseVisualStyleBackColor = true;
            this.bpay.Click += new System.EventHandler(this.bpay_Click);
            // 
            // typef
            // 
            this.typef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typef.FormattingEnabled = true;
            this.typef.Items.AddRange(new object[] {
            "Не выбрано",
            "Наличный расчет",
            "Безналичный расчет"});
            this.typef.Location = new System.Drawing.Point(88, 154);
            this.typef.Name = "typef";
            this.typef.Size = new System.Drawing.Size(234, 24);
            this.typef.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 34);
            this.label4.TabIndex = 9;
            this.label4.Text = "Способ\r\nоплаты";
            // 
            // branchf
            // 
            this.branchf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchf.FormattingEnabled = true;
            this.branchf.Location = new System.Drawing.Point(88, 199);
            this.branchf.Name = "branchf";
            this.branchf.Size = new System.Drawing.Size(234, 24);
            this.branchf.TabIndex = 68;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 67;
            this.label11.Text = "Филиал";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // payAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 355);
            this.Controls.Add(this.branchf);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.typef);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bpay);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.paymentt);
            this.Controls.Add(this.labelpay);
            this.Controls.Add(this.datet);
            this.Controls.Add(this.person);
            this.Controls.Add(this.lableperson);
            this.Name = "payAll";
            this.Text = "Оплатить все";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lableperson;
        private System.Windows.Forms.Label person;
        private System.Windows.Forms.Label datet;
        private System.Windows.Forms.Label labelpay;
        private System.Windows.Forms.Label paymentt;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button bpay;
        private System.Windows.Forms.ComboBox typef;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox branchf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}