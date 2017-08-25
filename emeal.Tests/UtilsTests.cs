using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using emeal.Models;
using NUnit.Framework;
using NUnit.Framework.Internal;
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
        public void testCheckUrlValid()
        {
            const string validSource = "https://stackoverflow.com/";
            const string inValidSource = "stackoverflow.com";

            var trueResult = validSource.CheckUrlValid();
            var falseResult = inValidSource.CheckUrlValid();

            Assert.That(trueResult, Is.True);
            Assert.That(falseResult, Is.False);
        }

    }
}

