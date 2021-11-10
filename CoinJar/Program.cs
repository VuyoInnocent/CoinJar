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
            Coin coin;
            CoinJar jar = new CoinJar();

            //Adding all the US latest coinages twice using for loop 
            for (int i = 0; i < 2; i++)
            {
                coin = new Coin
                {
                    Amount = 0.01m,
                    Volume = 0.0146m
                };
                jar.AddCoin(coin);
            }
            for (int i = 0; i < 2; i++)
            {
                coin = new Coin
                {
                    Amount = 0.05m,
                    Volume = 0.0233m
                };
                jar.AddCoin(coin);
            }
            for (int i = 0; i < 2; i++)
            {
                coin = new Coin
                {
                    Amount = 0.10m,
                    Volume = 0.0115m
                };
                jar.AddCoin(coin);
            }

            for (int i = 0; i < 2; i++)
            {
                coin = new Coin
                {
                    Amount = 0.25m,
                    Volume = 0.0274m
                };
                jar.AddCoin(coin);
            }

            for (int i = 0; i < 2; i++)
            {
                coin = new Coin
                {
                    Amount = 0.50m,
                    Volume = 0.0535m
                };
                jar.AddCoin(coin);
            }
            for (int i = 0; i < 2; i++)
            {
                coin = new Coin
                {
                    Amount = 1.00m,
                    Volume = 0.0373m
                };
                jar.AddCoin(coin);
            }

            var coinsTotalAmount = jar.GetTotalAmount();

            Console.WriteLine($"Total amount of coins accumulated in the Jar:- {coinsTotalAmount}");

            jar.Reset();

        }
    }
}
