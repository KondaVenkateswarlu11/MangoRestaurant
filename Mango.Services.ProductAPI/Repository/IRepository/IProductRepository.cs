using Mango.Services.ProductAPI.Models.Dto;

namespace Mango.Services.ProductAPI.Repository.IRepository
{
	public interface IProductRepository
	{
		Task<IEnumerable<ProductDto>> GetProducts();
		Task<ProductDto> GetProductById(int productId);
		Task<ProductDto> CreateUpdate(ProductDto productDto);
		Task<bool> DeleteProduct(int productId);
	}
}
