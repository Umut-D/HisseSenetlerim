using HisseSenetlerimLib;
using HisseSenetlerimLib.Hesap;

namespace HisseSenetlerimTests.Hesap
{
    [TestClass]
    public class KarZararTests
    {
        [TestMethod]
        public void Test_KarZarar()
        {
            var yatirim = new List<Yatirim>
            {
                new()
                {
                    HisseSenedi = "THYAO",
                    Adet = 10,
                    AlisFiyati = 200,
                    GuncelFiyat = 210
                }
            };
            IHesap hesap = new KarZarar(yatirim);
            hesap.Hesapla();
            var sonuc = yatirim.First(y => y.HisseSenedi == "THYAO").KarZarar;

            Assert.AreEqual(sonuc, 100);
        }
    }
}