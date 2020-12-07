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
        public void SumOneAndTwoReturnsThree()
        {
            StringCalc calc = new StringCalc();

            int actual = calc.Sum("1,2");

            Assert.AreEqual(3, actual);
        }

        [Test]
        public void SumEmptyArgumentReturnsMinusOne()
        {
            StringCalc calc = new StringCalc();

            int actual = calc.Sum("");

            Assert.AreEqual(-1, actual);
        }

        [Test]
        public void SumNullArgumentReturnsMinusOne()
        {
            StringCalc calc = new StringCalc();

            int actual = calc.Sum(null);

            Assert.AreEqual(-1, actual);
        }

        [Test]
        public void SumNegativeArgumentReturnsMinusOne()
        {
            StringCalc calc = new StringCalc();

            int actual = calc.Sum("2,-1");

            Assert.AreEqual(-1, actual);
        }

        [Test]
        public void SumNonDigitArgumentReturnsMinusOne()
        {
            StringCalc calc = new StringCalc();

            int actual = calc.Sum("2,test");

            Assert.AreEqual(-1, actual);
        }
    }
}