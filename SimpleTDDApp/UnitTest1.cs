using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleTDDApp.learning;
namespace SimpleTDDApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Addition()
        {
            BasicMath bm = new BasicMath();
            int res = bm.Add(20, 10);
            Assert.AreEqual(res, 30);
        }


        [TestMethod]
        public void Test_Subtraction()
        {
            BasicMath bm = new BasicMath();
            int res = bm.Sub(20, 10);
            Assert.AreEqual(res, 10);
        }


        [TestMethod]
        public void Test_Devide()
        {
            BasicMath bm = new BasicMath();
            int res = (int)bm.Devide(20, 2);
            Assert.AreEqual(res, 10);
        }


        [TestMethod]
        public void Test_Multiply()
        {
            BasicMath bm = new BasicMath();
            int res = (int)bm.Multi(20, 2);
            Assert.AreEqual(res, 40);
        }
    }
}