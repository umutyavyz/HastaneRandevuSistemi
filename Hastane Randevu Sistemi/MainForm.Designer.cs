namespace Hastane_Randevu_Sistemi
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelHastaBilgi;
        private System.Windows.Forms.ComboBox comboBoxDoktorlar;
        private System.Windows.Forms.ListBox listBoxRandevuGecmisi;
        private System.Windows.Forms.DateTimePicker dateTimePickerRandevu;
        private System.Windows.Forms.Button buttonRandevuAl;
        private System.Windows.Forms.Button buttonRandevuIptal;
        private System.Windows.Forms.Button buttonCikis; // Çıkış butonu tanımlandı

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelHastaBilgi = new System.Windows.Forms.Label();
            this.comboBoxDoktorlar = new System.Windows.Forms.ComboBox();
            this.listBoxRandevuGecmisi = new System.Windows.Forms.ListBox();
            this.dateTimePickerRandevu = new System.Windows.Forms.DateTimePicker();
            this.buttonRandevuAl = new System.Windows.Forms.Button();
            this.buttonRandevuIptal = new System.Windows.Forms.Button();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHastaBilgi
            // 
            this.labelHastaBilgi.AutoSize = true;
            this.labelHastaBilgi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHastaBilgi.Location = new System.Drawing.Point(532, 9);
            this.labelHastaBilgi.Name = "labelHastaBilgi";
            this.labelHastaBilgi.Size = new System.Drawing.Size(98, 23);
            this.labelHastaBilgi.TabIndex = 0;
            this.labelHastaBilgi.Text = "Hoşgeldiniz";
            // 
            // comboBoxDoktorlar
            // 
            this.comboBoxDoktorlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDoktorlar.FormattingEnabled = true;
            this.comboBoxDoktorlar.Location = new System.Drawing.Point(57, 189);
            this.comboBoxDoktorlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDoktorlar.Name = "comboBoxDoktorlar";
            this.comboBoxDoktorlar.Size = new System.Drawing.Size(317, 24);
            this.comboBoxDoktorlar.TabIndex = 1;
            // 
            // listBoxRandevuGecmisi
            // 
            this.listBoxRandevuGecmisi.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxRandevuGecmisi.FormattingEnabled = true;
            this.listBoxRandevuGecmisi.ItemHeight = 17;
            this.listBoxRandevuGecmisi.Location = new System.Drawing.Point(404, 118);
            this.listBoxRandevuGecmisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxRandevuGecmisi.Name = "listBoxRandevuGecmisi";
            this.listBoxRandevuGecmisi.Size = new System.Drawing.Size(357, 174);
            this.listBoxRandevuGecmisi.TabIndex = 2;
            // 
            // dateTimePickerRandevu
            // 
            this.dateTimePickerRandevu.CalendarFont = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerRandevu.Location = new System.Drawing.Point(125, 259);
            this.dateTimePickerRandevu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerRandevu.Name = "dateTimePickerRandevu";
            this.dateTimePickerRandevu.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerRandevu.TabIndex = 3;
            // 
            // buttonRandevuAl
            // 
            this.buttonRandevuAl.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRandevuAl.Location = new System.Drawing.Point(156, 324);
            this.buttonRandevuAl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRandevuAl.Name = "buttonRandevuAl";
            this.buttonRandevuAl.Size = new System.Drawing.Size(115, 39);
            this.buttonRandevuAl.TabIndex = 4;
            this.buttonRandevuAl.Text = "Randevu Al";
            this.buttonRandevuAl.UseVisualStyleBackColor = true;
            this.buttonRandevuAl.Click += new System.EventHandler(this.buttonRandevuAl_Click_1);
            // 
            // buttonRandevuIptal
            // 
            this.buttonRandevuIptal.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRandevuIptal.Location = new System.Drawing.Point(314, 324);
            this.buttonRandevuIptal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRandevuIptal.Name = "buttonRandevuIptal";
            this.buttonRandevuIptal.Size = new System.Drawing.Size(115, 39);
            this.buttonRandevuIptal.TabIndex = 5;
            this.buttonRandevuIptal.Text = "İptal Et";
            this.buttonRandevuIptal.UseVisualStyleBackColor = true;
            this.buttonRandevuIptal.Click += new System.EventHandler(this.buttonRandevuIptal_Click_1);
            // 
            // buttonCikis
            // 
            this.buttonCikis.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCikis.Location = new System.Drawing.Point(473, 324);
            this.buttonCikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(115, 39);
            this.buttonCikis.TabIndex = 6;
            this.buttonCikis.Text = "Çıkış";
            this.buttonCikis.UseVisualStyleBackColor = true;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Aktif Randevularım";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Doktor Seçiniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tarih Seçiniz";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hastane_Randevu_Sistemi.Properties.Resources.Logo_of_Ministry_of_Health__Turkey_;
            this.pictureBox2.Location = new System.Drawing.Point(2, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.buttonRandevuIptal);
            this.Controls.Add(this.buttonRandevuAl);
            this.Controls.Add(this.dateTimePickerRandevu);
            this.Controls.Add(this.listBoxRandevuGecmisi);
            this.Controls.Add(this.comboBoxDoktorlar);
            this.Controls.Add(this.labelHastaBilgi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Randevu Ekranı";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
