using System.Collections.Generic;
using AgencyPro.BillingCategories.Entities;
using AgencyPro.Categories.Interfaces;
using AgencyPro.Common.Data.Bases;
using AgencyPro.Organizations.Entities;
using AgencyPro.PaymentTerms.Entities;
using AgencyPro.Positions.Entities;
using Microsoft.EntityFrameworkCore;
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
            builder.HasKey(x => x.CategoryId);

            builder.Property(x => x.CategoryId).ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                .IsRequired().HasMaxLength(100);

            builder.Property(x => x.ContractorTitle)
                .HasMaxLength(50)
                .HasDefaultValue("Contractor")
                .IsRequired();

            builder.Property(x => x.AccountManagerTitle)
                .HasMaxLength(50)
                .HasDefaultValue("Account Manager")
                .IsRequired();

            builder.Property(x => x.ProjectManagerTitle)
                .HasMaxLength(50)
                .HasDefaultValue("Project Manager")
                .IsRequired();

            builder.Property(x => x.AccountManagerTitlePlural)
                .HasMaxLength(50)
                .HasDefaultValue("Account Managers")
                .IsRequired();

            builder.Property(x => x.ProjectManagerTitlePlural)
                .HasMaxLength(50)
                .HasDefaultValue("Project Managers")
                .IsRequired();

            builder.Property(x => x.ContractorTitlePlural).HasMaxLength(50)
                .HasDefaultValue("Contractors")
                .IsRequired();

            builder.Property(x => x.RecruiterTitlePlural).HasMaxLength(50)
                .HasDefaultValue("Recruiters")
                .IsRequired();

            builder.Property(x => x.RecruiterTitle).HasMaxLength(50)
                .HasDefaultValue("Recruiter")
                .IsRequired();

            builder.Property(x => x.MarketerTitle).HasMaxLength(50)
                .HasDefaultValue("Marketer")
                .IsRequired();

            builder.Property(x => x.MarketerTitlePlural).HasMaxLength(50)
                .HasDefaultValue("Marketers")
                .IsRequired();

            builder.Property(x => x.CustomerTitle).HasMaxLength(50)
                .HasDefaultValue("Customer")
                .IsRequired();

            builder.Property(x => x.CustomerTitlePlural).HasMaxLength(50)
                .HasDefaultValue("Customers")
                .IsRequired();

            builder.Property(x => x.DefaultAccountManagerStream)
                .HasDefaultValue(5)
                .HasColumnType("Money")
                .IsRequired();

            builder.Property(x => x.DefaultMarketerStream)
                .HasDefaultValue(2.50)
                .HasColumnType("Money")
                .IsRequired();

            builder.Property(x => x.DefaultRecruiterStream)
                .HasDefaultValue(2.50)
                .HasColumnType("Money")
                .IsRequired();

            builder.Property(x => x.DefaultProjectManagerStream)
                .HasDefaultValue(7.50)
                .HasColumnType("Money")
                .IsRequired();

            builder.Property(x => x.DefaultContractorStream)
                .HasDefaultValue(25)
                .HasColumnType("Money")
                .IsRequired();

            builder.Property(x => x.DefaultAgencyStream)
                .HasDefaultValue(15)
                .HasColumnType("Money")
                .IsRequired();

            builder.Property(x => x.DefaultMarketingAgencyStream)
                .HasDefaultValue(1)
                .HasColumnType("Money")
                .IsRequired();

            builder.Property(x => x.DefaultRecruitingAgencyStream)
                .HasDefaultValue(2)
                .HasColumnType("Money")
                .IsRequired();

            builder.Property(x => x.DefaultMarketerBonus)
                .HasDefaultValue(10)
                .HasColumnType("Money")
                .IsRequired();

            builder.Property(x => x.DefaultMarketingAgencyBonus)
                .HasDefaultValue(10)
                .HasColumnType("Money")
                .IsRequired();

            builder.Property(x => x.Searchable)
                .HasDefaultValue(false)
                .IsRequired();

            builder.HasMany(x => x.Organizations)
                .WithOne(x => x.Category)
                .HasForeignKey(x => x.CategoryId);

            builder.HasMany(x => x.Positions)
                .WithOne(x => x.Category)
                .HasForeignKey(x => x.CategoryId)
                .IsRequired();
        }
    }
}