using HisseSenetlerimLib;

namespace HisseSenetlerimUI
{
    public partial class FrmCanliBorsa : Form
    {
        private readonly FrmHisseSenetlerim _frmHisse;

        public FrmCanliBorsa(FrmHisseSenetlerim frmHisse)
        {
            InitializeComponent();

            _frmHisse = frmHisse;
        }

        private void FrmCanliBorsa_Load(object sender, EventArgs e)
        {
            if (_frmHisse.Sayfa != null) 
                ListVieweEkle(_frmHisse.Sayfa.Hisseler);

            _frmHisse.SutunAyarlari(lstCanliBorsa);
        }

        private void ListVieweEkle(List<HisseSenedi> hisseler)
        {
            foreach (var hisseSenedi in hisseler)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(hisseSenedi.Hisse);
                lvi.SubItems.Add(hisseSenedi.Son);
                lvi.SubItems.Add(hisseSenedi.Alis);
                lvi.SubItems.Add(hisseSenedi.Satis);
                lvi.SubItems.Add(hisseSenedi.Fark);
                lvi.SubItems.Add(hisseSenedi.EnDusuk);
                lvi.SubItems.Add(hisseSenedi.EnYuksek);
                lvi.SubItems.Add(hisseSenedi.Aof);
                lvi.SubItems.Add(hisseSenedi.HacimLira);
                lvi.SubItems.Add(hisseSenedi.HacimLot);

                lvi.SubItems.RemoveAt(0);
                lstCanliBorsa.Items.Add(lvi);
            }
        }
    }
}