using Zamin.Core.ApplicationServices.Events;

namespace InventoryManagement.EndPoint.Api.CustomDecorators;
// pak shavad
public sealed class CustomEventDecorator : EventDispatcherDecorator
{
    public override int Order => 0;

    public override async Task PublishDomainEventAsync<TDomainEvent>(TDomainEvent @event)
    {
        await _eventDispatcher.PublishDomainEventAsync(@event);
    }
}