using Jazani.Taller.Domain.Admins.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Infrastructure.Admins.Configuration
{
    public class PermissionLabelConfiguration : IEntityTypeConfiguration<PermissionLabel>
    {
        public void Configure(EntityTypeBuilder<PermissionLabel> builder)
        {
            builder.ToTable("permissionlabel", "adm");
            builder.HasKey(pl => new { pl.PermissionId, pl.LabelId });
            builder.Property(pl => pl.PermissionId).HasColumnName("permissionid");
            builder.Property(pl => pl.LabelId).HasColumnName("labelid");
            builder.Property(pl => pl.RegistrationDate).HasColumnName("registrationdate");
            builder.Property(pl => pl.State).HasColumnName("state");
            // Configuración de clave foránea para Permission
            builder.HasOne(pl => pl.Permission)
                .WithMany(p => p.PermissionLabels)
                .HasForeignKey(pl => pl.PermissionId);

            // Configuración de clave foránea para Label
            builder.HasOne(pl => pl.Label)
                .WithMany(l => l.PermissionLabels)
                .HasForeignKey(pl => pl.LabelId);

        }

    }
}
