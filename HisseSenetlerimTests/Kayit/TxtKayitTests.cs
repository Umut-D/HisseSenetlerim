using HisseSenetlerimLib.Kayit;
using HisseSenetlerimLib;
using HisseSenetlerimLib.Kayit.Arayuzler;

namespace HisseSenetlerimTests.Kayit
{
    [TestClass]
    public class TxtKayitTests
    {
        private readonly string _testDizin = AppDomain.CurrentDomain.BaseDirectory + "yatirimlar.txt";

        [TestMethod]
        public void Test_Serialize_DosyaKayit()
        {
            IKaydet kaydet = new TxtKayit();
            kaydet.Kaydet(new List<Yatirim>());

            bool sonuc = File.Exists(_testDizin);

            Assert.IsTrue(sonuc);
        }
    }
}