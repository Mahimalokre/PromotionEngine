using NUnit.Framework;
using PromotionEngine;
using PromotionEngine.Contracts;

namespace PromotionEngineTests
{
    /// <summary>
    /// The cart test.
    /// </summary>
    public class CartTest
    {
        ICart cart;
        [SetUp]
        public void Setup()
        {
            cart = new Cart();
        }

        [Test]
        public void Test1()
        {
            var sku = new Sku()
            {
                A = 1,
                B = 1,
                C = 1
            };
            var result = cart.GetCartCalculated(sku);
            Assert.AreEqual(result, 100);            
        }

        [Test]
        public void Test2()
        {
            var sku = new Sku()
            {
                A = 5,
                B = 5,
                C = 1
            };
            var result = cart.GetCartCalculated(sku);
            Assert.AreEqual(result, 370);
        }

        [Test]
        public void Test3()
        {
            var sku = new Sku()
            {
                A = 3,
                B = 5,
                C = 1,
                D = 1
            };
            var result = cart.GetCartCalculated(sku);
            Assert.AreEqual(result, 280);
        }
    }
}