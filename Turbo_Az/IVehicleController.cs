using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo_Az
{
    public interface IVehicleController
    {
        public void AddVehicle();
        
        public void RemoveVehicle(IVehicle vehicle);

        public void UpdateVehicle(int id , IVehicle vehicle);

        public void ShowVehicles();
    }
}
