
using Mango.Web.Models;

namespace Mango.Web.Services.IServices
{
	public interface IProductService:IBaseService
	{
		Task<T> GetAllProductsAsync<T>();
		Task<T> GetProductById<T>(int id);
		Task<T> CreateProduct<T>(ProductDto productDto);
		Task<T> UpdateProduct<T>(ProductDto productDto);
		Task<T> DeleteProduct<T>(int id);
	}
}
