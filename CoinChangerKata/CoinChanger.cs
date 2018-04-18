using System;
using System.Linq;
using System.Linq.Expressions;

namespace CoinChangerKata
{
    public class CoinChanger
    {

        public int[] Change(int change, int[] coins)
        {
            int[] changeCoins = new int[coins.Length];
            for(int i = 0; i < coins.Length ; i++)
            {
                if (coins[i] == change)
                {
                    changeCoins[i] = 1;
                }
                else
                {
                    changeCoins[i] = 0;
                }
            }

            return changeCoins;
        }
    }
}
