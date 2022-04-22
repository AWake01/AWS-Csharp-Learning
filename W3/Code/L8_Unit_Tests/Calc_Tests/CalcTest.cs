using L8_Unit_Tests;
using NUnit.Framework;

namespace Calc_Tests
{
    public class Tests
    {
        [Test]
        public void AddTest()
        {
            Calc c = new Calc();
            double x = 4.0;
            double y = 5.0;
            double expectedValue = 9.0;
            double actualValue = c.Add(x, y);

            Assert.AreEqual(expectedValue, actualValue);
        }

        public void AddFail()
        {
            Calc c = new Calc();
            double x = 4.0;
            double y = 5.0;
            double expectedValue = 5.0;
            double actualValue = c.Add(x, y);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void SubTest()
        {
            Calc c = new Calc();
            double x = 4.0;
            double y = 5.0;
            double expectedValue = -1;
            double actualValue = c.Subtract(x, y);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void SubFail()
        {
            Calc c = new Calc();
            double x = 4.0;
            double y = 5.0;
            double expectedValue = 8;
            double actualValue = c.Subtract(x, y);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}