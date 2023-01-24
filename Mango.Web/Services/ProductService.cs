using Mango.Web.Models;
using Mango.Web.Services.IServices;

namespace Mango.Web.Services
{
	public class ProductService : BaseService, IProductService
	{
		private readonly IHttpClientFactory _clientFactory;
		public ProductService(IHttpClientFactory clientFactory) : base(clientFactory)
		{
			_clientFactory= clientFactory;
		}

		public async Task<T> CreateProduct<T>(ProductDto productDto)
		{
			return await this.SendAsync<T>(new ApiRequest()
			{
				ApiType = SD.ApiType.POST,
				Data = productDto,
				Url = SD.ProductAPIBase + "/api+products",
				AccessToken = ""
			});
		}

		public async Task<T> DeleteProduct<T>(int id)
		{
			return await this.SendAsync<T>(new ApiRequest()
			{
				ApiType = SD.ApiType.DELETE,
				
				Url = SD.ProductAPIBase + "/api+products/"+id,
				AccessToken = ""
			});
		}

		public async Task<T> GetAllProductsAsync<T>()
		{
			return await this.SendAsync<T>(new ApiRequest()
			{
				ApiType = SD.ApiType.GET,
				
				Url = SD.ProductAPIBase + "/api+products",
				AccessToken = ""
			});
		}

		public async Task<T> GetProductById<T>(int id)
		{
			return await this.SendAsync<T>(new ApiRequest()
			{
				ApiType = SD.ApiType.GET,
				
				Url = SD.ProductAPIBase + "/api+products/"+id,
				AccessToken = ""
			});

		}

		public async Task<T> UpdateProduct<T>(ProductDto productDto)
		{
			return await this.SendAsync<T>(new ApiRequest()
			{
				ApiType = SD.ApiType.PUT,
				Data = productDto,
				Url = SD.ProductAPIBase + "/api+products",
				AccessToken = ""
			});
		}
	}
}
