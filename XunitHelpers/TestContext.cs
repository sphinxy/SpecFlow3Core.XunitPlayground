using System;
using System.Threading.Tasks;
using Xunit;

namespace SpecFlow3Core.XunitPlayground.XunitHelpers

{
    public class TestContext : IDisposable, IAsyncLifetime
    {
        public  bool InitializeAsyncIsCalled = false;
        public TestContext()
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