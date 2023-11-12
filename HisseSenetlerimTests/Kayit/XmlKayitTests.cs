using HisseSenetlerimLib;
using HisseSenetlerimLib.Kayit;
using HisseSenetlerimLib.Kayit.Arayuzler;

namespace HisseSenetlerimTests.Kayit
{
    [TestClass]
    public class XmlKayitTests
    {
        private readonly string _testDizin = AppDomain.CurrentDomain.BaseDirectory + "yatirimlar.xml";
        private readonly Yatirim _testYatirim = new Yatirim
        {
            HisseSenedi = "THYAO",
            Adet = 5,
            AlisFiyati = 210
        };

        [TestMethod]
        public void Test_Serialize_XmlKayit()
        {
            IKaydet kaydet = new XmlKayit();
            kaydet.Kaydet(new List<Yatirim>
            {
                _testYatirim
            });

            bool sonuc = File.Exists(_testDizin);
            Assert.IsTrue(sonuc);
        }

        [TestMethod]
        public void Test_Serialize_XmlAc()
        {
            IKaydet kaydet = new XmlKayit();
            kaydet.Kaydet(new List<Yatirim>
            {
                _testYatirim
            });

            IAc ac = new XmlKayit();
            var sonuc = ac.Ac();

            Assert.AreEqual(sonuc?.ElementAt(0).HisseSenedi, "THYAO");
        }
    }
}