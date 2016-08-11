using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication3.Controllers;
using System.Collections.Generic;

namespace UnitTestProjectCodeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new CodeTestController();
            List<long> expectedResult = new List<long>();
            expectedResult.Add(19);
            expectedResult.Add(28);
            expectedResult.Add(37);
            expectedResult.Add(46);
            expectedResult.Add(55);
            expectedResult.Add(64);
            expectedResult.Add(73);
            expectedResult.Add(82);
            expectedResult.Add(91);
            List<long> result = controller.Get("100");
            Assert.AreEqual(expectedResult.Count, result.Count);
            for(int i = 0; i < expectedResult.Count; i++)
                Assert.AreEqual(expectedResult[i], result[i]);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var controller = new CodeTestController();
            List<long> expectedResult = new List<long>();
            List<long> result = controller.Get("0");
            Assert.AreEqual(expectedResult.Count, result.Count);
          
        }
        [TestMethod]
        public void TestMethod3()
        {
            var controller = new CodeTestController();
            List<long> expectedResult = new List<long>();
            expectedResult.Add(19);
            List<long> result = controller.Get("19");
            Assert.AreEqual(expectedResult.Count, result.Count);
            for (int i = 0; i < expectedResult.Count; i++)
                Assert.AreEqual(expectedResult[i], result[i]);
        }
        [TestMethod]
        public void TestMethod4()
        {
            var controller = new CodeTestController();
            List<long> expectedResult = new List<long>();
            List<long> result = controller.Get("ACD42");
            Assert.AreEqual(expectedResult.Count, result.Count);

        }
    }
}
