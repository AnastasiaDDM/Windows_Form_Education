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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.homeworkt = new System.Windows.Forms.TextBox();
            this.namet = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.datenull = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teacherf = new System.Windows.Forms.TextBox();
            this.bteach = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.deadlinecountt = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deadlinecountt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название темы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Домашняя работа";
            // 
            // homeworkt
            // 
            this.homeworkt.Location = new System.Drawing.Point(149, 101);
            this.homeworkt.Multiline = true;
            this.homeworkt.Name = "homeworkt";
            this.homeworkt.Size = new System.Drawing.Size(511, 109);
            this.homeworkt.TabIndex = 5;
            // 
            // namet
            // 
            this.namet.Location = new System.Drawing.Point(149, 12);
            this.namet.Multiline = true;
            this.namet.Name = "namet";
            this.namet.Size = new System.Drawing.Size(511, 74);
            this.namet.TabIndex = 7;
            this.namet.TextChanged += new System.EventHandler(this.namet_TextChanged);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(542, 373);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(118, 44);
            this.save.TabIndex = 10;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(15, 373);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(118, 44);
            this.cancel.TabIndex = 11;
            this.cancel.Text = "Отменить";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // datenull
            // 
            this.datenull.AutoSize = true;
            this.datenull.Location = new System.Drawing.Point(339, 250);
            this.datenull.Name = "datenull";
            this.datenull.Size = new System.Drawing.Size(0, 17);
            this.datenull.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Преподаватель";
            // 
            // teacherf
            // 
            this.teacherf.Location = new System.Drawing.Point(149, 302);
            this.teacherf.Multiline = true;
            this.teacherf.Name = "teacherf";
            this.teacherf.ReadOnly = true;
            this.teacherf.Size = new System.Drawing.Size(278, 22);
            this.teacherf.TabIndex = 44;
            // 
            // bteach
            // 
            this.bteach.Location = new System.Drawing.Point(429, 301);
            this.bteach.Name = "bteach";
            this.bteach.Size = new System.Drawing.Size(23, 23);
            this.bteach.TabIndex = 45;
            this.bteach.Text = "🔍";
            this.bteach.UseVisualStyleBackColor = true;
            this.bteach.Click += new System.EventHandler(this.bteach_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 34);
            this.label5.TabIndex = 46;
            this.label5.Text = "Количество дней \r\nна выполнение домашней работы";
            // 
            // deadlinecountt
            // 
            this.deadlinecountt.Location = new System.Drawing.Point(264, 245);
            this.deadlinecountt.Name = "deadlinecountt";
            this.deadlinecountt.Size = new System.Drawing.Size(120, 22);
            this.deadlinecountt.TabIndex = 47;
            // 
            // Theme_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 428);
            this.Controls.Add(this.deadlinecountt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.teacherf);
            this.Controls.Add(this.bteach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datenull);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.namet);
            this.Controls.Add(this.homeworkt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Theme_edit";
            this.Text = "Тема №";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Theme_edit_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deadlinecountt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox homeworkt;
        private System.Windows.Forms.TextBox namet;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label datenull;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teacherf;
        private System.Windows.Forms.Button bteach;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown deadlinecountt;
        private System.Windows.Forms.Label label5;
    }
}