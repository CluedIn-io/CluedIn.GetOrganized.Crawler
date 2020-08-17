using System.Collections.Generic;

using CluedIn.Core.Crawling;
using CluedIn.Crawling.GetOrganized.Core;
using CluedIn.Crawling.GetOrganized.Infrastructure.Factories;

namespace CluedIn.Crawling.GetOrganized
{
    public class GetOrganizedCrawler : ICrawlerDataGenerator
    {
        private readonly IGetOrganizedClientFactory clientFactory;
        public GetOrganizedCrawler(IGetOrganizedClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public IEnumerable<object> GetData(CrawlJobData jobData)
        {
            if (!(jobData is GetOrganizedCrawlJobData getorganizedcrawlJobData))
            {
                yield break;
            }

            var client = clientFactory.CreateNew(getorganizedcrawlJobData);

            //retrieve data from provider and yield objects
            
        }       
    }
}
