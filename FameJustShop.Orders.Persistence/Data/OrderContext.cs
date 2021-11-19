using System;
using FameJustShop.Orders.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FameJustShop.Orders.Data
{
    public class OrderContext : DbContext
    {
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderProduct> Products { get; set; }
        public virtual DbSet<OrderStatus> Statuses { get; set; }

        public OrderContext(DbContextOptions<OrderContext> options) : base(options) { }
    }
}

