using HisseSenetlerimLib.Internet;

namespace HisseSenetlerimTests.Internet
{
    [TestClass]
    public class WebSayfasiTests
    {
        [TestMethod]
        public void Test_Yuklenen_Hisse_Adedi()
        {
            WebSayfasi belge = new WebSayfasi();
            belge.HtmlYukle();
            var yuklenenHisseAdedi = belge.Hisseler.Take(1).Count();

            Assert.AreEqual(1, yuklenenHisseAdedi);
        }

        [TestMethod]
        public void Test_Yuklenen_Hisse_Bilgisi()
        {
            WebSayfasi belge = new WebSayfasi();
            belge.HtmlYukle();
            var a1Cap = belge.Hisseler.Take(1).ElementAt(0);

            Assert.AreEqual("A1CAP", a1Cap.Hisse);
        }
    }
}