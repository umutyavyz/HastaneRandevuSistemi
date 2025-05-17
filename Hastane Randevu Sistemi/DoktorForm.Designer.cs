namespace Hastane_Randevu_Sistemi
{
    partial class DoktorForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelDoktor;
        private System.Windows.Forms.ListBox listBoxRandevular;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRandevuIptal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorForm));
            this.labelDoktor = new System.Windows.Forms.Label();
            this.listBoxRandevular = new System.Windows.Forms.ListBox();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRandevuIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDoktor
            // 
            this.labelDoktor.AutoSize = true;
            this.labelDoktor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDoktor.Location = new System.Drawing.Point(12, 9);
            this.labelDoktor.Name = "labelDoktor";
            this.labelDoktor.Size = new System.Drawing.Size(132, 28);
            this.labelDoktor.TabIndex = 0;
            this.labelDoktor.Text = "Hoş geldiniz...";
            // 
            // listBoxRandevular
            // 
            this.listBoxRandevular.FormattingEnabled = true;
            this.listBoxRandevular.ItemHeight = 16;
            this.listBoxRandevular.Location = new System.Drawing.Point(23, 94);
            this.listBoxRandevular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxRandevular.Name = "listBoxRandevular";
            this.listBoxRandevular.Size = new System.Drawing.Size(361, 180);
            this.listBoxRandevular.TabIndex = 2;
            this.listBoxRandevular.SelectedIndexChanged += new System.EventHandler(this.listBoxRandevular_SelectedIndexChanged);
            // 
            // buttonCikis
            // 
            this.buttonCikis.Location = new System.Drawing.Point(23, 300);
            this.buttonCikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(100, 30);
            this.buttonCikis.TabIndex = 3;
            this.buttonCikis.Text = "Çıkış";
            this.buttonCikis.UseVisualStyleBackColor = true;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sisteme Kayıtlı Randevular";
            // 
            // buttonRandevuIptal
            // 
            this.buttonRandevuIptal.Location = new System.Drawing.Point(246, 300);
            this.buttonRandevuIptal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRandevuIptal.Name = "buttonRandevuIptal";
            this.buttonRandevuIptal.Size = new System.Drawing.Size(117, 30);
            this.buttonRandevuIptal.TabIndex = 5;
            this.buttonRandevuIptal.Text = "Randevu İptal";
            this.buttonRandevuIptal.UseVisualStyleBackColor = true;
            this.buttonRandevuIptal.Click += new System.EventHandler(this.buttonRandevuIptal_Click);
            // 
            // DoktorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.buttonRandevuIptal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.listBoxRandevular);
            this.Controls.Add(this.labelDoktor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DoktorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Paneli";
            this.Load += new System.EventHandler(this.DoktorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
