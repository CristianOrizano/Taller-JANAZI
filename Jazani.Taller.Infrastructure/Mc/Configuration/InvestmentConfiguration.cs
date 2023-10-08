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
            builder.Property(t => t.InvestmentTypeid).HasColumnName("investmenttypeid");
            builder.Property(t => t.CurrencyTypeid).HasColumnName("currencytypeid");

            builder.Property(t => t.Investmentconceptid).HasColumnName("investmentconceptid");
            builder.Property(t => t.Measureunitid).HasColumnName("measureunitid");
            builder.Property(t => t.Periodtypeid).HasColumnName("periodtypeid");

            builder.Property(t => t.RegistrationDate).HasColumnName("registrationdate");
            builder.Property(t => t.HolderId).HasColumnName("holderid");
            builder.Property(t => t.State).HasColumnName("state");
            builder.Property(t => t.DeclaredTypeid).HasColumnName("declaredtypeid");

            // Definir relaciones foráneas
            builder.HasOne(t => t.Holder)
                .WithMany(many => many.Investments)
                .HasForeignKey(t => t.HolderId);

            builder.HasOne(t => t.Investmentconcept)
                 .WithMany(many => many.Investments)
                .HasForeignKey(t => t.Investmentconceptid);

            builder.HasOne(t => t.Investmenttype)
                 .WithMany(many => many.Investments)
                .HasForeignKey(t => t.InvestmentTypeid);

            builder.HasOne(t => t.MeasureUnit)
                  .WithMany(many => many.Investments)
                .HasForeignKey(t => t.Measureunitid);

            builder.HasOne(t => t.MiningConcession)
                  .WithMany(many => many.Investments)
                .HasForeignKey(t => t.MiningConcessionid);

            builder.HasOne(t => t.PeriodType)
                  .WithMany(many => many.Investments)
                .HasForeignKey(t => t.Periodtypeid);

        }

    }
}
