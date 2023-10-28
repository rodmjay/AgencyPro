using System;
using AgencyPro.Organizations.Interfaces;
using AgencyPro.TimeEntries.Enums;
using AgencyPro.TimeEntries.Interfaces;
using Newtonsoft.Json;

namespace AgencyPro.TimeEntries.Models
{
    public abstract class TimeEntryOutput : TimeEntryInput, ITimeEntry, IOrganizationPersonTarget
    {

        
        public virtual Guid CustomerId { get; set; }

        public virtual Guid ContractorId { get; set; }
        public virtual string ContractorName { get; set; }
        public virtual string ContractorImageUrl { get; set; }
        public virtual string ContractorEmail { get; set; }
        public virtual string ContractorPhoneNumber { get; set; }


        public virtual string ContractorOrganizationName { get; set; }
        public virtual Guid ContractorOrganizationId { get; set; }
        public virtual string ContractorOrganizationImageUrl { get; set; }

        public virtual Guid CustomerOrganizationId { get; set; }
        public virtual Guid AccountManagerId { get; set; }

        public virtual Guid Id { get; set; }
        public virtual TimeStatus Status { get; set; }
        public virtual string ProjectId { get; set; }
        public virtual string ProjectName { get; set; }
        public virtual string StoryNumber { get; set; } 
        public virtual string StoryDescription { get; set; }
        public virtual decimal InstantContractorStream { get; set; }
        public virtual string RejectionReason { get; set; }
        public virtual decimal InstantRecruiterStream { get; set; }
        public virtual decimal InstantMarketerStream { get; set; }
        public virtual decimal InstantProjectManagerStream { get; set; }
        public virtual decimal InstantAccountManagerStream { get; set; }
        public virtual decimal InstantSystemStream { get; set; }
        public virtual decimal InstantAgencyStream { get; set; }

        public bool IsMarketingExternal => MarketingOrganizationId != ContractorOrganizationId;
        public bool IsRecruitingExternal => RecruitingOrganizationId != ContractorOrganizationId;

        public virtual decimal TotalContractorStream
        {
            get => InstantContractorStream * TotalHours;
            set { }
        }

        public virtual decimal TotalRecruiterStream
        {
            get => InstantRecruiterStream * TotalHours;
            set { }
        }

        public virtual decimal TotalMarketerStream
        {
            get => InstantMarketerStream * TotalHours;
            set { }
        }

        public virtual decimal TotalProjectManagerStream
        {
            get => InstantProjectManagerStream * TotalHours;
            set { }
        }

        public virtual decimal TotalAccountManagerStream
        {
            get => InstantAccountManagerStream * TotalHours;
            set { }
        }

        public virtual decimal TotalSystemStream
        {
            get => InstantSystemStream * TotalHours;
            set { }
        }

        public virtual decimal TotalAgencyStream
        {
            get => InstantAgencyStream * TotalHours;
            set { }
        }

        public virtual decimal TotalMarketingAgencyStream
        {
            get => InstantMarketingAgencyStream * TotalHours;
            set { }
        }

        public virtual decimal TotalRecruitingAgencyStream
        {
            get => InstantRecruitingAgencyStream * TotalHours;
            set { }
        }

        public virtual decimal TotalRecruitingStream
        {
            get => (InstantRecruiterStream + InstantRecruitingAgencyStream) * TotalHours;
            set { }
        }

        public virtual decimal TotalMarketingStream
        {
            get => (InstantMarketingAgencyStream + InstantMarketerStream) * TotalHours;
            set { }
        }

        public virtual decimal TotalCustomerAmount
        {
            get => (
                       InstantAgencyStream +
                       InstantSystemStream +
                       InstantAccountManagerStream +
                       InstantContractorStream +
                       InstantMarketerStream +
                       InstantRecruiterStream +
                       InstantProjectManagerStream + 
                       InstantMarketingAgencyStream +
                       InstantRecruitingAgencyStream
                   ) * TotalHours;
            set { }
        }

        public virtual decimal InstantRecruitingAgencyStream { get; set; }
        public virtual decimal InstantMarketingAgencyStream { get; set; }

        public int TotalMinutes
        {
            get => Convert.ToInt32((EndDate - StartDate).TotalMinutes);
            set { }
        }

        public decimal TotalHours
        {
            get => Convert.ToDecimal((EndDate - StartDate).TotalHours);
            set { }
        }

        [JsonIgnore]
        public override int? MinutesDuration { get; set; }

        public virtual DateTimeOffset Created { get; set; }
        public virtual DateTimeOffset Updated { get; set; }

        [JsonIgnore]
        public override bool? CompleteStory { get; set; }

        public string RecruitingOrganizationName { get; set; }
        public string RecruitingOrganizationImageUrl { get; set; }
        public Guid RecruitingOrganizationId { get; set; }
        public Guid RecruiterId { get; set; }
        public string MarketingOrganizationName { get; set; }
        public string MarketingOrganizationImageUrl { get; set; }
        public Guid MarketingOrganizationId { get; set; }
        public Guid MarketerId { get; set; }

        [JsonIgnore]
        public abstract Guid TargetOrganizationId { get; }

        [JsonIgnore]
        public abstract Guid TargetPersonId { get; }

        public Guid ProviderOrganizationOwnerId { get; set; }
        public Guid RecruitingOrganizationOwnerId { get; set; }
        public Guid MarketingOrganizationOwnerId { get; set; }
        public Guid ProjectManagerId { get; set; }
    }
}