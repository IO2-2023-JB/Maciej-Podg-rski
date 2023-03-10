using lab1_IO2;
using System.Text;

namespace Testy
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd1()
        {
            Assert.AreEqual(0, Calculator.Add(""));
        }
        [TestMethod]
        public void TestAdd2()
        {
            double d = 0.123;
            string s = "0.123";
            Assert.AreEqual(d, Calculator.Add(s));
        }
        [TestMethod]
        public void TestAdd3()
        {
            double d = 1.46;
            string s = "1.23,0.23";
            Assert.AreEqual(d, Calculator.Add(s));
        }
        [TestMethod]
        public void TestAdd4()
        {
            double d = 2;
            string s = "1.23\n0.77";
            Assert.AreEqual(d, Calculator.Add(s));
        }
        [TestMethod]
        public void TestAdd5()
        {
            double d1 = 30.28;
            string s1 = "9.89,3.15,8.02\n9.22";
            Assert.AreEqual(d1, Calculator.Add(s1));

            double d2 = 12.32;
            string s2 = "2.01\n1.89,3.27\n5.15";
            Assert.AreEqual(d2, Calculator.Add(s2));

            double d3 = 51.457;
            string s3 = "10.657,3.892\n15.413\n7.715\n13.78";
            Assert.AreEqual(d3, Calculator.Add(s3));
        }
        [TestMethod]
        public void TestAdd6()
        {
            double d1 = -16.113;
            string s1 = "-10.657,3.892\n-15.413\n-7.715\n13.78";
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Calculator.Add(s1));

            double d2 = 51.457;
            string s2 = "10.657,3.892\n15.413\n7.715\n13.78";
            Assert.AreEqual(d2, Calculator.Add(s2));

        }
        [TestMethod]
        public void TestAdd7()
        {
            double d = 1002;
            string s = "1.23\n0.77,1000.1,1000";
            Assert.AreEqual(d, Calculator.Add(s));
        }
    }
}