namespace HisseSenetlerimUI
{
    partial class FrmHisseSenetlerim
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHisseSenetlerim));
            menuStrip = new MenuStrip();
            tsmiDosya = new ToolStripMenuItem();
            tsmiKaydet = new ToolStripMenuItem();
            tsmiDisariAktar = new ToolStripMenuItem();
            tsmiCikis = new ToolStripMenuItem();
            tsmiEkle = new ToolStripMenuItem();
            tsmiCanliBorsa = new ToolStripMenuItem();
            lstHisselerim = new ListView();
            chHisse = new ColumnHeader();
            chAdet = new ColumnHeader();
            chAlisFiyati = new ColumnHeader();
            chGuncelFiyat = new ColumnHeader();
            chKarZarar = new ColumnHeader();
            csmSagTik = new ContextMenuStrip(components);
            tsmEkle = new ToolStripMenuItem();
            tsmSil = new ToolStripMenuItem();
            sStrip = new StatusStrip();
            tsslKarZararDurum = new ToolStripStatusLabel();
            menuStrip.SuspendLayout();
            csmSagTik.SuspendLayout();
            sStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(30, 30);
            menuStrip.Items.AddRange(new ToolStripItem[] { tsmiDosya, tsmiEkle, tsmiCanliBorsa });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(625, 40);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // tsmiDosya
            // 
            tsmiDosya.DropDownItems.AddRange(new ToolStripItem[] { tsmiKaydet, tsmiDisariAktar, tsmiCikis });
            tsmiDosya.Name = "tsmiDosya";
            tsmiDosya.Size = new Size(99, 36);
            tsmiDosya.Text = "Dosya";
            // 
            // tsmiKaydet
            // 
            tsmiKaydet.Name = "tsmiKaydet";
            tsmiKaydet.Size = new Size(262, 42);
            tsmiKaydet.Text = "Kaydet";
            tsmiKaydet.Click += TsmiKaydet_Click;
            // 
            // tsmiDisariAktar
            // 
            tsmiDisariAktar.Name = "tsmiDisariAktar";
            tsmiDisariAktar.Size = new Size(262, 42);
            tsmiDisariAktar.Text = "Dışarı Aktar";
            tsmiDisariAktar.Click += TsmiDisariAktar_Click;
            // 
            // tsmiCikis
            // 
            tsmiCikis.Name = "tsmiCikis";
            tsmiCikis.Size = new Size(262, 42);
            tsmiCikis.Text = "Çıkış";
            tsmiCikis.Click += TsmiCikis_Click;
            // 
            // tsmiEkle
            // 
            tsmiEkle.Name = "tsmiEkle";
            tsmiEkle.Size = new Size(220, 36);
            tsmiEkle.Text = "Hisse Senedi Ekle";
            tsmiEkle.Click += TsmiEkle_Click;
            // 
            // tsmiCanliBorsa
            // 
            tsmiCanliBorsa.Name = "tsmiCanliBorsa";
            tsmiCanliBorsa.Size = new Size(152, 36);
            tsmiCanliBorsa.Text = "Canlı Borsa";
            tsmiCanliBorsa.Click += TsmiCanliBorsa_Click;
            // 
            // lstHisselerim
            // 
            lstHisselerim.AllowColumnReorder = true;
            lstHisselerim.Columns.AddRange(new ColumnHeader[] { chHisse, chAdet, chAlisFiyati, chGuncelFiyat, chKarZarar });
            lstHisselerim.ContextMenuStrip = csmSagTik;
            lstHisselerim.Dock = DockStyle.Fill;
            lstHisselerim.FullRowSelect = true;
            lstHisselerim.GridLines = true;
            lstHisselerim.Location = new Point(0, 40);
            lstHisselerim.MultiSelect = false;
            lstHisselerim.Name = "lstHisselerim";
            lstHisselerim.Size = new Size(625, 476);
            lstHisselerim.TabIndex = 1;
            lstHisselerim.UseCompatibleStateImageBehavior = false;
            lstHisselerim.View = View.Details;
            lstHisselerim.DoubleClick += LstHisselerim_DoubleClick;
            // 
            // chHisse
            // 
            chHisse.Text = "Hisse Senedi";
            // 
            // chAdet
            // 
            chAdet.Text = "Adet";
            // 
            // chAlisFiyati
            // 
            chAlisFiyati.Text = "Alış Fiyatı";
            // 
            // chGuncelFiyat
            // 
            chGuncelFiyat.Text = "Güncel Fiyat";
            // 
            // chKarZarar
            // 
            chKarZarar.Text = "Kar/Zarar";
            // 
            // csmSagTik
            // 
            csmSagTik.ImageScalingSize = new Size(30, 30);
            csmSagTik.Items.AddRange(new ToolStripItem[] { tsmEkle, tsmSil });
            csmSagTik.Name = "csmSagTik";
            csmSagTik.Size = new Size(132, 80);
            // 
            // tsmEkle
            // 
            tsmEkle.Name = "tsmEkle";
            tsmEkle.Size = new Size(131, 38);
            tsmEkle.Text = "Ekle";
            tsmEkle.Click += TsmEkle_Click;
            // 
            // tsmSil
            // 
            tsmSil.Name = "tsmSil";
            tsmSil.Size = new Size(131, 38);
            tsmSil.Text = "Sil";
            tsmSil.Click += TsmSil_Click;
            // 
            // sStrip
            // 
            sStrip.Font = new Font("Segoe UI", 9.89011F, FontStyle.Regular, GraphicsUnit.Point);
            sStrip.ImageScalingSize = new Size(30, 30);
            sStrip.Items.AddRange(new ToolStripItem[] { tsslKarZararDurum });
            sStrip.Location = new Point(0, 494);
            sStrip.Name = "sStrip";
            sStrip.Size = new Size(625, 22);
            sStrip.TabIndex = 2;
            sStrip.Text = "statusStrip1";
            // 
            // tsslKarZararDurum
            // 
            tsslKarZararDurum.Name = "tsslKarZararDurum";
            tsslKarZararDurum.Size = new Size(0, 12);
            // 
            // FrmHisseSenetlerim
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 516);
            Controls.Add(sStrip);
            Controls.Add(lstHisselerim);
            Controls.Add(menuStrip);
            Font = new Font("Segoe UI", 9.89011F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            Name = "FrmHisseSenetlerim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hisse Senetlerim";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            csmSagTik.ResumeLayout(false);
            sStrip.ResumeLayout(false);
            sStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem tsmiDosya;
        private ToolStripMenuItem tsmiKaydet;
        private ToolStripMenuItem tsmiDisariAktar;
        private ToolStripMenuItem tsmiCikis;
        private ToolStripMenuItem tsmiCanliBorsa;
        private ListView lstHisselerim;
        private ColumnHeader chHisse;
        private ColumnHeader chAdet;
        private ColumnHeader chAlisFiyati;
        private ColumnHeader chGuncelFiyat;
        private ColumnHeader chKarZarar;
        private ToolStripMenuItem tsmiEkle;
        private ContextMenuStrip csmSagTik;
        private ToolStripMenuItem tsmEkle;
        private ToolStripMenuItem tsmSil;
        private StatusStrip sStrip;
        private ToolStripStatusLabel tsslKarZararDurum;
    }
}