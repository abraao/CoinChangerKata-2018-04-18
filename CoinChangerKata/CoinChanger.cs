using System;
using System.Linq;
using System.Linq.Expressions;

namespace CoinChangerKata
{
    public class CoinChanger
    {

        public int[] Change(int change, int[] availableCoins)
        {
            int[] sortedCoins = (int[]) availableCoins.Clone(); 
            Array.Sort(sortedCoins);
            int[] changeCoins = new int[availableCoins.Length];

            int totalChange = 0;
            int remainingChange = change;

            for(int i = sortedCoins.Length - 1; i > 0; i--)
            {
                int position = Array.IndexOf(availableCoins, sortedCoins[i]);
                if (sortedCoins[i] <= remainingChange)
                {
                    changeCoins[position] = remainingChange / sortedCoins[i];
                    remainingChange -= sortedCoins[i] * changeCoins[position];
                    totalChange += sortedCoins[i] * changeCoins[position];
                }
                else
                {
                    changeCoins[position] = 0;
                }
            }

            int smallestCoinPosition = Array.IndexOf(availableCoins, sortedCoins[0]);
            changeCoins[smallestCoinPosition] = (change - totalChange) / sortedCoins[0];

            return changeCoins;
        }
    }
}
