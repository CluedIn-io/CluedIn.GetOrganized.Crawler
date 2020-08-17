using CluedIn.Core;
using CluedIn.Crawling.GetOrganized.Core;

using ComponentHost;

namespace CluedIn.Crawling.GetOrganized
{
    [Component(GetOrganizedConstants.CrawlerComponentName, "Crawlers", ComponentType.Service, Components.Server, Components.ContentExtractors, Isolation = ComponentIsolation.NotIsolated)]
    public class GetOrganizedCrawlerComponent : CrawlerComponentBase
    {
        public GetOrganizedCrawlerComponent([NotNull] ComponentInfo componentInfo)
            : base(componentInfo)
        {
        }
    }
}

