using AutoMapper;
using GeekShop.ProductAPI.Data.ValueObjects;
using GeekShop.ProductAPI.Model;

namespace GeekShop.ProductAPI.Config
{
	public class MappingConfig
	{
		public static MapperConfiguration RegisterMaps()
		{
			var mappingConfig = new MapperConfiguration(Config =>
			{
				Config.CreateMap<ProductVO, Product>();
				Config.CreateMap<Product, ProductVO>();
			});
			return mappingConfig;
		}
	}
}
