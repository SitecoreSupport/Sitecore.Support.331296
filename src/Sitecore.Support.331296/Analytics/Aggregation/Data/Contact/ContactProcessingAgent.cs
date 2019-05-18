namespace Sitecore.Support.Analytics.Aggregation.Data.Contact
{
  [UsedImplicitly]
  public class ContactProcessingAgent : Sitecore.Analytics.Aggregation.Data.Contact.ContactProcessingAgent
  {
    public override void Execute()
    {
      if (AggregationHelper.IsAnalyticsIndexActive())
        base.Execute();
    }
  }
}