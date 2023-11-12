namespace HisseSenetlerimUI
{
    partial class FrmCanliBorsa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCanliBorsa));
            lstCanliBorsa = new ListView();
            chHisse = new ColumnHeader();
            chSonFiyat = new ColumnHeader();
            chAlis = new ColumnHeader();
            chSatis = new ColumnHeader();
            chFark = new ColumnHeader();
            chEnDusuk = new ColumnHeader();
            chEnYuksek = new ColumnHeader();
            chAof = new ColumnHeader();
            chHacimLira = new ColumnHeader();
            chHacimLot = new ColumnHeader();
            SuspendLayout();
            // 
            // lstCanliBorsa
            // 
            lstCanliBorsa.Columns.AddRange(new ColumnHeader[] { chHisse, chSonFiyat, chAlis, chSatis, chFark, chEnDusuk, chEnYuksek, chAof, chHacimLira, chHacimLot });
            lstCanliBorsa.Dock = DockStyle.Fill;
            lstCanliBorsa.Font = new Font("Segoe UI", 9.89011F, FontStyle.Regular, GraphicsUnit.Point);
            lstCanliBorsa.FullRowSelect = true;
            lstCanliBorsa.GridLines = true;
            lstCanliBorsa.Location = new Point(0, 0);
            lstCanliBorsa.Name = "lstCanliBorsa";
            lstCanliBorsa.Size = new Size(1461, 722);
            lstCanliBorsa.TabIndex = 0;
            lstCanliBorsa.UseCompatibleStateImageBehavior = false;
            lstCanliBorsa.View = View.Details;
            // 
            // chHisse
            // 
            chHisse.Text = "Hisse Senedi";
            chHisse.Width = 90;
            // 
            // chSonFiyat
            // 
            chSonFiyat.Text = "Son Fiyat";
            // 
            // chAlis
            // 
            chAlis.Text = "Alış";
            // 
            // chSatis
            // 
            chSatis.Text = "Satış";
            // 
            // chFark
            // 
            chFark.Text = "Fark";
            // 
            // chEnDusuk
            // 
            chEnDusuk.Text = "En Düşük";
            // 
            // chEnYuksek
            // 
            chEnYuksek.Text = "En Yüksek";
            // 
            // chAof
            // 
            chAof.Text = "AOF";
            // 
            // chHacimLira
            // 
            chHacimLira.Text = "Hacim Lira";
            // 
            // chHacimLot
            // 
            chHacimLot.Text = "Hacim Lot";
            // 
            // FrmCanliBorsa
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1461, 722);
            Controls.Add(lstCanliBorsa);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCanliBorsa";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Canlı Borsa";
            Load += FrmCanliBorsa_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lstCanliBorsa;
        private ColumnHeader chHisse;
        private ColumnHeader chAlis;
        private ColumnHeader chSonFiyat;
        private ColumnHeader chSatis;
        private ColumnHeader chFark;
        private ColumnHeader chEnDusuk;
        private ColumnHeader chEnYuksek;
        private ColumnHeader chAof;
        private ColumnHeader chHacimLira;
        private ColumnHeader chHacimLot;
    }
}