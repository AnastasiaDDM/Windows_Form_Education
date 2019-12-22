namespace Add_Type
{
    partial class Grade_view
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
            this.datet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.Button();
            this.courset = new System.Windows.Forms.LinkLabel();
            this.themet = new System.Windows.Forms.LinkLabel();
            this.teacherst = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.D)).BeginInit();
            this.SuspendLayout();
            // 
            // datet
            // 
            this.datet.AutoSize = true;
            this.datet.Location = new System.Drawing.Point(535, 8);
            this.datet.Name = "datet";
            this.datet.Size = new System.Drawing.Size(42, 17);
            this.datet.TabIndex = 14;
            this.datet.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Название курса";
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(261, 605);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(123, 41);
            this.Close.TabIndex = 12;
            this.Close.Text = "Закрыть";
            this.Close.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Преподаватели";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Тема";
            // 
            // D
            // 
            this.D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.D.Location = new System.Drawing.Point(12, 115);
            this.D.Name = "D";
            this.D.RowTemplate.Height = 24;
            this.D.Size = new System.Drawing.Size(632, 457);
            this.D.TabIndex = 8;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(538, 74);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(106, 34);
            this.update.TabIndex = 31;
            this.update.Text = "Изменить";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // courset
            // 
            this.courset.AutoSize = true;
            this.courset.Location = new System.Drawing.Point(234, 83);
            this.courset.Name = "courset";
            this.courset.Size = new System.Drawing.Size(72, 17);
            this.courset.TabIndex = 47;
            this.courset.TabStop = true;
            this.courset.Text = "linkLabel1";
            // 
            // themet
            // 
            this.themet.AutoSize = true;
            this.themet.Location = new System.Drawing.Point(57, 8);
            this.themet.Name = "themet";
            this.themet.Size = new System.Drawing.Size(72, 17);
            this.themet.TabIndex = 49;
            this.themet.TabStop = true;
            this.themet.Text = "linkLabel3";
            // 
            // teacherst
            // 
            this.teacherst.AutoSize = true;
            this.teacherst.Location = new System.Drawing.Point(126, 44);
            this.teacherst.Name = "teacherst";
            this.teacherst.Size = new System.Drawing.Size(46, 17);
            this.teacherst.TabIndex = 50;
            this.teacherst.Text = "label4";
            // 
            // Grade_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 658);
            this.Controls.Add(this.teacherst);
            this.Controls.Add(this.themet);
            this.Controls.Add(this.courset);
            this.Controls.Add(this.update);
            this.Controls.Add(this.datet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.D);
            this.Name = "Grade_view";
            this.Text = "Успеваемость";
            ((System.ComponentModel.ISupportInitialize)(this.D)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label datet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView D;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.LinkLabel courset;
        private System.Windows.Forms.LinkLabel themet;
        private System.Windows.Forms.Label teacherst;
    }
}