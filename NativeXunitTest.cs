using System;
using SpecFlow3Core.XunitPlayground.XunitHelpers;
using Xunit;

namespace SpecFlow3Core.XunitPlayground
{
    [Collection(nameof(SampleCollection))]
    public class NativeXunitTest
    {
        private TestFixture _testFixture;
        public NativeXunitTest(TestFixture testFixture)
        {
            _testFixture = testFixture;
        }
        [Fact]
        public void AsyncInitOfCollectionFixtureWorksViaNativeXunit()
        {
            Assert.True(_testFixture.InitializeAsyncIsCalled);
        }
    }
}
