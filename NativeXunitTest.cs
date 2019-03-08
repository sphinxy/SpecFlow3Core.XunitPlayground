using System;
using SpecFlow3Core.XunitPlayground.XunitHelpers;
using Xunit;

namespace SpecFlow3Core.XunitPlayground
{
    [Collection(nameof(TestContextCollection))]
    public class NativeXunitTest
    {
        private TestContext _testContext;
        public NativeXunitTest(TestContext testContext)
        {
            Type reflectedTestContext = Type.GetType("specflow3core.xunit.playground.XunitHelpers.TestContext");
            _testContext = testContext;
        }
        [Fact]
        public void AsyncInitOfCollectionContextWorksViaNativeXunit()
        {
            Assert.True(_testContext.InitializeAsyncIsCalled);
        }
    }
}
