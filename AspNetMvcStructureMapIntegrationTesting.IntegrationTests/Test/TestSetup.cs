using StructureMap;

namespace AspNetMvcStructureMapIntegrationTesting.IntegrationTests.Test
{
    public class TestSetup
    {
        public static IContainer Container { get; private set; }

        public static IContainer Setup()
        {
            Container = new Container();
            Container.Configure(init => init.AddRegistry<TestIocRegistry>());

            return Container;
        }
    }
}