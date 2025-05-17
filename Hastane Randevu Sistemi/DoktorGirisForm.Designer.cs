namespace Hastane_Randevu_Sistemi
{
    partial class DoktorGirisForm
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorGirisForm));
            this.textBoxDoktorIsim = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.buttonGiris = new System.Windows.Forms.Button();
            this.buttonIptal = new System.Windows.Forms.Button();
            this.labelDoktorIsim = new System.Windows.Forms.Label();
            this.labelSifre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxDoktorIsim
            // 
            this.textBoxDoktorIsim.Location = new System.Drawing.Point(120, 50);
            this.textBoxDoktorIsim.Name = "textBoxDoktorIsim";
            this.textBoxDoktorIsim.Size = new System.Drawing.Size(200, 22);
            this.textBoxDoktorIsim.TabIndex = 0;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(120, 100);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.PasswordChar = '*';
            this.textBoxSifre.Size = new System.Drawing.Size(200, 22);
            this.textBoxSifre.TabIndex = 1;
            // 
            // buttonGiris
            // 
            this.buttonGiris.Location = new System.Drawing.Point(120, 150);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Size = new System.Drawing.Size(75, 30);
            this.buttonGiris.TabIndex = 2;
            this.buttonGiris.Text = "Giriş";
            this.buttonGiris.UseVisualStyleBackColor = true;
            this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click);
            // 
            // buttonIptal
            // 
            this.buttonIptal.Location = new System.Drawing.Point(245, 150);
            this.buttonIptal.Name = "buttonIptal";
            this.buttonIptal.Size = new System.Drawing.Size(75, 30);
            this.buttonIptal.TabIndex = 3;
            this.buttonIptal.Text = "İptal";
            this.buttonIptal.UseVisualStyleBackColor = true;
            this.buttonIptal.Click += new System.EventHandler(this.buttonIptal_Click);
            // 
            // labelDoktorIsim
            // 
            this.labelDoktorIsim.AutoSize = true;
            this.labelDoktorIsim.Location = new System.Drawing.Point(32, 55);
            this.labelDoktorIsim.Name = "labelDoktorIsim";
            this.labelDoktorIsim.Size = new System.Drawing.Size(77, 16);
            this.labelDoktorIsim.TabIndex = 4;
            this.labelDoktorIsim.Text = "Doktor İsmi:";
            // 
            // labelSifre
            // 
            this.labelSifre.AutoSize = true;
            this.labelSifre.Location = new System.Drawing.Point(30, 100);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(37, 16);
            this.labelSifre.TabIndex = 5;
            this.labelSifre.Text = "Şifre:";
            // 
            // DoktorGirisForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.labelSifre);
            this.Controls.Add(this.labelDoktorIsim);
            this.Controls.Add(this.buttonIptal);
            this.Controls.Add(this.buttonGiris);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxDoktorIsim);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoktorGirisForm";
            this.Text = "Doktor Giriş";
            this.Load += new System.EventHandler(this.DoktorGirisForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBoxDoktorIsim;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Button buttonGiris;
        private System.Windows.Forms.Button buttonIptal;
        private System.Windows.Forms.Label labelDoktorIsim;
        private System.Windows.Forms.Label labelSifre;
    }
}
