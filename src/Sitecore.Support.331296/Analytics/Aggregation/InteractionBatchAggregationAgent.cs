namespace Sitecore.Support.Analytics.Aggregation
{
  [UsedImplicitly]
  public class InteractionBatchAggregationAgent : Sitecore.Analytics.Aggregation.InteractionBatchAggregationAgent, Sitecore.Analytics.Core.IAgent
  {
    void Sitecore.Analytics.Core.IAgent.Execute()
    {
      if (AggregationHelper.IsAnalyticsIndexActive())
        base.Execute();
    }
  }
}