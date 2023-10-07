using Jazani.Taller.Domain.Soc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Infrastructure.Soc.Configuration
{
    public class HolderConfiguration : IEntityTypeConfiguration<Holder>
    {
        public void Configure(EntityTypeBuilder<Holder> builder)
        {
            builder.ToTable("holder", "soc"); 
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).HasColumnName("id");
            builder.Property(t => t.Name).HasColumnName("name");
            builder.Property(t => t.Lastname).HasColumnName("lastname");
            builder.Property(t => t.MaidenName).HasColumnName("maidenname");
            builder.Property(t => t.documentnumber).HasColumnName("documentnumber");
            builder.Property(t => t.landline).HasColumnName("landline");
            builder.Property(t => t.mobile).HasColumnName("mobile");
            builder.Property(t => t.corporatemail).HasColumnName("corporatemail");
            builder.Property(t => t.personalmail).HasColumnName("personalmail");
            builder.Property(t => t.State).HasColumnName("state");
            builder.Property(t => t.RegistrationDate).HasColumnName("registrationdate");

        }

    }
}
