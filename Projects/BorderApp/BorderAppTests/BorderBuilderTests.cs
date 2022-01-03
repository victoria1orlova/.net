using BorderApp;
using BorderApp.Model;
using Xunit;

namespace BorderAppTests
{
    public class BorderBuilderTests
    {
        private readonly BorderBuilder _target;

        public BorderBuilderTests()
        {
            _target = new BorderBuilder();
        }

        [Fact]
        public void ExamplesTableParam_string_BuildTest()
        {
            // arrange
            string[] examples =
            {
                "2 * 2 = 4",
                "2 * 5 = 10"
            };

            var tableParam = new TableParam
            {
                Length = 10,
                Height = 2
            };

            var expected =
                "╔══════════╗\n"+
                "║2 * 2 = 4 ║\n"+
                "║2 * 5 = 10║\n"+
                "╚══════════╝";

            // action
            var actual = _target.Build(examples, tableParam);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ExamplesTableParam_Positive_BuildTest()
        {
            // arrange
            string[] examples =
            {
                "2 * 2 = 4",
                "2 * 3 = 6"
            };

            var tableParam = new TableParam
            {
                Length = 9,
                Height = 2
            };

            var expected =
                "╔═════════╗\n"+
                "║2 * 2 = 4║\n"+
                "║2 * 3 = 6║\n"+
                "╚═════════╝";

            // action
            var actual = _target.Build(examples, tableParam);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
