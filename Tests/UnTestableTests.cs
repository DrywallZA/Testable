using UnTestableTests;
using Xunit;

namespace Tests.UnTestableTest
{
    public class UnTestableTests
    {

        [Fact]
        public void GetCurrentTimeGreeting_ShouldReturnMorning_WhenBeforeNoon_STATIC_DEPENDANCY()
        {
            var untestableTests = new UnTestable();
            var result = untestableTests.GetCurrentTimeGreeting();

            Assert.Equal("Good Morning", result);
        }

    }
}