using System.Threading;
using System.Threading.Tasks;
using Aerolinea.Vuelos.Domain.Event;
using MassTransit;
using MediatR;
using Sharedkernel.Core;

namespace Aerolinea.Vuelos.Application.UseCases.DomainEventHandler.Vuelo {
    public class PublishIntegrationEventWhenVueloCreadoHandler : INotificationHandler<ConfirmedDomainEvent<VueloHabilitado>> {
        private readonly IPublishEndpoint _publishEndpoint;

        public PublishIntegrationEventWhenVueloCreadoHandler(IPublishEndpoint publishEndpoint) {
            _publishEndpoint = publishEndpoint;
        }

        public async Task Handle(ConfirmedDomainEvent<VueloHabilitado> notification, CancellationToken cancellationToken) {

            //SharedKernel.IntegrationEvents.evento = new SharedKernel.IntegrationEvents.ArticuloCreado() {
            //    ArticuloId = notification.DomainEvent.ArticuloId,
            //    Nombre = notification.DomainEvent.Nombre,
            //    PrecioVenta = notification.DomainEvent.PrecioVenta
            //};
            //await _publishEndpoint.Publish<SharedKernel.IntegrationEvents.VueloHabilitado>(evento);


        }
    }
}
