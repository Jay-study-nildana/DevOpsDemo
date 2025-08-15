namespace WeatherUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Passing()
        {
            Assert.True(true);
        }

        [Fact]
        public void Test_Failing()
        {
            Assert.False(false);
        }
    }
}