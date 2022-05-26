using KeesTalksTech.Utilities.Latin.Numerals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumerals.Tests
{
    [TestClass]
    public class RoundTripCheck
    {
        [TestMethod]
        public void test_roundtrip()
        {
            var input = 5;
            var first = new RomanNumeral(input);
            var result = RomanNumeral.Parse(first).Number;

            Assert.AreEqual(5,result);
        }
    }
}
