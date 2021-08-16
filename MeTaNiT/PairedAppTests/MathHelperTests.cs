using PairedApp;
using Xunit;

namespace PairedAppTests
{
    // test's class
    public class MathHelperTests
    {
        // field
        private readonly MathHelper _target;

        // ctor constructor
        public MathHelperTests()
        {
            _target = new MathHelper();
        }

        [Fact] // attribute
        public void Number_IsEvenNumber_True() // test method
        {
            // arrange
            var number = 2;
            
            // action
            var actual = _target.IsEvenNumber(number);

            // assert
            Assert.True(actual);
        }

        [Fact]
        public void Number_IsEvenNumber_False()
        {
            // arrange
            var number = 3;

            // action
            var actual = _target.IsEvenNumber(number);

            // assert
            Assert.False(actual);
        }
    }
}