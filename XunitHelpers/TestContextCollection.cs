using Xunit;

namespace SpecFlow3Core.XunitPlayground.XunitHelpers
{
    [CollectionDefinition(nameof(TestContextCollection))]
    public class TestContextCollection : ICollectionFixture<TestContext>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }
}