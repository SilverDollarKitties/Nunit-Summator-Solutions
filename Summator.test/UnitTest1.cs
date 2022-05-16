using NUnit.Framework;

namespace Summator.test
{
    public class Tests
    {
        [Test]
        public void Test_Sum_TwoPositiveNumbers()
        {
            int result = Summator.Sum(new int [] { 1, 2, });

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Test_Sum_OnePositiveNumber()
        {
            int result = Summator.Sum(new int[] { 1 });

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Test_EmptyArray()
        {
            int result = Summator.Sum(new int[] { } );

            Assert.That(result, Is.EqualTo(0));
        }
    }
}