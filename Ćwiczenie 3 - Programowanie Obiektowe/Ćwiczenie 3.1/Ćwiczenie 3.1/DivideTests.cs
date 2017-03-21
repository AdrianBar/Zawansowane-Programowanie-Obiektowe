using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie_3._1
{
    class DivideTests
    {
        [Test]
        public void DividePlusPlus()
        {
            var Divide = new DivideNumbers();
            double wynik = Divide.DivideNumber(12, 4);
            Assert.AreEqual(3, wynik);
        }
        [Test]
        public void DividePlusMinus()
        {
            var Divide = new DivideNumbers();
            double wynik = Divide.DivideNumber(10, -2);
            Assert.AreEqual(-5,wynik);
        }
        [Test]
        public void ZeroDivide()
        {
            var Divide = new DivideNumbers();
            double wynik = Divide.DivideNumber(0, 5);
            Assert.AreEqual(0, wynik);
        }
        [Test]
        public void DivideZero()
        {
            var Divide = new DivideNumbers();
            double wynik = Divide.DivideNumber(5, 0);
            Assert.AreEqual(typeof(DivideByZeroException), wynik);
        }
    }
}
