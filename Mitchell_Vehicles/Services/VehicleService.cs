using System;
using System.Collections.Generic;

namespace Mitchell_Vehicles.Services
{
    public class VehicleService : IVehicleService
    {
        private List<Vehicle> _vehicleEntities;

        public VehicleService()
        {
            _vehicleEntities = new List<Vehicle>();
        }

        public List<Vehicle> GetVehicles()
        {
            return _vehicleEntities;
        }

        public Vehicle GetVehicleById(int id)
        {
            Vehicle vehicle = new Vehicle();

            for (int index = _vehicleEntities.Count - 1; index >= 0; index--)
            {
                if (_vehicleEntities[index].Id == id)
                {
                    vehicle = _vehicleEntities[index];
                }
            }

            return vehicle;
        }

        public Vehicle AddVehicle(Vehicle vehicleEntity)
        {
            _vehicleEntities.Add(vehicleEntity);
            return vehicleEntity;
        }

        public Vehicle UpdateVehicle(int id, Vehicle vehicleEntity)
        {
            for (int index = _vehicleEntities.Count - 1; index >= 0; index--)
            {
                if (_vehicleEntities[index].Id == id)
                {
                    _vehicleEntities[index] = vehicleEntity;
                }
            }

            return vehicleEntity;
        }

        public int DeleteVehicle(int id)
        {
            for (int index = _vehicleEntities.Count - 1; index >= 0; index--)
            {
                if (_vehicleEntities[index].Id == id)
                {
                    _vehicleEntities.RemoveAt(index);
                }
            }

            return id;
        }
    }
}
