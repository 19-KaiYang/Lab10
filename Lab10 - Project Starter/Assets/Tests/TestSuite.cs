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
        // A Test behaves as an ordinary method
        [Test]
        public void TestAddition()
        {
            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);

        }

        [UnityTest]
        public IEnumerator TestUnityAddition()
        {
            yield return null;

            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }
        [Test]
        public void TestSubtraction()
        {
            result = Calculator.CalculatePair(5, 2, "-");
            Assert.AreEqual(result, 3);

        }
        [UnityTest]
        public IEnumerator TestUnitySubtraction()
        {
            yield return null;

            result = Calculator.CalculatePair(5, 2, "-");
            Assert.AreEqual(result, 3);
        }

        [UnityTest]
        public IEnumerator TestUnityMultiplication()
        {
            yield return null;

            result = Calculator.CalculatePair(5, 2, "*");
            Assert.AreEqual(result, 10);
        }
        [Test]
        public void TestMutiplication()
        {
            result = Calculator.CalculatePair(5, 2, "*");
            Assert.AreEqual(result, 10);

        }

        [UnityTest]
        public IEnumerator TestUnityDivision()
        {
            yield return null;

            result = Calculator.CalculatePair(6, 2, "/");
            Assert.AreEqual(result, 3);
        }
        [Test]
        public void TestDivision()
        {
            result = Calculator.CalculatePair(6, 2, "/");
            Assert.AreEqual(result, 3);

        }

        [UnityTest]
        public IEnumerator TestUnitySquare()
        {
            yield return null;

            result = Calculator.CalculatePair(25,0, "Sqrt");
            Assert.AreEqual(result, 5);
        }
        [Test]
        public void TestSquare()
        {
            result = Calculator.CalculatePair(25,0,"Sqrt");
            Assert.AreEqual(result, 5);

        }



        [Test]
        public void TestSuiteSimplePasses()
        {
            

        }
        [UnityTest]
        public IEnumerable TestSuiteWithEnumeratorPasses()
        {

            yield return null;
        }



        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
    }
}
