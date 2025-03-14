﻿namespace ECommerce.API.Orders.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
        public List<Models.OrderItem> Items { get; set; }
    }
}
