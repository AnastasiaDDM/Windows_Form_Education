namespace Add_Type
{
    partial class Contract_view
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
            this.addpay = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.datef = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.DataGridView();
            this.costt = new System.Windows.Forms.Label();
            this.paymentt = new System.Windows.Forms.Label();
            this.studentt = new System.Windows.Forms.LinkLabel();
            this.courset = new System.Windows.Forms.LinkLabel();
            this.managert = new System.Windows.Forms.LinkLabel();
            this.brancht = new System.Windows.Forms.LinkLabel();
            this.bcancel = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.D)).BeginInit();
            this.SuspendLayout();
            // 
            // addpay
            // 
            this.addpay.Location = new System.Drawing.Point(469, 214);
            this.addpay.Name = "addpay";
            this.addpay.Size = new System.Drawing.Size(142, 52);
            this.addpay.TabIndex = 38;
            this.addpay.Text = "Добавить оплату";
            this.addpay.UseVisualStyleBackColor = true;
            this.addpay.Click += new System.EventHandler(this.addpay_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(227, 592);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(142, 41);
            this.close.TabIndex = 37;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // datef
            // 
            this.datef.Location = new System.Drawing.Point(154, 17);
            this.datef.Name = "datef";
            this.datef.Size = new System.Drawing.Size(172, 22);
            this.datef.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Ежемесячная плата";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Стоимость обучения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Наименование курса";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Менеджер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Филиал";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ученик";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 34);
            this.label1.TabIndex = 25;
            this.label1.Text = "Дата заключения\r\nдоговра";
            // 
            // D
            // 
            this.D.AllowUserToAddRows = false;
            this.D.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.D.Location = new System.Drawing.Point(12, 272);
            this.D.Name = "D";
            this.D.RowTemplate.Height = 24;
            this.D.Size = new System.Drawing.Size(599, 266);
            this.D.TabIndex = 39;
            this.D.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.D_CellClick);
            this.D.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.D_CellDoubleClick);
            // 
            // costt
            // 
            this.costt.AutoSize = true;
            this.costt.Location = new System.Drawing.Point(187, 170);
            this.costt.Name = "costt";
            this.costt.Size = new System.Drawing.Size(54, 17);
            this.costt.TabIndex = 44;
            this.costt.Text = "label13";
            // 
            // paymentt
            // 
            this.paymentt.AutoSize = true;
            this.paymentt.Location = new System.Drawing.Point(507, 170);
            this.paymentt.Name = "paymentt";
            this.paymentt.Size = new System.Drawing.Size(54, 17);
            this.paymentt.TabIndex = 45;
            this.paymentt.Text = "label14";
            // 
            // studentt
            // 
            this.studentt.AutoSize = true;
            this.studentt.Location = new System.Drawing.Point(95, 67);
            this.studentt.Name = "studentt";
            this.studentt.Size = new System.Drawing.Size(0, 17);
            this.studentt.TabIndex = 46;
            this.studentt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.studentt_LinkClicked);
            // 
            // courset
            // 
            this.courset.AutoSize = true;
            this.courset.Location = new System.Drawing.Point(512, 67);
            this.courset.Name = "courset";
            this.courset.Size = new System.Drawing.Size(72, 17);
            this.courset.TabIndex = 47;
            this.courset.TabStop = true;
            this.courset.Text = "linkLabel2";
            this.courset.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.courset_LinkClicked);
            // 
            // managert
            // 
            this.managert.AutoSize = true;
            this.managert.Location = new System.Drawing.Point(438, 15);
            this.managert.Name = "managert";
            this.managert.Size = new System.Drawing.Size(72, 17);
            this.managert.TabIndex = 48;
            this.managert.TabStop = true;
            this.managert.Text = "linkLabel3";
            this.managert.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.managert_LinkClicked);
            // 
            // brancht
            // 
            this.brancht.AutoSize = true;
            this.brancht.Location = new System.Drawing.Point(95, 122);
            this.brancht.Name = "brancht";
            this.brancht.Size = new System.Drawing.Size(72, 17);
            this.brancht.TabIndex = 49;
            this.brancht.TabStop = true;
            this.brancht.Text = "linkLabel4";
            this.brancht.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.brancht_LinkClicked);
            // 
            // bcancel
            // 
            this.bcancel.Location = new System.Drawing.Point(12, 544);
            this.bcancel.Name = "bcancel";
            this.bcancel.Size = new System.Drawing.Size(142, 52);
            this.bcancel.TabIndex = 50;
            this.bcancel.Text = "Расторгнуть договор";
            this.bcancel.UseVisualStyleBackColor = true;
            this.bcancel.Click += new System.EventHandler(this.bcancel_Click);
            // 
            // cancel
            // 
            this.cancel.AutoSize = true;
            this.cancel.Location = new System.Drawing.Point(15, 249);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(0, 17);
            this.cancel.TabIndex = 51;
            // 
            // Contract_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 645);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.bcancel);
            this.Controls.Add(this.brancht);
            this.Controls.Add(this.managert);
            this.Controls.Add(this.courset);
            this.Controls.Add(this.studentt);
            this.Controls.Add(this.paymentt);
            this.Controls.Add(this.costt);
            this.Controls.Add(this.addpay);
            this.Controls.Add(this.close);
            this.Controls.Add(this.datef);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.D);
            this.Name = "Contract_view";
            this.Text = "Договор №";
            ((System.ComponentModel.ISupportInitialize)(this.D)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addpay;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.DateTimePicker datef;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView D;
        private System.Windows.Forms.Label costt;
        private System.Windows.Forms.Label paymentt;
        private System.Windows.Forms.LinkLabel studentt;
        private System.Windows.Forms.LinkLabel courset;
        private System.Windows.Forms.LinkLabel managert;
        private System.Windows.Forms.LinkLabel brancht;
        private System.Windows.Forms.Button bcancel;
        private System.Windows.Forms.Label cancel;
    }
}