using System.Collections.Generic;
using AgencyPro.BillingCategories.Entities;
using AgencyPro.Categories.Interfaces;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Organizations.Entities;
using AgencyPro.PaymentTerms.Entities;
using AgencyPro.Positions.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.Categories.Entities
{
    public class Category : BaseEntity<Category>, ICategory
    {
        public ICollection<CategorySkill> AvailableSkills { get; set; }
        public ICollection<Organization> Organizations { get; set; }
        public ICollection<CategoryPaymentTerm> AvailablePaymentTerms { get; set; }
        public ICollection<CategoryBillingCategory> AvailableBillingCategories { get; set; }
        public ICollection<CategoryPosition> Positions { get; set; }

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string ContractorTitle { get; set; }
        public string ContractorTitlePlural { get; set; }
        public string AccountManagerTitle { get; set; }
        public string AccountManagerTitlePlural { get; set; }
        public string ProjectManagerTitle { get; set; }
        public string ProjectManagerTitlePlural { get; set; }
        public string RecruiterTitle { get; set; }
        public string MarketerTitle { get; set; }
        public string StoryTitle { get; set; }
        public string StoryTitlePlural { get; set; }
        public string RecruiterTitlePlural { get; set; }
        public string MarketerTitlePlural { get; set; }
        public string CustomerTitle { get; set; }
        public string CustomerTitlePlural { get; set; }
        public bool Searchable { get; set; }

        public decimal DefaultRecruiterStream { get; set; }
        public decimal DefaultMarketerStream { get; set; }
        public decimal DefaultProjectManagerStream { get; set; }
        public decimal DefaultAccountManagerStream { get; set; }
        public decimal DefaultContractorStream { get; set; }
        public decimal DefaultAgencyStream { get; set; }

        public decimal DefaultMarketingAgencyStream { get; set; }
        public decimal DefaultRecruitingAgencyStream { get; set; }
        public decimal DefaultMarketerBonus { get; set; }
        public decimal DefaultMarketingAgencyBonus { get; set; }

        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}