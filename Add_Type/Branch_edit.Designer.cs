namespace Add_Type
{
    partial class Branch_edit
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
            this.namet = new System.Windows.Forms.TextBox();
            this.addresst = new System.Windows.Forms.TextBox();
            this.directorf = new System.Windows.Forms.ComboBox();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.adddirector = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название филиала";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Директор филиала";
            // 
            // namet
            // 
            this.namet.Location = new System.Drawing.Point(170, 32);
            this.namet.Multiline = true;
            this.namet.Name = "namet";
            this.namet.Size = new System.Drawing.Size(458, 70);
            this.namet.TabIndex = 3;
            // 
            // addresst
            // 
            this.addresst.Location = new System.Drawing.Point(170, 127);
            this.addresst.Multiline = true;
            this.addresst.Name = "addresst";
            this.addresst.Size = new System.Drawing.Size(458, 53);
            this.addresst.TabIndex = 4;
            // 
            // directorf
            // 
            this.directorf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.directorf.FormattingEnabled = true;
            this.directorf.Location = new System.Drawing.Point(170, 206);
            this.directorf.Name = "directorf";
            this.directorf.Size = new System.Drawing.Size(458, 24);
            this.directorf.TabIndex = 5;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(541, 292);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(134, 48);
            this.save.TabIndex = 6;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(13, 292);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(134, 48);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Отменить";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // adddirector
            // 
            this.adddirector.Location = new System.Drawing.Point(653, 206);
            this.adddirector.Name = "adddirector";
            this.adddirector.Size = new System.Drawing.Size(29, 24);
            this.adddirector.TabIndex = 8;
            this.adddirector.Text = "➕";
            this.adddirector.UseVisualStyleBackColor = true;
            this.adddirector.Click += new System.EventHandler(this.adddirector_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 9;
            // 
            // Branch_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 352);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adddirector);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.directorf);
            this.Controls.Add(this.addresst);
            this.Controls.Add(this.namet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Branch_edit";
            this.Text = "Редактирование филиала №";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Branch_edit_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox namet;
        private System.Windows.Forms.TextBox addresst;
        private System.Windows.Forms.ComboBox directorf;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button adddirector;
        private System.Windows.Forms.Label label4;
    }
}