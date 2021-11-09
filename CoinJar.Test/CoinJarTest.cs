using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoinJar.Test
{
    [TestClass]
    public class CoinJarTest
    {
        [TestMethod]
        public void AddCoin_CoinOnjectTwoDecimalNumumbers_ReturnVoid()
        {
            //    new Coin(0.01m, 0.0146m),
            //    new Coin(0.05m, 0.0233m),
            //    new Coin(0.10m, 0.0115m),
            //    new Coin(0.25m, 0.0274m),
            //    new Coin(0.50m, 0.0535m),
            //    new Coin(1.00m, 0.0373m)


            //Arrange
            Coin coin = new Coin();
            CoinJar coinJar = new CoinJar();
            var ammout = 0.01m;
            var expectedVolume = 0.0146m;

            //Act
            var actual = coin.GetCoinByAmount(ammout);
            coinJar.AddCoin(actual);

            //Assert
            Assert.AreEqual(expectedVolume, actual.Volume);

        }
        [TestMethod]
        public void GetTotalAmount_NoParameters_ReturndecimalTotal()
        {

            CoinJar coinJar = new CoinJar();
            var expectedTotal = 0.01m;

            var actual = coinJar.GetTotalAmount();

            Assert.AreEqual(expectedTotal, actual);

        }
        [TestMethod]
        public void Reset_NoParameters_ReturnVoid()
        {
            CoinJar coinJar = new CoinJar();
            var totalAmmout = coinJar.CoinsTotalAmount;

            coinJar.Reset();

            Assert.IsTrue(totalAmmout == 0.00m);

        }
    }
}
