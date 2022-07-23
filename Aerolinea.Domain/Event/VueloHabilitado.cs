using System;
using Aerolinea.Vuelos.Domain.Entities;
using Sharedkernel.Core;

namespace Aerolinea.Vuelos.Domain.Event {
    public class VueloHabilitado : DomainEvent {
        // public Guid vueloId { get; }
        public VueloHabilitado(Vuelo vuelo) : base(DateTime.Now) {

            vueloHabilitado = vuelo;


        }


        //public VueloHabilitado(Guid _vueloId) : base(DateTime.Now)
        //{

        //    vueloId = _vueloId;


        //}
        public Vuelo vueloHabilitado { get; private set; }

    }
}
