using System;
using OOP_Assignment_2.Class;
using OOP_Assignment_2.Struct;

namespace OOP_Assignment_2.Inheritance
{
    internal class ExpressShipment : Shipment
    {
        private decimal extraFee;

        public decimal ExtraFee
        {
            get { return extraFee; }
            set
            {
                if (value >= 0)
                    extraFee = value;
            }
        }

        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5m) + ExtraFee; }
        }

        public ExpressShipment(string? trackingCode, string? description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }
    }
}
