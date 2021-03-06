﻿using System.Collections.Generic;
using AgencyPro.Cards.Entities;
using AgencyPro.Charges.Entities;
using AgencyPro.Common.Data.Bases;
using AgencyPro.FinancialAccounts.Enums;
using AgencyPro.FinancialAccounts.Interfaces;
using AgencyPro.Transfers.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgencyPro.FinancialAccounts.Entities
{
    public class FinancialAccount : BaseEntity<FinancialAccount>, IFinancialAccount
    {
  
        public string RefreshToken { get; set; }

        public string AccessToken { get; set; }

        public string AccountId { get; set; }
        public string StripePublishableKey { get; set; }

        public string AccountType { get; set; }
        public FinancialAccountStatus Status { get; set; }

       // public ICollection<Payment> Payments { get; set; }

        public virtual OrganizationFinancialAccount OrganizationFinancialAccount { get; set; }

        public virtual IndividualFinancialAccount IndividualFinancialAccount { get; set; }
        
        public bool IsDeleted { get; set; }
        public bool ChargesEnabled { get; set; }
        public bool PayoutsEnabled { get; set; }

        public string CardIssuingCapabilityStatus { get; set; }

        public string CardPaymentsCapabilityStatus { get; set; }
        public string TransfersCapabilityStatus { get; set; }

       // public string Blob { get; set; }
        public string DefaultCurrency { get; set; }
        public string MerchantCategoryCode { get; set; }
        public string SupportEmail { get; set; }
        public string SupportPhone { get; set; }

        public ICollection<StripeCharge> DestinationCharges { get; set; }

        public ICollection<StripeTransfer> Transfers { get; set; }
        public ICollection<AccountCard> Cards { get; set; }
        public override void Configure(EntityTypeBuilder<FinancialAccount> builder)
        {
            builder.HasKey(x => x.AccountId);

            builder.HasQueryFilter(x => x.IsDeleted == false);

            builder.Property(x => x.AccountId).IsRequired();

            builder.HasOne(x => x.IndividualFinancialAccount)
                .WithOne(x => x.FinancialAccount)
                .HasForeignKey<IndividualFinancialAccount>(x => x.FinancialAccountId);

            builder.HasOne(x => x.OrganizationFinancialAccount)
                .WithOne(x => x.FinancialAccount)
                .HasForeignKey<OrganizationFinancialAccount>(x => x.FinancialAccountId);

            builder.HasMany(x => x.DestinationCharges)
                .WithOne(x => x.Destination)
                .HasForeignKey(x => x.DestinationId);

            builder.HasMany(x => x.Transfers)
                .WithOne(x => x.DestinationAccount)
                .HasForeignKey(x => x.DestinationId);

            builder.HasMany(x => x.Cards)
                .WithOne(x => x.FinancialAccount)
                .HasForeignKey(x => x.AccountId);



            AddAuditProperties(builder);
        }
    }

}