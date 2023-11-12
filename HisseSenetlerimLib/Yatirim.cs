namespace HisseSenetlerimLib
{
    public class Yatirim
    {
        public string? HisseSenedi { get; set; }
        public int Adet { get; set; }
        public double AlisFiyati { get; set; }
        public double GuncelFiyat { get; set; }
        public double KarZarar { get; set; }

        public string HisseBilgisi => $"{HisseSenedi} | Adet: {Adet} | Alış Fiyatı: {AlisFiyati}";
    }
}