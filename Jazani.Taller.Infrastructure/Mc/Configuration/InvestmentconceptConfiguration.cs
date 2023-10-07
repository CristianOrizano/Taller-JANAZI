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
    public class InvestmentconceptConfiguration : IEntityTypeConfiguration<Investmentconcept>
    {
        public void Configure(EntityTypeBuilder<Investmentconcept> builder)
        {
            builder.ToTable("investmentconcept", "mc");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).HasColumnName("name");
            builder.Property(t => t.Description).HasColumnName("description");
            builder.Property(t => t.RegistrationDate).HasColumnName("registrationDate");
            builder.Property(t => t.State).HasColumnName("state");
        }
    }
}
