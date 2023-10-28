using System;

namespace AgencyPro.StoryTemplates.Interfaces
{
    public interface IStoryTemplate
    {
        Guid Id { get; set; }
        int? StoryPoints { get; set; }
        string Description { get; set; }
        string Title { get; set; }
        decimal Hours { get; set; }
    }
}