﻿using GeekShop.Web.Models;

namespace GeekShop.Web.Services.IServices
{
	public interface IProductService
	{
		Task<IEnumerable<ProductModel>> FindAllProducts(string token);
		
		Task<ProductModel> FindById(long id, string token);

		Task<ProductModel> CreateProduct(ProductModel model, string token);

		Task<ProductModel> UpdateProduct(ProductModel model, string token);

		Task<bool> DeleteProductById(long id, string token);
	}
}
