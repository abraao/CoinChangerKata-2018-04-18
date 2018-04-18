﻿using CoinChangerKata;
using NUnit.Framework;

namespace CoinChangerKataTests
{
    [TestFixture]
    public class CoinChangerShould
    {
        private readonly CoinChanger _coinChanger = new CoinChanger();

        [TestCase(1, new[] { 1 }, new[] { 1 })]
        [TestCase(2, new[] { 1 }, new[] { 2 })]
        [TestCase(5, new[] { 1, 5 }, new[] { 0, 1 })]
        [TestCase(6, new[] { 1, 5 }, new[] { 1, 1 })]
        [TestCase(10, new[] { 1, 5 }, new[] { 0, 2 })]
        [TestCase(13, new[] { 1, 2, 5 }, new[] { 1, 1, 2 })]
        [TestCase(14, new[] { 2, 5 }, new[] { 2, 2 })]
        public void Return_correct_change(int change, int[] availableCoins, int[] expectedChangeCoins)
        {
            int[] changeCoins = _coinChanger.Change(change, availableCoins);

            Assert.AreEqual(expectedChangeCoins, changeCoins);
        }
    }
}
