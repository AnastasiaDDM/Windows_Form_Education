﻿namespace Add_Type
{
    partial class Student_edit
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
            this.fio = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.MaskedTextBox();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО ученика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер телефона";
            // 
            // fio
            // 
            this.fio.Location = new System.Drawing.Point(136, 12);
            this.fio.Multiline = true;
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(361, 36);
            this.fio.TabIndex = 2;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(136, 59);
            this.phone.Mask = "+7(999) 000-0000";
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(122, 22);
            this.phone.TabIndex = 3;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(391, 114);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(126, 42);
            this.save.TabIndex = 4;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(4, 114);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(126, 42);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Отменить";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // Student_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 194);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Student_edit";
            this.Text = "Редактировать ученика №";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fio;
        private System.Windows.Forms.MaskedTextBox phone;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label3;
    }
}