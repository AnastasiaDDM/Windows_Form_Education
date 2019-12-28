namespace Add_Type
{
    partial class Course_edit
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.namet = new System.Windows.Forms.TextBox();
            this.typef = new System.Windows.Forms.ComboBox();
            this.costt = new System.Windows.Forms.MaskedTextBox();
            this.branchf = new System.Windows.Forms.ComboBox();
            this.datefrom = new System.Windows.Forms.DateTimePicker();
            this.dateto = new System.Windows.Forms.DateTimePicker();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.countmonth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование курса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип курса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Стоимость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Филиал";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата начала занятий";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "окончание";
            // 
            // namet
            // 
            this.namet.Location = new System.Drawing.Point(176, 23);
            this.namet.Multiline = true;
            this.namet.Name = "namet";
            this.namet.Size = new System.Drawing.Size(455, 49);
            this.namet.TabIndex = 6;
            // 
            // typef
            // 
            this.typef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typef.FormattingEnabled = true;
            this.typef.Location = new System.Drawing.Point(176, 101);
            this.typef.Name = "typef";
            this.typef.Size = new System.Drawing.Size(455, 24);
            this.typef.TabIndex = 7;
            this.typef.SelectionChangeCommitted += new System.EventHandler(this.typef_SelectionChangeCommitted);
            // 
            // costt
            // 
            this.costt.Location = new System.Drawing.Point(176, 156);
            this.costt.Mask = "00000";
            this.costt.Name = "costt";
            this.costt.Size = new System.Drawing.Size(57, 22);
            this.costt.TabIndex = 8;
            this.costt.ValidatingType = typeof(int);
            // 
            // branchf
            // 
            this.branchf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchf.FormattingEnabled = true;
            this.branchf.Location = new System.Drawing.Point(380, 156);
            this.branchf.Name = "branchf";
            this.branchf.Size = new System.Drawing.Size(251, 24);
            this.branchf.TabIndex = 9;
            // 
            // datefrom
            // 
            this.datefrom.Location = new System.Drawing.Point(176, 211);
            this.datefrom.Name = "datefrom";
            this.datefrom.Size = new System.Drawing.Size(168, 22);
            this.datefrom.TabIndex = 11;
            // 
            // dateto
            // 
            this.dateto.Location = new System.Drawing.Point(457, 211);
            this.dateto.Name = "dateto";
            this.dateto.Size = new System.Drawing.Size(174, 22);
            this.dateto.TabIndex = 12;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(505, 292);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(126, 38);
            this.save.TabIndex = 13;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(44, 292);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(126, 38);
            this.cancel.TabIndex = 14;
            this.cancel.Text = "Отменить";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "руб.";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(448, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "* Примечание: Количество месяцев, установленное в типе курса: ";
            // 
            // countmonth
            // 
            this.countmonth.AutoSize = true;
            this.countmonth.Location = new System.Drawing.Point(474, 250);
            this.countmonth.Name = "countmonth";
            this.countmonth.Size = new System.Drawing.Size(0, 17);
            this.countmonth.TabIndex = 17;
            // 
            // Course_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 342);
            this.Controls.Add(this.countmonth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.dateto);
            this.Controls.Add(this.datefrom);
            this.Controls.Add(this.branchf);
            this.Controls.Add(this.costt);
            this.Controls.Add(this.typef);
            this.Controls.Add(this.namet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Course_edit";
            this.Text = "Редактирование курса №";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Course_edit_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox namet;
        private System.Windows.Forms.ComboBox typef;
        private System.Windows.Forms.MaskedTextBox costt;
        private System.Windows.Forms.ComboBox branchf;
        private System.Windows.Forms.DateTimePicker datefrom;
        private System.Windows.Forms.DateTimePicker dateto;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label countmonth;
        private System.Windows.Forms.Label label8;
    }
}