using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    public interface ICoin
    {
        decimal Amount { get; set; }
        decimal Volume { get; set; }
        public abstract Coin GetCoinByAmount(decimal amount);
    }
}
