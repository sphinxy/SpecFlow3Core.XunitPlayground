using System;
using System.Threading.Tasks;
using Xunit;

namespace SpecFlow3Core.XunitPlayground.XunitHelpers

{
    public class TestFixture : IDisposable, IAsyncLifetime
    {
        public  bool InitializeAsyncIsCalled = false;
        public TestFixture()
        {
        }

        public void Dispose()
        {
        }
        public Task InitializeAsync()
        {
            InitializeAsyncIsCalled = true;
            return Task.CompletedTask;
        }

        public Task DisposeAsync()
        {
            return Task.CompletedTask;
        }
    }
}