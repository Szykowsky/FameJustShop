using System;
using System.Collections.Generic;

namespace FameJustShop.Orders.Data.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid PaymentId { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        public virtual ICollection<OrderStatus> OrderStatuses { get; set; }
    }
}

