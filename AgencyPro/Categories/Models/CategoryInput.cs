namespace AgencyPro.Categories.Models
{
    public class CategoryInput
    {
        public virtual string Name { get; set; }
        public virtual string ContractorTitle { get; set; }
        public virtual string ContractorTitlePlural { get; set; }
        public virtual string AccountManagerTitle { get; set; }
        public virtual string AccountManagerTitlePlural { get; set; }
        public virtual string ProjectManagerTitle { get; set; }
        public virtual string ProjectManagerTitlePlural { get; set; }
        public virtual string RecruiterTitle { get; set; }
        public virtual string MarketerTitle { get; set; }
        public virtual string RecruiterTitlePlural { get; set; }
        public virtual string MarketerTitlePlural { get; set; }
        public virtual string CustomerTitle { get; set; }
        public virtual string CustomerTitlePlural { get; set; }
        public virtual string StoryTitle { get; set; }
        public virtual string StoryTitlePlural { get; set; }
    }
}