using System;
using Sharedkernel.Core;

namespace Sharedkernel.IntegrationEvents {
    public record VueloHabilitado : IntegrationEvent {
        public DateTime horaSalida { get; private set; }
        public DateTime horaLLegada { get; private set; }
        public string estado { get; private set; }
        public decimal precio { get; private set; }
        public DateTime fecha { get; private set; }
        public Guid codDestino { get; private set; }
        public Guid codOrigen { get; private set; }
        public Guid codAeronave { get; private set; }
        public int activo { get; private set; }
        public int stockAsientos { get; set; }
    }
}
