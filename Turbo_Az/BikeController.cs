using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo_Az
{
    public class BikeController : IVehicleController
    {
        public ArrayList bikes = new ArrayList();
        public void AddVehicle()
        {
            Console.Write("Input bike brand");
            string newBrand = Console.ReadLine();
            Console.Write("Input bike model");
            string newModel = Console.ReadLine();
            Console.Write("bike price");
            double newPrice = Convert.ToDouble(Console.ReadLine());
            Console.Write("bike riddenkm");
            double newRiddenkm = Convert.ToDouble(Console.ReadLine());

            Bike bike = new Bike(newBrand, newModel, newPrice, newRiddenkm);
            bikes.Add(bike);
            Console.WriteLine("this car added succcessfully!");
        }
        public void RemoveVehicle(IVehicle bike)
        {
            bikes.Remove(bike);
        }

        public void ShowVehicles()
        {
            int id = 1;

            foreach (Bike bike in bikes) 
            {
                Console.WriteLine($"ID:{id++}\n" +
                    $"Brand:{bike.Brand}\n" +
                    $"Model:{bike.Model}\n" +
                    $"Price:{bike.Price} \n" +
                    $"Ridden Km:{bike.RiddenKm}\n");
            }
        }

        public void UpdateVehicle(int id , IVehicle bike)
        {
            bikes[id-1] = bike;
        }

        public void SearchByPrice(double price)
        {
            ArrayList result = new ArrayList();
            foreach (Bike bike in bikes)
            {
                if (bike.Price == price)
                {
                    result.Add(bike);
                }
            }
            if (result.Count == 0)
            {
                Console.WriteLine("No trucks found with the specified price.");
            }
            else
            {
                Console.WriteLine($"Trucks with price {price}:");
                foreach (Bike bike in result)
                {
                    Console.WriteLine($"Brand: {bike.Brand}, Model: {bike.Model}, Price: {bike.Price}, Ridden Km: {bike.RiddenKm}");
                }
            }
        }

        public void SearchByPriceLow(double price)
        {
            ArrayList result = new ArrayList();
            foreach (Bike bike in bikes)
            {
                if (bike.Price < price)
                {
                    result.Add(bike);
                }
            }
            if (result.Count == 0)
            {
                Console.WriteLine("No trucks found with the specified price.");
            }
            else
            {
                Console.WriteLine($"Trucks with price {price}:");
                foreach (Bike bike in result)
                {
                    Console.WriteLine($"Brand: {bike.Brand}, Model: {bike.Model}, Price: {bike.Price}, Ridden Km: {bike.RiddenKm}");
                }
            }
        }

        public void SearchByPriceHigh(double price)
        {
            ArrayList result = new ArrayList();
            foreach (Bike bike in bikes)
            {
                if (bike.Price > price)
                {
                    result.Add(bike);
                }
            }
            if (result.Count == 0)
            {
                Console.WriteLine("No trucks found with the specified price.");
            }
            else
            {
                Console.WriteLine($"Trucks with price {price}:");
                foreach (Bike bike in result)
                {
                    Console.WriteLine($"Brand: {bike.Brand}, Model: {bike.Model}, Price: {bike.Price}, Ridden Km: {bike.RiddenKm}");
                }
            }
        }

        public void SearchByModel(string model)
        {
            ArrayList result = new ArrayList();
            foreach (Bike bike in bikes)
            {
                if (bike.Model.Equals(model, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(bike);
                }
            }
            if (result.Count == 0)
            {
                Console.WriteLine("No trucks found with the specified price.");
            }
            else
            {
                Console.WriteLine($"Trucks with model {model}:");
                foreach (Bike bike in result)
                {
                    Console.WriteLine($"Brand: {bike.Brand}, Model: {bike.Model}, Price: {bike.Price}, Ridden Km: {bike.RiddenKm}");
                }
            }
        }

        public void SearchByBrand(string brand)
        {
            ArrayList result = new ArrayList();
            foreach (Bike bike in bikes)
            {
                if (bike.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(bike);
                }
            }
            if (result.Count == 0)
            {
                Console.WriteLine("No trucks found with the specified price.");
            }
            else
            {
                Console.WriteLine($"Trucks with brand {brand}:");
                foreach (Bike  bike in result)
                {
                    Console.WriteLine($"Brand: {bike.Brand}, Model: {bike.Model}, Price: {bike.Price}, Ridden Km: {bike.RiddenKm}");
                }
            }
        }

        public void SearchByKm(double km)
        {
            ArrayList result = new ArrayList();
            foreach (Bike bike in bikes)
            {
                if (bike.RiddenKm == km)
                {
                    result.Add(bike);
                }
            }
            if (result.Count == 0)
            {
                Console.WriteLine("No trucks found with the specified price.");
            }
            else
            {
                Console.WriteLine($"Trucks under {km} riddenkm\n");
                foreach (Bike bike in result)
                {
                    Console.WriteLine($"Brand: {bike.Brand}, Model: {bike.Model}, Price: {bike.Price}, Ridden Km: {bike.RiddenKm}");
                }
            }
        }
    }
}
