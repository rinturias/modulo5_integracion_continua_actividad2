using System;
using Sharedkernel.Core;

namespace Aerolinea.Vuelos.Domain.Entities {
    public class PlanillaAsientoVuelo : Entity<Guid> {

        public string asiento { get; private set; }
        public string estado { get; private set; }
        public int activo { get; private set; }
        //public Guid vueloId { get; private set; }
        private PlanillaAsientoVuelo() {

        }

        public PlanillaAsientoVuelo(string asiento, string estado, int activo) {
            Id = Guid.NewGuid();
            this.asiento = asiento;
            this.estado = estado;
            this.activo = activo;
        }
    }
}
