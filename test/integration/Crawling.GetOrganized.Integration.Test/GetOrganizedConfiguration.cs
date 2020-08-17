using System.Collections.Generic;
using CluedIn.Crawling.GetOrganized.Core;

namespace CluedIn.Crawling.GetOrganized.Integration.Test
{
  public static class GetOrganizedConfiguration
  {
    public static Dictionary<string, object> Create()
    {
      return new Dictionary<string, object>
            {
                { GetOrganizedConstants.KeyName.ApiKey, "demo" }
            };
    }
  }
}
