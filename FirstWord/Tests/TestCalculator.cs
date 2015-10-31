using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using FirstWord;

namespace Tests
{
    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        public void TestInstance()
        {
            Calculator calc = new Calculator();
            object c = new Calculator();

            Assert.ReferenceEquals(c, calc);
        }

        [TestMethod]
        public void TestSumTrue()
        {
            try
            {
                Calculator calc = new Calculator();
                object c = new Calculator();

                int result = calc.Sum(3, 4);

                Assert.AreEqual(7, result);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [TestMethod]
        public void TestSumFalse()
        {
            try {
                Calculator calc = new Calculator();
                object c = new Calculator();

                int result = calc.Sum(3, 4);

                Assert.AreNotEqual(5, result);
            }
            catch (Exception e) {
                throw e;
            }
        }

        [TestMethod]
        public void TestSubTrue()
        {
            try
            {
                Calculator calc = new Calculator();
                object c = new Calculator();

                int result = calc.Sub(4, 2);

                Assert.AreEqual(2, result);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [TestMethod]
        public void TestSubFalse()
        {
            try
            {
                Calculator calc = new Calculator();
                object c = new Calculator();

                int result = calc.Sub(4, 2);

                Assert.AreNotEqual(4, result);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [TestMethod]
        public void TestMultTrue()
        {
            try
            {
                Calculator calc = new Calculator();
                object c = new Calculator();

                int result = calc.Mult(2, 2);

                Assert.AreEqual(4, result);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [TestMethod]
        public void TestMultFalse()
        {
            try
            {
                Calculator calc = new Calculator();
                object c = new Calculator();

                int result = calc.Sum(4, 2);

                Assert.AreNotEqual(3, result);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [TestMethod]
        public void TestDivTrue()
        {
            try
            {
                Calculator calc = new Calculator();
                object c = new Calculator();

                int result = calc.Div(4, 2);

                Assert.AreEqual(2, result);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        [TestMethod]
        public void TestDivFalse()
        {
            try
            {
                Calculator calc = new Calculator();
                object c = new Calculator();

                int result = calc.Div(4, 2);

                Assert.AreNotEqual(4, result);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
