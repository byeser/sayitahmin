namespace cstech
{
    partial class frmSayiTahmini
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSayiTahmini));
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSayi = new System.Windows.Forms.Button();
            this.hata = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblArti = new System.Windows.Forms.Label();
            this.lblEksi = new System.Windows.Forms.Label();
            this.btnYeniSayi = new System.Windows.Forms.Button();
            this.lblRakam1 = new System.Windows.Forms.Label();
            this.lblRakam4 = new System.Windows.Forms.Label();
            this.lblRakam3 = new System.Windows.Forms.Label();
            this.lblRakam2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hata)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(93, 12);
            this.txtSayi.MaxLength = 4;
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(167, 20);
            this.txtSayi.TabIndex = 1;
            this.txtSayi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayi_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sayı Giriniz :";
            // 
            // btnSayi
            // 
            this.btnSayi.Location = new System.Drawing.Point(93, 39);
            this.btnSayi.Name = "btnSayi";
            this.btnSayi.Size = new System.Drawing.Size(80, 23);
            this.btnSayi.TabIndex = 3;
            this.btnSayi.Text = "Tahmin Et";
            this.btnSayi.UseVisualStyleBackColor = true;
            this.btnSayi.Click += new System.EventHandler(this.btnSayi_Click);
            // 
            // hata
            // 
            this.hata.ContainerControl = this;
            // 
            // lblArti
            // 
            this.lblArti.AutoSize = true;
            this.lblArti.Location = new System.Drawing.Point(97, 74);
            this.lblArti.Name = "lblArti";
            this.lblArti.Size = new System.Drawing.Size(40, 13);
            this.lblArti.TabIndex = 4;
            this.lblArti.Text = "+ puan";
            // 
            // lblEksi
            // 
            this.lblEksi.AutoSize = true;
            this.lblEksi.Location = new System.Drawing.Point(138, 74);
            this.lblEksi.Name = "lblEksi";
            this.lblEksi.Size = new System.Drawing.Size(37, 13);
            this.lblEksi.TabIndex = 5;
            this.lblEksi.Text = "- puan";
            // 
            // btnYeniSayi
            // 
            this.btnYeniSayi.Location = new System.Drawing.Point(180, 38);
            this.btnYeniSayi.Name = "btnYeniSayi";
            this.btnYeniSayi.Size = new System.Drawing.Size(80, 23);
            this.btnYeniSayi.TabIndex = 6;
            this.btnYeniSayi.Text = "Yeni Sayi";
            this.btnYeniSayi.UseVisualStyleBackColor = true;
            this.btnYeniSayi.Click += new System.EventHandler(this.btnYeniSayi_Click);
            // 
            // lblRakam1
            // 
            this.lblRakam1.AutoSize = true;
            this.lblRakam1.Location = new System.Drawing.Point(288, 14);
            this.lblRakam1.Name = "lblRakam1";
            this.lblRakam1.Size = new System.Drawing.Size(48, 13);
            this.lblRakam1.TabIndex = 7;
            this.lblRakam1.Text = "1. rakam";
            // 
            // lblRakam4
            // 
            this.lblRakam4.AutoSize = true;
            this.lblRakam4.Location = new System.Drawing.Point(288, 84);
            this.lblRakam4.Name = "lblRakam4";
            this.lblRakam4.Size = new System.Drawing.Size(48, 13);
            this.lblRakam4.TabIndex = 8;
            this.lblRakam4.Text = "4. rakam";
            // 
            // lblRakam3
            // 
            this.lblRakam3.AutoSize = true;
            this.lblRakam3.Location = new System.Drawing.Point(288, 62);
            this.lblRakam3.Name = "lblRakam3";
            this.lblRakam3.Size = new System.Drawing.Size(48, 13);
            this.lblRakam3.TabIndex = 9;
            this.lblRakam3.Text = "3. rakam";
            // 
            // lblRakam2
            // 
            this.lblRakam2.AutoSize = true;
            this.lblRakam2.Location = new System.Drawing.Point(288, 38);
            this.lblRakam2.Name = "lblRakam2";
            this.lblRakam2.Size = new System.Drawing.Size(48, 13);
            this.lblRakam2.TabIndex = 10;
            this.lblRakam2.Text = "2. rakam";
            // 
            // frmSayiTahmini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 116);
            this.Controls.Add(this.lblRakam2);
            this.Controls.Add(this.lblRakam3);
            this.Controls.Add(this.lblRakam4);
            this.Controls.Add(this.lblRakam1);
            this.Controls.Add(this.btnYeniSayi);
            this.Controls.Add(this.lblEksi);
            this.Controls.Add(this.lblArti);
            this.Controls.Add(this.btnSayi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSayi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSayiTahmini";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sayı Tahmin Oyunu";
            this.Load += new System.EventHandler(this.frmSayiTahmini_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSayi;
        private System.Windows.Forms.ErrorProvider hata;
        private System.Windows.Forms.Label lblEksi;
        private System.Windows.Forms.Label lblArti;
        private System.Windows.Forms.Button btnYeniSayi;
        private System.Windows.Forms.Label lblRakam2;
        private System.Windows.Forms.Label lblRakam3;
        private System.Windows.Forms.Label lblRakam4;
        private System.Windows.Forms.Label lblRakam1;
    }
}

