using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinChangerKata;
using NUnit.Framework;

namespace CoinChangerKataTests
{
    [TestFixture]
    public class CoinChangerShould
    {
        private readonly CoinChanger coinChanger = new CoinChanger();

        [Test]
        public void Return_1_cent_when_change_is_1_cent_and_coin_is_1_cent()
        {
            int[] change = coinChanger.Change(1, new int[] { 1 });

            Assert.AreEqual(new int[] {1}, change);
        }
    }
}
