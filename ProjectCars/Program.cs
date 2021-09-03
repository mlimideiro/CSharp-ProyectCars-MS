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

            var carAdd1 = new Car
            {
                Id = "CU9856BA",
                Model = "Renault",
                DoorsQuantity = 4,
                Color = "Rojo",
                IsManualTransmition = false
            };

            var runningProgram = new CarCRUD();

            //runningProgram.Create(carAdd1);

            

            

            


        }
    }

    
        
}
