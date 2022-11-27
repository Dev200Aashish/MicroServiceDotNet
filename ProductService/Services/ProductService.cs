using CatalogService.Models;
using ProductService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.Services
{
    public class ProductServices : IProductService
    {
        List<Products> IProductService.FindAll()
        {
            return new List<Products> { 
            new Products{Id=1,Name="Mobile",Price=6.7M},
             new Products{Id=2,Name="Tablets",Price=6.7M},
             new Products{Id=3,Name="Covers",Price=6.7M},
             new Products{Id=4,Name="bods",Price=6.7M},
             new Products{Id=4,Name="Cables",Price=6.7M},
            };
        }
    }
}

 