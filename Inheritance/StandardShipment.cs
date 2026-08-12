using System;
using OOP_Assignment_2.Class;
using OOP_Assignment_2.Struct;

namespace OOP_Assignment_2.Inheritance
{
    internal class StandardShipment : Shipment
    {
        public StandardShipment(string? trackingCode, string? description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }
    }
}
