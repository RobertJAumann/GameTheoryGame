using Ardalis.Specification;
using FSH.Framework.Core.Paging;
using FSH.Framework.Core.Specifications;
using GameTheoryGame.WebApi.Catalog.Application.Brands.Get.v1;
using GameTheoryGame.WebApi.Catalog.Domain;

namespace GameTheoryGame.WebApi.Catalog.Application.Brands.Search.v1;
public class SearchBrandSpecs : EntitiesByPaginationFilterSpec<Brand, BrandResponse>
{
    public SearchBrandSpecs(SearchBrandsCommand command)
        : base(command) =>
        Query
            .OrderBy(c => c.Name, !command.HasOrderBy())
            .Where(b => b.Name.Contains(command.Keyword), !string.IsNullOrEmpty(command.Keyword));
}
