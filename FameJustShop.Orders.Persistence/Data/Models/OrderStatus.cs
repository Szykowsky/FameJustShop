using System;

namespace FameJustShop.Orders.Data.Models
{
    public class OrderStatus
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public OrderStatusType StatusType { get; set; }
        public DateTime Date { get; set; }
    }

    public enum OrderStatusType
    {
        Initialize,
        Accept,
        Execution,
        Shipped,
        Finish,
        Cancel,
        Complaint
    }
}

