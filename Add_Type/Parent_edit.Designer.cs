namespace Add_Type
{
    partial class Parent_edit
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
            this.label3 = new System.Windows.Forms.Label();
            this.fiof = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phonef = new System.Windows.Forms.MaskedTextBox();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "ФИО ";
            // 
            // fiof
            // 
            this.fiof.Location = new System.Drawing.Point(142, 27);
            this.fiof.Multiline = true;
            this.fiof.Name = "fiof";
            this.fiof.Size = new System.Drawing.Size(361, 36);
            this.fiof.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Номер телефона";
            // 
            // phonef
            // 
            this.phonef.Location = new System.Drawing.Point(142, 103);
            this.phonef.Mask = "+7(999) 000-0000";
            this.phonef.Name = "phonef";
            this.phonef.Size = new System.Drawing.Size(122, 22);
            this.phonef.TabIndex = 13;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(364, 176);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(126, 42);
            this.save.TabIndex = 14;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(24, 176);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(126, 42);
            this.cancel.TabIndex = 15;
            this.cancel.Text = "Отменить";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Parent_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 229);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.phonef);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fiof);
            this.Controls.Add(this.label3);
            this.Name = "Parent_edit";
            this.Text = "Редактирование ответственного лица №";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Parent_edit_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fiof;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox phonef;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}