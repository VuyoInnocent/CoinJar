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

        public decimal TotalVolume { get; set; }
        public decimal UsedVolume { get; set; }
        public decimal CoinsTotalAmount { get; set; }

        public CoinJar()
        {
            _coins = new List<Coin>();

            TotalVolume = 42m;
            UsedVolume = 0m;
            CoinsTotalAmount = 0.00m;
        }

        public void AddCoin(ICoin coin)
        {
            if (coin == null)
            {
                Console.WriteLine("Coin Jar is null");
            }
            if (coin.Volume + UsedVolume > TotalVolume)
            {
                Console.WriteLine("CoinJar is full, you cannot insert more Coins");
            }

            if (coin != null && coin.Volume < TotalVolume)
            {
                _coins.Add((Coin)coin);

                CoinsTotalAmount += coin.Amount;
                UsedVolume += coin.Volume;

                Console.WriteLine($"Coin {coin.Amount} added in the Coin Jar!");
                Console.WriteLine($"used voume is:  {UsedVolume} of {TotalVolume} CoinJar volume");
            }
        }

        public decimal GetTotalAmount()
        {
            return CoinsTotalAmount;
        }

        public void Reset()
        {
            _coins = new List<Coin>();
            UsedVolume = 0m;
            CoinsTotalAmount = 0.00m;
            Console.WriteLine($"No more money in the Jar :(. Balance is:  R{CoinsTotalAmount}");
        }
    }
}
