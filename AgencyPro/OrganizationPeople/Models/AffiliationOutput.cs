using System;
using System.Collections.Generic;
using System.Linq;
using AgencyPro.Organizations.Enums;
using AgencyPro.Organizations.Models;
using Newtonsoft.Json;

namespace AgencyPro.OrganizationPeople.Models
{
    public class AffiliationOutput
    {
        public string OrganizationName { get; set; }
        public Guid OrganizationId { get; set; }
        public string OrganizationImageUrl { get; set; }
        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        public string TertiaryColor { get; set; }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public bool IsDefault { get; set; }

        public bool IsAgencyOwner { get; set; }
        public bool IsMarketingAgencyOwner { get; set; }
        public bool IsRecruitingAgencyOwner { get; set; }
        public bool IsProviderAgencyOwner { get; set; }
        public bool IsProjectManager { get; set; }
        public bool IsAccountManager { get; set; }
        public bool IsContractor { get; set; }
        public bool IsCustomer { get; set; }
        public bool IsRecruiter { get; set; }
        public bool IsMarketer { get; set; }

        public bool IsAffiliate => IsRecruiter | IsMarketer;

        public string AffiliateCode { get; set; }

        public bool IsHidden { get; set; }

        [JsonIgnore] public ICollection<OrganizationSettingViewModel> OrganizationSettings { get; set; }

        public bool ProviderAgencyFeaturesEnabled { get; set; }
        public bool RecruitingAgencyFeaturesEnabled { get; set; }
        public bool MarketingAgencyFeaturesEnabled { get; set; }

        public bool IsAccountManagerProjectEnabled => CheckEnabled(SectionType.AccountManager, MenuType.Project);

        public bool IsAccountManagerContractEnabled => CheckEnabled(SectionType.AccountManager, MenuType.Contract);

        public bool IsAccountManagerStoryEnabled => CheckEnabled(SectionType.AccountManager, MenuType.Story);

        public bool IsProjectManagerProjectEnabled => CheckEnabled(SectionType.ProjectManager, MenuType.Project);
        public bool IsProjectManagerContractEnabled => CheckEnabled(SectionType.ProjectManager, MenuType.Contract);
        public bool IsProjectManagerStoryEnabled => CheckEnabled(SectionType.ProjectManager, MenuType.Story);

        private bool CheckEnabled(SectionType sectionType, MenuType menuType)
        {
            return OrganizationSettings?.Any(a => a.SectionType == sectionType && a.MenuType == menuType && a.IsEnabled) ?? false;
        }
    }
}