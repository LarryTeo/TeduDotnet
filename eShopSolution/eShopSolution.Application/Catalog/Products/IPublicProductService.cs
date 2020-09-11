using eShopSolution.Application.Catalog.Products.Dtos;
using eShopSolution.Application.Catalog.Products.Dtos.Public;
using eShopSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GetProductPagingRequest = eShopSolution.Application.Catalog.Products.Dtos.GetProductPagingRequest;

namespace eShopSolution.Application.Catalog.Products
{
   public interface IPublicProductService
    {
        Task<PageResult<ProductViewModle>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
