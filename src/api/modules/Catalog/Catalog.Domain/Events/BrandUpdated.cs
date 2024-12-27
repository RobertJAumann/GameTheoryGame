using FSH.Framework.Core.Domain.Events;

namespace GameTheoryGame.WebApi.Catalog.Domain.Events;
public sealed record BrandUpdated : DomainEvent
{
    public Brand? Brand { get; set; }
}
