using NUnit.Framework;

namespace _3Line_Algorithm_Test.Test
{
    [TestFixture]
    public class SmallestPositiveNumberTest
    {
        [Test, Description("should handle normal case")]
        public void TestIncrement()
        {
            var arr = new int[] {5, 7, 4};
            const int expected = 1;
            Assert.AreEqual(expected, Challenge.SmallestPositiveNumber(arr));
        }

        [Test, Description("should handle separated numbers")]
        public void TestCarry()
        {
            var arr = new int[] {1, 2, 4, 3, 9};
            const int expected = 5;
            Assert.AreEqual(expected, Challenge.SmallestPositiveNumber(arr));
        }

        [Test, Description("should handle a single element")]
        public void TestSingleElementWithCarry()
        {
            var arr = new int[] {9};
            const int expected = 1;
            Assert.AreEqual(expected, Challenge.SmallestPositiveNumber(arr));
        }

        [Test, Description("should handle a single small element")]
        public void TestSingleElementWithoutCarry()
        {
            var arr = new int[] {1};
            const int expected = 2;
            Assert.AreEqual(expected, Challenge.SmallestPositiveNumber(arr));
        }

        [Test, Description("should handle repeated element")]
        public void TestLongerCarry()
        {
            var arr = new int[] {1, 2, 1, 3, 3, 4, 5, 6, 6, 9, 9, 9};
            const int expected = 7;
            Assert.AreEqual(expected, Challenge.SmallestPositiveNumber(arr));
        }

        [Test, Description("should handle negative element")]
        public void TestMultipleCarries()
        {
            var arr = new int[] {-1, -9, -9, -9};
            const int expected = 1;
            Assert.AreEqual(expected, Challenge.SmallestPositiveNumber(arr));
        }
    }
}