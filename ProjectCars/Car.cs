using System;

namespace ProjectCars
{
    public enum BrandCar
    {
        Fiat,
        Ford,
        Chevrolet,
        Peugeot,
        Renault,
        Volkswagen
    }
    public class Car
    {
        public String Id { get; set; }
        public String Model { get; set; }
        public int DoorsQuantity { get; set; }
        public String Color { get; set; }
        public bool IsManualTransmission { get; set; }

    }
}
