namespace OOPDevam_1
{
    partial class Form1
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
            this.LstSonuc = new System.Windows.Forms.ListBox();
            this.TxtIsim = new System.Windows.Forms.TextBox();
            this.TxtSoyIsim = new System.Windows.Forms.TextBox();
            this.TxtKimlik = new System.Windows.Forms.TextBox();
            this.BtnYarat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstSonuc
            // 
            this.LstSonuc.FormattingEnabled = true;
            this.LstSonuc.ItemHeight = 16;
            this.LstSonuc.Location = new System.Drawing.Point(309, 46);
            this.LstSonuc.Name = "LstSonuc";
            this.LstSonuc.Size = new System.Drawing.Size(410, 324);
            this.LstSonuc.TabIndex = 0;
            // 
            // TxtIsim
            // 
            this.TxtIsim.Location = new System.Drawing.Point(24, 46);
            this.TxtIsim.Name = "TxtIsim";
            this.TxtIsim.Size = new System.Drawing.Size(100, 22);
            this.TxtIsim.TabIndex = 1;
            // 
            // TxtSoyIsim
            // 
            this.TxtSoyIsim.Location = new System.Drawing.Point(24, 95);
            this.TxtSoyIsim.Name = "TxtSoyIsim";
            this.TxtSoyIsim.Size = new System.Drawing.Size(100, 22);
            this.TxtSoyIsim.TabIndex = 1;
            // 
            // TxtKimlik
            // 
            this.TxtKimlik.Location = new System.Drawing.Point(24, 147);
            this.TxtKimlik.Name = "TxtKimlik";
            this.TxtKimlik.Size = new System.Drawing.Size(100, 22);
            this.TxtKimlik.TabIndex = 1;
            // 
            // BtnYarat
            // 
            this.BtnYarat.Location = new System.Drawing.Point(21, 223);
            this.BtnYarat.Name = "BtnYarat";
            this.BtnYarat.Size = new System.Drawing.Size(138, 29);
            this.BtnYarat.TabIndex = 2;
            this.BtnYarat.Text = "Yarat";
            this.BtnYarat.UseVisualStyleBackColor = true;
            this.BtnYarat.Click += new System.EventHandler(this.BtnYarat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnYarat);
            this.Controls.Add(this.TxtKimlik);
            this.Controls.Add(this.TxtSoyIsim);
            this.Controls.Add(this.TxtIsim);
            this.Controls.Add(this.LstSonuc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstSonuc;
        private System.Windows.Forms.TextBox TxtIsim;
        private System.Windows.Forms.TextBox TxtSoyIsim;
        private System.Windows.Forms.TextBox TxtKimlik;
        private System.Windows.Forms.Button BtnYarat;
    }
}

