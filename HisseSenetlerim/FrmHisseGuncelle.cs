using HisseSenetlerimLib;
using System.Globalization;

namespace HisseSenetlerimUI
{
    public partial class FrmHisseGuncelle : Form
    {
        private readonly IYatirimKayit _kayit;

        public FrmHisseGuncelle(IYatirimKayit kayit)
        {
            InitializeComponent();

            _kayit = kayit;
        }

        public void HisseYukle(string hisseAdi, int adet, double alisFiyati)
        {
            cBoxHisseAdi.Text = hisseAdi;
            txtAdet.Text = adet.ToString();
            txtAlisFiyati.Text = alisFiyati.ToString(CultureInfo.CurrentCulture);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var hisseSenedi = new Yatirim
                {
                    HisseSenedi = cBoxHisseAdi.Text,
                    Adet = Convert.ToInt32(txtAdet.Text),
                    AlisFiyati = Convert.ToDouble(txtAlisFiyati.Text)
                };
                _kayit.Guncelle(hisseSenedi);

                Close();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Bir şeyler yazaydınız", @"Hata", MessageBoxButtons.OK);
            }
        }
    }
}