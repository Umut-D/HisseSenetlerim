namespace HisseSenetlerimLib.Hesap
{
    public class KarZarar : IHesap
    {
        private readonly List<Yatirim> _yatirimlarim;

        public KarZarar(List<Yatirim> yatirim)
        {
            _yatirimlarim = yatirim;
        }

        public void Hesapla()
        {
            foreach (var yatirim in _yatirimlarim)
            {
                double alisFiyatToplam = yatirim.Adet * yatirim.AlisFiyati;
                double guncelFiyatToplam = yatirim.Adet * yatirim.GuncelFiyat;
                yatirim.KarZarar = Math.Round(guncelFiyatToplam - alisFiyatToplam, 2);
            }
        }
    }
}