namespace Add_Type
{
    partial class Cabinet_edit
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
            this.numbert = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.branchf = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.capacityf = new System.Windows.Forms.NumericUpDown();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.capacityf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер кабинета";
            // 
            // numbert
            // 
            this.numbert.Location = new System.Drawing.Point(148, 45);
            this.numbert.Multiline = true;
            this.numbert.Name = "numbert";
            this.numbert.Size = new System.Drawing.Size(387, 50);
            this.numbert.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Филиал";
            // 
            // branchf
            // 
            this.branchf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchf.FormattingEnabled = true;
            this.branchf.Location = new System.Drawing.Point(148, 101);
            this.branchf.Name = "branchf";
            this.branchf.Size = new System.Drawing.Size(387, 24);
            this.branchf.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Вместимость";
            // 
            // capacityf
            // 
            this.capacityf.Location = new System.Drawing.Point(148, 138);
            this.capacityf.Name = "capacityf";
            this.capacityf.Size = new System.Drawing.Size(82, 22);
            this.capacityf.TabIndex = 5;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(405, 213);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(115, 39);
            this.save.TabIndex = 6;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(24, 213);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(115, 39);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Отменить";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Cabinet_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 264);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.capacityf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.branchf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numbert);
            this.Controls.Add(this.label1);
            this.Name = "Cabinet_edit";
            this.Text = "Редактирование кабинета №";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cabinet_edit_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.capacityf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numbert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox branchf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown capacityf;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}