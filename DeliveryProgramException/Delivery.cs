﻿namespace ConsoleApp1
{
    public class Delivery
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public DeliveryStatus DeliveryStatus { get; set; }
        public override string ToString()
        {
            return $"{{\n   ID: {Id}\n   Name: {CustomerName}\n   Address: {Address}\n   Status: {DeliveryStatus}\n}}";
        }
    }
}
    