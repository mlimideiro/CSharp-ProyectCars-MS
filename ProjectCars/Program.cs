using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ProjectCars
{
    class Program
    {
        private static string _path = @"C:\Json Store\Cars.json";

        static void Main(string[] args)
        {

            var carAdd1 = new Car
            {
                id = "CU9856BA",
                model = "Renault",
                doorsQuantity = 4,
                color = "Rojo",
                gearBox = false
            };

            CarCRUD runningProgram = new CarCRUD();

            runningProgram.Create(carAdd1);

            Console.WriteLine(runningProgram);

        }
    }

    
        
}
