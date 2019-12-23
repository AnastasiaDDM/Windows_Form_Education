namespace Add_Type
{
    partial class Cabinet_view
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
            this.timetable = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numbert = new System.Windows.Forms.Label();
            this.capacityt = new System.Windows.Forms.Label();
            this.brancht = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // timetable
            // 
            this.timetable.Location = new System.Drawing.Point(428, 97);
            this.timetable.Name = "timetable";
            this.timetable.Size = new System.Drawing.Size(187, 61);
            this.timetable.TabIndex = 17;
            this.timetable.Text = "Расписание\r\nкабинета";
            this.timetable.UseVisualStyleBackColor = true;
            this.timetable.Click += new System.EventHandler(this.timetable_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(265, 179);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(115, 39);
            this.close.TabIndex = 16;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Вместимость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Филиал";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Номер кабинета";
            // 
            // numbert
            // 
            this.numbert.AutoSize = true;
            this.numbert.Location = new System.Drawing.Point(141, 16);
            this.numbert.Name = "numbert";
            this.numbert.Size = new System.Drawing.Size(46, 17);
            this.numbert.TabIndex = 18;
            this.numbert.Text = "label4";
            // 
            // capacityt
            // 
            this.capacityt.AutoSize = true;
            this.capacityt.Location = new System.Drawing.Point(141, 119);
            this.capacityt.Name = "capacityt";
            this.capacityt.Size = new System.Drawing.Size(46, 17);
            this.capacityt.TabIndex = 20;
            this.capacityt.Text = "label6";
            // 
            // brancht
            // 
            this.brancht.AutoSize = true;
            this.brancht.Location = new System.Drawing.Point(141, 72);
            this.brancht.Name = "brancht";
            this.brancht.Size = new System.Drawing.Size(72, 17);
            this.brancht.TabIndex = 47;
            this.brancht.TabStop = true;
            this.brancht.Text = "linkLabel1";
            this.brancht.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.brancht_LinkClicked);
            // 
            // Cabinet_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 228);
            this.Controls.Add(this.brancht);
            this.Controls.Add(this.capacityt);
            this.Controls.Add(this.numbert);
            this.Controls.Add(this.timetable);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cabinet_view";
            this.Text = "Каибнет №";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cabinet_view_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button timetable;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numbert;
        private System.Windows.Forms.Label capacityt;
        private System.Windows.Forms.LinkLabel brancht;
    }
}