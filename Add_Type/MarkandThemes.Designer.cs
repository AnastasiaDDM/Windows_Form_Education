namespace Add_Type
{
    partial class MarkandThemes
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
            this.D = new System.Windows.Forms.DataGridView();
            this.teacht = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.court = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.brant = new System.Windows.Forms.LinkLabel();
            this.studt = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.D)).BeginInit();
            this.SuspendLayout();
            // 
            // D
            // 
            this.D.AllowUserToAddRows = false;
            this.D.AllowUserToDeleteRows = false;
            this.D.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.D.Location = new System.Drawing.Point(12, 107);
            this.D.Name = "D";
            this.D.RowTemplate.Height = 24;
            this.D.Size = new System.Drawing.Size(860, 518);
            this.D.TabIndex = 0;
            this.D.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.D_CellContentClick);
            // 
            // teacht
            // 
            this.teacht.AutoSize = true;
            this.teacht.Location = new System.Drawing.Point(203, 19);
            this.teacht.Name = "teacht";
            this.teacht.Size = new System.Drawing.Size(0, 17);
            this.teacht.TabIndex = 1;
            this.teacht.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.teacht_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 3;
            // 
            // court
            // 
            this.court.AutoSize = true;
            this.court.Location = new System.Drawing.Point(129, 51);
            this.court.Name = "court";
            this.court.Size = new System.Drawing.Size(0, 17);
            this.court.TabIndex = 4;
            this.court.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.court_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 6;
            // 
            // brant
            // 
            this.brant.AutoSize = true;
            this.brant.Location = new System.Drawing.Point(648, 52);
            this.brant.Name = "brant";
            this.brant.Size = new System.Drawing.Size(0, 17);
            this.brant.TabIndex = 7;
            this.brant.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.brant_LinkClicked);
            // 
            // studt
            // 
            this.studt.AutoSize = true;
            this.studt.Location = new System.Drawing.Point(648, 19);
            this.studt.Name = "studt";
            this.studt.Size = new System.Drawing.Size(0, 17);
            this.studt.TabIndex = 8;
            this.studt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.studt_LinkClicked);
            // 
            // MarkandThemes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 638);
            this.Controls.Add(this.studt);
            this.Controls.Add(this.brant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.court);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teacht);
            this.Controls.Add(this.D);
            this.Name = "MarkandThemes";
            this.Text = "Оценивание по темам";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MarkandThemes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.D)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView D;
        private System.Windows.Forms.LinkLabel teacht;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel court;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel brant;
        private System.Windows.Forms.LinkLabel studt;
    }
}