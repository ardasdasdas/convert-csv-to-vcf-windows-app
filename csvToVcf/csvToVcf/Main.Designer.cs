namespace csvToVcf
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnDosyaYukle = new System.Windows.Forms.Button();
            this.lblDosyaAdi = new System.Windows.Forms.Label();
            this.txtBoxOrgName = new System.Windows.Forms.TextBox();
            this.txtBoxYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCreator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(135, 207);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(192, 37);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Dönüştür";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnDosyaYukle
            // 
            this.btnDosyaYukle.Location = new System.Drawing.Point(227, 42);
            this.btnDosyaYukle.Name = "btnDosyaYukle";
            this.btnDosyaYukle.Size = new System.Drawing.Size(112, 37);
            this.btnDosyaYukle.TabIndex = 1;
            this.btnDosyaYukle.Text = "Dosya Yükle";
            this.btnDosyaYukle.UseVisualStyleBackColor = true;
            this.btnDosyaYukle.Click += new System.EventHandler(this.btnDosyaYukle_Click);
            // 
            // lblDosyaAdi
            // 
            this.lblDosyaAdi.AutoSize = true;
            this.lblDosyaAdi.Location = new System.Drawing.Point(132, 52);
            this.lblDosyaAdi.Name = "lblDosyaAdi";
            this.lblDosyaAdi.Size = new System.Drawing.Size(0, 17);
            this.lblDosyaAdi.TabIndex = 2;
            // 
            // txtBoxOrgName
            // 
            this.txtBoxOrgName.Location = new System.Drawing.Point(227, 104);
            this.txtBoxOrgName.Name = "txtBoxOrgName";
            this.txtBoxOrgName.Size = new System.Drawing.Size(100, 22);
            this.txtBoxOrgName.TabIndex = 3;
            // 
            // txtBoxYear
            // 
            this.txtBoxYear.Location = new System.Drawing.Point(227, 142);
            this.txtBoxYear.Name = "txtBoxYear";
            this.txtBoxYear.Size = new System.Drawing.Size(100, 22);
            this.txtBoxYear.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kulüp Adı:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(171, 145);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(27, 17);
            this.lblYear.TabIndex = 6;
            this.lblYear.Text = "Yıl:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(85, 95);
            this.panel1.TabIndex = 7;
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.Location = new System.Drawing.Point(270, 273);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(202, 17);
            this.lblCreator.TabIndex = 8;
            this.lblCreator.Text = "Created by Muzaffer Arda Uslu";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 299);
            this.Controls.Add(this.lblCreator);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxYear);
            this.Controls.Add(this.txtBoxOrgName);
            this.Controls.Add(this.lblDosyaAdi);
            this.Controls.Add(this.btnDosyaYukle);
            this.Controls.Add(this.btnConvert);
            this.Name = "Main";
            this.Text = "Csv to Vcf - BBTK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnDosyaYukle;
        private System.Windows.Forms.Label lblDosyaAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblYear;
        public System.Windows.Forms.TextBox txtBoxOrgName;
        public System.Windows.Forms.TextBox txtBoxYear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCreator;
    }
}

