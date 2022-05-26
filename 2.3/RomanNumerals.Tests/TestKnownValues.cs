using KeesTalksTech.Utilities.Latin.Numerals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumerals.Tests
{
    [TestClass]
    public class TestKnownValues
    {
        [TestMethod]
        [DataRow("V",5)]
        [DataRow("X",10)]
        [DataRow("MCMX",1910)]
        public void test_to_known_values(string numeral, int expected)
        {
            Assert.AreEqual(expected,RomanNumeral.Parse(numeral).Number);
        }


        [TestMethod]
        [DataRow(5,"V")]
        [DataRow(10,"X")]
        [DataRow(1910, "MCMX")]
        public void test_from_known_values(int number, string expected)
        {
            Assert.AreEqual(expected, new RomanNumeral(number).ToString());
        }
    }
}
