using System;

namespace Aerolinea.Vuelos.Infrastructure.EF.ReadModel {
    public class PlanillaAsientoVueloReadModel {
        public Guid Id { get; set; }
        public string asiento { get; set; }
        public string estado { get; set; }
        public int activo { get; set; }
        public VueloReadModel vuelo { get; set; }
    }
}
