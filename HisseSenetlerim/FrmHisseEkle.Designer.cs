namespace HisseSenetlerimUI
{
    partial class FrmHisseEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHisseEkle));
            btnEkle = new Button();
            txtAlisFiyati = new TextBox();
            txtAdet = new TextBox();
            lblHisseSenedi = new Label();
            lblAlisFiyati = new Label();
            lblAdet = new Label();
            cBoxHisseAdi = new ComboBox();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(278, 179);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(153, 50);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += BtnEkle_Click;
            // 
            // txtAlisFiyati
            // 
            txtAlisFiyati.Location = new Point(195, 71);
            txtAlisFiyati.Name = "txtAlisFiyati";
            txtAlisFiyati.Size = new Size(236, 41);
            txtAlisFiyati.TabIndex = 2;
            // 
            // txtAdet
            // 
            txtAdet.Location = new Point(195, 118);
            txtAdet.Name = "txtAdet";
            txtAdet.Size = new Size(236, 41);
            txtAdet.TabIndex = 3;
            // 
            // lblHisseSenedi
            // 
            lblHisseSenedi.AutoSize = true;
            lblHisseSenedi.Location = new Point(29, 24);
            lblHisseSenedi.Name = "lblHisseSenedi";
            lblHisseSenedi.Size = new Size(160, 35);
            lblHisseSenedi.TabIndex = 4;
            lblHisseSenedi.Text = "Hisse Senedi:";
            lblHisseSenedi.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAlisFiyati
            // 
            lblAlisFiyati.AutoSize = true;
            lblAlisFiyati.Location = new Point(66, 71);
            lblAlisFiyati.Name = "lblAlisFiyati";
            lblAlisFiyati.Size = new Size(123, 35);
            lblAlisFiyati.TabIndex = 5;
            lblAlisFiyati.Text = "Alış Fiyatı:";
            lblAlisFiyati.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAdet
            // 
            lblAdet.AutoSize = true;
            lblAdet.Location = new Point(117, 121);
            lblAdet.Name = "lblAdet";
            lblAdet.Size = new Size(72, 35);
            lblAdet.TabIndex = 6;
            lblAdet.Text = "Adet:";
            // 
            // cBoxHisseAdi
            // 
            cBoxHisseAdi.AutoCompleteMode = AutoCompleteMode.Suggest;
            cBoxHisseAdi.AutoCompleteSource = AutoCompleteSource.ListItems;
            cBoxHisseAdi.FormattingEnabled = true;
            cBoxHisseAdi.Location = new Point(195, 22);
            cBoxHisseAdi.Name = "cBoxHisseAdi";
            cBoxHisseAdi.Size = new Size(236, 43);
            cBoxHisseAdi.TabIndex = 7;
            // 
            // FrmHisseEkle
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
            Controls.Add(btnEkle);
            Font = new Font("Segoe UI", 9.89011F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmHisseEkle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ekle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private TextBox txtAlisFiyati;
        private TextBox txtAdet;
        private Label lblHisseSenedi;
        private Label lblAlisFiyati;
        private Label lblAdet;
        public ComboBox cBoxHisseAdi;
    }
}