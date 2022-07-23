using System;

namespace Sharedkernel.Core {
    public abstract class DomainEvent {
        public DateTime OccuredOn { get; }
        public Guid Id { get; }

        protected DomainEvent(DateTime occuredOn) {
            OccuredOn = occuredOn;
            Id = Guid.NewGuid();
        }
    }
}
