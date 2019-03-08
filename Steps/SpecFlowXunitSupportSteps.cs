using TechTalk.SpecFlow;
using SpecFlow3Core.XunitPlayground.XunitHelpers;
using Xunit;

namespace SpecFlow3Core.XunitPlayground.Steps
{
    [Binding]
    public class SpecFlowXunitSupportSteps
    {
        private TestContext _testContext;

        public SpecFlowXunitSupportSteps(TestContext testContext)
        {
            _testContext = testContext;
        }

        [Given(@"I have CollectionFixture with TFixture on tests")]
        public void GivenIHaveCollectionFixtureWithTFixtureOnTests()
        {
            //manually confirm that we have [Collection(nameof(TestContextCollection))] on this steps
        }

        [Given(@"TFixture of collection implements IAsyncLifetime")]
        public void GivenTFixtureOfCollectionImplementsIAsyncLifetime()
        {
            //manually confirm that TestContext has IAsyncLifetime
        }

        [When(@"I run tests via specflow with xunit runner")]
        public void WhenIRunTestsViaSpecflowWithXunitRunner()
        {
        }

        [Then(@"the InitializeAsync of TFixture should be called")]
        public void ThenTheInitializeAsyncOfTFixtureShouldBeCalled()
        {
            Assert.True(_testContext.InitializeAsyncIsCalled);
            //todo Somehow find that it's the same instance we have in CollectionInitialize, not a second instance created by BoDi.IObjectContainer 
        }


    }
}
