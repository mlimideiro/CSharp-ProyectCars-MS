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
        //public static List<Car> GetCars()
       // {
            List<Car> cars = new List<Car>
            {
                new Car
                {
                    id = "AA0456AA",
                    model = "Fiat",
                    doorsQuantity = 5,
                    color = "Verde",
                    gearBox = true
                },

                new Car
                {
                    id = "BB0156VV",
                    model = "Peugeot",
                    doorsQuantity = 3,
                    color = "Azul",
                    gearBox = true
                },
            };

           // return cars;
        //}


        public Car Create(Car car)
        {
            cars.Add(car);
            return car;
        }

        public Car Get(int id)
        {
            return null;
        }

        public Car Update(Car car)
        {
            return null;
        }

        public void Delete(int id)
        {

        }

    }
}
