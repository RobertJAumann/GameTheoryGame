using FSH.Framework.Core.Paging;
using GameTheoryGame.WebApi.Catalog.Application.Brands.Get.v1;
using MediatR;

namespace GameTheoryGame.WebApi.Catalog.Application.Brands.Search.v1;

public class SearchBrandsCommand : PaginationFilter, IRequest<PagedList<BrandResponse>>
{
    public string? Name { get; set; }
    public string? Description { get; set; }
}
