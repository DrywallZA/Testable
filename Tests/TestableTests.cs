using TestableTests;
using Xunit;

namespace Tests.TestableTest
{
    public class TestableTests
    {
        [Fact]
        public void IsSumAdded_ShouldReturnSumOfNumbers_PUBLIC()
        {
            var testableTests = new Testable();
            int result = testableTests.AddNumbers(11, 27);
            Assert.Equal(38, result);
        }

        [Fact]
        public void IsStringReturned_ShouldReturnStringIfIntIsPassed_GENERIC()
        {
            var testableTests = new Testable();
            string result = testableTests.ConvertToString<int>(1);
            Assert.Equal("1", result);
        }

        [Fact]
        public void IsStringReturned_ShouldReturnStringIfStringIsPassed_GENERIC()
        {
            var testableTests = new Testable();
            string result = testableTests.ConvertToString<string>("hello");
            Assert.Equal("hello", result);
        }

        [Fact]
        public void IsStringReturned_ShouldReturnStringIfBooleanIsPassed_GENERIC()
        {
            var testableTests = new Testable();
            string result = testableTests.ConvertToString<bool>(true);
            Assert.Equal("True", result);
        }

        [Theory]
        [InlineData("JennyBartsch", true)]
        [InlineData("Bob", false)]
        public void IsBoolReturned_ShouldReturnBoolIfStringIsGiven_VIRTUAL(string text, bool expectedResult)
        {
            var testableTests = new Testable();
            bool result = testableTests.IsStringLongEnough(text);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void IsBoolReturned_ShouldReturnTrueIfNumbersAreOdd_ABSTRACT()
        {
            List<int> ints = new List<int>() { 2, 3, 4 };

            var testableTests = new Testable();
            bool result = testableTests.IsNumberUneven(ints);
            Assert.True(result);
        }

        [Fact]
        public void IsBoolReturned_ShouldReturnFalseIfNumbersAreEven_ABSTRACT()
        {
            List<int> ints = new List<int>() { 1, 2, 3, 4 };

            var testableTests = new Testable();
            bool result = testableTests.IsNumberUneven(ints);
            Assert.False(result);
        }

    }
}