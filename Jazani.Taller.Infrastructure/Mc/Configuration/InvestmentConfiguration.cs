using Jazani.Taller.Domain.Mc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Infrastructure.Mc.Configuration
{
    public class InvestmentConfiguration : IEntityTypeConfiguration<Investment>
    {
        public void Configure(EntityTypeBuilder<Investment> builder)
        {
            builder.ToTable("investment", "mc");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.AmountInvested).HasColumnName("amountinvestd");
            builder.Property(t => t.MiningConcessionid).HasColumnName("miningconcessionid");
            builder.Property(t => t.InvestmentTypeId).HasColumnName("investmenttypeid");
            builder.Property(t => t.CurrencyTypeId).HasColumnName("currencytypeid");

            builder.Property(t => t.Investmentconceptid).HasColumnName("investmentconceptid");
            builder.Property(t => t.Measureunitid).HasColumnName("measureunitid");
            builder.Property(t => t.Periodtypeid).HasColumnName("periodtypeid");

            builder.Property(t => t.RegistrationDate).HasColumnName("registrationdate");
            builder.Property(t => t.Holderid).HasColumnName("holderid");
            builder.Property(t => t.State).HasColumnName("state");
            builder.Property(t => t.DeclaredTypeId).HasColumnName("declaredtypeid");

            // Definir relaciones foráneas
            builder.HasOne(t => t.Holder)
                .WithMany()
                .HasForeignKey(t => t.Holderid);

            builder.HasOne(t => t.Investmentconcept)
                .WithMany()
                .HasForeignKey(t => t.Investmentconceptid);

            builder.HasOne(t => t.Investmenttype)
                .WithMany()
                .HasForeignKey(t => t.InvestmentTypeId);

            builder.HasOne(t => t.MeasureUnit)
                .WithMany()
                .HasForeignKey(t => t.Measureunitid);

            builder.HasOne(t => t.MiningConcession)
                .WithMany()
                .HasForeignKey(t => t.MiningConcessionid);

            builder.HasOne(t => t.PeriodType)
                .WithMany()
                .HasForeignKey(t => t.Periodtypeid);

        }

    }
}
