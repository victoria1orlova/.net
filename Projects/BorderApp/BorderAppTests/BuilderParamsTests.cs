using BorderApp;
using BorderApp.Model;
using Xunit;

namespace BorderAppTests
{
    public class BuilderParamsTests
    {
        private readonly BuilderParams _target;

        public BuilderParamsTests()
        {
            _target = new BuilderParams();
        }
        [Fact]
        public void TestMethod()
        {
            // arrange
            string[] examples = {
                "2 * 2 = 4",
                "2 * 5 = 10",
            };

            var expected = new TableParam
            {
                Length = 10,
                Height = 2
            };

            // action
            var actual = _target.Build(examples);

            // assert
            Assert.Equal(expected.Length, actual.Length);
            Assert.Equal(expected.Height, actual.Height);
        }
    }
}
