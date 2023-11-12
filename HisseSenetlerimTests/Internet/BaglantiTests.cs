using HisseSenetlerimLib.Internet;

namespace HisseSenetlerimTests.Internet
{
    [TestClass]
    public class BaglantiTests
    {
        [TestMethod]
        public void Test_Baglanti()
        {
            var sonuc = Baglanti.InternetVarMi();

            Assert.AreEqual(true, sonuc);
        }
    }
}