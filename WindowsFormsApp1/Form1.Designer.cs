namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOgrListele = new System.Windows.Forms.Button();
            this.btnOgrSil = new System.Windows.Forms.Button();
            this.btnOgrGuncelle = new System.Windows.Forms.Button();
            this.btnOgrKaydet = new System.Windows.Forms.Button();
            this.comboOgrKulup = new System.Windows.Forms.ComboBox();
            this.txtOgrFotograf = new System.Windows.Forms.TextBox();
            this.txtOgrSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.txtOgrId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNotDurum = new System.Windows.Forms.TextBox();
            this.txtNotProje = new System.Windows.Forms.TextBox();
            this.txtNotOrtalama = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnNotListele = new System.Windows.Forms.Button();
            this.btnNotGuncelle = new System.Windows.Forms.Button();
            this.txtNotSinav3 = new System.Windows.Forms.TextBox();
            this.txtNotSinav2 = new System.Windows.Forms.TextBox();
            this.txtNotSinav1 = new System.Windows.Forms.TextBox();
            this.txtNotId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKulupListele = new System.Windows.Forms.Button();
            this.btnKulupSil = new System.Windows.Forms.Button();
            this.BtnKulupGuncelle = new System.Windows.Forms.Button();
            this.btnKulupKaydet = new System.Windows.Forms.Button();
            this.txtKulupAd = new System.Windows.Forms.TextBox();
            this.txtKulupId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNotHesapla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fotoğraf";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kulüp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOgrListele);
            this.groupBox1.Controls.Add(this.btnOgrSil);
            this.groupBox1.Controls.Add(this.btnOgrGuncelle);
            this.groupBox1.Controls.Add(this.btnOgrKaydet);
            this.groupBox1.Controls.Add(this.comboOgrKulup);
            this.groupBox1.Controls.Add(this.txtOgrFotograf);
            this.groupBox1.Controls.Add(this.txtOgrSoyad);
            this.groupBox1.Controls.Add(this.txtOgrAd);
            this.groupBox1.Controls.Add(this.txtOgrId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 368);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // btnOgrListele
            // 
            this.btnOgrListele.BackColor = System.Drawing.Color.Aqua;
            this.btnOgrListele.Location = new System.Drawing.Point(172, 286);
            this.btnOgrListele.Name = "btnOgrListele";
            this.btnOgrListele.Size = new System.Drawing.Size(131, 32);
            this.btnOgrListele.TabIndex = 13;
            this.btnOgrListele.Text = "Listele";
            this.btnOgrListele.UseVisualStyleBackColor = false;
            // 
            // btnOgrSil
            // 
            this.btnOgrSil.BackColor = System.Drawing.Color.Aqua;
            this.btnOgrSil.Location = new System.Drawing.Point(33, 286);
            this.btnOgrSil.Name = "btnOgrSil";
            this.btnOgrSil.Size = new System.Drawing.Size(131, 32);
            this.btnOgrSil.TabIndex = 12;
            this.btnOgrSil.Text = "Sil";
            this.btnOgrSil.UseVisualStyleBackColor = false;
            // 
            // btnOgrGuncelle
            // 
            this.btnOgrGuncelle.BackColor = System.Drawing.Color.Aqua;
            this.btnOgrGuncelle.Location = new System.Drawing.Point(172, 248);
            this.btnOgrGuncelle.Name = "btnOgrGuncelle";
            this.btnOgrGuncelle.Size = new System.Drawing.Size(131, 32);
            this.btnOgrGuncelle.TabIndex = 11;
            this.btnOgrGuncelle.Text = "Güncelle";
            this.btnOgrGuncelle.UseVisualStyleBackColor = false;
            this.btnOgrGuncelle.Click += new System.EventHandler(this.btnOgrGuncelle_Click);
            // 
            // btnOgrKaydet
            // 
            this.btnOgrKaydet.BackColor = System.Drawing.Color.Aqua;
            this.btnOgrKaydet.Location = new System.Drawing.Point(33, 248);
            this.btnOgrKaydet.Name = "btnOgrKaydet";
            this.btnOgrKaydet.Size = new System.Drawing.Size(131, 32);
            this.btnOgrKaydet.TabIndex = 10;
            this.btnOgrKaydet.Text = "Kaydet";
            this.btnOgrKaydet.UseVisualStyleBackColor = false;
            this.btnOgrKaydet.Click += new System.EventHandler(this.btnOgrKaydet_Click);
            // 
            // comboOgrKulup
            // 
            this.comboOgrKulup.FormattingEnabled = true;
            this.comboOgrKulup.Location = new System.Drawing.Point(130, 190);
            this.comboOgrKulup.Name = "comboOgrKulup";
            this.comboOgrKulup.Size = new System.Drawing.Size(173, 30);
            this.comboOgrKulup.TabIndex = 9;
            // 
            // txtOgrFotograf
            // 
            this.txtOgrFotograf.Location = new System.Drawing.Point(130, 150);
            this.txtOgrFotograf.Name = "txtOgrFotograf";
            this.txtOgrFotograf.Size = new System.Drawing.Size(173, 28);
            this.txtOgrFotograf.TabIndex = 8;
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.Location = new System.Drawing.Point(130, 108);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(173, 28);
            this.txtOgrSoyad.TabIndex = 7;
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.Location = new System.Drawing.Point(130, 69);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(173, 28);
            this.txtOgrAd.TabIndex = 6;
            // 
            // txtOgrId
            // 
            this.txtOgrId.Location = new System.Drawing.Point(130, 32);
            this.txtOgrId.Name = "txtOgrId";
            this.txtOgrId.Size = new System.Drawing.Size(173, 28);
            this.txtOgrId.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNotHesapla);
            this.groupBox2.Controls.Add(this.txtNotDurum);
            this.groupBox2.Controls.Add(this.txtNotProje);
            this.groupBox2.Controls.Add(this.txtNotOrtalama);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnNotListele);
            this.groupBox2.Controls.Add(this.btnNotGuncelle);
            this.groupBox2.Controls.Add(this.txtNotSinav3);
            this.groupBox2.Controls.Add(this.txtNotSinav2);
            this.groupBox2.Controls.Add(this.txtNotSinav1);
            this.groupBox2.Controls.Add(this.txtNotId);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(397, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 384);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Not Bilgileri";
            // 
            // txtNotDurum
            // 
            this.txtNotDurum.Location = new System.Drawing.Point(130, 270);
            this.txtNotDurum.Name = "txtNotDurum";
            this.txtNotDurum.Size = new System.Drawing.Size(173, 28);
            this.txtNotDurum.TabIndex = 19;
            // 
            // txtNotProje
            // 
            this.txtNotProje.Location = new System.Drawing.Point(130, 187);
            this.txtNotProje.Name = "txtNotProje";
            this.txtNotProje.Size = new System.Drawing.Size(173, 28);
            this.txtNotProje.TabIndex = 18;
            // 
            // txtNotOrtalama
            // 
            this.txtNotOrtalama.Location = new System.Drawing.Point(130, 230);
            this.txtNotOrtalama.Name = "txtNotOrtalama";
            this.txtNotOrtalama.Size = new System.Drawing.Size(173, 28);
            this.txtNotOrtalama.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 24);
            this.label11.TabIndex = 15;
            this.label11.Text = "Durum";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 24);
            this.label12.TabIndex = 14;
            this.label12.Text = "Ortalama";
            // 
            // btnNotListele
            // 
            this.btnNotListele.BackColor = System.Drawing.Color.Aqua;
            this.btnNotListele.Location = new System.Drawing.Point(42, 309);
            this.btnNotListele.Name = "btnNotListele";
            this.btnNotListele.Size = new System.Drawing.Size(131, 32);
            this.btnNotListele.TabIndex = 13;
            this.btnNotListele.Text = "Listele";
            this.btnNotListele.UseVisualStyleBackColor = false;
            this.btnNotListele.Click += new System.EventHandler(this.btnNotListele_Click);
            // 
            // btnNotGuncelle
            // 
            this.btnNotGuncelle.BackColor = System.Drawing.Color.Aqua;
            this.btnNotGuncelle.Location = new System.Drawing.Point(190, 309);
            this.btnNotGuncelle.Name = "btnNotGuncelle";
            this.btnNotGuncelle.Size = new System.Drawing.Size(131, 32);
            this.btnNotGuncelle.TabIndex = 11;
            this.btnNotGuncelle.Text = "Güncelle";
            this.btnNotGuncelle.UseVisualStyleBackColor = false;
            this.btnNotGuncelle.Click += new System.EventHandler(this.btnNotGuncelle_Click);
            // 
            // txtNotSinav3
            // 
            this.txtNotSinav3.Location = new System.Drawing.Point(130, 150);
            this.txtNotSinav3.Name = "txtNotSinav3";
            this.txtNotSinav3.Size = new System.Drawing.Size(173, 28);
            this.txtNotSinav3.TabIndex = 8;
            // 
            // txtNotSinav2
            // 
            this.txtNotSinav2.Location = new System.Drawing.Point(130, 108);
            this.txtNotSinav2.Name = "txtNotSinav2";
            this.txtNotSinav2.Size = new System.Drawing.Size(173, 28);
            this.txtNotSinav2.TabIndex = 7;
            // 
            // txtNotSinav1
            // 
            this.txtNotSinav1.Location = new System.Drawing.Point(130, 69);
            this.txtNotSinav1.Name = "txtNotSinav1";
            this.txtNotSinav1.Size = new System.Drawing.Size(173, 28);
            this.txtNotSinav1.TabIndex = 6;
            // 
            // txtNotId
            // 
            this.txtNotId.Location = new System.Drawing.Point(130, 32);
            this.txtNotId.Name = "txtNotId";
            this.txtNotId.Size = new System.Drawing.Size(173, 28);
            this.txtNotId.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sınav1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Proje";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Sınav2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "Sınav3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKulupListele);
            this.groupBox3.Controls.Add(this.btnKulupSil);
            this.groupBox3.Controls.Add(this.BtnKulupGuncelle);
            this.groupBox3.Controls.Add(this.btnKulupKaydet);
            this.groupBox3.Controls.Add(this.txtKulupAd);
            this.groupBox3.Controls.Add(this.txtKulupId);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(783, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 358);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kulüp Bilgileri";
            // 
            // btnKulupListele
            // 
            this.btnKulupListele.BackColor = System.Drawing.Color.Aqua;
            this.btnKulupListele.Location = new System.Drawing.Point(172, 175);
            this.btnKulupListele.Name = "btnKulupListele";
            this.btnKulupListele.Size = new System.Drawing.Size(131, 32);
            this.btnKulupListele.TabIndex = 13;
            this.btnKulupListele.Text = "Listele";
            this.btnKulupListele.UseVisualStyleBackColor = false;
            this.btnKulupListele.Click += new System.EventHandler(this.btnKulupListele_Click);
            // 
            // btnKulupSil
            // 
            this.btnKulupSil.BackColor = System.Drawing.Color.Aqua;
            this.btnKulupSil.Location = new System.Drawing.Point(33, 175);
            this.btnKulupSil.Name = "btnKulupSil";
            this.btnKulupSil.Size = new System.Drawing.Size(131, 32);
            this.btnKulupSil.TabIndex = 12;
            this.btnKulupSil.Text = "Sil";
            this.btnKulupSil.UseVisualStyleBackColor = false;
            this.btnKulupSil.Click += new System.EventHandler(this.btnKulupSil_Click);
            // 
            // BtnKulupGuncelle
            // 
            this.BtnKulupGuncelle.BackColor = System.Drawing.Color.Aqua;
            this.BtnKulupGuncelle.Location = new System.Drawing.Point(172, 137);
            this.BtnKulupGuncelle.Name = "BtnKulupGuncelle";
            this.BtnKulupGuncelle.Size = new System.Drawing.Size(131, 32);
            this.BtnKulupGuncelle.TabIndex = 11;
            this.BtnKulupGuncelle.Text = "Güncelle";
            this.BtnKulupGuncelle.UseVisualStyleBackColor = false;
            this.BtnKulupGuncelle.Click += new System.EventHandler(this.BtnKulupGuncelle_Click);
            // 
            // btnKulupKaydet
            // 
            this.btnKulupKaydet.BackColor = System.Drawing.Color.Aqua;
            this.btnKulupKaydet.Location = new System.Drawing.Point(33, 137);
            this.btnKulupKaydet.Name = "btnKulupKaydet";
            this.btnKulupKaydet.Size = new System.Drawing.Size(131, 32);
            this.btnKulupKaydet.TabIndex = 10;
            this.btnKulupKaydet.Text = "Kaydet";
            this.btnKulupKaydet.UseVisualStyleBackColor = false;
            this.btnKulupKaydet.Click += new System.EventHandler(this.btnKulupKaydet_Click);
            // 
            // txtKulupAd
            // 
            this.txtKulupAd.Location = new System.Drawing.Point(130, 69);
            this.txtKulupAd.Name = "txtKulupAd";
            this.txtKulupAd.Size = new System.Drawing.Size(173, 28);
            this.txtKulupAd.TabIndex = 6;
            // 
            // txtKulupId
            // 
            this.txtKulupId.Location = new System.Drawing.Point(130, 32);
            this.txtKulupId.Name = "txtKulupId";
            this.txtKulupId.Size = new System.Drawing.Size(173, 28);
            this.txtKulupId.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 24);
            this.label13.TabIndex = 0;
            this.label13.Text = "Kulüp Ad";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(64, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 24);
            this.label17.TabIndex = 2;
            this.label17.Text = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 402);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1129, 271);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnNotHesapla
            // 
            this.btnNotHesapla.BackColor = System.Drawing.Color.Aqua;
            this.btnNotHesapla.Location = new System.Drawing.Point(112, 347);
            this.btnNotHesapla.Name = "btnNotHesapla";
            this.btnNotHesapla.Size = new System.Drawing.Size(131, 32);
            this.btnNotHesapla.TabIndex = 20;
            this.btnNotHesapla.Text = "Hesapla";
            this.btnNotHesapla.UseVisualStyleBackColor = false;
            this.btnNotHesapla.Click += new System.EventHandler(this.btnNotHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1155, 685);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOgrListele;
        private System.Windows.Forms.Button btnOgrSil;
        private System.Windows.Forms.Button btnOgrGuncelle;
        private System.Windows.Forms.Button btnOgrKaydet;
        private System.Windows.Forms.ComboBox comboOgrKulup;
        private System.Windows.Forms.TextBox txtOgrFotograf;
        private System.Windows.Forms.TextBox txtOgrSoyad;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.TextBox txtOgrId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNotDurum;
        private System.Windows.Forms.TextBox txtNotProje;
        private System.Windows.Forms.TextBox txtNotOrtalama;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnNotListele;
        private System.Windows.Forms.Button btnNotGuncelle;
        private System.Windows.Forms.TextBox txtNotSinav3;
        private System.Windows.Forms.TextBox txtNotSinav2;
        private System.Windows.Forms.TextBox txtNotSinav1;
        private System.Windows.Forms.TextBox txtNotId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnKulupListele;
        private System.Windows.Forms.Button btnKulupSil;
        private System.Windows.Forms.Button BtnKulupGuncelle;
        private System.Windows.Forms.Button btnKulupKaydet;
        private System.Windows.Forms.TextBox txtKulupAd;
        private System.Windows.Forms.TextBox txtKulupId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNotHesapla;
    }
}

