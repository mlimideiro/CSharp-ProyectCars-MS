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
                id = "CU9856BA",
                model = "Renault",
                doorsQuantity = 4,
                color = "Rojo",
                gearBox = false
            };

            CarCRUD runningProgram = new CarCRUD();

            //runningProgram.Create(carAdd1);

            

            

            


        }
    }

    
        
}
