using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo_Az
{
    public class CarController : IVehicleController
    {
        public ArrayList cars = new ArrayList();
        public void AddVehicle()
        {
            Console.Write("Input car brand");
            string newBrand = Console.ReadLine();
            Console.Write("Input car model");
            string newModel = Console.ReadLine();
            Console.Write("car price");
            double newPrice = Convert.ToDouble(Console.ReadLine());
            Console.Write("Car riddenkm");
            double newRiddenkm = Convert.ToDouble(Console.ReadLine());

            Car car = new Car(newBrand , newModel , newPrice , newRiddenkm);
            cars.Add(car);
            Console.WriteLine("this car added succcessfully!");
        }

        public void RemoveVehicle(IVehicle car)
        {
            cars.Remove(car);
        }

        public void ShowVehicles()
        {
            int id = 1;

            foreach (Car car in cars) 
            {
                Console.WriteLine($"ID:{id++}\n" +
                    $"Brand:{car.Brand}\n" +
                    $"Model:{car.Model}\n" +
                    $"Price:{car.Price} \n" +
                    $"Ridden Km:{car.RiddenKm}\n");
            }
        }

        public void UpdateVehicle(int id , IVehicle car)
        {
            cars[id-1] = car;
        }

        public void SearchByPrice(double price)
        {
            ArrayList result = new ArrayList();
            foreach (Car car in cars)
            {
                if (car.Price == price)
                {
                    result.Add(car);
                }
            }
            if (result.Count == 0)
            {
                Console.WriteLine("No trucks found with the specified price.");
            }
            else
            {
                Console.WriteLine($"Trucks with price {price}:");
                foreach (Car car in result)
                {
                    Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Price: {car.Price}, Ridden Km: {car.RiddenKm}");
                }
            }
        }

        public void SearchByPriceLow(double price)
        {
            ArrayList result = new ArrayList();
            foreach (Car car in cars)
            {
                if (car.Price < price)
                {
                    result.Add(car);
                }
            }
            if (result.Count == 0)
            {
                Console.WriteLine("No trucks found with the specified price.");
            }
            else
            {
                Console.WriteLine($"Trucks with price {price}:");
                foreach (Car car in result)
                {
                    Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Price: {car.Price}, Ridden Km: {car.RiddenKm}");
                }
            }
        }

        public void SearchByPriceHigh(double price)
        {
            ArrayList result = new ArrayList();
            foreach (Car car in cars)
            {
                if (car.Price > price)
                {
                    result.Add(car);
                }
            }
            if (result.Count == 0)
            {
                Console.WriteLine("No trucks found with the specified price.");
            }
            else
            {
                Console.WriteLine($"Trucks with price {price}:");
                foreach (Car car in result)
                {
                    Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Price: {car.Price}, Ridden Km: {car.RiddenKm}");
                }
            }
        }

        public void SearchByModel(string model)
        {
            ArrayList result = new ArrayList();
            foreach (Car car in cars)
            {
                if (car.Model.Equals(model, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(car);
                }
            }
            if (result.Count == 0)
            {
                Console.WriteLine("No trucks found with the specified price.");
            }
            else
            {
                Console.WriteLine($"Trucks with model {model}:");
                foreach (Car car in result)
                {
                    Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Price: {car.Price}, Ridden Km: {car.RiddenKm}");
                }
            }
        }

        public void SearchByBrand(string brand)
        {
            ArrayList result = new ArrayList();
            foreach (Car car in cars)
            {
                if (car.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(car);
                }
            }
            if (result.Count == 0)
            {
                Console.WriteLine("No trucks found with the specified price.");
            }
            else
            {
                Console.WriteLine($"Trucks with brand {brand}:");
                foreach (Car car in result)
                {
                    Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Price: {car.Price}, Ridden Km: {car.RiddenKm}");
                }
            }
        }

        public void SearchByKm(double km)
        {
            ArrayList result = new ArrayList();
            foreach (Car car in cars)
            {
                if (car.RiddenKm == km)
                {
                    result.Add(car);
                }
            }
            if (result.Count == 0)
            {
                Console.WriteLine("No trucks found with the specified price.");
            }
            else
            {
                Console.WriteLine($"Trucks under {km} riddenkm\n");
                foreach (Car car in result)
                {
                    Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model} , Price:  {car.Price} , Ridden Km:  {car.RiddenKm}");
                }
            }
        }
    }
}
