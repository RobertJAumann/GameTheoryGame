using FSH.Framework.Core.Domain.Events;

namespace GameTheoryGame.WebApi.Catalog.Domain.Events;
public sealed record BrandCreated : DomainEvent
{
    public Brand? Brand { get; set; }
}
