using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngineApp;

namespace PromotionEngineTest
{
    [TestClass]
    public class PromotionEngineTest
    {
        [TestMethod]
        public void TestMethod()
        {
            PromotionEngine promoEngine = new PromotionEngine();
            int totalPrice = promoEngine.GetTotalUnitsPrice();
            Assert.AreEqual(100, totalPrice);

        }
    }
}
