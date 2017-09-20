using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170920_IsANumberPrime
{
    [TestClass]
    public class IsPrimeTests
    {
        [TestMethod]
        public void Input_0_should_return_false()
        {
            IsPrimeShouldBeFalse(0);
        }

        private static void IsPrimeShouldBeFalse(int n)
        {
            var kata = new Kata();
            var actual = kata.IsPrime(n);
            Assert.IsFalse(actual);
        }
    }

    public class Kata
    {
        public bool IsPrime(int n)
        {
            return false;
        }
    }
}
