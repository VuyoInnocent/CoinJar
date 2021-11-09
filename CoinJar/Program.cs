using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    class Program
    {
        static void Main(string[] args)
        {
            Coin coin = new Coin();
            CoinJar jar = new CoinJar();
            for (int i = 0; i < 2; i++)
            {

                jar.AddCoin(coin.GetCoinByAmount(0.01m));
            }
            for (int i = 0; i < 2; i++)
            {
                jar.AddCoin(coin.GetCoinByAmount(0.05m));
            }
            for (int i = 0; i < 2; i++)
            {
                jar.AddCoin(coin.GetCoinByAmount(0.25m));
            }

            for (int i = 0; i < 2; i++)
            {
                jar.AddCoin(coin.GetCoinByAmount(0.10m));
            }
           
            for (int i = 0; i < 2; i++)
            {
                jar.AddCoin(coin.GetCoinByAmount(0.50m));
            }
            for (int i = 0; i < 2; i++)
            {
                jar.AddCoin(coin.GetCoinByAmount(1.00m));
            }
           
           var coinsTotal = jar.GetTotalAmount();

            Console.WriteLine($"Total amount of coins accumulated in the Jar:- {coinsTotal}");
            jar.Reset();

        }
    }
}
