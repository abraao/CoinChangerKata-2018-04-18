using System;
using System.Linq;
using System.Linq.Expressions;

namespace CoinChangerKata
{
    public class CoinChanger
    {

        public int[] Change(int change, int[] availableCoins)
        {
            int[] changeCoins = new int[availableCoins.Length];

            int totalChange = 0;
            int remainingChange = change;
       

            for(int i = availableCoins.Length - 1; i > 0; i--)
            {
                if (availableCoins[i] <= remainingChange)
                {
                    changeCoins[i] = remainingChange / availableCoins[i];
                    remainingChange -= availableCoins[i] * changeCoins[i];
                    totalChange += availableCoins[i] * changeCoins[i];
                }
                else
                {
                    changeCoins[i] = 0;
                }
            }

            changeCoins[0] = change - totalChange;

            return changeCoins;
        }
    }
}
