using FSH.Framework.Core.Domain.Events;

namespace GameTheoryGame.WebApi.Catalog.Domain.Events;
public sealed record ProductCreated : DomainEvent
{
    public Product? Product { get; set; }
}
