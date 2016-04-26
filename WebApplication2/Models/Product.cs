using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Photo { get; set; }
      //  public int InventoryId { get; set; }
       // [ForeignKey("InventoryId")]
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Inventory Inventory { get; set; }
    }
}