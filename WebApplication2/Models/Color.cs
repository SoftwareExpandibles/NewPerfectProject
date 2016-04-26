using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Color
    {
        public Color()
        {
            List<Size> SizeList = new List<Size>();
        }
        [Key]
        public int ColorId { get; set; }
        public string ActualColor { get; set; }
        public int InventoryId { get; set; }
        [ForeignKey("InventoryId")]
        public Inventory Inventory { get; set; }
        public ICollection<Size> Size { get; set; }
    }
}