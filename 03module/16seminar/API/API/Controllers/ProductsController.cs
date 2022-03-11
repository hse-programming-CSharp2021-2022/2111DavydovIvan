using System;
using System.Collections.Generic;
using System.Linq;
using API.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("/api/[controller]")]
    public class ProductsController
    {
        public ProductsController()
        {
        }

        private static List<Product> products = new List<Product>(new[] {
        new Product() { Id = 1, Name = "Notebook", Price = 100000 },
        new Product() { Id = 2, Name = "Car", Price = 2000000 },
        new Product() { Id = 3, Name = "Apple", Price = 30 },
        });

        [HttpGet]
        public IEnumerable<Product> Get() => products;

        [HttpGet("{id}")]           // параметр для маршрутизации
        public IActionResult Get(int id)
        {
            var product = products.SingleOrDefault(p => p.Id == id);

            if (product == null)
            {
                return new NotFoundResult();
            }

            return new OkObjectResult(product);
        }


    }
}
