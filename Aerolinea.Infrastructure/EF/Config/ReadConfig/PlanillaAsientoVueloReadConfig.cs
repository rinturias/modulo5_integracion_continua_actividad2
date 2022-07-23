using Aerolinea.Vuelos.Infrastructure.EF.ReadModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aerolinea.Vuelos.Infrastructure.EF.Config.ReadConfig {
    public class PlanillaAsientoVueloReadConfig : IEntityTypeConfiguration<PlanillaAsientoVueloReadModel> {
        public void Configure(EntityTypeBuilder<PlanillaAsientoVueloReadModel> builder) {
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
        }
    }
}
