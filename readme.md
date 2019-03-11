Test program for specflow 3 .net core with xunit runner

Pre-setup for VS is required: https://specflow.org/2018/specflow-3-public-preview-now-available/

It has two tests of usage ICollectionFixture<TFixture> of xunit (https://xunit.github.io/docs/shared-context#collection-fixture)

Also, this TFixture implements IAsyncLifeTime https://github.com/xunit/xunit/blob/master/src/xunit.core/IAsyncLifetime.cs which supposed to be called while initializing TFixture. 
  
TFixture supported to be initialized once per collection and then injected via contructor to xunit test. 
It works for native xunit tests.

For specflow tests, it works partly. 

IAsyncLifeTimes works, thanks to https://github.com/techtalk/SpecFlow/pull/1380 and using @xunit:collection(TestContextCollection). But then another new instance of TFixture is instantiated and injected in specflow steps. Also, InitializeAsync is not called for second instance.
