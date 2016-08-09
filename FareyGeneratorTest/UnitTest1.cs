using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FareyGeneratorLib;

namespace FareyGeneratorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestZero()
        {
            string result = FareyGenerator.Generate(0);
            Assert.AreEqual("0", result);
        }

        [TestMethod]
        public void TestNegative()
        {
            string result = FareyGenerator.Generate(-1);
            Assert.AreEqual("0", result);
        }
    }
}
