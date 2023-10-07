using Jazani.Taller.Domain.Ge.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Infrastructure.Ge.Configuration
{
    public class PeriodTypeConfiguration : IEntityTypeConfiguration<PeriodType>
    {
        public void Configure(EntityTypeBuilder<PeriodType> builder)
        {
            builder.ToTable("periodtype", "ge");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).HasColumnName("id");
            builder.Property(t => t.Name).HasColumnName("name").IsRequired().HasMaxLength(20);
            builder.Property(t => t.Description).HasColumnName("description").HasMaxLength(50);
            builder.Property(t => t.Time).HasColumnName("time").IsRequired();
            builder.Property(t => t.RegistrationDate).HasColumnName("registrationdate").IsRequired();
            builder.Property(t => t.State).HasColumnName("state").IsRequired();

        }

    }
}
