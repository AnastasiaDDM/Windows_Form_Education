namespace Add_Type
{
    partial class Input
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
            this.passwordt = new System.Windows.Forms.TextBox();
            this.binput = new System.Windows.Forms.Button();
            this.phonet = new System.Windows.Forms.MaskedTextBox();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер телефона";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // passwordt
            // 
            this.passwordt.Location = new System.Drawing.Point(138, 101);
            this.passwordt.Name = "passwordt";
            this.passwordt.Size = new System.Drawing.Size(252, 22);
            this.passwordt.TabIndex = 3;
            // 
            // binput
            // 
            this.binput.Location = new System.Drawing.Point(269, 155);
            this.binput.Name = "binput";
            this.binput.Size = new System.Drawing.Size(121, 40);
            this.binput.TabIndex = 4;
            this.binput.Text = "Войти";
            this.binput.UseVisualStyleBackColor = true;
            this.binput.Click += new System.EventHandler(this.binput_Click);
            // 
            // phonet
            // 
            this.phonet.Location = new System.Drawing.Point(138, 48);
            this.phonet.Mask = "+7(999) 000-0000";
            this.phonet.Name = "phonet";
            this.phonet.Size = new System.Drawing.Size(122, 22);
            this.phonet.TabIndex = 5;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(12, 155);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(121, 40);
            this.close.TabIndex = 6;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 207);
            this.Controls.Add(this.close);
            this.Controls.Add(this.phonet);
            this.Controls.Add(this.binput);
            this.Controls.Add(this.passwordt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Input";
            this.Text = "Авторизация";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordt;
        private System.Windows.Forms.Button binput;
        private System.Windows.Forms.MaskedTextBox phonet;
        private System.Windows.Forms.Button close;
    }
}