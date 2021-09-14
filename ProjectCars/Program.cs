using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace ProjectCars
{
    class Program
    {
        static void Main(string[] args)
        {

            var Crud = new CarCRUD();

            var carNew = new Car()
            {
                Id = "CC0123DD",
                Model = "Peugeot",
                DoorsQuantity = 5,
                Color = "Blanco",
                IsManualTransmission = true
            };

            Crud.Create(carNew);
            Console.WriteLine(Crud.Get("CC0123DD").Model);
            Crud.Delete("CC0123DD");

            var carUpd = new Car()
            {
                Id = "AA0456AA",
                Model = "Peugeot",
                DoorsQuantity = 5,
                Color = "Azul",
                IsManualTransmission = true
            };

            Crud.Update(carUpd);








        }
    }

    
        
}
