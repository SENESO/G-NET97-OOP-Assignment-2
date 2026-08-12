using System;
using OOP_Assignment_2.Struct;

namespace OOP_Assignment_2.Class
{
    internal class Shipment
    {
        private string? trackingCode;
        private string? description;
        private decimal weight;
        private decimal deliveryFee;

        public string? TrackingCode
        {
            get { return trackingCode; }
        }

        public string? Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;
            }
        }

        public decimal Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
        }

        public DeliveryAddress Destination { get; set; }

        public virtual decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5m); }
        }

        public Shipment(string? trackingCode)
        {
            this.trackingCode = string.IsNullOrWhiteSpace(trackingCode) ? "UNKNOWN" : trackingCode;
            this.description = "Unknown";
            this.weight = 1;
            this.deliveryFee = 50;
            this.Destination = default;
        }

        public Shipment(string? trackingCode, string? description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            this.trackingCode = string.IsNullOrWhiteSpace(trackingCode) ? "UNKNOWN" : trackingCode;
            this.description = string.IsNullOrWhiteSpace(description) ? "Unknown" : description;
            this.weight = weight > 0 ? weight : 1m;
            this.deliveryFee = deliveryFee > 0 ? deliveryFee : 50;
            this.Destination = destination;
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }

        public virtual void PrintShipment()
        {
            Console.WriteLine("---Tracking Code:");
            Console.WriteLine($"{TrackingCode} Description:");
            Console.WriteLine($"{Description} Weight: {Weight} KG");
            Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }

        public override string ToString()
        {
            return $"Tracking Code: {TrackingCode}, Description: {Description}";
        }
    }
}
