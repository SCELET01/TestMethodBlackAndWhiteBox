using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestMethodBlackAndWhiteBox;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            Test test = new Test();
            Assert.IsTrue(test.Sum(3,8) == 11);
        }
        [TestMethod]
        public void TestMethod2() 
        { 
            Test test = new Test();
            Assert.IsTrue(test.Raznosti(5, 2) == 3);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Test test = new Test();
            Assert.IsTrue(test.Del(-10, -2) == 5);
        }
        [TestMethod]
        public void TestMethod4()
        {
            Test test = new Test();
            Assert.IsTrue(test.Proizv(2, 5) == 10);
        }
        [TestMethod]
        public void TestMethod5()
        {
            Test test = new Test();
            Assert.IsTrue(test.Vosved(5) == 25);
        }
        [TestMethod]
        public void TestMethod6()
        {
            Test test = new Test();
            Assert.IsTrue(test.Izvlech(9) == 3);
        }
        [TestMethod]
        public void TestMethod7()
        {
            Test test = new Test();
            Assert.IsTrue(test.Procent(5, 5) == 0.25);
        }
        [TestMethod]
        public void TestMethod8()
        {
            Test test = new Test();
            Assert.IsTrue(test.Log(1) == 0);
        }
        [TestMethod]
        public void TestMethod9()
        {
            Test test = new Test();
            Assert.IsTrue(test.Sin(90) == 1);
        }
        [TestMethod]
        public void TestMethod10()
        {
            Test test = new Test();
            Assert.IsTrue(test.Ctg(90) == 0);
        }
    }
}
