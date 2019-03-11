#only having this tag in feature file makes InitializeAsync from IAsyncLifetime works for specflow
@xunit:collection(SampleCollection)
Feature: Specflow xunit support
	Running xunit test via specflow and as native xunit test should be same
Scenario: Async init of collection fixture works via Specflow Xunit
	Given I have CollectionFixture with TFixture on tests 
	And TFixture of collection implements IAsyncLifetime 
	When I run tests via specflow with xunit runner
	Then the InitializeAsync of TFixture should be called
