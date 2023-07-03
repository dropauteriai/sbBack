﻿namespace SmartBar.Controllers.DTO
{
    public class AddOrderItemRequest
    {
        public AddOrderItemRequest(string name, Guid orderId, int amount)
        {
            Name = name;
            OrderId = orderId;
            Amount = amount;
        }
        public string Name { get; set; }
        public Guid OrderId { get; set; }
        public int Amount { get; set; }

    }
}
