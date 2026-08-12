using System;
using OOP_Assignment_2.Inheritance;

namespace OOP_Assignment_2.Class
{
    internal class DeliveryCenter
    {
        public string? CenterName { get; set; }

        private Shipment[]? shipments;
        private int currentCount;

        public int Count => currentCount;

        public DeliveryCenter(string? centerName)
        {
            CenterName = centerName;
            shipments = new Shipment[20];
            currentCount = 0;
        }

        public Shipment this[int index]
        {
            get
            {
                if (shipments == null || index < 0 || index >= currentCount)
                    return default!;
                return shipments[index];
            }
            set
            {
                if (shipments != null && index >= 0 && index < currentCount)
                {
                    shipments[index] = value;
                }
            }
        }

        public Shipment this[string? trackingCode]
        {
            get
            {
                if (shipments != null && trackingCode != null)
                {
                    for (int i = 0; i < currentCount; i++)
                    {
                        if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
                            return shipments[i];
                    }
                }
                return default!;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            if (shipments == null)
            {
                shipments = new Shipment[20];
                currentCount = 0;
            }

            if (currentCount < shipments.Length)
            {
                shipments[currentCount] = shipment;
                currentCount++;
                return true;
            }
            return false;
        }

        public bool RemoveShipment(string? trackingCode)
        {
            if (shipments == null || trackingCode == null) return false;

            for (int i = 0; i < currentCount; i++)
            {
                if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
                {
                    for (int j = i; j < currentCount - 1; j++)
                    {
                        shipments[j] = shipments[j + 1];
                    }
                    shipments[currentCount - 1] = default!;
                    currentCount--;
                    return true;
                }
            }
            return false;
        }
    }
}
