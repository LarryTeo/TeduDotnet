using eShopSolution.Application.Catalog.Products.Dtos;
using eShopSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IManagedProductService
    {
        Task<int> Create(ProductCreateRequest request);//trả về mã sản phẩm
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int productId);
       
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdateStock(int productId, int addedQuantity);
        Task AddViewCount(int productId);
       
        Task<PageResult<ProductViewModle>> GetAllPaging(GetProductPagingRequest request);
    }
}
