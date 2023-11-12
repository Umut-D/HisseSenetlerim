using HisseSenetlerimLib.Internet;

namespace HisseSenetlerimLib.Hesap
{
    public class GuncelFiyat : IHesap
    {
        private readonly List<Yatirim> _yatirimlarim;
        private readonly WebSayfasi? _sayfa;

        public GuncelFiyat(List<Yatirim> yatirimlarim, WebSayfasi? sayfa)
        {
            _yatirimlarim = yatirimlarim;
            _sayfa = sayfa;
        }

        public void Hesapla()
        {
            foreach (var yatirim in _yatirimlarim)
            {
                var sonFiyat = _sayfa?.Hisseler.First(h => h.Hisse == yatirim.HisseSenedi).Son;
                yatirim.GuncelFiyat = Convert.ToDouble(sonFiyat);
            }
        }
    }
}