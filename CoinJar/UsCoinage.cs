using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    public abstract class UsCoinage
    {
        public abstract Coin GetCoinByAmount(decimal amount);
    }
}
