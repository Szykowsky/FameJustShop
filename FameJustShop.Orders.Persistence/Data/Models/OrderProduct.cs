using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FameJustShop.Orders.Data.Models
{
    public class OrderProduct
    {
        public Guid Id { get; set; }
        public Guid OrderId{ get; set; }
        public Guid ProductId{ get; set; }
        public int OrderQuantity { get; set; }
        public decimal UnitPrice { get; set; }

        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }
    }
}

