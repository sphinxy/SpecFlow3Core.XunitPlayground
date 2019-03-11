using Xunit;

namespace SpecFlow3Core.XunitPlayground.XunitHelpers
{
    [CollectionDefinition(nameof(SampleCollection))]
    public class SampleCollection : ICollectionFixture<TestFixture>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }
}