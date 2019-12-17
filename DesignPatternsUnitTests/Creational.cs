using Creational;
using Xunit;

namespace DesignPatternsUnitTests
{
    public class Creational
    {
        [Fact]
        public void SingltonPatternSimple_CompareSomeValue()
        {
            var InstacneOne = SingltonPatternSimple.Instance;
            var InstacneTwo = SingltonPatternSimple.Instance;
            Assert.Same(InstacneOne, InstacneTwo);

            InstacneOne.SomeValue++;
            Assert.Equal(InstacneOne.SomeValue, InstacneTwo.SomeValue);
        }
        [Fact]
        public void SingltonPatternThreadSafe_CompareSomeValue()
        {
            var InstacneOne = SingletonPatternThreadSafe.Instance;
            var InstacneTwo = SingletonPatternThreadSafe.Instance;
            Assert.Same(InstacneOne, InstacneTwo);

            InstacneOne.SomeValue++;
            Assert.Equal(InstacneOne.SomeValue, InstacneTwo.SomeValue);
        }
    }
}
