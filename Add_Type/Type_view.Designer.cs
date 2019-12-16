namespace Add_Type
{
    partial class Type_view
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
            this.bcour = new System.Windows.Forms.Button();
            this.opentemlate = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.namet = new System.Windows.Forms.Label();
            this.costt = new System.Windows.Forms.Label();
            this.lessont = new System.Windows.Forms.Label();
            this.montht = new System.Windows.Forms.Label();
            this.createtemplate = new System.Windows.Forms.Button();
            this.notet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bcour
            // 
            this.bcour.Location = new System.Drawing.Point(354, 76);
            this.bcour.Name = "bcour";
            this.bcour.Size = new System.Drawing.Size(176, 49);
            this.bcour.TabIndex = 32;
            this.bcour.Text = "Посмотреть курсы\r\nс этим типом";
            this.bcour.UseVisualStyleBackColor = true;
            this.bcour.Click += new System.EventHandler(this.bcour_Click);
            // 
            // opentemlate
            // 
            this.opentemlate.Location = new System.Drawing.Point(399, 203);
            this.opentemlate.Name = "opentemlate";
            this.opentemlate.Size = new System.Drawing.Size(131, 55);
            this.opentemlate.TabIndex = 30;
            this.opentemlate.Text = "Открыть шаблон";
            this.opentemlate.UseVisualStyleBackColor = true;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(210, 361);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(131, 40);
            this.close.TabIndex = 28;
            this.close.Text = "Закрыть ";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Описание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Количество месяцев";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Количество занятий";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Стоимость курса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 34);
            this.label2.TabIndex = 20;
            this.label2.Text = "Название \r\nтипа курса";
            // 
            // namet
            // 
            this.namet.AutoSize = true;
            this.namet.Location = new System.Drawing.Point(169, 9);
            this.namet.Name = "namet";
            this.namet.Size = new System.Drawing.Size(46, 17);
            this.namet.TabIndex = 33;
            this.namet.Text = "label1";
            // 
            // costt
            // 
            this.costt.AutoSize = true;
            this.costt.Location = new System.Drawing.Point(169, 62);
            this.costt.Name = "costt";
            this.costt.Size = new System.Drawing.Size(46, 17);
            this.costt.TabIndex = 34;
            this.costt.Text = "label7";
            // 
            // lessont
            // 
            this.lessont.AutoSize = true;
            this.lessont.Location = new System.Drawing.Point(169, 108);
            this.lessont.Name = "lessont";
            this.lessont.Size = new System.Drawing.Size(46, 17);
            this.lessont.TabIndex = 35;
            this.lessont.Text = "label8";
            // 
            // montht
            // 
            this.montht.AutoSize = true;
            this.montht.Location = new System.Drawing.Point(169, 143);
            this.montht.Name = "montht";
            this.montht.Size = new System.Drawing.Size(46, 17);
            this.montht.TabIndex = 36;
            this.montht.Text = "label9";
            // 
            // createtemplate
            // 
            this.createtemplate.Location = new System.Drawing.Point(399, 275);
            this.createtemplate.Name = "createtemplate";
            this.createtemplate.Size = new System.Drawing.Size(131, 55);
            this.createtemplate.TabIndex = 38;
            this.createtemplate.Text = "Создать шаблон из файла";
            this.createtemplate.UseVisualStyleBackColor = true;
            // 
            // notet
            // 
            this.notet.Location = new System.Drawing.Point(12, 203);
            this.notet.Multiline = true;
            this.notet.Name = "notet";
            this.notet.ReadOnly = true;
            this.notet.Size = new System.Drawing.Size(329, 127);
            this.notet.TabIndex = 39;
            // 
            // Type_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 413);
            this.Controls.Add(this.notet);
            this.Controls.Add(this.createtemplate);
            this.Controls.Add(this.montht);
            this.Controls.Add(this.lessont);
            this.Controls.Add(this.costt);
            this.Controls.Add(this.namet);
            this.Controls.Add(this.bcour);
            this.Controls.Add(this.opentemlate);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Type_view";
            this.Text = "Тип курса №";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bcour;
        private System.Windows.Forms.Button opentemlate;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label namet;
        private System.Windows.Forms.Label costt;
        private System.Windows.Forms.Label lessont;
        private System.Windows.Forms.Label montht;
        private System.Windows.Forms.Button createtemplate;
        private System.Windows.Forms.TextBox notet;
    }
}