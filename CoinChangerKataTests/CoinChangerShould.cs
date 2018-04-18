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
    }
}
