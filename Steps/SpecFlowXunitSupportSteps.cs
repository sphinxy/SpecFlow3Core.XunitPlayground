using BoDi;
using TechTalk.SpecFlow;
using SpecFlow3Core.XunitPlayground.XunitHelpers;
using Xunit;

namespace SpecFlow3Core.XunitPlayground.Steps
{
    [Binding]

    public class TestFixtureInitHelper
    {
        private readonly IObjectContainer _objectContainer;
        private static TestFixture _testFixture;
        public TestFixtureInitHelper(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeFeature()]
        public static async void InitializeFixture()
        {
            _testFixture = new TestFixture();
            await _testFixture.InitializeAsync();
        }

        [BeforeScenario()]
        public void RegisterStaticInstanceInSpecflowDI()
        {
            _objectContainer.RegisterInstanceAs<TestFixture>(_testFixture);
        }
    }


    [Binding]
    public class SpecFlowXunitSupportSteps
    {
        private TestFixture _testFixture;

        public SpecFlowXunitSupportSteps(TestFixture testFixture)
        {
            _testFixture = testFixture;
        }

        [Given(@"I have CollectionFixture with TFixture on tests")]
        public void GivenIHaveCollectionFixtureWithTFixtureOnTests()
        {
            //manually confirm that we have [Collection(nameof(SampleCollection))] on this steps
        }

        [Given(@"TFixture of collection implements IAsyncLifetime")]
        public void GivenTFixtureOfCollectionImplementsIAsyncLifetime()
        {
            //manually confirm that TestFixture has IAsyncLifetime
        }

        [When(@"I run tests via specflow with xunit runner")]
        public void WhenIRunTestsViaSpecflowWithXunitRunner()
        {
        }

        [Then(@"the InitializeAsync of TFixture should be called")]
        public void ThenTheInitializeAsyncOfTFixtureShouldBeCalled()
        {
            Assert.True(_testFixture.InitializeAsyncIsCalled);
            //todo Somehow find that it's the same instance we have in CollectionInitialize, not a second instance created by BoDi.IObjectContainer 
        }
    }
}
