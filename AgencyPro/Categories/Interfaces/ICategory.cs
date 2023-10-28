namespace AgencyPro.Categories.Interfaces
{
    public interface ICategory
    {
        int CategoryId { get; set; }
        string Name { get; set; }
        string ContractorTitle { get; set; }
        string ContractorTitlePlural { get; set; }
        string AccountManagerTitle { get; set; }
        string AccountManagerTitlePlural { get; set; }
        string ProjectManagerTitle { get; set; }
        string ProjectManagerTitlePlural { get; set; }
        string RecruiterTitle { get; set; }
        string MarketerTitle { get; set; }
        string StoryTitle { get; set; }
        string StoryTitlePlural { get; set; }
        string RecruiterTitlePlural { get; set; }
        string MarketerTitlePlural { get; set; }
        string CustomerTitle { get; set; }
        string CustomerTitlePlural { get; set; }
        bool Searchable { get; set; }
        decimal DefaultRecruiterStream { get; set; }
        decimal DefaultMarketerStream { get; set; }
        decimal DefaultProjectManagerStream { get; set; }
        decimal DefaultAccountManagerStream { get; set; }
        decimal DefaultContractorStream { get; set; }
        decimal DefaultAgencyStream { get; set; }
    }
}