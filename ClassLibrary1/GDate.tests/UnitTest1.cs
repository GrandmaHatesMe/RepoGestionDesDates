using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;

namespace GDate.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsLeapYear_AnneeBissextile_ReturnsTrue()
        {
            bool result = Class1.IsLeapYear(2024);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsLeapYear_AnneeNonBissextile_ReturnsFalse()
        {
            bool result = Class1.IsLeapYear(2023);
            Assert.IsFalse(result);
        }

        // ✅ Test DayOfYear valide
        [TestMethod]
        public void DayOfYear_1Janvier_Returns1()
        {
            int result = Class1.DayOfYear(1, 1, 2024);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void DayOfYear_31DecembreAnneeBissextile_Returns366()
        {
            int result = Class1.DayOfYear(12, 31, 2024);
            Assert.AreEqual(366, result);
        }

        // ❌ Mois invalide
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DayOfYear_MoisInvalide_ThrowsException()
        {
            Class1.DayOfYear(13, 10, 2024);
        }

        // ❌ Jour invalide
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DayOfYear_JourInvalide_ThrowsException()
        {
            Class1.DayOfYear(2, 30, 2023);
        }
    }
}
