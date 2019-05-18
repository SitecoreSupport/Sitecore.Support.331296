namespace Sitecore.Support.Analytics.Aggregation
{
  using ContentSearch;
  internal class AggregationHelper
  {
    private static readonly string AnalyticsIndexName = ContentSearchManager.SearchConfiguration.AnalyticsIndexName;

    internal static bool IsAnalyticsIndexActive()
    {
      ISearchIndex analyticsIndex;

      if (ContentSearchManager.SearchConfiguration == null)
        return false;
      if (ContentSearchManager.SearchConfiguration.Indexes == null)
        return false;
      if (string.IsNullOrEmpty(AnalyticsIndexName))
        return false;
      if (!ContentSearchManager.SearchConfiguration.Indexes.TryGetValue(AnalyticsIndexName, out analyticsIndex))
        return false;
      if (analyticsIndex == null || analyticsIndex.IndexingState != IndexingState.Started)
        return false;
      return true;
    }
  }
}