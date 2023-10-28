namespace AgencyPro.BillingCategories.Models
{
    public class BillingCategoryOutput
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsStoryBucket { get; set; }
        public bool IsPrivate { get; set; }
    }
}
