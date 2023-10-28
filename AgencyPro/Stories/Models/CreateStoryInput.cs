using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AgencyPro.Stories.Models
{
    public class CreateStoryInput
    {
        [Required] public virtual string Title { get; set; }

        public virtual string Description { get; set; }

        public virtual int StoryPoints { get; set; }

        [BindRequired] public virtual Guid ProjectId { get; set; }

        public Guid? ContractorId { get; set; }

        public Guid? TemplateId { get; set; }
    }
}