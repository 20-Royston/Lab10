using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestSuite
    {
        private float result = 0.0f;

        [Test]
        public void TestAdditional()
        {
            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }

        [Test]
        public void TestMiuns()
        {
            result = Calculator.CalculatePair(5, 2, "-");
            Assert.AreEqual(result, 3);
        }

        [Test]
        public void TestMultiply()
        {
            result = Calculator.CalculatePair(5, 2, "*");
            Assert.AreEqual(result, 10);
        }

        [Test]
        public void TestDivide()
        {
            result = Calculator.CalculatePair(10, 2, "/");
            Assert.AreEqual(result, 5);
        }

        [Test]
        public void TestPower()
        {
            result = Calculator.CalculatePair(9, 3, "^");
            Assert.AreEqual(result, 729);
        }

        [Test]
        public void TestSquare()
        {
            result = Calculator.CalculatePair(25, 0, "√");
            Assert.AreEqual(result, 5);
        }


        [UnityTest]
        public IEnumerator TestUnityAddition()
        {
            yield return null;

            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);

        }
    }
}
