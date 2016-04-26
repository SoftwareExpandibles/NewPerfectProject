using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Genre
    {
        public Genre()
        {
            List<Product> ProductList = new List<Product>();
        }
        [Key]
        public int GenreId { get; set; }
        public string Category { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}