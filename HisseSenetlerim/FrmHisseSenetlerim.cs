using System.Globalization;
using HisseSenetlerimLib;
using HisseSenetlerimLib.Hesap;
using HisseSenetlerimLib.Internet;
using HisseSenetlerimLib.Kayit;
using HisseSenetlerimLib.Kayit.Arayuzler;

namespace HisseSenetlerimUI
{
    public partial class FrmHisseSenetlerim : Form, IYatirimKayit
    {
        private readonly List<Yatirim> _yatirimlarim = new();
        public WebSayfasi? Sayfa { get; private set; }

        public FrmHisseSenetlerim()
        {
            InitializeComponent();

            IAc ac = new XmlKayit();
            var hisseler = ac.Ac();

            if (hisseler != null)
                _yatirimlarim.AddRange(hisseler);

            SutunAyarlari(lstHisselerim);

            CanliBorsa();
        }

        public void SutunAyarlari(ListView listView)
        {
            for (int i = 0; i < listView.Columns.Count; i++)
            {
                listView.Columns[i].TextAlign = HorizontalAlignment.Right;
                listView.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        public async void CanliBorsa()
        {
            Sayfa = new WebSayfasi();
            await Task.Run(() =>
            {
                Sayfa.HtmlYukle();
            });

            GuncelFiyatHesapla();

            KarZararHesapla();

            foreach (var yatirim in _yatirimlarim)
                ListVieweEkle(yatirim);

            ToplamKarZarar();
        }

        private void GuncelFiyatHesapla()
        {
            IHesap guncelFiyat = new GuncelFiyat(_yatirimlarim, Sayfa);
            guncelFiyat.Hesapla();
        }

        private void KarZararHesapla()
        {
            IHesap karZarar = new KarZarar(_yatirimlarim);
            karZarar.Hesapla();
        }

        public void Ekle(Yatirim yatirim)
        {
            _yatirimlarim.Add(yatirim);

            ListVieweEkle(yatirim);

            lstHisselerim.Items.Clear();

            CanliBorsa();
        }

        private void ListVieweEkle(Yatirim yatirim)
        {
            ListViewItem lvi = new ListViewItem
            {
                UseItemStyleForSubItems = false
            };

            lvi.SubItems.Add(yatirim.HisseSenedi);
            lvi.SubItems.Add(yatirim.Adet.ToString());
            lvi.SubItems.Add(yatirim.AlisFiyati.ToString(CultureInfo.CurrentCulture));
            lvi.SubItems.Add(yatirim.GuncelFiyat.ToString(CultureInfo.CurrentCulture));
            lvi.SubItems.Add(yatirim.KarZarar.ToString("C2"), yatirim.KarZarar < 0 ? Color.Red : Color.Green, default,
                default);

            lvi.SubItems.RemoveAt(0);
            lstHisselerim.Items.Add(lvi);
        }

        public void Guncelle(Yatirim yatirim)
        {
            ListViewGuncelle(yatirim);

            lstHisselerim.Items.Clear();

            CanliBorsa();
        }

        private void ListViewGuncelle(Yatirim yatirim)
        {
            foreach (ListViewItem nesne in lstHisselerim.Items)
            {
                if (nesne.SubItems[0].Text != yatirim.HisseSenedi)
                    continue;

                nesne.Selected = true;

                if (_yatirimlarim.Any(y => y.HisseSenedi == yatirim.HisseSenedi))
                {
                    _yatirimlarim
                        .FirstOrDefault(y => y.HisseSenedi == yatirim.HisseSenedi)
                        !.Adet = yatirim.Adet;
                    _yatirimlarim
                        .FirstOrDefault(y => y.HisseSenedi == yatirim.HisseSenedi)
                        !.AlisFiyati = yatirim.AlisFiyati;
                }

                break;
            }
        }

        private void ToplamKarZarar()
        {
            var genelToplam = $"{_yatirimlarim.Sum(y => y.KarZarar):C2}";
            tsslKarZararDurum.Text = $@"Toplam Kar/Zarar: {genelToplam}";
        }

        private void TsmiKaydet_Click(object sender, EventArgs e)
        {
            IKaydet kayit = new XmlKayit();
            kayit.Kaydet(_yatirimlarim);
        }

        private void TsmiDisariAktar_Click(object sender, EventArgs e)
        {
            IKaydet kaydet = new TxtKayit();
            kaydet.Kaydet(_yatirimlarim);
        }

        private void TsmiEkle_Click(object sender, EventArgs e)
        {
            var kayit = new FrmHisseEkle(this);

            HisseleriYukle(kayit);

            kayit.ShowDialog();
        }

        private void HisseleriYukle(FrmHisseEkle kayit)
        {
            if (Sayfa == null)
                return;

            foreach (var hisseSenedi in Sayfa.Hisseler)
            {
                if (hisseSenedi.Hisse != null)
                    kayit.cBoxHisseAdi.Items.Add(hisseSenedi.Hisse);
            }
        }

        private void TsmiCanliBorsa_Click(object sender, EventArgs e)
        {
            var borsa = new FrmCanliBorsa(this);
            borsa.ShowDialog();
        }

        private void TsmEkle_Click(object sender, EventArgs e)
        {
            TsmiEkle_Click(sender, e);
        }

        private void LstHisselerim_DoubleClick(object sender, EventArgs e)
        {
            string hisseAdi = lstHisselerim.SelectedItems[0].SubItems[0].Text;
            int adet = Convert.ToInt32(lstHisselerim.SelectedItems[0].SubItems[1].Text);
            double alisFiyati = Convert.ToDouble(lstHisselerim.SelectedItems[0].SubItems[2].Text);

            var kayit = new FrmHisseGuncelle(this);
            kayit.HisseYukle(hisseAdi, adet, alisFiyati);
            kayit.ShowDialog();
        }

        private void TsmSil_Click(object sender, EventArgs e)
        {
            var seciliIndeks = lstHisselerim.Items.IndexOf(lstHisselerim.SelectedItems[0]);
            _yatirimlarim.RemoveAt(seciliIndeks);

            lstHisselerim.Items.Clear();

            CanliBorsa();
        }

        private void TsmiCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}