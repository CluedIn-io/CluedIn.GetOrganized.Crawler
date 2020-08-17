using CluedIn.Crawling.GetOrganized.Core;

namespace CluedIn.Crawling.GetOrganized.Infrastructure.Factories
{
    public interface IGetOrganizedClientFactory
    {
        GetOrganizedClient CreateNew(GetOrganizedCrawlJobData getorganizedCrawlJobData);
    }
}
