using KeesTalksTech.Utilities.Latin.Numerals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumerals.Tests
{
    [TestClass]
    public class ToRomanBadInput
    {
        [TestMethod]
        [DataRow(0)]
        [DataRow(5000)]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void ReturnArgumentOutOfRange(int input)
        {
            new RomanNumeral(input).ToString();
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void TestForBadInputString()
        {
            var result = RomanNumeral.Parse("MIKAEL").Number;
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void test_negative_input()
        {
            var result = new RomanNumeral(-5).ToString();
        }
    }
}
