using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


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
        public void TestThree()
        {
            var result = FareyGeneratorLib.FareyGenerator.Generate(3);
            Assert.AreEqual(5, result.Length);
        }
    }
}
