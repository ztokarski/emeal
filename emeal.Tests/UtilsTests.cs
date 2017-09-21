using NUnit.Framework;
using emeal.Models.Utils;

namespace emeal.Tests
{
    [TestFixture]
    internal class UtilsTests
    {
        [Test]
        public void InRangeTest()
        {
            const int valueInRange = 5;
            const int valueOutsideRange = 55;
            const int rangeBottom = 1;
            const int rangeTop = 5;

            var trueResult = valueInRange.InRange(rangeBottom, rangeTop);
            var falseResult = valueOutsideRange.InRange(rangeBottom, rangeTop);

            Assert.That(trueResult, Is.True);
            Assert.That(falseResult, Is.False);
        }


        [Test]
        public void TestCheckUrlValid()
        {
            const string validSource = "https://stackoverflow.com/";
            var invalidSource = string.Empty;

            Assert.That(validSource.CheckUrlValid(), Is.True);
            Assert.That(invalidSource.CheckUrlValid(), Is.False);
        }
    }
}