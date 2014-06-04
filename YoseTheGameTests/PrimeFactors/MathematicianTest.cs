using System.Collections.Generic;
using NUnit.Framework;
using YoseTheGame.PrimeFactors;

namespace YoseTheGameTests.PrimeFactors
{
    [TestFixture]
    class MathematicianTest
    {
        Genius einstein = new Mathematician();

        [Test]
        public void CanDecompose2()
        {
            Assert.That(einstein.Decompose(2), Is.EqualTo(new List<int> { 2 }));
        }

        [Test]
        public void CanDecompose4()
        {
            Assert.That(einstein.Decompose(4), Is.EqualTo(new List<int> { 2, 2 }));
        }
    }
}
