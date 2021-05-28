using CoreFeatures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CoreFeaturesTest
{
    [TestClass]
    public class SpecialListTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_max_0_exception()
        {
            MySpecialList mySpecialList = new MySpecialList(0);
        }

        [TestMethod]
        public void Test_max_in_ctor()
        {
            MySpecialList mySpecialList = new MySpecialList(10);
            Assert.AreEqual(mySpecialList.Max, 10);
        }
        [TestMethod]
        public void Test_push_2_different_items()
        {
            MySpecialList mySpecialList = new MySpecialList(10);
            bool res1 = mySpecialList.Push(100);
            Assert.AreEqual(res1, true);
            bool res2 = mySpecialList.Push(99);
            Assert.AreEqual(res2, true);
            Assert.AreEqual(mySpecialList.Count, 2);
        }

        [TestMethod]
        public void Test_clear()
        {
            MySpecialList mySpecialList = new MySpecialList(10);
            bool res1 = mySpecialList.Push(100);
            Assert.AreEqual(res1, true);
            bool res2 = mySpecialList.Push(99);
            Assert.AreEqual(res2, true);
            mySpecialList.Clear();
            Assert.AreEqual(mySpecialList.Count, 0);
        }
    }
}
