using Aerolinea.Vuelos.Application.Dto;
using MediatR;

namespace Aerolinea.Vuelos.Application.UseCases.Queries.Vuelos.SearchVuelos {
    public class SearchListPlanillaAsientosVuelosQuery : IRequest<ResulService> {

        public SearchListPlanillaAsientosVuelosQuery() { }
        public SearchVuelosDTO SearchVuelosDTO { get; set; }
    }


}
