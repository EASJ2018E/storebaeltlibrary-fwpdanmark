using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StorebæltLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMC()
        {
            MC mc = new MC();

            string a = mc.Køretøjet();

            Assert.AreEqual(a,"MC");
        }

        [TestMethod]
        public void TestMC2()
        {
            MC mc = new MC();

            decimal a = mc.Pris(false);

            Assert.AreEqual(a, 125m);
        }

        [TestMethod]
        public void TestMC3()
        {
            MC mc = new MC();

            decimal a = mc.Pris(true);

            Assert.AreEqual(a, (125m/100m)*95m);
        }

        [TestMethod]
        public void TestBil()
        {
            Bil bil = new Bil();

            decimal a = bil.Pris(false);

            Assert.AreEqual(a,240m);
        }

        [TestMethod]
        public void TestBildato()
        {
            Bil bil = new Bil();

            bil.Dato = new DateTime(2018,9,22);
            decimal a = bil.Pris(false);

            Assert.AreEqual(a, (240m/100m)*80m);
        }

        [TestMethod]
        public void TestBildato2()
        {
            Bil bil = new Bil();

            bil.Dato = new DateTime(2018, 9, 22);
            decimal a = bil.Pris(true);
            decimal res = (240m / 100m) * 80m;

            Assert.AreEqual(a, (res / 100m) * 95m);
        }

        [TestMethod]
        public void TestBil2()
        {
            Bil bil = new Bil();

            decimal a = bil.Pris(true);
            decimal result = (240m/100m)*95m;
            
            
            Assert.AreEqual(a, result);
        }

        [TestMethod]
        public void TestBildato5()
        {
            Bil bil = new Bil();

            bil.Dato = new DateTime(2018, 9, 22);
            decimal a = bil.Pris(false);

            Assert.AreEqual(a, (240m / 100m) * 80m);


        }

        [TestMethod]
        public void TestDato()
        {
            Bil bil = new Bil();

            bool a = bil.IsWeekend(DateTime.Now);
            Assert.AreEqual(a,false);


        }
    }
}
