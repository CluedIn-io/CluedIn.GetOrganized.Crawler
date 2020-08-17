using Castle.Windsor;
using CluedIn.Core;
using CluedIn.Core.Providers;
using CluedIn.Crawling.GetOrganized.Infrastructure.Factories;
using Moq;

namespace CluedIn.Provider.GetOrganized.Unit.Test.GetOrganizedProvider
{
    public abstract class GetOrganizedProviderTest
    {
        protected readonly ProviderBase Sut;

        protected Mock<IGetOrganizedClientFactory> NameClientFactory;
        protected Mock<IWindsorContainer> Container;

        protected GetOrganizedProviderTest()
        {
            Container = new Mock<IWindsorContainer>();
            NameClientFactory = new Mock<IGetOrganizedClientFactory>();
            var applicationContext = new ApplicationContext(Container.Object);
            Sut = new GetOrganized.GetOrganizedProvider(applicationContext, NameClientFactory.Object);
        }
    }
}
