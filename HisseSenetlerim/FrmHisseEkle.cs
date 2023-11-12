using HisseSenetlerimLib;

namespace HisseSenetlerimUI
{
    public partial class FrmHisseEkle : Form
    {
        private readonly IYatirimKayit _kayit;

        public FrmHisseEkle(IYatirimKayit kayit)
        {
            InitializeComponent();

            _kayit = kayit;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var hisseSenedi = new Yatirim
                {
                    HisseSenedi = cBoxHisseAdi.Text,
                    Adet = Convert.ToInt32(txtAdet.Text),
                    AlisFiyati = Convert.ToDouble(txtAlisFiyati.Text)
                };
                _kayit.Ekle(hisseSenedi);

                Close();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Bir şeyler yazaydınız", @"Hata", MessageBoxButtons.OK);
            }
        }
    }
}