using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    public class LatestUsCoinage : UsCoinage
    {
        private List<Coin> CoinTypes { get; set; }

        public LatestUsCoinage()
        {
            CoinTypes = new List<Coin>
            {
                new Coin(0.01m, 0.0146m),
                new Coin(0.05m, 0.0233m),
                new Coin(0.10m, 0.0115m),
                new Coin(0.25m, 0.0274m),
                new Coin(0.50m, 0.0535m),
                new Coin(1.00m, 0.0373m)
            };
        }
        public override Coin GetCoinByAmount(decimal amount)
        {
            Coin coinModel = null;

            foreach (Coin coin in CoinTypes)
            {
                if (coin.Amount == amount)
                {
                    coinModel = coin;
                    break;
                }
            }
            if (coinModel !=null)
            {
                return new Coin(coinModel.Amount, coinModel.Volume);
            }
            else
            {
               return null;
            }
        }
    }
}
