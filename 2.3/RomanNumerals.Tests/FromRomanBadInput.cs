using KeesTalksTech.Utilities.Latin.Numerals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumerals.Tests
{
    [TestClass]
    public class FromRomanBadInput
    {
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void test_blank()
        {
            var result = RomanNumeral.Parse("").Number;
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void test_null()
        {
            var result = RomanNumeral.Parse(null).Number;
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void test_repeated_pairs()
        {
            var result = RomanNumeral.Parse("IVIV").Number;
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void test_too_many_repeated_numerals()
        {
            var result = RomanNumeral.Parse("VVVVVXIIVIIXVIXVXIVIXVIXVIX").Number;
        }

        [TestMethod]
        public void test_lower_case()
        {
            Assert.AreEqual(5, RomanNumeral.Parse("v").Number);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void test_invalid_character()
        {
            var result = RomanNumeral.Parse("S").Number;
        }
    }
}
