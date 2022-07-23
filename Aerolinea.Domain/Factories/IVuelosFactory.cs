using System;
using Aerolinea.Vuelos.Domain.Entities;
using Aerolinea.Vuelos.Domain.ValueObjects;

namespace Aerolinea.Vuelos.Domain.Factories {
    public interface IVuelosFactory {

        Vuelo Create(DateTime horaSalida, DateTime horaLLegada, string estado, PrecioValue precio, DateTime fecha, Guid codDestino, Guid codOrigen, Guid codAeronave, int activo, CantidadValue StockAsientos);
    }
}
