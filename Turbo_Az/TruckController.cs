using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Turbo_Az
{
    public class TruckController : IVehicleController
    {
        public ArrayList trucks = new ArrayList();
        Truck truck;
        public void AddVehicle()
        {
            Console.Write("Input truck brand");
            string newBrand = Console.ReadLine();
            Console.Write("Input truck model");
            string newModel = Console.ReadLine();
            Console.Write("truck price");
            double newPrice = Convert.ToDouble(Console.ReadLine());
            Console.Write("truck riddenkm");
            double newRiddenkm = Convert.ToDouble(Console.ReadLine());

            Truck truck = new Truck(newBrand, newModel, newPrice, newRiddenkm);
            trucks.Add(truck);
            Console.WriteLine("this car added succcessfully!");
        }

        public void RemoveVehicle(IVehicle truck)
        {
            trucks.Remove(truck);
        }

        public void UpdateVehicle(int id , IVehicle truck)
        {
            trucks[id-1] = truck;
        }

        public void ShowVehicles()
        {
            int id = 1;

            foreach (Truck truck in trucks)
            {
                Console.WriteLine($"ID:{id++}\n" +
                    $"Brand:{truck.Brand}\n" +
                    $"Model:{truck.Model}\n" +
                    $"Price:{truck.Price} \n" +
                    $"Quantity:{truck.RiddenKm}\n");
            }
        }

        public void SearchByPrice(double price)
        {
            ArrayList result = new ArrayList();
            foreach (Truck truck in trucks)
            {
                if (truck.Price == price)
                {
                    result.Add(truck);
                }
            }
            if (result.Count == 0)
            {
                Console.WriteLine("No trucks found with the specified price.");
            }
            else
            {
                Console.WriteLine($"Trucks with price {price}:");
                foreach (Truck truck in result)
                {
                    Console.WriteLine($"Brand: {truck.Brand}, Model: {truck.Model}, Price: {truck.Price}, Ridden Km: {truck.RiddenKm}");
                }
            }
        }

        public void SearchByPriceLow(double price)
        {
            ArrayList result = new ArrayList();
            foreach (Truck truck in trucks)
            {
                if (truck.Price < price)
                {
                    result.Add(truck);
                }
            }
            if (result.Count == 0)
            {
                Console.WriteLine("No trucks found with the specified price.");
            }
            else
            {
                Console.WriteLine($"Trucks with price {price}:");
                foreach (Truck truck in result)
                {
                    Console.WriteLine($"Brand: {truck.Brand}, Model: {truck.Model}, Price: {truck.Price}, Ridden Km: {truck.RiddenKm}");
                }
            }
        }

        public void SearchByPriceHigh(double price)
        {
            ArrayList result = new ArrayList();
            foreach (Truck truck in trucks)
            {
                if (truck.Price > price)
                {
                    result.Add(truck);
                }
            }
            if (result.Count == 0)
            {
                Console.WriteLine("No trucks found with the specified price.");
            }
            else
            {
                Console.WriteLine($"Trucks with price {price}:");
                foreach (Truck truck in result)
                {
                    Console.WriteLine($"Brand: {truck.Brand}, Model: {truck.Model}, Price: {truck.Price}, Ridden Km: {truck.RiddenKm}");
                }
            }
        }

        public void SearchByModel(string model)
        {
            ArrayList result = new ArrayList();
            foreach (Truck truck in trucks)
            {
                if (truck.Model.Equals(model, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(truck);
                }
            }
            if (result.Count == 0)
            {
                Console.WriteLine("No trucks found with the specified price.");
            }
            else
            {
                Console.WriteLine($"Trucks with model {model}:");
                foreach (Truck truck in result)
                {
                    Console.WriteLine($"Brand: {truck.Brand}, Model: {truck.Model}, Price: {truck.Price}, Ridden Km: {truck.RiddenKm}");
                }
            }
        }

        public void SearchByBrand(string brand)
        {
            ArrayList result = new ArrayList();
            foreach (Truck truck in trucks)
            {
                if (truck.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(truck);
                }
            }
            if (result.Count == 0)
            {
                Console.WriteLine("No trucks found with the specified price.");
            }
            else
            {
                Console.WriteLine($"Trucks with brand {brand}:");
                foreach (Truck truck in result)
                {
                    Console.WriteLine($"Brand: {truck.Brand}, Model: {truck.Model}, Price: {truck.Price}, Ridden Km: {truck.RiddenKm}");
                }
            }
        }

        public void SearchByKm(double km)
        {
            ArrayList result = new ArrayList();
            foreach (Truck truck in trucks)
            {
                if (truck.RiddenKm == km)
                {
                    result.Add(truck);
                }
            }
            if (result.Count == 0)
            {
                Console.WriteLine("No trucks found with the specified price.");
            }
            else
            {
                Console.WriteLine($"Trucks under {km} riddenkm\n");
                foreach (Truck truck in result)
                {
                    Console.WriteLine($"Brand: {truck.Brand}, Model: {truck.Model}, Price: {truck.Price}, Ridden Km: {truck.RiddenKm}");
                }
            }
        }
    }
}
