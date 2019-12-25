namespace Add_Type
{
    partial class StatisticsforOneBranch
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
            this.revenuet = new System.Windows.Forms.Label();
            this.profitt = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.statistic = new System.Windows.Forms.Button();
            this.countt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // revenuet
            // 
            this.revenuet.AutoSize = true;
            this.revenuet.Location = new System.Drawing.Point(12, 26);
            this.revenuet.Name = "revenuet";
            this.revenuet.Size = new System.Drawing.Size(46, 17);
            this.revenuet.TabIndex = 0;
            this.revenuet.Text = "label1";
            // 
            // profitt
            // 
            this.profitt.AutoSize = true;
            this.profitt.Location = new System.Drawing.Point(12, 76);
            this.profitt.Name = "profitt";
            this.profitt.Size = new System.Drawing.Size(46, 17);
            this.profitt.TabIndex = 1;
            this.profitt.Text = "label2";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(153, 215);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(102, 37);
            this.close.TabIndex = 2;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.KeyDown += new System.Windows.Forms.KeyEventHandler(this.close_KeyDown);
            // 
            // statistic
            // 
            this.statistic.Location = new System.Drawing.Point(237, 38);
            this.statistic.Name = "statistic";
            this.statistic.Size = new System.Drawing.Size(181, 55);
            this.statistic.TabIndex = 3;
            this.statistic.Text = "Сравнить с \r\nдругими филиалами";
            this.statistic.UseVisualStyleBackColor = true;
            this.statistic.Click += new System.EventHandler(this.statistic_Click);
            // 
            // countt
            // 
            this.countt.AutoSize = true;
            this.countt.Location = new System.Drawing.Point(15, 120);
            this.countt.Name = "countt";
            this.countt.Size = new System.Drawing.Size(46, 17);
            this.countt.TabIndex = 4;
            this.countt.Text = "label1";
            // 
            // StatisticsforOneBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 264);
            this.Controls.Add(this.countt);
            this.Controls.Add(this.statistic);
            this.Controls.Add(this.close);
            this.Controls.Add(this.profitt);
            this.Controls.Add(this.revenuet);
            this.Name = "StatisticsforOneBranch";
            this.Text = "Филиал № ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label revenuet;
        private System.Windows.Forms.Label profitt;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button statistic;
        private System.Windows.Forms.Label countt;
    }
}