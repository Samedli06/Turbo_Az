using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo_Az
{
    public class Truck : IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public double RiddenKm { get; set; }

        public Truck(string brand, string model, double price, double riddenkm) 
        {
            Brand = brand;
            Model = model;
            Price = price;
            RiddenKm = riddenkm;
        }
        public void Getinfo()
        {
            Console.WriteLine($"Truck: {Brand} {Model}\nPrice: {Price}\nRidden Km: {RiddenKm}");
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
