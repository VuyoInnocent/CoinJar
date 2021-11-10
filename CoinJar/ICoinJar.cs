using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    public interface ICoinJar
    {
        //Jar methods
        void AddCoin(ICoin coin);
        decimal GetTotalAmount();
        void Reset();

        //Jar properties
        decimal TotalVolume { get; set; }
        decimal UsedVolume { get; set; }
        decimal CoinsTotalAmount { get; set; }
    }
}
