using CluedIn.Crawling.GetOrganized.Core;

namespace CluedIn.Crawling.GetOrganized
{
    public class GetOrganizedCrawlerJobProcessor : GenericCrawlerTemplateJobProcessor<GetOrganizedCrawlJobData>
    {
        public GetOrganizedCrawlerJobProcessor(GetOrganizedCrawlerComponent component) : base(component)
        {
        }
    }
}
