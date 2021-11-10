using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    public class CoinJar : ICoinJar
    {
        private List<Coin> _coins;

        decimal usedVolume = 0m;
        decimal totalVolume = 42m;
        decimal coinsTotalAmount = 0m;

        public CoinJar()
        {
            _coins = new List<Coin>();
        }

        public void AddCoin(ICoin coin)
        {
            

            if (coin == null)
            {
                Console.WriteLine("Coin Jar is null");
            }
            if (coin.Volume + usedVolume > totalVolume)
            {
                Console.WriteLine("CoinJar is full, you cannot insert more Coins");
            }

            if (coin != null && coin.Volume < totalVolume)
            {
                _coins.Add((Coin)coin);

                coinsTotalAmount += coin.Amount;
                usedVolume += coin.Volume;

                Console.WriteLine($"Coin {coin.Amount} added in the Coin Jar!");
                Console.WriteLine($"used voume is:  {usedVolume} of {totalVolume} CoinJar volume");
            }
        }

        public decimal GetTotalAmount()
        {
            return coinsTotalAmount;
        }

        public void Reset()
        {
            _coins = new List<Coin>();
            usedVolume = 0m;
            coinsTotalAmount = 0.00m;
            Console.WriteLine($"No more money in the Jar :(. Balance is:  $ {coinsTotalAmount}");
        }
    }
}
