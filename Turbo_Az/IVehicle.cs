using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo_Az
{
    public interface IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public double RiddenKm { get; set; }

        public void Getinfo();

        public void Update();
            
    }
}
