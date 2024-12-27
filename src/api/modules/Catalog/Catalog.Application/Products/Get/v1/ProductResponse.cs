using GameTheoryGame.WebApi.Catalog.Application.Brands.Get.v1;

namespace GameTheoryGame.WebApi.Catalog.Application.Products.Get.v1;
public sealed record ProductResponse(Guid? Id, string Name, string? Description, decimal Price, BrandResponse? Brand);
