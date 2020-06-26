using System;
using System.Collections.Generic;

namespace Mitchell_Vehicles.Services
{
    public interface IVehicleService
    {
        public List<Vehicle> GetVehicles();
        public Vehicle GetVehicleById(int id);
        public Vehicle AddVehicle(Vehicle vehicleEntity);
        public Vehicle UpdateVehicle(int id, Vehicle vehicleEntity);
        public int DeleteVehicle(int id);
    }
}
