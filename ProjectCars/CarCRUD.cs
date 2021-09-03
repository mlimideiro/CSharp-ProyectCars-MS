using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProjectCars
{
     public class CarCRUD
    {
        //private static string path = @"C:\Json Store\Cars.json";

        public static List<Car> GetCars()
        {
            var cars = new List<Car>
            {
                new Car
                {
                    Id = "AA0456AA",
                    Model = "Fiat",
                    DoorsQuantity = 5,
                    Color = "Verde",
                    IsManualTransmition = true
                },

                new Car
                {
                    Id = "BB0156VV",
                    Model = "Peugeot",
                    DoorsQuantity = 3,
                    Color = "Azul",
                    IsManualTransmition = true
                },
            };

            return cars;
        }


        public Car Create(Car car)
        {
            
            return null;
        }

        public Car Get(int Id)
        {
            return null;
        }

        public Car Update(Car car)
        {
            return null;
        }

        public void Delete(int Id)
        {

        }

    }
}
