using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoinJar.Test
{

    [TestClass]
    public class CoinJarTest
    {
        [TestMethod]
        public void AddCoin_CoinTwoDecimalNumumbers_ReturnVoid()
        {
            //Arrange
            Coin coin;
            CoinJar coinJar = new CoinJar();
            coin = new Coin
            {
                Amount = 0.25m,
                Volume = 0.0274m
            };

            //Act
            coinJar.AddCoin(coin);

            //Assert
            
        }
        [TestMethod]
        public void GetTotalAmount_NoParameters_ReturndecimalTotal()
        {

            CoinJar coinJar = new CoinJar();
            var expectedTotal = 0.00m;

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
