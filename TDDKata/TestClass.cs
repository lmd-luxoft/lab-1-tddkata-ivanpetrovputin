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
        public void Sum_OneTwoAndThree_Returns_Six()
        {
            StringCalc calc = new StringCalc();

            int actual = calc.Sum("1,2\n3");

            Assert.AreEqual(6, actual);
        }

        [Test]
        public void Sum_EmptyArgument_Returns_MinusOne()
        {
            StringCalc calc = new StringCalc();

            int actual = calc.Sum("");

            Assert.AreEqual(-1, actual);
        }

        [Test]
        public void Sum_NullArgument_Returns_MinusOne()
        {
            StringCalc calc = new StringCalc();

            int actual = calc.Sum(null);

            Assert.AreEqual(-1, actual);
        }

        [Test]
        public void Sum_NegativeArgument_Returns_MinusOne()
        {
            StringCalc calc = new StringCalc();

            int actual = calc.Sum("2,-1");

            Assert.AreEqual(-1, actual);
        }

        [Test]
        public void Sum_NonDigitArgument_Returns_MinusOne()
        {
            StringCalc calc = new StringCalc();

            int actual = calc.Sum("2,test");

            Assert.AreEqual(-1, actual);
        }

        [Test]
        public void Sum_TwoFourAndThree_WithDotSeparator_Returns_Nine()
        {
            StringCalc calc = new StringCalc();

            int actual = calc.Sum("//.\n2,4.3");

            Assert.AreEqual(9, actual);
        }
    }
}