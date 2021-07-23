using System.Security.Cryptography.X509Certificates;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductWithFiltersForCountSpecification : BaseSpecification<Product>
    {
        public ProductWithFiltersForCountSpecification(ProductSpecificationParameters productParameters)
            : base(x =>
                (string.IsNullOrEmpty(productParameters.Search) || x.Name.ToLower().Contains(productParameters.Search)) &&
                (!productParameters.BrandId.HasValue || x.ProductBrandId == productParameters.BrandId) &&
                (!productParameters.TypeId.HasValue || x.ProductTypeId == productParameters.TypeId)
            )
        {
        }
    }
}