using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace KentBeckTDDSampleCode
{
    [TestClass]
    public class CurrencyTest
    {
       [TestMethod]
        public void TestMultiplication() {
            Dollar five = new Dollar(5);
            Dollar product = five.Times(2);
            Assert.AreEqual(10, product.Amount);
        }

    }
}
