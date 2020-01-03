namespace Add_Type
{
    partial class Theme_view
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
            this.label1 = new System.Windows.Forms.Label();
            this.deadlinet = new System.Windows.Forms.Label();
            this.namet = new System.Windows.Forms.TextBox();
            this.homeworkt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.teachert = new System.Windows.Forms.LinkLabel();
            this.deadlinedatet = new System.Windows.Forms.Label();
            this.addtimetable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(171, 345);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(118, 44);
            this.close.TabIndex = 46;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 51);
            this.label4.TabIndex = 39;
            this.label4.Text = "Кол-во дней \r\nна выполнение\r\nдом. задания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Домашняя работа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Название темы";
            // 
            // deadlinet
            // 
            this.deadlinet.AutoSize = true;
            this.deadlinet.Location = new System.Drawing.Point(125, 241);
            this.deadlinet.Name = "deadlinet";
            this.deadlinet.Size = new System.Drawing.Size(0, 17);
            this.deadlinet.TabIndex = 55;
            // 
            // namet
            // 
            this.namet.Location = new System.Drawing.Point(15, 29);
            this.namet.Multiline = true;
            this.namet.Name = "namet";
            this.namet.ReadOnly = true;
            this.namet.Size = new System.Drawing.Size(418, 69);
            this.namet.TabIndex = 57;
            // 
            // homeworkt
            // 
            this.homeworkt.Location = new System.Drawing.Point(15, 140);
            this.homeworkt.Multiline = true;
            this.homeworkt.Name = "homeworkt";
            this.homeworkt.ReadOnly = true;
            this.homeworkt.Size = new System.Drawing.Size(418, 82);
            this.homeworkt.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "Преподаватель";
            // 
            // teachert
            // 
            this.teachert.AutoSize = true;
            this.teachert.Location = new System.Drawing.Point(124, 310);
            this.teachert.Name = "teachert";
            this.teachert.Size = new System.Drawing.Size(72, 17);
            this.teachert.TabIndex = 59;
            this.teachert.TabStop = true;
            this.teachert.Text = "linkLabel1";
            this.teachert.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.teachert_LinkClicked);
            // 
            // deadlinedatet
            // 
            this.deadlinedatet.AutoSize = true;
            this.deadlinedatet.Location = new System.Drawing.Point(233, 241);
            this.deadlinedatet.Name = "deadlinedatet";
            this.deadlinedatet.Size = new System.Drawing.Size(0, 17);
            this.deadlinedatet.TabIndex = 60;
            // 
            // addtimetable
            // 
            this.addtimetable.Location = new System.Drawing.Point(324, 265);
            this.addtimetable.Name = "addtimetable";
            this.addtimetable.Size = new System.Drawing.Size(109, 44);
            this.addtimetable.TabIndex = 61;
            this.addtimetable.Text = "Добавить на\r\nзанятие";
            this.addtimetable.UseVisualStyleBackColor = true;
            this.addtimetable.Click += new System.EventHandler(this.addtimetable_Click);
            // 
            // Theme_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 401);
            this.Controls.Add(this.addtimetable);
            this.Controls.Add(this.deadlinedatet);
            this.Controls.Add(this.teachert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.namet);
            this.Controls.Add(this.homeworkt);
            this.Controls.Add(this.deadlinet);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Theme_view";
            this.Text = "Тема №";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Theme_view_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label deadlinet;
        private System.Windows.Forms.TextBox namet;
        private System.Windows.Forms.TextBox homeworkt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel teachert;
        private System.Windows.Forms.Label deadlinedatet;
        private System.Windows.Forms.Button addtimetable;
    }
}