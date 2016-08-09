using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FareyGeneratorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestZero()
        {
            var result = FareyGeneratorLib.FareyGenerator.Generate(0);
            Assert.AreEqual("0", result[0]);
        }

        [TestMethod]
        public void TestNegative()
        {
            var result = FareyGeneratorLib.FareyGenerator.Generate(-2);
            Assert.AreEqual("0", result[0]);
        }

        [TestMethod]
        public void TestThree_VerifyResult()
        {
            var result = FareyGeneratorLib.FareyGenerator.Generate(3);
            Assert.AreEqual(5, result.Count);
        }

        [TestMethod]
        public void TestThree_VerifyDetails()
        {
            var result = FareyGeneratorLib.FareyGenerator.Generate(3);
            var expected = new List<string>() { "0/1", "1/3", "1/2", "2/3", "1/1" };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestOne_VerifyCount()
        {
            var result = FareyGeneratorLib.FareyGenerator.Generate(1);
            Assert.AreEqual(2, result.Count);
        }
    }
}
