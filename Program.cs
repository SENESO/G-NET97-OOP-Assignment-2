using System;
using OOP_Assignment_2.Struct;
using OOP_Assignment_2.Class;
using OOP_Assignment_2.Inheritance;

namespace OOP_Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeliveryCenter center = new DeliveryCenter("Central Hub");

            DeliveryAddress addr1 = new DeliveryAddress("Cairo", "Street 1", 10);
            DeliveryAddress addr2 = new DeliveryAddress("Giza", "Street 2", 20);
            DeliveryAddress addr3 = new DeliveryAddress("Alex", "Street 3", 30);

            StandardShipment stdShipment = new StandardShipment("STD123", "Books", 2.5m, 50, addr1);
            ExpressShipment expShipment = new ExpressShipment("EXP456", "Electronics", 1.5m, 60, addr2, 20);
            InternationalShipment intShipment = new InternationalShipment("INT789", "Clothes", 5.0m, 100, addr3, "USA", 150);

            center.AddShipment(stdShipment);
            center.AddShipment(expShipment);
            center.AddShipment(intShipment);

            Console.WriteLine($"--- Welcome to {center.CenterName} ---");
            Console.WriteLine($"Total Shipments: {center.Count}\n");

            for (int i = 0; i < center.Count; i++)
            {
                center[i].PrintShipment();
                Console.WriteLine(new string('-', 30));
            }

            Console.WriteLine("Removing shipment EXP456...");
            bool isRemoved = center.RemoveShipment("EXP456");
            Console.WriteLine(isRemoved ? "Removed successfully.\n" : "Not found.\n");

            Console.WriteLine($"Total Shipments after removal: {center.Count}");
        }
    }
}
