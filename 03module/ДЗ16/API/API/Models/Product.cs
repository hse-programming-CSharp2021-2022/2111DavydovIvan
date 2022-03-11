using System;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Product
    {
        public Product()
        {
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
    }
}
