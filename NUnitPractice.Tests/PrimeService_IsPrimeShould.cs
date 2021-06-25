using NUnit.Framework;
using System;

namespace NUnitPractice.Tests
{
    [TestFixture]
    public class PrimeService_IsPrimeShould
    {
        private PrimeService _primeService;

        [SetUp]
        public void SetUp()
        {
            _primeService = new PrimeService();
        }

        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsPrime_InputLessThan2_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.IsFalse(result, "1 should not be prime");
        }

        [Test]
        public void IsPrime_InputIs2_ReturnTrue()
        {
            var result = _primeService.IsPrime(2);

            Assert.IsTrue(result, "1 should not be prime");
        }

        [TestCase(3)]
        public void IsPrime_InputGreaterThan2_ReturnNotImplement(int value)
        {
            var actual = Assert.Catch<NotImplementedException>(() => _primeService.IsPrime(value));

            StringAssert.Contains("Please create a test first.", actual.Message);
        }
    }
}