using Jazani.Taller.Domain.Geo.Models;
using Jazani.Taller.Domain.Mc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Jazani.Taller.Infrastructure.Geo.Configuration
{
    public class DistrictConfiguration : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.ToTable("district", "geo");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).HasColumnName("name");
            builder.Property(t => t.Capital).HasColumnName("capital");
            builder.Property(t => t.RegistrationDate).HasColumnName("registrationDate");
            builder.Property(t => t.State).HasColumnName("state");
        }

    }
}
