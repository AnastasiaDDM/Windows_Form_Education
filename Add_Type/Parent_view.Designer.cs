namespace Add_Type
{
    partial class Parent_view
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
            this.close = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fiot = new System.Windows.Forms.Label();
            this.phonet = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.DataGridView();
            this.choosestudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.D)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(185, 407);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(126, 42);
            this.close.TabIndex = 21;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Номер телефона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "ФИО ";
            // 
            // fiot
            // 
            this.fiot.AutoSize = true;
            this.fiot.Location = new System.Drawing.Point(147, 18);
            this.fiot.Name = "fiot";
            this.fiot.Size = new System.Drawing.Size(46, 17);
            this.fiot.TabIndex = 22;
            this.fiot.Text = "label1";
            // 
            // phonet
            // 
            this.phonet.AutoSize = true;
            this.phonet.Location = new System.Drawing.Point(147, 76);
            this.phonet.Name = "phonet";
            this.phonet.Size = new System.Drawing.Size(46, 17);
            this.phonet.TabIndex = 23;
            this.phonet.Text = "label2";
            // 
            // D
            // 
            this.D.AllowUserToAddRows = false;
            this.D.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.D.Location = new System.Drawing.Point(15, 119);
            this.D.Name = "D";
            this.D.RowTemplate.Height = 24;
            this.D.Size = new System.Drawing.Size(503, 203);
            this.D.TabIndex = 24;
            // 
            // choosestudent
            // 
            this.choosestudent.Location = new System.Drawing.Point(15, 328);
            this.choosestudent.Name = "choosestudent";
            this.choosestudent.Size = new System.Drawing.Size(149, 26);
            this.choosestudent.TabIndex = 25;
            this.choosestudent.Text = "Добавить ученика";
            this.choosestudent.UseVisualStyleBackColor = true;
            this.choosestudent.Click += new System.EventHandler(this.choosestudent_Click);
            // 
            // Parent_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 461);
            this.Controls.Add(this.choosestudent);
            this.Controls.Add(this.D);
            this.Controls.Add(this.phonet);
            this.Controls.Add(this.fiot);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Parent_view";
            this.Text = "Ответственное лицо№";
            ((System.ComponentModel.ISupportInitialize)(this.D)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fiot;
        private System.Windows.Forms.Label phonet;
        private System.Windows.Forms.DataGridView D;
        private System.Windows.Forms.Button choosestudent;
    }
}