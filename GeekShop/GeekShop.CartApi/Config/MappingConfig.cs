using AutoMapper;
using GeekShop.CartApi.Data.ValueObjects;
using GeekShop.CartApi.Model;
using GeekShop.CartAPI.Model;

namespace GeekShop.CartAPI.Config
{
	public class MappingConfig
	{
		public static MapperConfiguration RegisterMaps()
		{
			var mappingConfig = new MapperConfiguration(Config =>
			{
				Config.CreateMap<ProductVO, Product>().ReverseMap();
				Config.CreateMap<CartHeaderVO, CartHeader>().ReverseMap();
				Config.CreateMap<CartDetailVO, CartDetail>().ReverseMap();
				Config.CreateMap<CartVO, Cart>().ReverseMap();
			});
			return mappingConfig;
		}
	}
}
