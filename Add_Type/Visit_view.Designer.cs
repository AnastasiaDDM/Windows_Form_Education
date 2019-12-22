namespace Add_Type
{
    partial class Visit_view
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
            this.label5 = new System.Windows.Forms.Label();
            this.datet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.courset = new System.Windows.Forms.LinkLabel();
            this.cabinett = new System.Windows.Forms.LinkLabel();
            this.teacherst = new System.Windows.Forms.Label();
            this.themest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.D)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Кабинет";
            // 
            // datet
            // 
            this.datet.AutoSize = true;
            this.datet.Location = new System.Drawing.Point(664, 9);
            this.datet.Name = "datet";
            this.datet.Size = new System.Drawing.Size(42, 17);
            this.datet.TabIndex = 25;
            this.datet.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Название курса";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 641);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 41);
            this.button2.TabIndex = 23;
            this.button2.Text = "Отменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 641);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 41);
            this.button1.TabIndex = 22;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Преподаватели";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Темы";
            // 
            // D
            // 
            this.D.AllowUserToAddRows = false;
            this.D.AllowUserToDeleteRows = false;
            this.D.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.D.Location = new System.Drawing.Point(15, 112);
            this.D.Name = "D";
            this.D.ReadOnly = true;
            this.D.RowTemplate.Height = 24;
            this.D.Size = new System.Drawing.Size(780, 457);
            this.D.TabIndex = 19;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(685, 72);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(106, 34);
            this.update.TabIndex = 30;
            this.update.Text = "Изменить";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(345, 581);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(123, 41);
            this.Close.TabIndex = 31;
            this.Close.Text = "Закрыть";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // courset
            // 
            this.courset.AutoSize = true;
            this.courset.Location = new System.Drawing.Point(346, 86);
            this.courset.Name = "courset";
            this.courset.Size = new System.Drawing.Size(72, 17);
            this.courset.TabIndex = 49;
            this.courset.TabStop = true;
            this.courset.Text = "linkLabel3";
            // 
            // cabinett
            // 
            this.cabinett.AutoSize = true;
            this.cabinett.Location = new System.Drawing.Point(82, 72);
            this.cabinett.Name = "cabinett";
            this.cabinett.Size = new System.Drawing.Size(72, 17);
            this.cabinett.TabIndex = 50;
            this.cabinett.TabStop = true;
            this.cabinett.Text = "linkLabel4";
            // 
            // teacherst
            // 
            this.teacherst.AutoSize = true;
            this.teacherst.Location = new System.Drawing.Point(130, 41);
            this.teacherst.Name = "teacherst";
            this.teacherst.Size = new System.Drawing.Size(46, 17);
            this.teacherst.TabIndex = 51;
            this.teacherst.Text = "label6";
            // 
            // themest
            // 
            this.themest.AutoSize = true;
            this.themest.Location = new System.Drawing.Point(62, 9);
            this.themest.Name = "themest";
            this.themest.Size = new System.Drawing.Size(46, 17);
            this.themest.TabIndex = 52;
            this.themest.Text = "label6";
            // 
            // Visit_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 634);
            this.Controls.Add(this.themest);
            this.Controls.Add(this.teacherst);
            this.Controls.Add(this.cabinett);
            this.Controls.Add(this.courset);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.D);
            this.Name = "Visit_view";
            this.Text = "Посещаемость";
            ((System.ComponentModel.ISupportInitialize)(this.D)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label datet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView D;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.LinkLabel courset;
        private System.Windows.Forms.LinkLabel cabinett;
        private System.Windows.Forms.Label teacherst;
        private System.Windows.Forms.Label themest;
    }
}