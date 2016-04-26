using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Size
    {
        [Key]
        public int SizeId { get; set; }
        public string ActualSize { get; set; }
        public int StockOnHand { get; set; }
        public int ReOrderQuantity { get; set; }
        public int ColorId { get; set; }
        public decimal Price { get; set; }
        [ForeignKey("ColorId")]
        public Color Color { get; set; }
    }
}