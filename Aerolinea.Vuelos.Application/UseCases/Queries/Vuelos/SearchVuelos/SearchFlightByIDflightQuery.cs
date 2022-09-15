using Aerolinea.Vuelos.Application.Dto;
using MediatR;

namespace Aerolinea.Vuelos.Application.UseCases.Queries.Vuelos.SearchVuelos {
    public class SearchFlightByIDflightQuery : IRequest<ResulService> {

        public SearchFlightByIDflightQuery() { }
        public SearchFlightDTO searchFlightDTO { get; set; }
    }
}
