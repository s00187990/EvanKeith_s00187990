using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EvanKeith_s00187990;

namespace PhoneAppTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange

            Phone phone = new Phone();
            phone.Price = 100;
            decimal expected = 110;

            //act
            phone.IncreasePrice(10);
            decimal actual = phone.Price;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
