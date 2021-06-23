using System;
using System.Collections.Generic;

namespace MapsterApp.Models
{
    public class ProductModel
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public decimal Weight { get; set; }
        public string Description { get; set; }
        public List<ProductVariantModel> Options { get; set; }
    }
}
