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

        [TestMethod]
        public void Input_2_should_return_true()
        {
            IsPrimeShouldBeTrue(2);
        }

        [TestMethod]
        public void Input_3_should_return_true()
        {
            IsPrimeShouldBeTrue(3);
        }

        [TestMethod]
        public void Input_5_should_return_true()
        {
            IsPrimeShouldBeTrue(5);
        }

        [TestMethod]
        public void Input_1_should_return_false()
        {
            IsPrimeShouldBeFalse(1);
        }

        [TestMethod]
        public void Input_4_should_return_false()
        {
            IsPrimeShouldBeFalse(4);
        }

        [TestMethod]
        public void Input_n1_should_return_false()
        {
            IsPrimeShouldBeFalse(-1);
        }

        private static void IsPrimeShouldBeFalse(int n)
        {
            var kata = new Kata();
            var actual = kata.IsPrime(n);
            Assert.IsFalse(actual);
        }
        private static void IsPrimeShouldBeTrue(int n)
        {
            var kata = new Kata();
            var actual = kata.IsPrime(n);
            Assert.IsTrue(actual);
        }
    }

    public class Kata
    {
        public bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }

            for (var i = 2; i < n - 1; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
