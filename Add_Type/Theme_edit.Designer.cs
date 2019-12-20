namespace Add_Type
{
    partial class Theme_edit
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
            this.homeworkt = new System.Windows.Forms.TextBox();
            this.datet = new System.Windows.Forms.DateTimePicker();
            this.namet = new System.Windows.Forms.TextBox();
            this.deadlinet = new System.Windows.Forms.DateTimePicker();
            this.coursef = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.bcour = new System.Windows.Forms.Button();
            this.toMark = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название темы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Домашняя работа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата сдачи \r\nдомашней работы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Курс";
            // 
            // homeworkt
            // 
            this.homeworkt.Location = new System.Drawing.Point(149, 267);
            this.homeworkt.Multiline = true;
            this.homeworkt.Name = "homeworkt";
            this.homeworkt.Size = new System.Drawing.Size(511, 109);
            this.homeworkt.TabIndex = 5;
            // 
            // datet
            // 
            this.datet.Location = new System.Drawing.Point(149, 20);
            this.datet.Name = "datet";
            this.datet.Size = new System.Drawing.Size(165, 22);
            this.datet.TabIndex = 6;
            // 
            // namet
            // 
            this.namet.Location = new System.Drawing.Point(149, 131);
            this.namet.Multiline = true;
            this.namet.Name = "namet";
            this.namet.Size = new System.Drawing.Size(511, 109);
            this.namet.TabIndex = 7;
            // 
            // deadlinet
            // 
            this.deadlinet.Location = new System.Drawing.Point(149, 411);
            this.deadlinet.Name = "deadlinet";
            this.deadlinet.Size = new System.Drawing.Size(165, 22);
            this.deadlinet.TabIndex = 8;
            // 
            // coursef
            // 
            this.coursef.Location = new System.Drawing.Point(149, 71);
            this.coursef.Multiline = true;
            this.coursef.Name = "coursef";
            this.coursef.Size = new System.Drawing.Size(315, 34);
            this.coursef.TabIndex = 9;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(555, 476);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(118, 44);
            this.save.TabIndex = 10;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(12, 476);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(118, 44);
            this.cancel.TabIndex = 11;
            this.cancel.Text = "Отменить";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // bcour
            // 
            this.bcour.Location = new System.Drawing.Point(464, 69);
            this.bcour.Name = "bcour";
            this.bcour.Size = new System.Drawing.Size(37, 37);
            this.bcour.TabIndex = 33;
            this.bcour.Text = "🔍";
            this.bcour.UseVisualStyleBackColor = true;
            // 
            // toMark
            // 
            this.toMark.Location = new System.Drawing.Point(555, 69);
            this.toMark.Name = "toMark";
            this.toMark.Size = new System.Drawing.Size(105, 34);
            this.toMark.TabIndex = 34;
            this.toMark.Text = "Оценить";
            this.toMark.UseVisualStyleBackColor = true;
            // 
            // Theme_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 534);
            this.Controls.Add(this.toMark);
            this.Controls.Add(this.bcour);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.coursef);
            this.Controls.Add(this.deadlinet);
            this.Controls.Add(this.namet);
            this.Controls.Add(this.datet);
            this.Controls.Add(this.homeworkt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Theme_edit";
            this.Text = "Тема №";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox homeworkt;
        private System.Windows.Forms.DateTimePicker datet;
        private System.Windows.Forms.TextBox namet;
        private System.Windows.Forms.DateTimePicker deadlinet;
        private System.Windows.Forms.TextBox coursef;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button bcour;
        private System.Windows.Forms.Button toMark;
    }
}