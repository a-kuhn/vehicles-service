using System;
using System.ComponentModel.DataAnnotations;
using Mitchell_Vehicles.Validations;

namespace Mitchell_Vehicles
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        [YearAttribute]
        public int Year { get; set; }

        [Required(ErrorMessage = " is required.")]
        public string Make { get; set; }

        [Required(ErrorMessage = " is required.")]
        public string Model { get; set; }

        public Vehicle() { }

        public Vehicle(int id, int year, string make, string model)
        {
            Id = id;
            Year = year;
            Make = make;
            Model = model;
        }
    }
}
