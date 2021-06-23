using Mapster;
using MapsterApp.Entities;
using MapsterApp.Models;

namespace MapsterApp.Configs
{
    public class MapsterAdaptorConfig
    {

        public static readonly MapsterMapper.IMapper MapsterMapper = new MapsterMapper.Mapper(GetTypeAdapterConfig());

        private static TypeAdapterConfig GetTypeAdapterConfig()
        {
            var config = new TypeAdapterConfig();
            config.NewConfig<Product, ProductModel>()
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.ProductName, src => src.ProductName)
                .Map(dest => dest.Description, src => src.Description)
                .Map(dest => dest.Weight, src => src.Weight)
                .Map(dest => dest.Options, src => src.Options);

            config.NewConfig<ProductVariant, ProductVariantModel>()
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.Color, src => src.Color)
                .Map(dest => dest.Size, src => src.Size);

            return config;
        }
    }
}
