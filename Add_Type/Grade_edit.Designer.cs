﻿namespace Add_Type
{
    partial class Grade_edit
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
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.datet = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.teacherst = new System.Windows.Forms.Label();
            this.themet = new System.Windows.Forms.LinkLabel();
            this.courset = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.D)).BeginInit();
            this.SuspendLayout();
            // 
            // D
            // 
            this.D.AllowUserToAddRows = false;
            this.D.AllowUserToDeleteRows = false;
            this.D.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.D.Location = new System.Drawing.Point(12, 116);
            this.D.Name = "D";
            this.D.RowTemplate.Height = 24;
            this.D.Size = new System.Drawing.Size(632, 457);
            this.D.TabIndex = 0;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(521, 645);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(123, 41);
            this.save.TabIndex = 3;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(12, 645);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(123, 41);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Отменить";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // datet
            // 
            this.datet.AutoSize = true;
            this.datet.Location = new System.Drawing.Point(499, 18);
            this.datet.Name = "datet";
            this.datet.Size = new System.Drawing.Size(42, 17);
            this.datet.TabIndex = 6;
            this.datet.Text = "Дата";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(502, 66);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(142, 44);
            this.add.TabIndex = 7;
            this.add.Text = "Добавить еще оценку";
            this.add.UseVisualStyleBackColor = true;
            // 
            // teacherst
            // 
            this.teacherst.AutoSize = true;
            this.teacherst.Location = new System.Drawing.Point(132, 54);
            this.teacherst.Name = "teacherst";
            this.teacherst.Size = new System.Drawing.Size(46, 17);
            this.teacherst.TabIndex = 56;
            this.teacherst.Text = "label4";
            // 
            // themet
            // 
            this.themet.AutoSize = true;
            this.themet.Location = new System.Drawing.Point(63, 18);
            this.themet.Name = "themet";
            this.themet.Size = new System.Drawing.Size(72, 17);
            this.themet.TabIndex = 55;
            this.themet.TabStop = true;
            this.themet.Text = "linkLabel3";
            // 
            // courset
            // 
            this.courset.AutoSize = true;
            this.courset.Location = new System.Drawing.Point(240, 93);
            this.courset.Name = "courset";
            this.courset.Size = new System.Drawing.Size(72, 17);
            this.courset.TabIndex = 54;
            this.courset.TabStop = true;
            this.courset.Text = "linkLabel1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 53;
            this.label5.Text = "Название курса";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 52;
            this.label6.Text = "Преподаватели";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 51;
            this.label7.Text = "Тема";
            // 
            // Grade_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 694);
            this.Controls.Add(this.teacherst);
            this.Controls.Add(this.themet);
            this.Controls.Add(this.courset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.add);
            this.Controls.Add(this.datet);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.D);
            this.Name = "Grade_edit";
            this.Text = "Редактирование успеваемости";
            ((System.ComponentModel.ISupportInitialize)(this.D)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView D;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label datet;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label teacherst;
        private System.Windows.Forms.LinkLabel themet;
        private System.Windows.Forms.LinkLabel courset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}