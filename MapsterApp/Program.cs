using MapsterApp.Configs;
using MapsterApp.Entities;
using MapsterApp.Helpers;
using MapsterApp.Models;
using MapsterMapper;
using System;
using System.Collections.Generic;

namespace MapsterApp
{
    public class Program
    {
        private static IMapper _mapper = MapsterAdaptorConfig.MapsterMapper;

        static void Main(string[] args)
        {
            #region Product Data
            var product = new Product
            {
                Id = Guid.NewGuid(),
                Description = "This is a description, that needs to be mapped. I can't believe that I'm writing this but oh well",
                Weight = 69m,
                ProductName = "The Best Map",
                Options = new List<ProductVariant>
               {
                   new ProductVariant()
                   {
                       Id = Guid.NewGuid(),
                       Color = "Red",
                       Size = "Small"
                   },
                   new ProductVariant()
                   {
                       Id = Guid.NewGuid(),
                       Color = "Blue",
                       Size = "Medium"
                   },
                   new ProductVariant()
                   {
                       Id = Guid.NewGuid(),
                       Color = "Green",
                       Size = "Big"
                   }
               }
            };
            #endregion
        
            var productModel = _mapper.From(product).AdaptToType<ProductModel>();

            productModel.Dump();

            Console.ReadKey();
        }
    }
}
