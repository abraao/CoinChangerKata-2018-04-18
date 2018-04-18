using CoinChangerKata;
using NUnit.Framework;

namespace CoinChangerKataTests
{
    [TestFixture]
    public class CoinChangerShould
    {
        private readonly CoinChanger _coinChanger = new CoinChanger();

        [Test]
        public void Return_1_cent_when_change_is_1_cent_and_coin_is_1_cent()
        {
            int[] change = _coinChanger.Change(1, new int[] { 1 });

            Assert.AreEqual(new int[] {1}, change);
        }

        [Test]
        public void Return_2_cents_coins_when_change_is_2_cents_and_coin_is_1_cent()
        {
            int[] change = _coinChanger.Change(2, new int[] { 1 });

            Assert.AreEqual(new int[] {2}, change);
        }

        [Test]
        public void Return_5_cent_coin_when_change_is_5_cents_and_coin_is_1_5_cents()
        {
            int[] change = _coinChanger.Change(5, new int[] { 1, 5 });

            Assert.AreEqual(new int[] { 0, 1 }, change);
        }

        [Test]
        public void Return_1_5_cent_coin_when_change_is_6_cents_and_coin_is_1_5_cents()
        {
            int[] change = _coinChanger.Change(6, new int[] { 1, 5 });

            Assert.AreEqual(new int[] { 1, 1 }, change);
        }
    }
}
