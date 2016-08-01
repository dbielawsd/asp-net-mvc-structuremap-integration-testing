using AspNetMvcStructureMapIntegrationTesting.IntegrationTests.Test;
using AspNetMvcStructureMapIntegrationTesting.Retrievers.Interfaces;
using NUnit.Framework;

namespace AspNetMvcStructureMapIntegrationTesting.IntegrationTests.Retrievers
{
    [TestFixture]
    public class When_retrieving_data
    {
        [SetUp]
        public void SetUp()
        {
            var container = TestSetup.Setup();
            _classUnderTest = container.GetInstance<IDataRetriever>();
            _result = _classUnderTest.Retrieve();
        }

        [Test]
        public void Then_the_found_data_is_returned()
        {
            Assert.That(_result, Is.Not.Null);
        }

        private IDataRetriever _classUnderTest;
        private string _result;
    }
}
