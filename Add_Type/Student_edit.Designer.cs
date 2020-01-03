namespace Add_Type
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fiof = new System.Windows.Forms.TextBox();
            this.phonef = new System.Windows.Forms.MaskedTextBox();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            // fiof
            // 
            this.fiof.Location = new System.Drawing.Point(136, 12);
            this.fiof.Multiline = true;
            this.fiof.Name = "fiof";
            this.fiof.Size = new System.Drawing.Size(361, 36);
            this.fiof.TabIndex = 2;
            this.fiof.TextChanged += new System.EventHandler(this.fiof_TextChanged);
            // 
            // phonef
            // 
            this.phonef.Location = new System.Drawing.Point(136, 59);
            this.phonef.Mask = "+7(999) 000-0000";
            this.phonef.Name = "phonef";
            this.phonef.Size = new System.Drawing.Size(122, 22);
            this.phonef.TabIndex = 3;
            this.phonef.TextChanged += new System.EventHandler(this.phonef_TextChanged);
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
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Student_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 194);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.phonef);
            this.Controls.Add(this.fiof);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Student_edit";
            this.Text = "Редактировать ученика №";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Student_edit_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fiof;
        private System.Windows.Forms.MaskedTextBox phonef;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}