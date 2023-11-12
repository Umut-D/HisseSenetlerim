namespace HisseSenetlerimUI
{
    partial class FrmHisseGuncelle
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
            cBoxHisseAdi = new ComboBox();
            lblAdet = new Label();
            lblAlisFiyati = new Label();
            lblHisseSenedi = new Label();
            txtAdet = new TextBox();
            txtAlisFiyati = new TextBox();
            BtnGuncelle = new Button();
            SuspendLayout();
            // 
            // cBoxHisseAdi
            // 
            cBoxHisseAdi.AutoCompleteSource = AutoCompleteSource.ListItems;
            cBoxHisseAdi.Enabled = false;
            cBoxHisseAdi.FlatStyle = FlatStyle.Flat;
            cBoxHisseAdi.FormattingEnabled = true;
            cBoxHisseAdi.Location = new Point(195, 22);
            cBoxHisseAdi.Name = "cBoxHisseAdi";
            cBoxHisseAdi.Size = new Size(236, 43);
            cBoxHisseAdi.TabIndex = 14;
            // 
            // lblAdet
            // 
            lblAdet.AutoSize = true;
            lblAdet.Location = new Point(117, 121);
            lblAdet.Name = "lblAdet";
            lblAdet.Size = new Size(72, 35);
            lblAdet.TabIndex = 13;
            lblAdet.Text = "Adet:";
            // 
            // lblAlisFiyati
            // 
            lblAlisFiyati.AutoSize = true;
            lblAlisFiyati.Location = new Point(66, 71);
            lblAlisFiyati.Name = "lblAlisFiyati";
            lblAlisFiyati.Size = new Size(123, 35);
            lblAlisFiyati.TabIndex = 12;
            lblAlisFiyati.Text = "Alış Fiyatı:";
            lblAlisFiyati.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblHisseSenedi
            // 
            lblHisseSenedi.AutoSize = true;
            lblHisseSenedi.Location = new Point(29, 24);
            lblHisseSenedi.Name = "lblHisseSenedi";
            lblHisseSenedi.Size = new Size(160, 35);
            lblHisseSenedi.TabIndex = 11;
            lblHisseSenedi.Text = "Hisse Senedi:";
            lblHisseSenedi.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtAdet
            // 
            txtAdet.Location = new Point(195, 118);
            txtAdet.Name = "txtAdet";
            txtAdet.Size = new Size(236, 41);
            txtAdet.TabIndex = 10;
            // 
            // txtAlisFiyati
            // 
            txtAlisFiyati.Location = new Point(195, 71);
            txtAlisFiyati.Name = "txtAlisFiyati";
            txtAlisFiyati.Size = new Size(236, 41);
            txtAlisFiyati.TabIndex = 9;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Location = new Point(278, 179);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(153, 50);
            BtnGuncelle.TabIndex = 8;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // FrmHisseGuncelle
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 252);
            Controls.Add(cBoxHisseAdi);
            Controls.Add(lblAdet);
            Controls.Add(lblAlisFiyati);
            Controls.Add(lblHisseSenedi);
            Controls.Add(txtAdet);
            Controls.Add(txtAlisFiyati);
            Controls.Add(BtnGuncelle);
            Font = new Font("Segoe UI", 9.89011F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmHisseGuncelle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Güncelle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ComboBox cBoxHisseAdi;
        private Label lblAdet;
        private Label lblAlisFiyati;
        private Label lblHisseSenedi;
        private TextBox txtAdet;
        private TextBox txtAlisFiyati;
        private Button BtnGuncelle;
    }
}