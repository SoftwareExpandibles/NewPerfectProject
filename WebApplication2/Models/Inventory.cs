using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Inventory
    {
        public Inventory()
        {
            List<Color> ColorList = new List<Color>();
        }
        //[Key]

        [ForeignKey("Product")]
        public int InventoryId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public ICollection<Color> Color { get; set; }
    }
}