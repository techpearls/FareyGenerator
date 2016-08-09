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
            int result = FareyGenerator.Generate(0);
            Assert.AreEqual(0, result);
        }
    }
}
