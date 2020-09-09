using CluedIn.Core.Crawling;
using CluedIn.Crawling;
using CluedIn.Crawling.GetOrganized;
using CluedIn.Crawling.GetOrganized.Infrastructure.Factories;
using Moq;
using Shouldly;
using Xunit;

namespace Crawling.GetOrganized.Unit.Test
{
    public class GetOrganizedCrawlerBehaviour
    {
        private readonly ICrawlerDataGenerator _sut;

        public GetOrganizedCrawlerBehaviour()
        {
            var nameClientFactory = new Mock<IGetOrganizedClientFactory>();

            _sut = new GetOrganizedCrawler(nameClientFactory.Object);
        }

        [Fact]
        public void GetDataReturnsData()
        {
            var jobData = new CrawlJobData();

            _sut.GetData(jobData)
                .ShouldNotBeNull();
        }
    }
}
