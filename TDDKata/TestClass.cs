// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace TDDKata
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void SumMoreThanTwoNumbersReturnsMinusOne()
        {
            StringCalc calc = new StringCalc();

            int actual = calc.Sum("2,2,2");

            Assert.AreEqual(-1, actual);
        }

        [Test]
        public void EmptyArgumentReturnsMinusOne()
        {
            StringCalc calc = new StringCalc();

            int actual = calc.Sum("");

            Assert.AreEqual(-1, actual);
        }

        [Test]
        public void NullArgumentReturnsMinusOne()
        {
            StringCalc calc = new StringCalc();

            int actual = calc.Sum(null);

            Assert.AreEqual(-1, actual);
        }

        [Test]
        public void NegativeArgumentReturnsMinusOne()
        {
            StringCalc calc = new StringCalc();

            int actual = calc.Sum("2,-1");

            Assert.AreEqual(-1, actual);
        }

        [Test]
        public void NonDigitArgumentReturnsMinusOne()
        {
            StringCalc calc = new StringCalc();

            int actual = calc.Sum("2,test");

            Assert.AreEqual(-1, actual);
        }
    }
}