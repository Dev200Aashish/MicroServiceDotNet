using CatalogService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogService.Services
{
    public class CatalogServices : ICatalogService
    {
        List<Category> ICatalogService.FindAll()
        {
            return new List<Category> { 
            new Category{Id=1,Name="Mobile"},
             new Category{Id=2,Name="Tablets"},
             new Category{Id=3,Name="Covers"},
             new Category{Id=4,Name="bods"},
             new Category{Id=4,Name="Cables"},
            };
        }
    }
}
