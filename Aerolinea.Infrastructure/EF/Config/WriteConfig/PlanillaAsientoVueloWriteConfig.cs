using Aerolinea.Vuelos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aerolinea.Vuelos.Infrastructure.EF.Config.WriteConfig {
    public class PlanillaAsientoVueloWriteConfig : IEntityTypeConfiguration<PlanillaAsientoVuelo> {
        public void Configure(EntityTypeBuilder<PlanillaAsientoVuelo> builder) {
            builder.ToTable("PlanillaAsientoVuelo");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.asiento)
           .HasColumnName("asiento")
           .HasMaxLength(20);



            builder.Property(x => x.estado)
           .HasColumnName("estado")
           .HasMaxLength(1);

            builder.Property(x => x.activo)
           .HasColumnName("activo");

            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
        }
    }
}
