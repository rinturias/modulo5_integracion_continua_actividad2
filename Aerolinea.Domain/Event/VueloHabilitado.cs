using System;
using Aerolinea.Vuelos.Domain.Entities;
using Sharedkernel.Core;

namespace Aerolinea.Vuelos.Domain.Event {
    public class VueloHabilitado : DomainEvent {
        // public Guid vueloId { get; }
        public VueloHabilitado(Vuelo vuelo) : base(DateTime.Now) {

            vueloHabilitado = vuelo;

        }

        public Vuelo vueloHabilitado { get; private set; }

    }
}
