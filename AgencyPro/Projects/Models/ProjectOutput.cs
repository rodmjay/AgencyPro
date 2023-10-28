using System;
using AgencyPro.Organizations.Interfaces;
using AgencyPro.Projects.Enums;
using AgencyPro.Projects.Interfaces;
using Newtonsoft.Json;

namespace AgencyPro.Projects.Models
{
    public abstract class ProjectOutput : ProjectInput, IProject, IOrganizationPersonTarget
    {
        public virtual int ContractCount { get; set; }
        public virtual int StoryCount { get; set; }
        public virtual int InvoiceCount { get; set; }
        public virtual bool HasProposal { get; set; }
        public virtual bool HasProposalApproved { get; set; }
        public virtual string AccountManagerName { get; set; }
        public virtual string AccountManagerImageUrl { get; set; }
        public virtual string AccountManagerEmail { get; set; }
        public virtual string AccountManagerPhoneNumber { get; set; }
        public virtual string AccountManagerOrganizationName { get; set; }
        public virtual string AccountManagerOrganizationImageUrl { get; set; }

        public virtual string ProjectManagerImageUrl { get; set; }
        public virtual string ProjectManagerName { get; set; }
        public virtual string ProjectManagerEmail { get; set; }
        public virtual string ProjectManagerPhoneNumber { get; set; }
        public virtual string ProjectManagerOrganizationName { get; set; }
        public virtual string ProjectManagerOrganizationImageUrl { get; set; }
        public virtual string CustomerName { get; set; }
        public virtual string CustomerEmail { get; set; }
        public virtual string CustomerPhoneNumber { get; set; }
        public virtual string CustomerImageUrl { get; set; }
        public virtual string CustomerOrganizationName { get; set; }
        public virtual string CustomerOrganizationImageUrl { get; set; }

        public virtual decimal TotalHoursLogged { get; set; }

        [JsonIgnore]
        public virtual decimal TotalHoursApproved { get; set; }

        public virtual int MaxBillableHours { get; set; }
        public virtual decimal MaxContractorStream { get; set; }
        public virtual decimal MaxRecruiterStream { get; set; }
        public virtual decimal MaxMarketerStream { get; set; }
        public virtual decimal MaxProjectManagerStream { get; set; }
        public virtual decimal MaxAccountManagerStream { get; set; }
        public virtual decimal MaxAgencyStream { get; set; }
        public virtual decimal MaxRecruitingAgencyStream { get; set; }
        public virtual decimal MaxMarketingAgencyStream { get; set; }

        public virtual decimal MaxSystemStream { get; set; }
        public virtual decimal WeightedRecruiterAverage
        {
            get
            {
                if (MaxBillableHours > 0)
                {
                    return MaxRecruiterStream / MaxBillableHours;
                }

                return 0;
            }
        }

        public virtual decimal WeightedMarketerAverage
        {
            get
            {
                if (MaxBillableHours > 0)
                {
                    return MaxMarketerStream / MaxBillableHours;
                }

                return 0;
            }
        }

        public virtual decimal WeightedProjectManagerAverage
        {
            get
            {
                if (MaxBillableHours > 0)
                {
                    return MaxProjectManagerStream / MaxBillableHours;
                }

                return 0;
            }
        }

        public virtual decimal WeightedAccountManagerAverage
        {
            get
            {
                if (MaxBillableHours > 0)
                {
                    return MaxAccountManagerStream / MaxBillableHours;
                }

                return 0;
            }
        }

        public virtual decimal WeightedAgencyAverage
        {
            get
            {
                if (MaxBillableHours > 0)
                {
                    return MaxAgencyStream / MaxBillableHours;
                }

                return 0;
            }
        }

        public virtual decimal WeightedRecruitingAgencyAverage
        {
            get
            {
                if (MaxBillableHours > 0)
                {
                    return MaxRecruitingAgencyStream / MaxBillableHours;
                }

                return 0;
            }
        }

        public virtual decimal WeightedMarketingAgencyAverage
        {
            get
            {
                if (MaxBillableHours > 0)
                {
                    return MaxMarketingAgencyStream / MaxBillableHours;
                }

                return 0;
            }
        }

        public virtual decimal WeightedSystemAverage
        {
            get
            {
                if (MaxBillableHours > 0)
                {
                    return MaxSystemStream / MaxBillableHours;
                }

                return 0;
            }
        }

        public virtual decimal CustomerAverageRate => WeightedSystemAverage + WeightedAgencyAverage + WeightedProjectManagerAverage +
                       WeightedAccountManagerAverage + WeightedContractorAverage + WeightedRecruiterAverage +
                       WeightedMarketerAverage + WeightedMarketingAgencyAverage + WeightedRecruitingAgencyAverage;

        public virtual bool CanInvoice => TotalHoursApproved > 0;

        public virtual Guid Id { get; set; }

        public virtual ProjectStatus Status { get; set; }

        public virtual Guid AccountManagerId { get; set; }
        public virtual Guid AccountManagerOrganizationId { get; set; }

        public virtual Guid CustomerId { get; set; }
        public virtual Guid CustomerOrganizationId { get; set; }

        public virtual decimal WeightedContractorAverage
        {
            get
            {
                if (MaxBillableHours > 0)
                {
                    return MaxContractorStream / MaxBillableHours;
                }
                return 0;
            }
        }

        public virtual DateTimeOffset Created { get; set; }
        public virtual DateTimeOffset Updated { get; set; }
        public virtual Guid CreatedById { get; set; }
        public virtual Guid UpdatedById { get; set; }

        [JsonIgnore]
        public abstract Guid TargetOrganizationId { get; }

        [JsonIgnore]
        public abstract Guid TargetPersonId { get; }
    }
}